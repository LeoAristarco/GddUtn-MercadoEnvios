

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
                                  @monto_ofertado numeric(10,2))
AS BEGIN

		INSERT INTO OFERTA
			(ofertante, publicacion, fecha_oferta,concretada, monto_ofertado)
			VALUES
			(@ofertante, @publicacion, @fecha_oferta, 0, @monto_ofertado)
			
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
	    set @tipoError = 'error, cliente es el mismo'
	  if(dbo.publicacion_en_estado_pausado(@id_publicacion) =1)
	    set @tipoError = 'error, publicacion pausada'
	  if(dbo.mas_de_tres_sin_calificar(@id_cliente) =1)
	   set @tipoError = 'error, el cliente debe calificar sus compras'
	    
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
	  select top 5 *
	  from COMPRA
	  inner join PUBLICACION on publicacion = id_publicacion
	  inner join CALIFICACION on id_calificacion =calificacion
	  where comprador = @id_usuario
	  order by fecha_operacion desc
end

------------------------------------------------ FIN de Calificar al vendedor----------------------------------------------------------------------




go


		/************ABM de usuario*************/

	CREATE PROCEDURE sp_crearUsuario(
		@user				nvarchar(255),
		@pass				nvarchar(255),
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
		INSERT INTO USUARIO(nick,pass,intentos_login,baja_logica,mail,telefono,calle,numero_calle,departamento,localidad,codigo_postal,fecha_nacimiento,fecha_alta_sistema)
		VALUES (@user,@pass,0,0,@mail,@telefono,@calle,@numero_calle,@numero_piso,@departamento,@localidad,@codigo_postal,@fecha_nacimiento,GETDATE())		
	END
	GO

	CREATE PROCEDURE sp_actualizarUsuario(
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
	
	CREATE PROCEDURE sp_darDeBajaLogicaAUsuario(@id_usuario numeric(10,0))
	AS BEGIN
		UPDATE USUARIO SET
		baja_logica = 1
		WHERE id_usuario = @id_usuario
	END
	GO

	CREATE PROCEDURE sp_crearCliente(
		@nombre				nvarchar(255),
		@apellido			nvarchar(255),
		@dni				numeric(18,0),
		@tipo_documento		nvarchar(255))

	AS BEGIN
		INSERT INTO CLIENTE(nombre,apellido,dni,tipo_documento)
		VALUES (@nombre,@apellido,@dni,@tipo_documento)
	END
	GO

	CREATE PROCEDURE sp_actualizarCliente(
		@id_usuario			numeric(10,0),
		@nombre				nvarchar(255),
		@apellido			nvarchar(255),
		@dni				numeric(18,0),
		@tipo_documento		nvarchar(255)
		)

	AS BEGIN
		UPDATE CLIENTE SET
		nombre = @nombre,
		apellido = @apellido,
		dni = @dni,
		tipo_documento = @tipo_documento		
		WHERE id_usuario = @id_usuario
	END
	GO
		


	CREATE PROCEDURE sp_crearEmpresa(
		@razon_social	nvarchar(255),
		@cuit			nvarchar(50),
		@nombre_contacto nvarchar(255),
		@ciudad			nvarchar(255),
		@rubro			nvarchar(255))
	AS BEGIN
		INSERT INTO EMPRESA(razon_social,cuit,nombre_contacto,ciudad,rubro)	
		VALUES (@razon_social,@cuit,@nombre_contacto,@ciudad,@rubro)
	END
	GO

	CREATE PROCEDURE sp_actualizarEmpresa(
		@id_empresa		numeric(10,0),
		@razon_social	nvarchar(255),
		@cuit			nvarchar(50),
		@nombre_contacto nvarchar(255),
		@ciudad			nvarchar(255),
		@rubro			nvarchar(255))
	AS BEGIN
		UPDATE EMPRESA SET
		razon_social = @razon_social,
		cuit = @cuit,
		nombre_contacto = @nombre_contacto,
		ciudad = @ciudad,
		rubro = @rubro
		WHERE id_empresa = @id_empresa
	END
	GO

/**********************Fin de ABM de Usuario*******************************/

--------------------------------------------------COMIENZO ABM VISIBILIDAD----------------------------------------------------------------

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
	 set @tipoError = 'error, no se puede borrar la visibilidad'
    END CATCH

END
GO

--------------------------------------------------FIN VISIBILIDAD----------------------------------------------------------------

--------------HISTORIAL DE CLIENTE------------

CREATE PROCEDURE sp_HistorialDelCliente (@dni varchar(255))
AS BEGIN
	SELECT descripcion
	FROM PUBLICACION INNER JOIN COMPRA ON id_publicacion = publicacion
		INNER JOIN USUARIO U ON U.id_usuario = comprador
		INNER JOIN CLIENTE C ON U.id_usuario = C.id_usuario 
	WHERE dni = @dni

	UNION

	SELECT  descripcion
	FROM PUBLICACION INNER JOIN OFERTA ON id_publicacion = publicacion
		INNER JOIN USUARIO U ON U.id_usuario = ofertante
		INNER JOIN CLIENTE C On U.id_usuario = C.id_usuario
	WHERE dni = @dni
END
GO


CREATE FUNCTION fu_cantDeOperacionesSinCalificar(@cliente numeric(10,0))
	RETURNS int
AS BEGIN
	DECLARE @cant int
		SELECT @cant = COUNT(*)
		FROM COMPRA INNER JOIN USUARIO U ON comprador = U.id_usuario
				INNER JOIN CLIENTE C ON U.id_usuario = C.id_usuario
		WHERE id_cliente = @cliente AND calificacion IS NULL

	RETURN @cant
END
GO


CREATE FUNCTION fu_resumenDeEstrellasDadas(@cliente numeric(10,0))
	RETURNS int
AS BEGIN
	DECLARE @resumen int
		SELECT @resumen = AVG(calif_estrellas)
		FROM CALIFICACION INNER JOIN COMPRA ON calificacion = id_calificacion
			INNER JOIN USUARIO U ON comprador = id_usuario
			INNER JOIN CLIENTE C ON U.id_usuario = C.id_usuario
		WHERE id_cliente = @cliente
	RETURN @resumen
END
GO


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


------------------------------------------------ INICIO LOGUIN----------------------------------------------------------------------
create procedure VERIFICAR_LOGUEO
	@nick nvarchar(255), 
	@pass nvarchar(255)
as begin
	
	declare 
		@filas int,
		@intentos int;

	select top 1 @filas = COUNT(*)
	from USUARIO
	where 
		nick = @nick and 
		pass = @pass;

	if(@filas = 0) begin
		select @intentos = intentos_login
		from USUARIO
		where nick = @nick;
		
		if(@intentos < 3) begin
			Set @intentos = @intentos + 1;

			update USUARIO
			set intentos_login = @intentos
			where nick = @nick;
		end

		if (@intentos = 3) begin 
			update USUARIO
			set 
				intentos_login = 0,
				baja_logica = 1
			where nick = @nick;

		end
		
	end
	
	else begin
		update USUARIO
		set intentos_login = 0
		where nick = @nick;
	end
	
	select u.id_usuario, u.nick, u.pass, ru.id_rol, r.rol_nombre, u.intentos_login, u.baja_logica
	from USUARIO as u
	inner join ROL_POR_USUARIO as ru
	on  u.id_usuario = ru.id_usuario
	inner join ROL as r
	on ru.id_rol = r.id_rol
	where u.nick = @nick and u.pass = @pass

end

go
------------------------------------------------ FIN LOGUIN----------------------------------------------------------------------

