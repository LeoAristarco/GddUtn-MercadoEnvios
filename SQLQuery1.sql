	CREATE PROCEDURE CHAR_DE_30.sp_actualizarUsuario(
		@id_usuario			numeric(10,0),				
		@mail				nvarchar(255),
		@fecha_nacimiento	date,
		@telefono			nvarchar(60),
		@calle				nvarchar(255),
		@numero_calle		numeric(18,0),
		@numero_piso		nvarchar(30),
		@departamento		nvarchar(50),
		@localidad			nvarchar(255),
		@codigo_postal		nvarchar(50))
	AS BEGIN
		UPDATE USUARIO SET
		mail = @mail,
		telefono = @telefono,
		calle = @calle,
		numero_calle = @numero_calle,
		numero_piso = @numero_piso,
		departamento = @departamento,
		localidad = @localidad,
		codigo_postal = @codigo_postal,
		fecha_nacimiento = @fecha_nacimiento
		WHERE id_usuario = @id_usuario
	END
	GO
	
	CREATE PROCEDURE CHAR_DE_30.sp_darDeBajaLogicaAUsuario(@id_usuario numeric(10,0))
	AS BEGIN
		UPDATE USUARIO SET
		baja_logica = 1
		WHERE id_usuario = @id_usuario
	END
	GO

	
/**********************Fin de ABM de Usuario*******************************/

------------------------------------------------ INICIO LOGUIN----------------------------------------------------------------------
--borro si existen versiones viejas
if EXISTS (SELECT * FROM sysobjects WHERE name='tg_actualizar_intentos_login') 
drop trigger CHAR_DE_30.tg_actualizar_intentos_login

go

if EXISTS (SELECT * FROM sysobjects WHERE name='VERIFICAR_LOGUEO') 
drop procedure CHAR_DE_30.VERIFICAR_LOGUEO

go

if EXISTS (SELECT * FROM sysobjects WHERE name='fn_hashear_pass') 
drop function CHAR_DE_30.fn_hashear_pass

go

create function CHAR_DE_30.fn_hashear_pass (@pass nvarchar(255))
returns nvarchar(255)
as begin
	return(
		SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA2_256', @pass)), 3, 255)
	)
end

go


--creo objetos necesarios
create procedure CHAR_DE_30.VERIFICAR_LOGUEO
	@nick nvarchar(255), 
	@pass nvarchar(255)
as begin
	
	declare @filas int;

	select top 1 @filas = COUNT(baja_logica)
	from CHAR_DE_30.USUARIO
	where 
		nick = @nick and 
		pass = CHAR_DE_30.fn_hashear_pass(@pass);

	if(@filas = 0) begin
		update CHAR_DE_30.USUARIO
		set intentos_login = (intentos_login +1)
		where nick = @nick;
	end
	else begin
		update CHAR_DE_30.USUARIO
		set intentos_login = 0
		where nick = @nick;
	end

	select u.id_usuario, ru.id_rol, r.rol_nombre, u.baja_logica 
	from CHAR_DE_30.USUARIO as u
	inner join CHAR_DE_30.ROL_POR_USUARIO as ru
	on  u.id_usuario = ru.id_usuario
	inner join CHAR_DE_30.ROL as r
	on ru.id_rol = r.id_rol
	where 
		u.nick = @nick and 
		u.pass = CHAR_DE_30.fn_hashear_pass(@pass) and
		r.habilitado = 1;
end

go

create trigger CHAR_DE_30.tg_actualizar_intentos_login
on CHAR_DE_30.USUARIO
after update
as begin

	if update(intentos_login) begin
		
		declare 
			@intentos int,
			@id_usuario_modificado numeric(18,0);

		select 
			@intentos = i.intentos_login, 
			@id_usuario_modificado = i.id_usuario
		from CHAR_DE_30.USUARIO as u
		inner join inserted as i
		on u.id_usuario = i.id_usuario
		where u.id_usuario = i.id_usuario;

		if(@intentos = 3) 
			update CHAR_DE_30.USUARIO
			set
				intentos_login = 0,
				baja_logica = 1
			where id_usuario = @id_usuario_modificado;
	end
		
end

go
------------------------------------------------ FIN LOGUIN----------------------------------------------------------------------

------------------------------------------------ SELECCION DE FUNCIONALIDADES----------------------------------------------------------------------
if EXISTS (SELECT * FROM sysobjects WHERE name='OBTENER_FUNCIONALIDADES_POR_ID_ROL') 
drop procedure OBTENER_FUNCIONALIDADES_POR_ID_ROL

go

create procedure CHAR_DE_30.OBTENER_FUNCIONALIDADES_POR_ID_ROL
	@id_rol numeric(18,0)
as begin 
	select f.id_funcionalidad, f.funcionalidad_nombre
	from CHAR_DE_30.FUNCIONALIDAD as f
	inner join CHAR_DE_30.FUNCIONALIDAD_POR_ROL as r
	on r.id_funcionalidad = f.id_funcionalidad
	where 
		r.id_rol = @id_rol and
		f.habilitado = 1;
end

go 
------------------------------------------------ FIN DE FUNCIONALIDADES----------------------------------------------------------------------

------------------------------------------------ ABM ROL----------------------------------------------------------------------
if EXISTS (SELECT * FROM sysobjects WHERE name='OBTENER_ROLES_POR_ID_USUARIO') 
drop procedure CHAR_DE_30.OBTENER_ROLES_POR_ID_USUARIO

go

create procedure CHAR_DE_30.OBTENER_ROLES_POR_ID_USUARIO
	@id_usuario numeric(18,0)
as begin 
	select r.id_rol, r.rol_nombre, r.habilitado
	from CHAR_DE_30.ROL_POR_USUARIO as ru
	inner join CHAR_DE_30.ROL as r
	on r.id_rol = ru.id_rol
	where
		ru.id_usuario = @id_usuario;
end

go 


--esto hay que mejorarlo agregandole paginado
if EXISTS (SELECT * FROM sysobjects WHERE name='OBTENER_USUARIOS_PARA_ABM_ROL') 
drop procedure CHAR_DE_30.OBTENER_USUARIOS_PARA_ABM_ROL

go

create procedure CHAR_DE_30.OBTENER_USUARIOS_PARA_ABM_ROL
as begin 
	select id_usuario, nick
	from CHAR_DE_30.USUARIO
end

go 


if EXISTS (SELECT * FROM sysobjects WHERE name='ACTUALIZAR_ROL_POR_USUARIO') 
drop procedure CHAR_DE_30.ACTUALIZAR_ROL_POR_USUARIO

go

create procedure CHAR_DE_30.ACTUALIZAR_ROL_POR_USUARIO
	@id_usuario numeric(18,0),
	@id_rol numeric(18,0),
	@lo_tiene_el_usuario bit
as begin 
	
	declare @cont int;

	select @cont = COUNT(*)
	from CHAR_DE_30.ROL_POR_USUARIO
	where 
		id_rol = @id_rol and
		id_usuario = @id_usuario;

	if @cont > 0 begin
		if @lo_tiene_el_usuario = 0 begin
			delete
			from CHAR_DE_30.ROL_POR_USUARIO
			where 
				id_rol = @id_rol and
				id_usuario = @id_usuario;
		end
	end
	else begin
		if @lo_tiene_el_usuario = 1 begin
			insert into CHAR_DE_30.ROL_POR_USUARIO
			values
				(@id_usuario, @id_rol);
		end
	end

end

go 

if EXISTS (SELECT * FROM sysobjects WHERE name='OBTENER_FUNCIONALIDADES_DEL_ROL') 
drop procedure CHAR_DE_30.OBTENER_FUNCIONALIDADES_DEL_ROL

go

create procedure CHAR_DE_30.OBTENER_FUNCIONALIDADES_DEL_ROL
	@id_rol nvarchar(255)
as begin 
	select f.id_funcionalidad, f.funcionalidad_nombre, f.habilitado 
	from CHAR_DE_30.FUNCIONALIDAD as f
	inner join CHAR_DE_30.FUNCIONALIDAD_POR_ROL as fr
	on fr.id_funcionalidad = f.id_funcionalidad
	where
		fr.id_rol = @id_rol;
end

go 


if EXISTS (SELECT * FROM sysobjects WHERE name='INSERTAR_NUEVO_ROL') 
drop procedure CHAR_DE_30.INSERTAR_NUEVO_ROL

go

create procedure CHAR_DE_30.INSERTAR_NUEVO_ROL
	@nombre nvarchar(255),
	@hab bit
as begin 
	insert into CHAR_DE_30.ROL
	values
		(@nombre, @hab);
end

go 


if EXISTS (SELECT * FROM sysobjects WHERE name='ACTUALIZAR_ROL') 
drop procedure CHAR_DE_30.ACTUALIZAR_ROL

go

create procedure CHAR_DE_30.ACTUALIZAR_ROL
	@id_rol numeric(18,0),
	@nombre nvarchar(255),
	@habilitado bit
as begin 
	update CHAR_DE_30.ROL
	set rol_nombre = @nombre, habilitado = @habilitado
	where id_rol = @id_rol;
end

go 


if EXISTS (SELECT * FROM sysobjects WHERE name='ACTUALIZAR_FUNCIONALIDADES_DE_ROL') 
drop procedure CHAR_DE_30.ACTUALIZAR_FUNCIONALIDADES_DE_ROL

go

create procedure CHAR_DE_30.ACTUALIZAR_FUNCIONALIDADES_DE_ROL
	@id_rol numeric(18,0),
	@id_funcionalidad numeric(18,0),
	@lo_tiene bit
as begin 
	
	declare @cont int;

	select @cont = COUNT(*)
	from CHAR_DE_30.FUNCIONALIDAD_POR_ROL
	where 
		id_rol = @id_rol and
		id_funcionalidad = @id_funcionalidad;

	if @cont > 0 begin
		if @lo_tiene = 0 begin
			delete
			from CHAR_DE_30.FUNCIONALIDAD_POR_ROL
			where 
				id_rol = @id_rol and
				id_funcionalidad = @id_funcionalidad;
		end
	end
	else begin
		if @lo_tiene = 1 begin
			insert into CHAR_DE_30.FUNCIONALIDAD_POR_ROL
			values
				(@id_funcionalidad, @id_rol);
		end
	end

end

go 



------------------------------------------------ FIN ABM ROL----------------------------------------------------------------------





--------------------------------------COMIENZO funcionalidad Comprar/Ofertar----------------------------------------------------------------------

-- Procedemiento para busqueda de un producto, se puede filtrar por id_rubro ( o no , segun que decida el usuario)
-- te devuelve 10 productos por paginas

create procedure CHAR_DE_30.st_buscar_publicaciones
@descripcion nvarchar(255) = null,
@rubroId nvarchar(255)= null,
@pagina int
AS
begin

 select*
 from(
      select *,(row_number() over (order by id_publicacion desc) ) as publicaciones
      from CHAR_DE_30.PUBLICACION
      inner join CHAR_DE_30.VISIBILIDAD on id_visibilidad = visibilidad
      inner join CHAR_DE_30.ESTADO_PUBLICACION on id_estado = estado_publicacion
      inner join CHAR_DE_30.TIPO_PUBLICACION on id_tipo = tipo_publicacion
      inner join CHAR_DE_30.RUBRO on id_rubro = rubro
      where (descripcion like '%' + @descripcion + '%') and 
      estado_nombre <> 'BORRADOR' and estado_nombre <> 'FINALIZADA' and
      (id_rubro = @rubroId OR @rubroId IS NULL)
      
      ) gg_vieja
 where publicaciones between (@pagina*10)-9 and (@pagina*10)
 order by precio_visibilidad desc

end

go

-- Procedimientos que usa el store st_insertarCompraSubasta
create procedure CHAR_DE_30.st_actualizar_Estado_Publicacion_a_Finalizado
@publicacion numeric(10,0),
@factura numeric(10,0),
@fecha_operacion datetime

as begin
 declare @stock int
 
      select @stock= stock
	  from CHAR_DE_30.PUBLICACION
	  where id_publicacion = @publicacion

	  if (@stock = 0)
	  begin
	   	    update CHAR_DE_30.PUBLICACION SET estado_publicacion = 4 -- le cambio el estado finalizado
	        where id_publicacion = @publicacion
			--cierro la factura   
		    update CHAR_DE_30.FACTURA SET factura_fecha = @fecha_operacion 
	           where id_factura = @factura
	  end
 
end

go

create PROCEDURE CHAR_DE_30.sp_AgregarOferta(@ofertante numeric(10,0),@publicacion numeric(10,0),
                                  @fecha_oferta datetime,
                                  @monto_ofertado numeric(10,2),@precio_envio int)
AS BEGIN

		INSERT INTO CHAR_DE_30.OFERTA
			(ofertante, publicacion, fecha_oferta,concretada, monto_ofertado,precio_envio)
			VALUES
			(@ofertante, @publicacion, @fecha_oferta, 0, @monto_ofertado,@precio_envio)
			
		update CHAR_DE_30.PUBLICACION SET precio = @monto_ofertado
	       where id_publicacion = @publicacion

END		


go

	create procedure CHAR_DE_30.st_insertarCompraSubasta(@comprador numeric(10,0), 
	    @publicacion numeric(10,0), 
	    @fecha_operacion datetime, @monto numeric(10,2), @cantidad int,
		@precio_envio int,@factura numeric(10,0))
	as begin
	        
			insert into CHAR_DE_30.COMPRA ( comprador, publicacion, fecha_operacion,monto, cantidad )
	           values (@comprador , @publicacion , @fecha_operacion , @monto ,@cantidad )
			   
			insert into CHAR_DE_30.ITEM_FACTURA(id_factura,cantidad_vendida ,precio_unitario,precio_envio )
			   values (@factura , @cantidad, @monto ,@precio_envio )
			   
			exec CHAR_DE_30.st_actualizar_Estado_Publicacion_a_Finalizado @publicacion,@factura,@fecha_operacion

			   
	end


go

--validaciones
create function CHAR_DE_30.mas_de_tres_sin_calificar(@id_cliente numeric(10,0))
returns bit
as
begin
declare @cant int,@bool bit

      select @cant= count(isnull (calif_estrellas,1))
	  from CHAR_DE_30.COMPRA inner join CHAR_DE_30.CALIFICACION on id_calificacion =calificacion
	  where @id_cliente = comprador


	  if (@cant > 3)
	   SET @bool=1
      ELSE
	   SET @bool=0

      return @bool

end

go

create function CHAR_DE_30.publicacion_en_estado_pausado(@id_publicacion numeric(10,0))
returns bit
as
begin
declare @cant int,@bool bit

      select @cant= count(id_publicacion)
	  from CHAR_DE_30.PUBLICACION inner join CHAR_DE_30.ESTADO_PUBLICACION on estado_publicacion = id_estado
	  where id_publicacion = @id_publicacion and estado_nombre = 'PAUSADA'

	  if (@cant <> 0)
	   SET @bool=1
      ELSE
	   SET @bool=0

      return @bool

end

go

--procedemiento para validar antes de comprar, segun el @tipoError deriba en distintas ventanas de c#
create procedure CHAR_DE_30.st_validacion_de_compra_oferta
@id_cliente numeric(10,0),
@usuario_responsable numeric(10,0),
@id_publicacion numeric(10,0),
@tipoError varchar(50)  = 'todo piolaa' out
as
begin
      if(@id_cliente = @usuario_responsable )
	    set @tipoError = 'i' --error, cliente es el mismo
	  if(CHAR_DE_30.publicacion_en_estado_pausado(@id_publicacion) =1)
	    set @tipoError = 'p' --error, publicacion pausada
	  if(CHAR_DE_30.mas_de_tres_sin_calificar(@id_cliente) =1)
	   set @tipoError = 'c' --error, el cliente debe calificar sus compras
	    
end


go

-- Procedimientos que usa el tr_insertarCompra
create procedure CHAR_DE_30.st_agregarCalificacion(@id_calificacion numeric(10,0) output )
as begin
		insert into CHAR_DE_30.CALIFICACION (calif_estrellas,calif_detalle)
		values (null, null)
		set @id_calificacion = scope_identity()
end
go


-- Se dispara cada vez q se inserta una compra ( post-migracion)
create trigger CHAR_DE_30.tr_insertarCompra
	on CHAR_DE_30.COMPRA
	instead of insert

	as begin
	declare @id_calificacion numeric(10,0)

	exec CHAR_DE_30.st_agregarCalificacion @id_calificacion output 
	
	declare @id_compra numeric(10,0), @comprador numeric(10,0), @publicacion numeric(10,0), 
	    @fecha_operacion datetime, @monto numeric(10,2), @cantidad int
			
	select  @id_compra =i.id_compra,@comprador=i.comprador,@publicacion=i.publicacion,@fecha_operacion=i.fecha_operacion,
	        @monto=i.monto, @cantidad=i.cantidad
	from inserted i

	insert into CHAR_DE_30.COMPRA ( comprador, publicacion, fecha_operacion,monto, cantidad,calificacion )
	values (  @comprador , @publicacion , @fecha_operacion , @monto ,
			 @cantidad, @id_calificacion )
	
	update CHAR_DE_30.PUBLICACION SET stock = stock - @cantidad
	 where id_publicacion = @publicacion
	 	 
	end
	

go


create procedure CHAR_DE_30.st_buscar_publicaciones_ULTIMA_PAGINA
@descripcion nvarchar(255) = null,
@rubroId nvarchar(255)= null,
@ultimaPagina int=0 output
AS
begin
declare @paginas int

 select @paginas=count(publicaciones)
 from(
      select (row_number() over (order by id_publicacion desc) ) as publicaciones
      from CHAR_DE_30.PUBLICACION
      inner join CHAR_DE_30.VISIBILIDAD on id_visibilidad = visibilidad
      inner join CHAR_DE_30.ESTADO_PUBLICACION on id_estado = estado_publicacion
      inner join CHAR_DE_30.TIPO_PUBLICACION on id_tipo = tipo_publicacion
      inner join CHAR_DE_30.RUBRO on id_rubro = rubro
      where (descripcion like '%' + @descripcion + '%') and 
      estado_nombre <> 'BORRADOR' and estado_nombre <> 'FINALIZADA' and
      (id_rubro = @rubroId OR @rubroId IS NULL)
      
      ) gg_vieja

	  if((@paginas%10)<>0)
	  begin
	       set @ultimaPagina = (@paginas/10)+1
	  end
	  else
	  begin
	       set @ultimaPagina = (@paginas/10)
	  end

end


go
	
-------------- FIN  funcionalidad Comprar/Ofertar----------------------------------------------------------------------

-------------- Comienzo de Calificar al vendedor----------------------------------------------------------------------

create procedure CHAR_DE_30.st_mostrarPublicacionesSinCalificar(@id_usuario numeric(10,0))
as begin  
	  select  id_publicacion,descripcion,stock,fecha_inicio,
	          fecha_vencimiento,precio,rubro,visibilidad,estado_publicacion,
			  usuario_responsable ,tipo_publicacion,envio,factura,id_calificacion
	  from CHAR_DE_30.COMPRA
	  inner join CHAR_DE_30.PUBLICACION on publicacion = id_publicacion
	  inner join CHAR_DE_30.CALIFICACION on id_calificacion =calificacion
	  where comprador = @id_usuario and calif_estrellas is null
end

go

create procedure CHAR_DE_30.st_insertarCalificacion(
@id_calificacion numeric(10,0),
@calif_estrellas int,
@calif_detalle nvarchar(255) )
as begin  
        update CHAR_DE_30.CALIFICACION set calif_estrellas= @calif_estrellas,calif_detalle =@calif_detalle
		where id_calificacion=@id_calificacion
end

go

create procedure CHAR_DE_30.st_resumenDeEstrellasDadas(@id_usuario numeric(10,0))
as begin

select * into #TablaTemporal --Tabla Temporal
from CHAR_DE_30.COMPRA
inner join CHAR_DE_30.CALIFICACION on id_calificacion =calificacion	
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

create procedure CHAR_DE_30.st_ultimas5compras(@id_usuario numeric(10,0))
as begin  
	  select top 5 descripcion,calif_estrellas
	  from CHAR_DE_30.COMPRA
	  inner join CHAR_DE_30.PUBLICACION on publicacion = id_publicacion
	  inner join CHAR_DE_30.CALIFICACION on id_calificacion =calificacion
	  where comprador = @id_usuario
	  order by fecha_operacion desc
end
go
------------------------------------------------ FIN de Calificar al vendedor----------------------------------------------------------------------


-------------- Historial de Cliente ----------------------------------------------------------------------

create procedure CHAR_DE_30.st_cantidadDeOperacionesSinCalificar(@id_usuario numeric(10,0))
as begin  
	  select  count (*) as alexisManco
	  from CHAR_DE_30.COMPRA
	  inner join CHAR_DE_30.PUBLICACION on publicacion = id_publicacion
	  inner join CHAR_DE_30.CALIFICACION on id_calificacion =calificacion
	  where comprador = @id_usuario and calif_estrellas is null
end

go

create procedure CHAR_DE_30.st_subastasDeCliente
@idUsuario numeric(10,0),
@pagina int
as
begin	
	 select*
 from(
       select id_publicacion,descripcion,tipo,monto_ofertado,concretada,fecha_oferta,
	  (row_number() over (order by id_publicacion desc) ) as publicaciones
			 from CHAR_DE_30.OFERTA o,CHAR_DE_30.PUBLICACION
			 inner join CHAR_DE_30.TIPO_PUBLICACION on id_tipo = tipo_publicacion
			 where (o.publicacion=id_publicacion) and
			 ( o.ofertante=@idUsuario)
      ) gg_vieja
 where publicaciones between (@pagina*10)-9 and (@pagina*10)
  order by fecha_oferta
end

go


create procedure CHAR_DE_30.st_comprasDeCliente
@idUsuario numeric(10,0),
@pagina int
as
begin	
	 select*
 from(
      select id_publicacion,descripcion,tipo,cantidad,monto,fecha_operacion,
	  (row_number() over (order by id_publicacion desc) ) as publicaciones
			 from CHAR_DE_30.COMPRA c,CHAR_DE_30.PUBLICACION
			 inner join CHAR_DE_30.TIPO_PUBLICACION on id_tipo = tipo_publicacion
			 where (c.publicacion=id_publicacion) and
			 (c.comprador=@idUsuario )
      
      ) gg_vieja
 where publicaciones between (@pagina*10)-9 and (@pagina*10)
end

go

create procedure CHAR_DE_30.st_cantidadPaginasSubastasDeCliente
@idUsuario numeric(10,0),
@ultimaPagina numeric(10,0)=0 out
as
begin	
      select @ultimaPagina=count(*)
			 from CHAR_DE_30.OFERTA o,CHAR_DE_30.PUBLICACION
			 inner join CHAR_DE_30.TIPO_PUBLICACION on id_tipo = tipo_publicacion
			 where (o.publicacion=id_publicacion) and
			 ( o.ofertante=@idUsuario)

	  if(((@ultimaPagina/10) - floor(@ultimaPagina/10))>0)
		set @ultimaPagina = (@ultimaPagina/10) + 1;

	  else
		set @ultimaPagina = @ultimaPagina/10;
end

go

create procedure CHAR_DE_30.st_cantidadPaginasComprasDeCliente
@idUsuario numeric(10,0),
@ultimaPagina numeric(10,0)=0 out
as
begin	
      select @ultimaPagina=count(*)
		from CHAR_DE_30.COMPRA c,CHAR_DE_30.PUBLICACION
		inner join CHAR_DE_30.TIPO_PUBLICACION on id_tipo = tipo_publicacion
		where (c.publicacion=id_publicacion) and
		(c.comprador=@idUsuario)

	  if(((@ultimaPagina/10) - floor(@ultimaPagina/10))>0)
		set @ultimaPagina = (@ultimaPagina/10) + 1;

	  else
		set @ultimaPagina = @ultimaPagina/10;
end

go


--resumen de estrallas dadadas, ya fue creado en "Calificar al vendedor" (se recicla)
-- "st_resumenDeEstrellasDadas"


-------------- FIN  funcionalidad "Historial de Cliente"----------------------------------------------------------------------


--------------------------------------------------COMIENZO ABM VISIBILIDAD----------------------------------------------------------------

go
CREATE PROCEDURE CHAR_DE_30.sp_AgregarVisibilidad
	(@visibilidad_nombre nvarchar(255), @precio_visibilidad numeric(10,0), @porcentaje_venta  numeric(10,2))
AS BEGIN
	INSERT INTO CHAR_DE_30.VISIBILIDAD
		(visibilidad_nombre, precio_visibilidad, porcentaje_venta)
	VALUES
		(@visibilidad_nombre, @precio_visibilidad, @porcentaje_venta)

END
GO

/* SP Editar VISIBILIDAD */

CREATE PROCEDURE CHAR_DE_30.sp_EditarVisibilidad
	(@id_visibilidad numeric(10,0), @visibilidad_nombre nvarchar(255), @precio_visibilidad numeric(10,0), 
		@porcentaje_venta  numeric(10,2))
AS BEGIN
	UPDATE CHAR_DE_30.VISIBILIDAD 
	SET visibilidad_nombre = @visibilidad_nombre, precio_visibilidad = @precio_visibilidad,
	porcentaje_venta = @porcentaje_venta
	WHERE id_visibilidad = @id_visibilidad
END
GO

/* SP Eliminar VISIBILIDAD */

create PROCEDURE CHAR_DE_30.sp_EliminarVisibilidad
	@id_visibilidad numeric(10,0),
	@tipoError varchar(50) = 'todo piolaa' out
AS BEGIN

    BEGIN TRY
	    DELETE FROM CHAR_DE_30.VISIBILIDAD WHERE id_visibilidad = @id_visibilidad
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

create function CHAR_DE_30.fu_nombre_visibilidad(@visibilidad numeric(10,0))
returns nvarchar(255)
as
begin
declare @visibilidad_nombre nvarchar(255)

      select @visibilidad_nombre= visibilidad_nombre
	  from CHAR_DE_30.VISIBILIDAD 
	  where id_visibilidad = @visibilidad

      return @visibilidad_nombre

end

go

create function CHAR_DE_30.fu_precio_visibilidad(@visibilidad numeric(10,0))
returns numeric(10,2)
as
begin
declare @precio_visibilidad numeric(10,2)

      select @precio_visibilidad= precio_visibilidad
	  from CHAR_DE_30.VISIBILIDAD 
	  where id_visibilidad = @visibilidad

      return @precio_visibilidad

end

go

create PROCEDURE CHAR_DE_30.sp_AgregarPublicacion
	(@descripcion nvarchar(255),@stock numeric(10,0), @fecha_inicio datetime, 
	 @fecha_vencimiento datetime,@precio numeric(10,2), @rubro numeric(10,0), 
	 @visibilidad numeric(10,0), @estado_publicacion numeric(10,0), @usuario_responsable numeric(10,0),
	 @tipo_publicacion numeric(10,0), @envio bit)
AS BEGIN

        declare @factura numeric (10,0)
		
	   if (@estado_publicacion <> 1)
	       begin
		        INSERT INTO CHAR_DE_30.FACTURA 
		          ( tipo_visibilidad,costo_visibilidad)
			       values
			      (CHAR_DE_30.fu_nombre_visibilidad(@visibilidad),CHAR_DE_30.fu_precio_visibilidad(@visibilidad))
			    SET @factura = SCOPE_IDENTITY();
		   end
		

		
		INSERT INTO CHAR_DE_30.PUBLICACION
			(descripcion, stock, fecha_inicio,fecha_vencimiento, precio, rubro, visibilidad,
			 estado_publicacion, usuario_responsable, tipo_publicacion, envio, factura)
			VALUES
			(@descripcion, @stock, @fecha_inicio, @fecha_vencimiento, @precio, @rubro, @visibilidad,
			 @estado_publicacion, @usuario_responsable, @tipo_publicacion, @envio, @factura)

END

go

create PROCEDURE CHAR_DE_30.sp_AgregarPublicacionGratiss
	(@descripcion nvarchar(255),@stock numeric(10,0), @fecha_inicio datetime, 
	 @fecha_vencimiento datetime,@precio numeric(10,2), @rubro numeric(10,0), 
	 @visibilidad numeric(10,0), @estado_publicacion numeric(10,0), @usuario_responsable numeric(10,0),
	 @tipo_publicacion numeric(10,0), @envio bit)
AS BEGIN

        declare @factura numeric (10,0)
		
	   if (@estado_publicacion <> 1)
	       begin
		        INSERT INTO CHAR_DE_30.FACTURA 
		          ( tipo_visibilidad,costo_visibilidad)
			       values
			      (CHAR_DE_30.fu_nombre_visibilidad(@visibilidad),0)
			    SET @factura = SCOPE_IDENTITY();
		   end
		

		INSERT INTO CHAR_DE_30.PUBLICACION
			(descripcion, stock, fecha_inicio,fecha_vencimiento, precio, rubro, visibilidad,
			 estado_publicacion, usuario_responsable, tipo_publicacion, envio, factura)
			VALUES
			(@descripcion, @stock, @fecha_inicio, @fecha_vencimiento, @precio, @rubro, @visibilidad,
			 @estado_publicacion, @usuario_responsable, @tipo_publicacion, @envio, @factura)

	update CHAR_DE_30.USUARIO set primer_ingreso=0
	where id_usuario=@usuario_responsable

END

go

----------------------  FIN DE GENERAR PUBLICACION----------------------------------------------------------------------


----------------------  COMIENZO DE ESTADISTICAS-------------------------------------------------------------------------------


--Vendedores con mayor cantidad de productos no vendidos, 
--dicho listado debe filtrarse por grado de visibilidad de la publicación y
--por mes-año. Primero se deberá ordenar por fecha y luego por visibilidad.

create procedure CHAR_DE_30.st_top5_vendedores_menos_venta
@mes1 int,
@mes2 int,
@mes3 int,
@anio int,
@visibilidad int=null
AS BEGIN
 
select top 5 nick,mail,count(*) as cant_productos_no_vendidos
FROM CHAR_DE_30.PUBLICACION
inner join CHAR_DE_30.VISIBILIDAD on id_visibilidad = visibilidad
inner join CHAR_DE_30.USUARIO on usuario_responsable = id_usuario
inner join CHAR_DE_30.FACTURA as f on f.id_factura = factura
 where year(f.factura_fecha)= @anio and (
									month(f.factura_fecha)=@mes1 or 
									month(f.factura_fecha)=@mes2 or 
									month(f.factura_fecha)=@mes3
									) and 
(@visibilidad=visibilidad or @visibilidad is null) and
	(select count(*) from CHAR_DE_30.ITEM_FACTURA as i
	 where i.id_factura = f.id_factura
	 )=0
group by nick,mail
 order by cant_productos_no_vendidos desc

 end

 go
 
 /*
create procedure st_top5_vendedores_menos_venta
@mes1 int,
@mes2 int,
@mes3 int,
@anio int,
@visibilidad int=null
AS BEGIN
 
select top 5 nick,mail,count(*) as cant_productos_no_vendidos
FROM PUBLICACION
inner join VISIBILIDAD on id_visibilidad = visibilidad
inner join USUARIO on usuario_responsable = id_usuario
inner join FACTURA on id_factura = factura
where (@mes1=month(factura_fecha) or @mes1 IS NULL) and ( @mes2=month(factura_fecha) or @mes2 IS NULL) and
( @mes3=month(factura_fecha) or  @mes3 IS NULL) and
@anio=year(factura_fecha) and (visibilidad = @visibilidad or @visibilidad IS NULL)
group by nick,mail,factura,factura_fecha,precio_visibilidad 
having 0 =(select count(*) from ITEM_FACTURA
                                   where factura = id_factura )
 order by factura_fecha,precio_visibilidad desc

 end

 go
 */
 create procedure CHAR_DE_30.st_top5_clientes_mas_compras
@mes1 int=null,
@mes2 int=null,
@mes3 int=null,
@anio int=null,
@rubro int=null
as begin
 select top 5 nick,mail,sum(cantidad) cant_de_productos_comprados from CHAR_DE_30.COMPRA
 inner join CHAR_DE_30.USUARIO on comprador=id_usuario
 inner join CHAR_DE_30.PUBLICACION on id_publicacion=publicacion
 where year(fecha_operacion)= @anio and (
									month(fecha_operacion)=@mes1 or 
									month(fecha_operacion)=@mes2 or 
									month(fecha_operacion)=@mes3
									) and 
(@rubro=rubro or @rubro is null)

 group by nick,mail
 order by cant_de_productos_comprados desc

 end

 go
--Clientes con mayor cantidad de productos comprados, por mes y por año, dentro de un rubro particular
/*
create procedure st_top5_clientes_mas_compras
@mes1 int,
@mes2 int,
@mes3 int,
@anio int,
@rubro int=null

AS BEGIN

select top 5 nick,mail,sum(cantidad) as cant_de_productos_comprados
FROM COMPRA
inner join USUARIO on comprador = id_usuario
inner join PUBLICACION on publicacion = id_publicacion
where (@mes1=month(fecha_operacion) or @mes1 IS NULL) and ( @mes2=month(fecha_operacion) or @mes2 IS NULL) and
( @mes3=month(fecha_operacion) or  @mes3 IS NULL) and
@anio=year(fecha_operacion) and (rubro = @rubro or  @rubro IS NULL)
group by nick,mail
order by cant_de_productos_comprados desc

end

go
*/

--Vendedores con mayor cantidad de facturas dentro de un mes y año particular

create procedure CHAR_DE_30.st_top5_vendedores_mayor_facturas
@mes1 int=null,
@mes2 int=null,
@mes3 int=null,
@anio int=null

AS BEGIN

select top 5 nick,mail,count(*) as cant_de_facturas
FROM CHAR_DE_30.PUBLICACION
inner join CHAR_DE_30.USUARIO on usuario_responsable = id_usuario
inner join CHAR_DE_30.FACTURA on id_factura = factura
 where year(factura_fecha)= @anio and (
									month(factura_fecha)=@mes1 or 
									month(factura_fecha)=@mes2 or 
									month(factura_fecha)=@mes3
									)
group by nick,mail
order by cant_de_facturas desc

end

go

/*create procedure st_top5_vendedores_mayor_facturas

@mes1 int,
@mes2 int,
@mes3 int,
@anio int

AS BEGIN

select top 5 nick,mail,count(*) as cant_de_facturas
FROM PUBLICACION
inner join USUARIO on usuario_responsable = id_usuario
inner join FACTURA on id_factura = factura
where (@mes1=month(factura_fecha) or @mes1 IS NULL) and ( @mes2=month(factura_fecha) or @mes2 IS NULL) and
( @mes3=month(factura_fecha) or  @mes3 IS NULL) and
@anio=year(factura_fecha)
group by nick,mail
order by cant_de_facturas desc

end

go*/


--Vendedores con mayor monto facturado dentro de un mes y año particular.

create procedure CHAR_DE_30.st_top5_vendedores_mayor_monto_facturado

@mes1 int,
@mes2 int,
@mes3 int,
@anio int

AS BEGIN

select top 5 nick,mail,sum(precio_unitario*cantidad_vendida+precio_envio) as mayor_monto_facturado
FROM CHAR_DE_30.PUBLICACION
inner join CHAR_DE_30.USUARIO on usuario_responsable = id_usuario
inner join CHAR_DE_30.FACTURA on id_factura = factura
inner join CHAR_DE_30.ITEM_FACTURA i on i.id_factura=factura
 where year(factura_fecha)= @anio and (
									month(factura_fecha)=@mes1 or 
									month(factura_fecha)=@mes2 or 
									month(factura_fecha)=@mes3
									)
group by nick,mail
order by mayor_monto_facturado desc

end

go

/*create procedure st_top5_vendedores_mayor_monto_facturado

@mes1 int,
@mes2 int,
@mes3 int,
@anio int

AS BEGIN

select top 5 nick,mail,sum(precio_unitario*cantidad_vendida+precio_envio) as mayor_monto_facturado
FROM PUBLICACION
inner join USUARIO on usuario_responsable = id_usuario
inner join FACTURA on id_factura = factura
inner join ITEM_FACTURA i on i.id_factura=factura
where (@mes1=month(factura_fecha) or @mes1 IS NULL) and ( @mes2=month(factura_fecha) or @mes2 IS NULL) and
( @mes3=month(factura_fecha) or  @mes3 IS NULL) and
@anio=year(factura_fecha)
group by nick,mail
order by mayor_monto_facturado desc

end

go*/

----------------------  FIN DE ESTADISTICAS----------------------------------------------------------------------

-------------------------------------ABM CLIENTE---------------------------------------------------------------------------------------

create procedure CHAR_DE_30.st_buscar_clientes
@nombre nvarchar(255)='',
@apellido nvarchar(255)='',
@numeroDocumento nvarchar(255)='',
@mail nvarchar(255)=''
as
begin

	select * from CHAR_DE_30.CLIENTE as c
	inner join CHAR_DE_30.USUARIO as u on c.id_usuario=u.id_usuario
	where (c.nombre=@nombre or @nombre='') and 
		  (c.apellido=@apellido or @apellido='') and
		  (c.dni=@numeroDocumento or @numeroDocumento='') and
		  (u.mail=@mail or @mail='')
end

go

CREATE procedure CHAR_DE_30.st_agregar_cliente
@nick nvarchar(255),
@pass nvarchar(255),
@fechaAltaSistema date,
@fechaNacimiento date,		
@mail nvarchar(255),
@telefono nvarchar(60),
@calle nvarchar(255),
@numeroCalle nvarchar(30),
@numeroPiso nvarchar(30),
@departamento nvarchar(50),
@localidad nvarchar(255),
@codigoPostal nvarchar(50),
@nombre nvarchar(255),
@apellido nvarchar(255),
@dni nvarchar(255),
@tipo_documento nvarchar(255),
@error varchar(3) output
as
begin


declare @idUsuario numeric(10,0)

     set @error = 't'
	
	BEGIN TRANSACTION  
     BEGIN TRY 
	insert into CHAR_DE_30.USUARIO(nick,pass,intentos_login,primer_ingreso,baja_logica,fecha_alta_sistema,fecha_nacimiento,
						mail,telefono,calle,numero_calle,numero_piso,departamento,localidad,codigo_postal
					   )
	values (@nick,@pass,0,1,0,@fechaAltaSistema,@fechaNacimiento,@mail,@telefono,@calle,@numeroCalle,
			@numeroPiso,@departamento,@localidad,@codigoPostal)

       select  @idUsuario =max(id_usuario) from CHAR_DE_30.USUARIO

	insert into CHAR_DE_30.CLIENTE(id_usuario,nombre,apellido,dni,tipo_documento)
	values (@idUsuario,@nombre,@apellido,@dni,@tipo_documento)

COMMIT TRAN  
END TRY  

BEGIN CATCH  
ROLLBACK TRAN 
set @error = 'e'
END CATCH 
 
end

go

create procedure CHAR_DE_30.st_modificar_cliente
@idUsuario numeric(10,0),
@idCliente numeric(10,0),
@mail nvarchar(255),
@telefono nvarchar(60),
@calle nvarchar(255),
@numeroCalle nvarchar(30),
@numeroPiso nvarchar(30),
@departamento nvarchar(50),
@localidad nvarchar(255),
@codigoPostal nvarchar(50),
@nombre nvarchar(255),
@apellido nvarchar(255)
as
begin
	
	update CHAR_DE_30.USUARIO set mail=@mail,telefono=@telefono,calle=@calle,numero_calle=@numeroCalle,numero_piso=@numeroPiso,
					   departamento=@departamento,localidad=@localidad,codigo_postal=@codigoPostal
	where id_usuario=@idUsuario

	update CHAR_DE_30.CLIENTE set nombre=@nombre,apellido=@apellido
	where id_cliente=@idCliente

end

go

--------------------------FIN ABM CLIENTE-------------------------------------------------------------------------------------

-------------------------------------ABM EMPRESA---------------------------------------------------------------------------------------

create procedure CHAR_DE_30.st_buscar_empresas
@razonSocial nvarchar(255)='',
@cuit nvarchar(50)='',
@mail nvarchar(255)=''
as
begin

	select * from CHAR_DE_30.EMPRESA as e
	inner join USUARIO as u on e.id_usuario=u.id_usuario
	where (e.razon_social=@razonSocial or @razonSocial='') and 
		  (e.cuit=@cuit or @cuit='') and
		  (u.mail=@mail or @mail='')
end

go

CREATE procedure CHAR_DE_30.st_agregar_empresa
@nick nvarchar(255),
@pass nvarchar(255),
@fechaAltaSistema date,
@fechaNacimiento date,		
@mail nvarchar(255),
@telefono nvarchar(60),
@calle nvarchar(255),
@numeroCalle nvarchar(30),
@numeroPiso nvarchar(30),
@departamento nvarchar(50),
@localidad nvarchar(255),
@codigoPostal nvarchar(50),
@razonSocial nvarchar(255),
@cuit nvarchar(50),
@nombreContacto nvarchar(255),
@ciudad nvarchar(255),
@rubro nvarchar(255),
@error varchar(3) output
as
begin

declare @idUsuario numeric(10,0)
     set @error = 't'

	 BEGIN TRANSACTION  
     BEGIN TRY 
	insert into CHAR_DE_30.USUARIO(nick,pass,intentos_login,primer_ingreso,baja_logica,fecha_alta_sistema,fecha_nacimiento,
						mail,telefono,calle,numero_calle,numero_piso,departamento,localidad,codigo_postal
					   )
	values (@nick,@pass,0,1,0,@fechaAltaSistema,@fechaNacimiento,@mail,@telefono,@calle,@numeroCalle,
			@numeroPiso,@departamento,@localidad,@codigoPostal)

	       select @idUsuario =max(id_usuario) from CHAR_DE_30.USUARIO

	insert into CHAR_DE_30.EMPRESA(id_usuario,razon_social,cuit,nombre_contacto,ciudad,reputacion,rubro,cantidad_votos)
	values (@idUsuario,@razonSocial,@cuit,@nombreContacto,@ciudad,0,@rubro,0)

COMMIT TRAN  
END TRY  

BEGIN CATCH  
ROLLBACK TRAN 
set @error = 'e'
END CATCH 

end

go

create procedure CHAR_DE_30.st_modificar_empresa
@idUsuario numeric(10,0),
@idEmpresa numeric(10,0),
@mail nvarchar(255),
@telefono nvarchar(60),
@calle nvarchar(255),
@numeroCalle nvarchar(30),
@numeroPiso nvarchar(30),
@departamento nvarchar(50),
@localidad nvarchar(255),
@codigoPostal nvarchar(50),
@nombreContacto nvarchar(255),
@ciudad nvarchar(255),
@rubro nvarchar(255)
as
begin
	
	update CHAR_DE_30.USUARIO set mail=@mail,telefono=@telefono,calle=@calle,numero_calle=@numeroCalle,numero_piso=@numeroPiso,
					   departamento=@departamento,localidad=@localidad,codigo_postal=@codigoPostal
	where id_usuario=@idUsuario

	update CHAR_DE_30.EMPRESA set nombre_contacto=@nombreContacto,ciudad=@ciudad,rubro=@rubro
	where id_empresa=@idEmpresa

end

go

--------------------------FIN ABM EMPRESA-------------------------------------------------------------------------------------


--------------------------COMIENZO FACTURAS VENDEDOR-------------------------------------------------------------------------------------

create procedure CHAR_DE_30.st_obtenerFacturasVendedorPorPaginas
@idUsuario numeric(10,0),
@pagina int,
@montoDesde numeric(10,2)=null,
@montoHasta numeric(10,2)=null,
@fechaDesde datetime=null,
@fechaHasta datetime=null
as
begin	
	 select*
 from(
      select f.id_factura,
			 f.forma_pago,
			 f.tipo_visibilidad,
			 f.costo_visibilidad,
			 f.factura_fecha,
			 sum(i.cantidad_vendida*i.precio_unitario*v.porcentaje_venta+i.precio_envio+
			 	f.costo_visibilidad) as total_facturar,
			(row_number() over (order by f.id_factura desc) ) as facturas
      from CHAR_DE_30.FACTURA as f
	  inner join CHAR_DE_30.ITEM_FACTURA as i on i.id_factura=f.id_factura
	  inner join CHAR_DE_30.VISIBILIDAD v on f.tipo_visibilidad=v.visibilidad_nombre
	  inner join CHAR_DE_30.PUBLICACION p on f.id_factura =p.factura
	  where (CAST(f.factura_fecha as DATE)>=@fechaDesde or @fechaDesde is null) and
			(CAST(f.factura_fecha as DATE)<=@fechaHasta or @fechaHasta is null) and
			p.usuario_responsable=@idUsuario 

	  group by f.id_factura,f.forma_pago,f.tipo_visibilidad,f.costo_visibilidad,f.factura_fecha
	  having (sum(i.cantidad_vendida*i.precio_unitario*
	              v.porcentaje_venta+i.precio_envio+f.costo_visibilidad) <=@montoHasta or @montoHasta is null) and 
			 (sum(i.cantidad_vendida*i.precio_unitario*
			      v.porcentaje_venta+i.precio_envio+f.costo_visibilidad) >=@montoDesde or @montoDesde is null)
      
      ) gg_vieja
 where facturas between (@pagina*10)-9 and (@pagina*10)

end

go

create procedure CHAR_DE_30.st_obtenerMaximaPaginaFacturasFiltradas
@idUsuario numeric(10,0),
@montoDesde numeric(10,2)=null,
@montoHasta numeric(10,2)=null,
@fechaDesde datetime=null,
@fechaHasta datetime=null,
@ultimaPagina numeric(10,0)=0 out
AS
begin
declare @paginas int

 select @paginas=count(*)
 from(
      select f.id_factura
      from CHAR_DE_30.FACTURA as f
	  inner join CHAR_DE_30.ITEM_FACTURA as i on i.id_factura=f.id_factura
	  inner join CHAR_DE_30.VISIBILIDAD v on f.tipo_visibilidad=v.visibilidad_nombre
	  inner join CHAR_DE_30.PUBLICACION p on f.id_factura =p.factura
	  where (CAST(f.factura_fecha as DATE)>=@fechaDesde or @fechaDesde is null) and
			(CAST(f.factura_fecha as DATE)<=@fechaHasta or @fechaHasta is null) and
			p.usuario_responsable=@idUsuario 

	  group by f.id_factura,f.forma_pago,f.tipo_visibilidad,f.costo_visibilidad,f.factura_fecha
	  having (sum(i.cantidad_vendida*i.precio_unitario*
	              v.porcentaje_venta+i.precio_envio+f.costo_visibilidad) <=@montoHasta or @montoHasta is null) and 
			 (sum(i.cantidad_vendida*i.precio_unitario*
			      v.porcentaje_venta+i.precio_envio+f.costo_visibilidad) >=@montoDesde or @montoDesde is null)
      
      ) gg_vieja

	  if((@paginas%10)<>0)
	  begin
	       set @ultimaPagina = (@paginas/10)+1
	  end
	  else
	  begin
	       set @ultimaPagina = (@paginas/10)
	  end


end

go

--------------------------FIN FACTURAS VENDEDOR-------------------------------------------------------------------------------------

--Al iniciar la aplicación se tiene que barrer la base de datos para saber que publicaciones
--estan vencidas, a las q estan vencidas hay que finalizarlas y cerrar la factura
--Las subasta vencidas hay q hacer lo mismo, y tambien insertar esa oferta como compra
create procedure CHAR_DE_30.st_actualizar_publicaciones_vencidas
@fechaDelSistema date

AS BEGIN
declare @id_publicacion numeric(10,0), @tipo_publicacion numeric(10,0), @factura numeric(10,0),@precio numeric(10,2),
@descripcion nvarchar(255),
@ofertante numeric(10,0),@precio_envio numeric(10,2),@id_oferta numeric(10,0)

set @ofertante =null

declare miCursor cursor
 for select id_publicacion,tipo_publicacion,
            factura,precio,descripcion 
 FROM CHAR_DE_30.PUBLICACION
 where  (CAST(fecha_vencimiento as DATE)) < @fechaDelSistema and
 estado_publicacion <> 1 AND --distinto de borrador
 estado_publicacion <> 4     --distinto de finalizado
 

open miCursor

fetch next from miCursor into @id_publicacion,@tipo_publicacion,@factura,@precio,@descripcion

while @@fetch_status=0
begin
       UPDATE CHAR_DE_30.PUBLICACION  
       SET estado_publicacion = 4 --finalizado
       where id_publicacion= @id_publicacion
       
       UPDATE CHAR_DE_30.FACTURA  
       SET factura_fecha = @fechaDelSistema --cierro la factura
       where id_factura =@factura

       if(@tipo_publicacion =2) -- si es una subasta
       begin
	       select @ofertante=ofertante,@precio_envio=precio_envio,@id_oferta=id_oferta
	       from OFERTA
	       where publicacion =@id_publicacion and
	       monto_ofertado = @precio

	       if(@ofertante is not null) --valido que alguien oferto por lo menos una vez
	       begin
	            exec CHAR_DE_30.st_insertarCompraSubasta @ofertante,@id_publicacion ,@fechaDelSistema, @precio, 
                              1 ,@precio_envio ,@factura
                
                  UPDATE OFERTA  
                     SET concretada = 1 --cierro la oferta
                       where id_oferta =@id_oferta

           end
       end

       fetch next from miCursor into @id_publicacion,@tipo_publicacion,@factura,@precio,@descripcion  
end

close miCursor

deallocate miCursor

end
