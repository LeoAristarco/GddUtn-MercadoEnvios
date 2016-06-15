USE GD1C2016

create table FUNCIONALIDAD
(
	id_funcionalidad        numeric(10,0) identity (1,1),
	funcionalidad_nombre    nvarchar(255),
	habilitado   bit,

	PRIMARY KEY (id_funcionalidad)
)

go

create table ROL
(
	id_rol                 numeric(10,0) identity (1,1),
	rol_nombre             nvarchar(255),
	habilitado             bit,

	PRIMARY KEY (id_rol)
)

go

create table FUNCIONALIDAD_POR_ROL 
( 
	id_funcionalidad    numeric(10,0) NOT NULL, 
	id_rol			    numeric(10,0) NOT NULL, 
	
	PRIMARY KEY (id_funcionalidad, id_rol), 
	FOREIGN KEY (id_funcionalidad)           references FUNCIONALIDAD(id_funcionalidad), 
	FOREIGN KEY (id_rol)		             references ROL(id_rol)
) 

go

create table USUARIO
(
	id_usuario             numeric(10,0) identity (1,1),
	nick			       nvarchar(255),
	pass			       nvarchar(255),
	intentos_login         int,
	primer_ingreso         bit,
	baja_logica		       bit,
	fecha_alta_sistema	   date,
	fecha_nacimiento	   date,		
	mail			       nvarchar(255),
	telefono		       nvarchar(60),
	calle			       nvarchar(255),
	numero_calle	       nvarchar(30),
	numero_piso		       nvarchar(30),
	departamento	       nvarchar(50),
	localidad		       nvarchar(255),
	codigo_postal	       nvarchar(50),


	UNIQUE (nick),
	PRIMARY KEY(id_usuario)
)

go

CREATE TABLE CLIENTE
(
	id_cliente			  numeric(10,0) IDENTITY,
	id_usuario			  numeric(10,0),
	nombre				  nvarchar(255),
	apellido			  nvarchar(255),
	dni	                  nvarchar(255),
	tipo_documento		  nvarchar(255),
		
	
	PRIMARY KEY(id_cliente),
	FOREIGN KEY(id_usuario) references USUARIO(id_usuario)
)

go

CREATE TABLE EMPRESA
(
	id_empresa		      numeric(10,0) IDENTITY,
	id_usuario		      numeric(10,0),
	razon_social	      nvarchar(255),
	cuit			      nvarchar(50),
	nombre_contacto       nvarchar(255),
	ciudad			      nvarchar(255),
	reputacion		      numeric(18,2),
	rubro			      nvarchar(255),
	cantidad_votos	      numeric(18,0),

	UNIQUE(razon_social),
	UNIQUE(cuit),
	PRIMARY KEY(id_empresa),
	FOREIGN KEY(id_usuario) REFERENCES USUARIO(id_usuario)

)

go

create table ROL_POR_USUARIO 
( 
	id_usuario numeric(10,0) NOT NULL,
	id_rol     numeric(10,0) NOT NULL,

    PRIMARY KEY	(id_usuario, id_rol), 
	FOREIGN KEY (id_usuario) references USUARIO(id_usuario), 
	FOREIGN KEY (id_rol)     references ROL(id_rol) 
	
)

go

create table RUBRO
(
	id_rubro            numeric(10,0)  identity (1,1),
	descripción_corta   varchar(30) NULL, 
	descripción_larga   nvarchar(255),

	PRIMARY KEY (id_rubro)
)

go

create table VISIBILIDAD
(
	id_visibilidad      numeric(10,0) identity (1,1),
	visibilidad_nombre              nvarchar(255),
	precio_visibilidad  numeric(10,2),
	porcentaje_venta    numeric(10,2),

	UNIQUE (visibilidad_nombre),
	PRIMARY KEY (id_visibilidad)
)

go

create table ESTADO_PUBLICACION
(
	id_estado  numeric(10,0) identity (1,1),
	estado_nombre     nvarchar(255),

	PRIMARY KEY (id_estado)
)

go

create table TIPO_PUBLICACION
(
	id_tipo  numeric(10,0) identity (1,1),
	tipo     nvarchar(255),
	
	PRIMARY KEY (id_tipo)
)

go

CREATE TABLE FACTURA
(
	id_factura		  numeric(10,0) identity (1,1),
	forma_pago		  nvarchar(255) ,
	tipo_visibilidad  nvarchar(255) NOT NULL,
	costo_visibilidad numeric(10,2) NOT NULL,
	factura_fecha	  datetime,
	total_facturar    numeric(10,2),
	
	PRIMARY KEY (id_factura)

)

go

CREATE TABLE ITEM_FACTURA
(
	id_item			 numeric(10,0) identity (1,1), 
	id_factura		 numeric(10,0) NOT NULL,
	descripcion		 nvarchar(255) NOT NULL,
	cantidad_vendida numeric(10,0) NOT NULL,
	precio_unitario  numeric(10,2) NOT NULL,
	precio_envio     numeric(10,2),
	
	PRIMARY KEY (id_item),
	FOREIGN KEY(id_factura) REFERENCES FACTURA(id_factura)
)

go

create table PUBLICACION
(
	id_publicacion      numeric(10,0) identity (1,1),
	descripcion         nvarchar(255),
	stock               numeric(10,0),
	fecha_inicio        datetime,
	fecha_vencimiento   datetime,
	precio              numeric(10,2),
	rubro               numeric(10,0),
	visibilidad         numeric(10,0),
	estado_publicacion  numeric(10,0),
	usuario_responsable numeric(10,0),
	tipo_publicacion    numeric(10,0),
	envio               bit,
	factura             numeric(10,0),
		

	PRIMARY KEY (id_publicacion),
	FOREIGN KEY (visibilidad)           references VISIBILIDAD(id_visibilidad),
	FOREIGN KEY	(estado_publicacion)    references ESTADO_PUBLICACION(id_estado),
	FOREIGN KEY (tipo_publicacion)      references TIPO_PUBLICACION(id_tipo),
	FOREIGN KEY	(usuario_responsable)   references USUARIO(id_usuario),
	FOREIGN KEY (rubro)                 references RUBRO(id_rubro),
	FOREIGN KEY (factura)  references FACTURA(id_factura)
)

go

create table OFERTA
(
	id_oferta      numeric(10,0) identity (1,1),
	ofertante      numeric(10,0),
	publicacion    numeric(10,0),
	fecha_oferta   datetime,
	concretada     bit,
	monto_ofertado numeric(10,2),

	PRIMARY KEY (id_oferta),
	FOREIGN KEY (ofertante)	  references USUARIO(id_usuario),
	FOREIGN KEY (publicacion) references PUBLICACION(id_publicacion)

)

go

create table CALIFICACION
(
	id_calificacion     numeric(10,0) identity (1,1),
	calif_estrellas     int           NULL, 
	calif_detalle       nvarchar(255) NULL,

	PRIMARY KEY (id_calificacion)
)

go

CREATE TABLE COMPRA
(
	id_compra		   numeric(10,0) identity (1,1),
	comprador	       numeric(10,0) NOT NULL,
	publicacion	       numeric(10,0) NOT NULL,
	fecha_operacion	   datetime	     NOT NULL,
	monto		       numeric(10,2) NOT NULL,
    cantidad           int,
	calificacion	   numeric(10,0) NULL, 
	
	PRIMARY KEY (id_compra),
	FOREIGN KEY (comprador)	  references USUARIO(id_usuario),
	FOREIGN KEY (publicacion)  references PUBLICACION(id_publicacion),
	FOREIGN KEY (calificacion) references CALIFICACION(id_calificacion)
)




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
      estado_nombre <> 'BORRADOR' and estado_nombre <> 'FINALIZADO' and
      (id_rubro = @rubroId OR @rubroId IS NULL)
      
      ) gg_vieja
 where publicaciones between (@pagina*10)-9 and (@pagina*10)
 order by precio_visibilidad desc

end


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


create function publicacion_en_estado_pausado(@id_publicacion numeric(10,0))
returns bit
as
begin
declare @cant int,@bool bit

      select @cant= count(id_publicacion)
	  from PUBLICACION inner join ESTADO_PUBLICACION on estado_publicacion = id_estado
	  where id_publicacion = @id_publicacion and estado_nombre = 'PAUSADO'

	  if (@cant <> 0)
	   SET @bool=1
      ELSE
	   SET @bool=0

      return @bool

end

--procedemiento para validar antes de comprar, segun el @tipoError deriba en distintas ventanas de c#
create procedure st_validacion_de_compra_oferta
@id_cliente numeric(10,0),
@usuario_responsable numeric(10,0),
@id_publicacion numeric(10,0),
@tipoError varchar(50) out
as
begin
      if(@id_cliente = @usuario_responsable )
	    set @tipoError = 'error, cliente es el mismo'
	  if(dbo.publicacion_en_estado_pausado(@id_publicacion) =1)
	    set @tipoError = 'error, publicacion pausada'
	  if(dbo.mas_de_tres_sin_calificar(@id_cliente) =1)
	   set @tipoError = 'error, el cliente debe calificar sus compras'
	    
end


-- Procedimientos que usa el tr_insertarCompra
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
	
	create procedure st_insertarCompraSubasta(@comprador numeric(10,0), 
	    @publicacion numeric(10,0), 
	    @fecha_operacion datetime, @monto numeric(10,2), @cantidad int,
		@precio_envio int,@factura numeric(10,0),@descripcion nvarchar(255))
	as begin
	        
			insert into COMPRA ( comprador, publicacion, fecha_operacion,monto, cantidad )
	           values (@comprador , @publicacion , @fecha_operacion , @monto ,@cantidad )
			   
			insert into ITEM_FACTURA(nro_factura ,descripcion,cantidad_vendida ,precio_unitario,precio_envio )
			   values (@factura , @descripcion, @cantidad, @monto ,@precio_envio )
			   
			exec st_actualizar_Estado_Publicacion_a_Finalizado @publicacion,@factura,@fecha_operacion

			   
	end

	
-------------- FIN  funcionalidad Comprar/Ofertar----------------------------------------------------------------------

-------------- Comienzo de Calificar al vendedor----------------------------------------------------------------------

create procedure st_mostrarPublicacionesSinCalificar(@id_usuario numeric(10,0))
as begin  
	  select  *
	  from COMPRA
	  inner join PUBLICACION on publicacion = id_publicacion
	  inner join CALIFICACION on id_calificacion =calificacion
	  where comprador = @id_usuario and calif_estrellas is null
end


create procedure st_insertarCalificacion(
@id_calificacion numeric(10,0),
@calif_estrellas int,
@calif_detalle nvarchar(255) )
as begin  
        update CALIFICACION set calif_estrellas= @calif_estrellas,calif_detalle =@calif_detalle
		where id_calificacion=@id_calificacion
end

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







		/************ABM de usuario*************/

	CREATE PROCEDURE sp_crearUsuario
		@user			nvarchar(255),
		@pass			nvarchar(255),
		@rol			nvarchar(255),
		@mail			nvarchar(255),
		@telefono		nvarchar(60),
		@calle			nvarchar(255),
		@numero_calle	numeric(18,0),
		@numero_piso	nvarchar(30),
		@departamento	nvarchar(50),
		@localidad		nvarchar(255),
		@codigo_postal	nvarchar(50)
		
	AS BEGIN
		INSERT INTO USUARIO(nick,pass,baja_logica,mail,telefono,calle,numero_calle,departamento,localidad,codigo_postal)
		VALUES (@user,@pass,0,@mail,@telefono,@calle,@numero_calle,@numero_piso,@departamento,@localidad,@codigo_postal)		
	END
	GO
	--Falta validar la existencia del usuario

	CREATE PROCEDURE sp_crearCliente
		@nombre				nvarchar(255),
		@apellido			nvarchar(255),
		@dni				numeric(18,0),
		@tipo_documento		nvarchar(255),
		@fecha_nacimiento	date,
		@fecha_creacion		date

	AS BEGIN
		INSERT INTO CLIENTE(nombre,apellido,dni,tipo_documento,fecha_nacimiento,fecha_creacion)
		VALUES (@nombre,@apellido,@dni,@tipo_documento,@fecha_nacimiento,@fecha_creacion)
	END
	GO

	CREATE PROCEDURE sp_crearEmpresa
		@razon_social	nvarchar(255),
		@cuit			nvarchar(50),
		@nombre_contacto nvarchar(255),
		@ciudad			nvarchar(255),
		@rubro			nvarchar(255)
	AS BEGIN
		INSERT INTO EMPRESA(razon_social,cuit,nombre_contacto,ciudad,rubro)	
		VALUES (@razon_social,@cuit,@nombre_contacto,@ciudad,@rubro)
	END
	GO

	--Falta validar la existencia del usuario



--------------------------------------------------COMIENZO ABM VISIBILIDAD----------------------------------------------------------------

CREATE PROCEDURE sp_AgregarVisibilidad
	(@visibilidad_nombre nvarchar(255), @precio_visibilidad numeric(10,0), @porcentaje_venta  numeric(10,0),
	  @retorno numeric(10,0) output)
AS BEGIN
	INSERT INTO VISIBILIDAD
		(visibilidad_nombre, precio_visibilidad, porcentaje_venta)
	VALUES
		(@visibilidad_nombre, @precio_visibilidad, @porcentaje_venta)

	SET @retorno = SCOPE_IDENTITY();
END
GO

/* SP Editar VISIBILIDAD */

CREATE PROCEDURE sp_EditarVisibilidad
	(@id_visibilidad numeric(10,0), @visibilidad_nombre nvarchar(255), @precio_visibilidad numeric(10,0), 
		@porcentaje_venta  numeric(10,0))
AS BEGIN
	UPDATE VISIBILIDAD 
	SET visibilidad_nombre = @visibilidad_nombre, precio_visibilidad = @precio_visibilidad,
	porcentaje_venta = @porcentaje_venta
	WHERE id_visibilidad = @id_visibilidad
END
GO

/* SP Eliminar VISIBILIDAD */

CREATE PROCEDURE sp_EliminarVisibilidad
	(@id_visibilidad numeric(10,0))
AS BEGIN
	DELETE FROM VISIBILIDAD WHERE id_visibilidad = @id_visibilidad
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

	SELECT DISTINCT descripcion
	FROM PUBLICACION INNER JOIN OFERTA ON id_publicacion = publicacion
		INNER JOIN USUARIO U ON U.id_usuario = ofertante
		INNER JOIN CLIENTE C On U.id_usuario = C.id_usuario
	WHERE dni = @dni

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


----------------------  FIN DE GENERAR PUBLICACION----------------------------------------------------------------------


