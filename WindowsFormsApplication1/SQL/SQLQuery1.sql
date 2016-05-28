

create table FUNCIONALIDAD
(
	id_funcionalidad        numeric(10,0) identity (1,1),
	funcionalidad_nombre    nvarchar(255),

	PRIMARY KEY (id_funcionalidad)
)

create table ROL
(
	id_rol       numeric(10,0) identity (1,1),
	rol_nombre   nvarchar(255),
	habilitado   bit,

	PRIMARY KEY (id_rol)
)

create table FUNCIONALIDAD_POR_ROL 
( 
	id_funcionalidad    numeric(10,0) NOT NULL, 
	id_rol			    numeric(10,0) NOT NULL, 
	
	PRIMARY KEY (id_funcionalidad, id_rol), 
	FOREIGN KEY (id_funcionalidad)           references FUNCIONALIDAD(id_funcionalidad), 
	FOREIGN KEY (id_rol)		             references ROL(id_rol)
) 

create table USUARIO
(
	id_usuario      numeric(10,0) identity (1,1),
	username        nvarchar(255),
	password        nvarchar(255),
	intentos_login  int,
	primer_ingreso  bit,
	baja_logica		bit,
	fecha_creacion	datetime,
	mail			nvarchar(255),
	telefono		nvarchar(60),
	calle			nvarchar(255),
	numero_piso		nvarchar(30),
	departamento	nvarchar(50),
	localidad		nvarchar(255),
	codigo_postal	nvarchar(50),


	UNIQUE (username),
	PRIMARY KEY(id_usuario)
)

CREATE TABLE CLIENTE
(
	id_cliente			NUMERIC(10,0) IDENTITY
	id_usuario			NUMERIC(10,0)
	nombre				nvarchar(255)
	apellido			nvarchar(255)
	numero_documento	nvarchar(255) (UNIQUE)
	tipo_documento		nvarchar(255)
	
	PRIMARY KEY(id_cliente),
	FOREIGN KEY(id_usuario) REFERENCES USUARIO(id_usuario)
)

CREATE TABLE EMPRESA
(
	id_empresa		NUMERIC(10,0) IDENTITY,
	id_usuario		NUMERIC(10,0),
	razon_social	nvarchar(255),
	cuit			nvarchar(50),
	nombre_contacto nvarchar(255)
	ciudad			nvarchar(255),
	reputacion		numeric(18,2),

	rubro			nvarchar(255),
	cantidad_votos	numeric(18,0),

	UNIQUE(razon_social),
	UNIQUE(cuit),
	PRIMARY KEY(id_empresa),
	FOREIGN KEY(id_usuario) REFERENCES USUARIO(id_usuario)

)


create table ROL_POR_USUARIO 
( 
	id_usuario numeric(10,0) NOT NULL,
	id_rol     numeric(10,0) NOT NULL,

    PRIMARY KEY	(id_usuario, id_rol), 
	FOREIGN KEY (id_usuario) references USUARIO(id_usuario), 
	FOREIGN KEY (id_rol)     references ROL(id_rol) 
	
)


create table RUBRO
(
	id_rubro            numeric(10,0)  identity (1,1),
	descripción_corta   varchar(30) NULL, 
	descripción_larga   nvarchar(255),

	PRIMARY KEY (id_rubro)
)

create table VISIBILIDAD
(
	id_visibilidad      numeric(10,0) identity (1,1),
	visibilidad_nombre              nvarchar(255),
	precio_visibilidad  numeric(10,2),
	porcentaje_venta    numeric(10,2),

	UNIQUE (visibilidad_nombre),
	PRIMARY KEY (id_visibilidad)
)

create table ESTADO_PUBLICACION
(
	id_estado  numeric(10,0) identity (1,1),
	estado_nombre     nvarchar(255),

	PRIMARY KEY (id_estado)
)

create table TIPO_PUBLICACION
(
	id_tipo  numeric(10,0) identity (1,1),
	tipo     nvarchar(255),
	
	PRIMARY KEY (id_tipo)
)

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

	PRIMARY KEY (id_publicacion),
	FOREIGN KEY (visibilidad)           references VISIBILIDAD(id_visibilidad),
	FOREIGN KEY	(estado_publicacion)    references ESTADO_PUBLICACION(id_estado),
	FOREIGN KEY (tipo_publicacion)      references TIPO_PUBLICACION(id_tipo),
	FOREIGN KEY	(usuario_responsable)   references USUARIO(id_usuario),
	FOREIGN KEY (rubro)                 references RUBRO(id_rubro)
)

create table OFERTA
(
	id_oferta      numeric(10,0) identity (1,1),
	id_ofertante   numeric(10,0),
	id_publicacion numeric(10,0),
	fecha_oferta   datetime,
	concretada     bit,
	monto_ofertado numeric(10,2),

	PRIMARY KEY (id_oferta),
	FOREIGN KEY (id_ofertante)	 references USUARIO(id_usuario),
	FOREIGN KEY (id_publicacion) references PUBLICACION(id_publicacion)

)

create table CALIFICACION
(
	id_calificacion     numeric(10,0) identity (1,1),
	calif_estrellas     int,
	calif_detalle       nvarchar(255),

	PRIMARY KEY (id_calificacion)
)

CREATE TABLE COMPRA
(
	id_compra		   numeric(10,0) identity (1,1),
	id_comprador	   numeric(10,0) NOT NULL,
	id_publicacion	   numeric(10,0) NOT NULL,
	fecha_operacion	   datetime	     NOT NULL,
	monto		       numeric(10,2) NOT NULL,
    cantidad           int,
	id_calificacion	   numeric(10,0) NULL, 
	
	PRIMARY KEY (id_compra),
	FOREIGN KEY (id_comprador)	  references USUARIO(id_usuario),
	FOREIGN KEY (id_publicacion)  references PUBLICACION(id_publicacion),
	FOREIGN KEY (id_calificacion) references CALIFICACION(id_calificacion)
)

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
      order by precio_visibilidad desc
      ) gg_vieja
 where publicaciones between (@pagina*10)-9 and (@pagina*10)

end
