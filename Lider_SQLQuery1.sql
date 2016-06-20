

--------------------------------------COMIENZO funcionalidad Comprar/Ofertar----------------------------------------------------------------------

-- Procedemiento para busqueda de un producto, se puede filtrar por id_rubro ( o no , segun que decida el usuario)
-- te devuelve 10 productos por paginas

create procedure st_buscar_publicaciones
@descripcion nvarchar(255) = null,
@rubroId nvarchar(255)= null,
@pagina int
AS
begin

 select*
 from(
      select *,(row_number() over (order by id_publicacion desc) ) as publicaciones
      from PUBLICACION
      inner join VISIBILIDAD on id_visibilidad = visibilidad
      inner join ESTADO_PUBLICACION on id_estado = estado_publicacion
      inner join TIPO_PUBLICACION on id_tipo = tipo_publicacion
      inner join RUBRO on id_rubro = rubro
      where (descripcion like '%' + @descripcion + '%') and 
      estado_nombre <> 'BORRADOR' and estado_nombre <> 'FINALIZADA' and
      (id_rubro = @rubroId OR @rubroId IS NULL)
      
      ) gg_vieja
 where publicaciones between (@pagina*10)-9 and (@pagina*10)
 order by precio_visibilidad desc

end

go

-- Procedimientos que usa el store st_insertarCompraSubasta
create procedure st_actualizar_Estado_Publicacion_a_Finalizado
@publicacion numeric(10,0),
@factura numeric(10,0),
@fecha_operacion datetime

as begin
 declare @stock int
 
      select @stock= stock
	  from PUBLICACION
	  where id_publicacion = @publicacion

	  if (@stock = 0)
	  begin
	   	    update PUBLICACION SET estado_publicacion = 4 -- le cambio el estado finalizado
	        where id_publicacion = @publicacion
			--cierro la factura   
		    update FACTURA SET factura_fecha = @fecha_operacion 
	           where id_factura = @factura
	  end
 
end

go

create PROCEDURE sp_AgregarOferta(@ofertante numeric(10,0),@publicacion numeric(10,0),
                                  @fecha_oferta datetime,
                                  @monto_ofertado numeric(10,2),@precio_envio int)
AS BEGIN

		INSERT INTO OFERTA
			(ofertante, publicacion, fecha_oferta,concretada, monto_ofertado,precio_envio)
			VALUES
			(@ofertante, @publicacion, @fecha_oferta, 0, @monto_ofertado,@precio_envio)
			
		update PUBLICACION SET precio = @monto_ofertado
	       where id_publicacion = @publicacion

END		


go

	create procedure st_insertarCompraSubasta(@comprador numeric(10,0), 
	    @publicacion numeric(10,0), 
	    @fecha_operacion datetime, @monto numeric(10,2), @cantidad int,
		@precio_envio int,@factura numeric(10,0),@descripcion nvarchar(255))
	as begin
	        
			insert into COMPRA ( comprador, publicacion, fecha_operacion,monto, cantidad )
	           values (@comprador , @publicacion , @fecha_operacion , @monto ,@cantidad )
			   
			insert into ITEM_FACTURA(id_factura ,descripcion,cantidad_vendida ,precio_unitario,precio_envio )
			   values (@factura , @descripcion, @cantidad, @monto ,@precio_envio )
			   
			exec st_actualizar_Estado_Publicacion_a_Finalizado @publicacion,@factura,@fecha_operacion

			   
	end


go

--validaciones
create function mas_de_tres_sin_calificar(@id_cliente numeric(10,0))
returns bit
as
begin
declare @cant int,@bool bit

      select @cant= count(isnull (calif_estrellas,1))
	  from COMPRA inner join CALIFICACION on id_calificacion =calificacion
	  where @id_cliente = comprador


	  if (@cant > 3)
	   SET @bool=1
      ELSE
	   SET @bool=0

      return @bool

end

go

create function publicacion_en_estado_pausado(@id_publicacion numeric(10,0))
returns bit
as
begin
declare @cant int,@bool bit

      select @cant= count(id_publicacion)
	  from PUBLICACION inner join ESTADO_PUBLICACION on estado_publicacion = id_estado
	  where id_publicacion = @id_publicacion and estado_nombre = 'PAUSADA'

	  if (@cant <> 0)
	   SET @bool=1
      ELSE
	   SET @bool=0

      return @bool

end

go

--procedemiento para validar antes de comprar, segun el @tipoError deriba en distintas ventanas de c#
create procedure st_validacion_de_compra_oferta
@id_cliente numeric(10,0),
@usuario_responsable numeric(10,0),
@id_publicacion numeric(10,0),
@tipoError varchar(50)  = 'todo piolaa' out
as
begin
      if(@id_cliente = @usuario_responsable )
	    set @tipoError = 'i' --error, cliente es el mismo
	  if(dbo.publicacion_en_estado_pausado(@id_publicacion) =1)
	    set @tipoError = 'p' --error, publicacion pausada
	  if(dbo.mas_de_tres_sin_calificar(@id_cliente) =1)
	   set @tipoError = 'c' --error, el cliente debe calificar sus compras
	    
end


go

-- Procedimientos que usa el tr_insertarCompra
create procedure st_agregarCalificacion(@id_calificacion numeric(10,0) output )
as begin
		insert into CALIFICACION (calif_estrellas,calif_detalle)
		values (null, null)
		set @id_calificacion = scope_identity()
end
go


-- Se dispara cada vez q se inserta una compra ( post-migracion)
create trigger tr_insertarCompra
	on COMPRA
	instead of insert

	as begin
	declare @id_calificacion numeric(10,0)

	exec st_agregarCalificacion @id_calificacion output 
	
	declare @id_compra numeric(10,0), @comprador numeric(10,0), @publicacion numeric(10,0), 
	    @fecha_operacion datetime, @monto numeric(10,2), @cantidad int
			
	select  @id_compra =i.id_compra,@comprador=i.comprador,@publicacion=i.publicacion,@fecha_operacion=i.fecha_operacion,
	        @monto=i.monto, @cantidad=i.cantidad
	from inserted i

	insert into COMPRA ( comprador, publicacion, fecha_operacion,monto, cantidad,calificacion )
	values (  @comprador , @publicacion , @fecha_operacion , @monto ,
			 @cantidad, @id_calificacion )
	
	update PUBLICACION SET stock = stock - @cantidad
	 where id_publicacion = @publicacion
	 	 
	end
	

go
	
-------------- FIN  funcionalidad Comprar/Ofertar----------------------------------------------------------------------

-------------- Comienzo de Calificar al vendedor----------------------------------------------------------------------

create procedure st_mostrarPublicacionesSinCalificar(@id_usuario numeric(10,0))
as begin  
	  select  id_publicacion,descripcion,stock,fecha_inicio,
	          fecha_vencimiento,precio,rubro,visibilidad,estado_publicacion,
			  usuario_responsable ,tipo_publicacion,envio,factura,id_calificacion
	  from COMPRA
	  inner join PUBLICACION on publicacion = id_publicacion
	  inner join CALIFICACION on id_calificacion =calificacion
	  where comprador = @id_usuario and calif_estrellas is null
end

go

create procedure st_insertarCalificacion(
@id_calificacion numeric(10,0),
@calif_estrellas int,
@calif_detalle nvarchar(255) )
as begin  
        update CALIFICACION set calif_estrellas= @calif_estrellas,calif_detalle =@calif_detalle
		where id_calificacion=@id_calificacion
end

go

create procedure st_resumenDeEstrellasDadas(@id_usuario numeric(10,0))
as begin

select * into #TablaTemporal --Tabla Temporal
from COMPRA
inner join CALIFICACION on id_calificacion =calificacion	
where comprador = @id_usuario

select 
(select count(calif_estrellas) from #TablaTemporal where calif_estrellas = 1) as [1 estrella],
(select count(calif_estrellas) from #TablaTemporal where calif_estrellas = 2) as [2 estrella],
(select count(calif_estrellas) from #TablaTemporal where calif_estrellas = 3) as [3 estrella],
(select count(calif_estrellas) from #TablaTemporal where calif_estrellas = 4) as [4 estrella],
(select count(calif_estrellas) from #TablaTemporal where calif_estrellas = 5) as [5 estrella]

drop table #TablaTemporal
end

go

create procedure st_ultimas5compras(@id_usuario numeric(10,0))
as begin  
	  select top 5 descripcion,calif_estrellas
	  from COMPRA
	  inner join PUBLICACION on publicacion = id_publicacion
	  inner join CALIFICACION on id_calificacion =calificacion
	  where comprador = @id_usuario
	  order by fecha_operacion desc
end

------------------------------------------------ FIN de Calificar al vendedor----------------------------------------------------------------------

--------------------------------------------------COMIENZO ABM VISIBILIDAD----------------------------------------------------------------

go
CREATE PROCEDURE sp_AgregarVisibilidad
	(@visibilidad_nombre nvarchar(255), @precio_visibilidad numeric(10,0), @porcentaje_venta  numeric(10,2))
AS BEGIN
	INSERT INTO VISIBILIDAD
		(visibilidad_nombre, precio_visibilidad, porcentaje_venta)
	VALUES
		(@visibilidad_nombre, @precio_visibilidad, @porcentaje_venta)

END
GO

/* SP Editar VISIBILIDAD */

CREATE PROCEDURE sp_EditarVisibilidad
	(@id_visibilidad numeric(10,0), @visibilidad_nombre nvarchar(255), @precio_visibilidad numeric(10,0), 
		@porcentaje_venta  numeric(10,2))
AS BEGIN
	UPDATE VISIBILIDAD 
	SET visibilidad_nombre = @visibilidad_nombre, precio_visibilidad = @precio_visibilidad,
	porcentaje_venta = @porcentaje_venta
	WHERE id_visibilidad = @id_visibilidad
END
GO

/* SP Eliminar VISIBILIDAD */

create PROCEDURE sp_EliminarVisibilidad
	@id_visibilidad numeric(10,0),
	@tipoError varchar(50) = 'todo piolaa' out
AS BEGIN

    BEGIN TRY
	    DELETE FROM VISIBILIDAD WHERE id_visibilidad = @id_visibilidad
	END TRY

    BEGIN CATCH
	 set @tipoError = 'e' --error, no se puede borrar la visibilidad
    END CATCH

END
GO

--------------------------------------------------FIN VISIBILIDAD----------------------------------------------------------------


--------------HISTORIAL DE CLIENTE------------

--------FIN DE HISTORIAL DEL CLIENTE-----------------------

-------------- GENERAR PUBLICACION----------------------------------------------------------------------

create function fu_nombre_visibilidad(@visibilidad numeric(10,0))
returns nvarchar(255)
as
begin
declare @visibilidad_nombre nvarchar(255)

      select @visibilidad_nombre= visibilidad_nombre
	  from VISIBILIDAD 
	  where id_visibilidad = @visibilidad

      return @visibilidad_nombre

end

go

create function fu_precio_visibilidad(@visibilidad numeric(10,0))
returns numeric(10,2)
as
begin
declare @precio_visibilidad numeric(10,2)

      select @precio_visibilidad= precio_visibilidad
	  from VISIBILIDAD 
	  where id_visibilidad = @visibilidad

      return @precio_visibilidad

end

go

create PROCEDURE sp_AgregarPublicacion
	(@descripcion nvarchar(255),@stock numeric(10,0), @fecha_inicio datetime, 
	 @fecha_vencimiento datetime,@precio numeric(10,2), @rubro numeric(10,0), 
	 @visibilidad numeric(10,0), @estado_publicacion numeric(10,0), @usuario_responsable numeric(10,0),
	 @tipo_publicacion numeric(10,0), @envio bit)
AS BEGIN

        declare @factura numeric (10,0)
		
	   if (@estado_publicacion <> 1)
	       begin
		        INSERT INTO FACTURA 
		          ( tipo_visibilidad,costo_visibilidad)
			       values
			      (dbo.fu_nombre_visibilidad(@visibilidad),dbo.fu_precio_visibilidad(@visibilidad))
			    SET @factura = SCOPE_IDENTITY();
		   end
		

		
		INSERT INTO PUBLICACION
			(descripcion, stock, fecha_inicio,fecha_vencimiento, precio, rubro, visibilidad,
			 estado_publicacion, usuario_responsable, tipo_publicacion, envio, factura)
			VALUES
			(@descripcion, @stock, @fecha_inicio, @fecha_vencimiento, @precio, @rubro, @visibilidad,
			 @estado_publicacion, @usuario_responsable, @tipo_publicacion, @envio, @factura)

END

go

----------------------  FIN DE GENERAR PUBLICACION----------------------------------------------------------------------


----------------------  COMIENZO DE ESTADISTICAS-------------------------------------------------------------------------------
tres meses para todos y un año

--Vendedores con mayor cantidad de productos no vendidos, 
--dicho listado debe filtrarse por grado de visibilidad de la publicación y
--por mes-año. Primero se deberá ordenar por fecha y luego por visibilidad.
 
create procedure st_cant_productos_no_vendidos
@mes1 int,
@mes2 int,
@mes3 int,
@anio int,
@visibilidad int
AS BEGIN
 
select nick,mail,count(*) as cant_productos_no_vendidos
FROM PUBLICACION
inner join VISIBILIDAD on id_visibilidad = visibilidad
inner join USUARIO on usuario_responsable = id_usuario
inner join FACTURA on id_factura = factura
where (@mes1=month(factura_fecha) or @mes1 IS NULL) and ( @mes2=month(factura_fecha) or @mes2 IS NULL) and
( @mes3=month(factura_fecha) or  @mes3 IS NULL) and
@anio=year(factura_fecha) and visibilidad = @visibilidad
group by nick,mail,factura,factura_fecha,precio_visibilidad 
having 0 =(select count(*) from ITEM_FACTURA
                                   where factura = id_factura )
 order by factura_fecha,precio_visibilidad desc

 end
--Clientes con mayor cantidad de productos comprados, por mes y por año, dentro de un rubro particular
rubro
select nick,mail,sum(cantidad) as cant_de_productos_comprados
FROM COMPRA
inner join USUARIO on comprador = id_usuario
inner join PUBLICACION on publicacion = id_publicacion
where rubro=1 and month(fecha_operacion)= 03 and year(fecha_operacion)=2012
group by nick,mail
 order by cant_de_productos_comprados desc

--Vendedores con mayor cantidad de facturas dentro de un mes y año particular
select nick,mail,count(*) as cant_de_facturas
FROM PUBLICACION
inner join USUARIO on usuario_responsable = id_usuario
inner join FACTURA on id_factura = factura
group by nick,mail
order by cant_de_facturas desc


--Vendedores con mayor monto facturado dentro de un mes y año particular. 
select nick,mail,sum(precio_unitario*cantidad_vendida+precio_envio) as mayor_monto_facturado
FROM PUBLICACION
inner join USUARIO on usuario_responsable = id_usuario
inner join FACTURA on id_factura = factura
inner join ITEM_FACTURA i on i.id_factura=factura
group by nick,mail
order by mayor_monto_facturado desc



----------------------  FIN DE ESTADISTICAS----------------------------------------------------------------------

go

--Al iniciar la aplicación se tiene que barrer la base de datos para saber que publicaciones
--estan vencidas, a las q estan vencidas hay que finalizarlas y cerrar la factura
--Las subasta vencidas hay q hacer lo mismo, y tambien insertar esa oferta como compra
create procedure st_actualizar_publicaciones_vencidas
@fechaDelSistema datetime

AS BEGIN
declare @id_publicacion numeric(10,0), @tipo_publicacion numeric(10,0), @factura numeric(10,0),@precio numeric(10,2),
@descripcion nvarchar(255),
@ofertante numeric(10,0),@precio_envio numeric(10,2)

set @ofertante =null

declare miCursor cursor
 for select id_publicacion,tipo_publicacion,
            factura,precio,descripcion 
 FROM PUBLICACION
 where  year(fecha_vencimiento) < 2016 and
 estado_publicacion <> 1 AND --distinto de borrador
 estado_publicacion <> 4     --distinto de finalizado
 

open miCursor

fetch next from miCursor into @id_publicacion,@tipo_publicacion,@factura,@precio,@descripcion

while @@fetch_status=0
begin
       UPDATE PUBLICACION  
       SET estado_publicacion = 4 --finalizado
       where id_publicacion= @id_publicacion
       
       UPDATE FACTURA  
       SET factura_fecha = @fechaDelSistema --cierro la factura
       where id_factura =@factura

       if(@tipo_publicacion =2) -- si es una subasta
       begin
	       select @ofertante=ofertante,@precio_envio=precio_envio
	       from OFERTA
	       where publicacion =@id_publicacion and
	       monto_ofertado = @precio

	       if(@ofertante is not null) --valido que alguien oferto por lo menos una vez
	       begin
	            exec st_insertarCompraSubasta @ofertante,@id_publicacion ,@fechaDelSistema, @precio, 
                              1 ,@precio_envio ,@factura ,@descripcion 
           end
       end

       fetch next from miCursor into @id_publicacion,@tipo_publicacion,@factura,@precio,@descripcion  
end

close miCursor

deallocate miCursor

end
	
			

