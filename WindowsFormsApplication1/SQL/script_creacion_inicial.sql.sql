USE GD1C2016

go

/********************************************************************************************************************************/
/*VERIFICO EXISTENCIA DE TABLAS ANTSES DE CREARLAS*/
/********************************************************************************************************************************/


if EXISTS (SELECT * FROM sysobjects WHERE name='COMPRA') 
drop table CHAR_DE_30.COMPRA

go

if EXISTS (SELECT * FROM sysobjects WHERE name='CALIFICACION') 
drop table CHAR_DE_30.CALIFICACION

go

if EXISTS (SELECT * FROM sysobjects WHERE name='OFERTA') 
drop table CHAR_DE_30.OFERTA

go


if EXISTS (SELECT * FROM sysobjects WHERE name='PUBLICACION') 
drop table CHAR_DE_30.PUBLICACION

go


if EXISTS (SELECT * FROM sysobjects WHERE name='ESTADO_PUBLICACION') 
drop table CHAR_DE_30.ESTADO_PUBLICACION

go


if EXISTS (SELECT * FROM sysobjects WHERE name='TIPO_PUBLICACION') 
drop table CHAR_DE_30.TIPO_PUBLICACION

go


if EXISTS (SELECT * FROM sysobjects WHERE name='ITEM_FACTURA') 
drop table CHAR_DE_30.ITEM_FACTURA

go

if EXISTS (SELECT * FROM sysobjects WHERE name='FACTURA') 
drop table CHAR_DE_30.FACTURA

go

if EXISTS (SELECT * FROM sysobjects WHERE name='VISIBILIDAD') 
drop table CHAR_DE_30.VISIBILIDAD

go

if EXISTS (SELECT * FROM sysobjects WHERE name='RUBRO') 
drop table CHAR_DE_30.RUBRO

go

if EXISTS (SELECT * FROM sysobjects WHERE name='ROL_POR_USUARIO') 
drop table CHAR_DE_30.ROL_POR_USUARIO

go


if EXISTS (SELECT * FROM sysobjects WHERE name='CLIENTE') 
drop table CHAR_DE_30.CLIENTE

go

if EXISTS (SELECT * FROM sysobjects WHERE name='EMPRESA') 
drop table CHAR_DE_30.EMPRESA

go


if EXISTS (SELECT * FROM sysobjects WHERE name='USUARIO') 
drop table CHAR_DE_30.USUARIO

go

if EXISTS (SELECT * FROM sysobjects WHERE name='FUNCIONALIDAD_POR_ROL') 
drop table CHAR_DE_30.FUNCIONALIDAD_POR_ROL

go

if EXISTS (SELECT * FROM sysobjects WHERE name='ROL') 
drop table CHAR_DE_30.ROL

go


if EXISTS (SELECT * FROM sysobjects WHERE name='FUNCIONALIDAD') 
drop table CHAR_DE_30.FUNCIONALIDAD

go

--funcion
if EXISTS (SELECT * FROM sysobjects WHERE name='fn_hashear_pass') 
drop function CHAR_DE_30.fn_hashear_pass

go

/********************************************************************************************************************************/
/*VERIFICO EXISTENCIA DE OBJETOS ANTSES DE CREARLOS*/
/********************************************************************************************************************************/

------------------------------------------------ ABM USUARIO----------------------------------------------------------------------
if EXISTS (SELECT * FROM sysobjects WHERE name='sp_actualizarUsuario') 
drop procedure CHAR_DE_30.sp_actualizarUsuario

go

if EXISTS (SELECT * FROM sysobjects WHERE name='sp_darDeBajaLogicaAUsuario') 
drop procedure CHAR_DE_30.sp_darDeBajaLogicaAUsuario

go

------------------------------------------------ LOGUIN----------------------------------------------------------------------

if EXISTS (SELECT * FROM sysobjects WHERE name='OBTENER_FUNCIONALIDADES_POR_ID_ROL') 
drop procedure CHAR_DE_30.OBTENER_FUNCIONALIDADES_POR_ID_ROL

go

if EXISTS (SELECT * FROM sysobjects WHERE name='OBTENER_ROLES_POR_ID_USUARIO') 
drop procedure CHAR_DE_30.OBTENER_ROLES_POR_ID_USUARIO

go

------------------------------------------------ SELECCION DE FUNCIONALIDADES----------------------------------------------------------------------

if EXISTS (SELECT * FROM sysobjects WHERE name='OBTENER_FUNCIONALIDADES_DEL_ROL') 
drop procedure CHAR_DE_30.OBTENER_FUNCIONALIDADES_DEL_ROL

go

if EXISTS (SELECT * FROM sysobjects WHERE name='INSERTAR_NUEVO_ROL') 
drop procedure CHAR_DE_30.INSERTAR_NUEVO_ROL

go

if EXISTS (SELECT * FROM sysobjects WHERE name='ACTUALIZAR_ROL') 
drop procedure CHAR_DE_30.ACTUALIZAR_ROL

go

------------------------------------------------ ABM ROL----------------------------------------------------------------------
if EXISTS (SELECT * FROM sysobjects WHERE name='OBTENER_ROLES_POR_ID_USUARIO') 
drop procedure CHAR_DE_30.OBTENER_ROLES_POR_ID_USUARIO

go

if EXISTS (SELECT * FROM sysobjects WHERE name='OBTENER_USUARIOS_PARA_ABM_ROL') 
drop procedure CHAR_DE_30.OBTENER_USUARIOS_PARA_ABM_ROL

go

if EXISTS (SELECT * FROM sysobjects WHERE name='ACTUALIZAR_ROL_POR_USUARIO') 
drop procedure CHAR_DE_30.ACTUALIZAR_ROL_POR_USUARIO

go

if EXISTS (SELECT * FROM sysobjects WHERE name='ACTUALIZAR_FUNCIONALIDADES_DE_ROL') 
drop procedure CHAR_DE_30.ACTUALIZAR_FUNCIONALIDADES_DE_ROL

go 

if EXISTS (SELECT * FROM sysobjects WHERE name='fn_hashear_pass') 
drop function CHAR_DE_30.fn_hashear_pass

go

if EXISTS (SELECT * FROM sysobjects WHERE name='sp_actualizarUsuario') 
drop procedure CHAR_DE_30.sp_actualizarUsuario


go

if EXISTS (SELECT * FROM sysobjects WHERE name='sp_darDeBajaLogicaAUsuario') 
drop procedure CHAR_DE_30.sp_darDeBajaLogicaAUsuario

go

if EXISTS (SELECT * FROM sysobjects WHERE name='VERIFICAR_LOGUEO') 
drop procedure CHAR_DE_30.VERIFICAR_LOGUEO

go

-------------------------------------- Comprar/Ofertar----------------------------------------------------------------------

if EXISTS (SELECT * FROM sysobjects WHERE name='st_buscar_publicaciones') 
drop procedure CHAR_DE_30.st_buscar_publicaciones

go

if EXISTS (SELECT * FROM sysobjects WHERE name='st_actualizar_Estado_Publicacion_a_Finalizado') 
drop procedure CHAR_DE_30.st_actualizar_Estado_Publicacion_a_Finalizado

go

if EXISTS (SELECT * FROM sysobjects WHERE name='sp_AgregarOferta') 
drop procedure CHAR_DE_30.sp_AgregarOferta

go

if EXISTS (SELECT * FROM sysobjects WHERE name='st_insertarCompraSubasta') 
drop procedure CHAR_DE_30.st_insertarCompraSubasta

go

if EXISTS (SELECT * FROM sysobjects WHERE name='mas_de_tres_sin_calificar') 
drop function CHAR_DE_30.mas_de_tres_sin_calificar

go

if EXISTS (SELECT * FROM sysobjects WHERE name='publicacion_en_estado_pausado') 
drop function CHAR_DE_30.publicacion_en_estado_pausado

go

if EXISTS (SELECT * FROM sysobjects WHERE name='st_validacion_de_compra_oferta') 
drop procedure CHAR_DE_30.st_validacion_de_compra_oferta

go

if EXISTS (SELECT * FROM sysobjects WHERE name='st_agregarCalificacion') 
drop procedure CHAR_DE_30.st_agregarCalificacion

go

if EXISTS (SELECT * FROM sysobjects WHERE name='tr_insertarCompra') 
drop trigger CHAR_DE_30.tr_insertarCompra

go

if EXISTS (SELECT * FROM sysobjects WHERE name='st_buscar_publicaciones_ULTIMA_PAGINA') 
drop procedure CHAR_DE_30.st_buscar_publicaciones_ULTIMA_PAGINA

go

---------------------------------- Calificar al vendedor-----------------------------------------

if EXISTS (SELECT * FROM sysobjects WHERE name='st_mostrarPublicacionesSinCalificar') 
drop procedure CHAR_DE_30.st_mostrarPublicacionesSinCalificar

go

if EXISTS (SELECT * FROM sysobjects WHERE name='st_insertarCalificacion') 
drop procedure CHAR_DE_30.st_insertarCalificacion

go

if EXISTS (SELECT * FROM sysobjects WHERE name='st_resumenDeEstrellasDadas') 
drop procedure CHAR_DE_30.st_resumenDeEstrellasDadas

go

if EXISTS (SELECT * FROM sysobjects WHERE name='st_ultimas5compras') 
drop procedure CHAR_DE_30.st_ultimas5compras

go

--------------------------------- Historial de Cliente --------------------------------------

if EXISTS (SELECT * FROM sysobjects WHERE name='st_cantidadDeOperacionesSinCalificar') 
drop procedure CHAR_DE_30.st_cantidadDeOperacionesSinCalificar

go

if EXISTS (SELECT * FROM sysobjects WHERE name='st_subastasDeCliente') 
drop procedure CHAR_DE_30.st_subastasDeCliente

go


if EXISTS (SELECT * FROM sysobjects WHERE name='st_comprasDeCliente') 
drop procedure CHAR_DE_30.st_comprasDeCliente

go


if EXISTS (SELECT * FROM sysobjects WHERE name='st_cantidadPaginasSubastasDeCliente') 
drop procedure CHAR_DE_30.st_cantidadPaginasSubastasDeCliente

go


if EXISTS (SELECT * FROM sysobjects WHERE name='st_cantidadPaginasComprasDeCliente') 
drop procedure CHAR_DE_30.st_cantidadPaginasComprasDeCliente

go


if EXISTS (SELECT * FROM sysobjects WHERE name='st_cantidadDeOperacionesSinCalificar') 
drop procedure CHAR_DE_30.st_cantidadDeOperacionesSinCalificar

go

-------------------------------------------------COMIENZO ABM VISIBILIDAD---------------------------------------------------


if EXISTS (SELECT * FROM sysobjects WHERE name='sp_AgregarVisibilidad') 
drop procedure CHAR_DE_30.sp_AgregarVisibilidad

go


if EXISTS (SELECT * FROM sysobjects WHERE name='sp_EditarVisibilidad') 
drop procedure CHAR_DE_30.sp_EditarVisibilidad

go


if EXISTS (SELECT * FROM sysobjects WHERE name='sp_EliminarVisibilidad') 
drop procedure CHAR_DE_30.sp_EliminarVisibilidad

go

------------------------------------------------HISTORIAL DE CLIENTE-----------------------------------------------------------

---------------------------------------------- GENERAR PUBLICACION-----------------------------------------------------------

if EXISTS (SELECT * FROM sysobjects WHERE name='fu_nombre_visibilidad') 
drop function CHAR_DE_30.fu_nombre_visibilidad

go

if EXISTS (SELECT * FROM sysobjects WHERE name='fu_precio_visibilidad') 
drop function CHAR_DE_30.fu_precio_visibilidad

go

if EXISTS (SELECT * FROM sysobjects WHERE name='sp_AgregarPublicacion') 
drop procedure CHAR_DE_30.sp_AgregarPublicacion

go

if EXISTS (SELECT * FROM sysobjects WHERE name='sp_AgregarPublicacionGratiss') 
drop procedure CHAR_DE_30.sp_AgregarPublicacionGratiss

go

------------------------------------------------------ ESTADISTICAS-----------------------------------------------

if EXISTS (SELECT * FROM sysobjects WHERE name='st_top5_vendedores_menos_venta') 
drop procedure CHAR_DE_30.st_top5_vendedores_menos_venta

go

if EXISTS (SELECT * FROM sysobjects WHERE name='st_top5_clientes_mas_compras') 
drop procedure CHAR_DE_30.st_top5_clientes_mas_compras

go

if EXISTS (SELECT * FROM sysobjects WHERE name='st_top5_vendedores_mayor_facturas') 
drop procedure CHAR_DE_30.st_top5_vendedores_mayor_facturas

go

if EXISTS (SELECT * FROM sysobjects WHERE name='st_top5_vendedores_mayor_monto_facturado') 
drop procedure CHAR_DE_30.st_top5_vendedores_mayor_monto_facturado

go

-----------------------------------------------------ABM CLIENTE--------------------------------------------------------

if EXISTS (SELECT * FROM sysobjects WHERE name='st_buscar_clientes') 
drop procedure CHAR_DE_30.st_buscar_clientes

go

if EXISTS (SELECT * FROM sysobjects WHERE name='st_agregar_cliente') 
drop procedure CHAR_DE_30.st_agregar_cliente

go

if EXISTS (SELECT * FROM sysobjects WHERE name='st_modificar_cliente') 
drop procedure CHAR_DE_30.st_modificar_cliente

go

-------------------------------------ABM EMPRESA-------------------------------------------------

if EXISTS (SELECT * FROM sysobjects WHERE name='st_buscar_empresas') 
drop procedure CHAR_DE_30.st_buscar_empresas

go

if EXISTS (SELECT * FROM sysobjects WHERE name='st_agregar_empresa') 
drop procedure CHAR_DE_30.st_agregar_empresa

go

if EXISTS (SELECT * FROM sysobjects WHERE name='st_modificar_empresa') 
drop procedure CHAR_DE_30.st_modificar_empresa

go

-------------------------------------------------------COMIENZO FACTURAS VENDEDOR--------------------------------------------------------

if EXISTS (SELECT * FROM sysobjects WHERE name='st_obtenerFacturasVendedorPorPaginas') 
drop procedure CHAR_DE_30.st_obtenerFacturasVendedorPorPaginas

go

if EXISTS (SELECT * FROM sysobjects WHERE name='st_obtenerMaximaPaginaFacturasFiltradas') 
drop procedure CHAR_DE_30.st_obtenerMaximaPaginaFacturasFiltradas

go

------------------------------------------------------- CARGA DE PROGRAMA --------------------------------------------------------

if EXISTS (SELECT * FROM sysobjects WHERE name='st_actualizar_publicaciones_vencidas') 
drop procedure CHAR_DE_30.st_actualizar_publicaciones_vencidas

go

/********************************************************************************************************************************/
/*CREO ESQUEMA*/
/********************************************************************************************************************************/

if EXISTS (SELECT * FROM sys.schemas  WHERE name='CHAR_DE_30') 
drop schema CHAR_DE_30 

go

create schema CHAR_DE_30 authorization gd

go

/********************************************************************************************************************************/
/*CREACION DE TABLAS*/
/********************************************************************************************************************************/

create table CHAR_DE_30.FUNCIONALIDAD
(
	id_funcionalidad        numeric(10,0) identity (1,1),
	funcionalidad_nombre    nvarchar(255),
	habilitado   bit,

	PRIMARY KEY (id_funcionalidad)
)

go

create table CHAR_DE_30.ROL
(
	id_rol                 numeric(10,0) identity (1,1),
	rol_nombre             nvarchar(255),
	habilitado             bit,

	PRIMARY KEY (id_rol)
)

go

create table CHAR_DE_30.FUNCIONALIDAD_POR_ROL 
( 
	id_funcionalidad    numeric(10,0) NOT NULL, 
	id_rol			    numeric(10,0) NOT NULL, 
	
	--PRIMARY KEY (id_funcionalidad, id_rol), 
	FOREIGN KEY (id_funcionalidad)           references CHAR_DE_30.FUNCIONALIDAD(id_funcionalidad), 
	FOREIGN KEY (id_rol)		             references CHAR_DE_30.ROL(id_rol)
) 

go

create table CHAR_DE_30.USUARIO
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

CREATE TABLE CHAR_DE_30.CLIENTE
(
	id_cliente			  numeric(10,0) IDENTITY,
	id_usuario			  numeric(10,0),
	nombre				  nvarchar(255),
	apellido			  nvarchar(255),
	dni	                  nvarchar(255),
	tipo_documento		  nvarchar(255),
		
	UNIQUE(dni),
	PRIMARY KEY(id_cliente),
	FOREIGN KEY(id_usuario) references CHAR_DE_30.USUARIO(id_usuario)
)

go

CREATE TABLE CHAR_DE_30.EMPRESA
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
	FOREIGN KEY(id_usuario) REFERENCES CHAR_DE_30.USUARIO(id_usuario)

)

go

create table CHAR_DE_30.ROL_POR_USUARIO 
( 
	id_usuario numeric(10,0) NOT NULL,
	id_rol     numeric(10,0) NOT NULL,

    PRIMARY KEY	(id_usuario, id_rol), 
	FOREIGN KEY (id_usuario) references CHAR_DE_30.USUARIO(id_usuario), 
	FOREIGN KEY (id_rol)     references CHAR_DE_30.ROL(id_rol) 
	
)

go

create table CHAR_DE_30.RUBRO
(
	id_rubro            numeric(10,0)  identity (1,1),
	descripción_corta   varchar(30) NULL, 
	descripción_larga   nvarchar(255),

	PRIMARY KEY (id_rubro)
)

go

create table CHAR_DE_30.VISIBILIDAD
(
	id_visibilidad      numeric(10,0) identity (1,1),
	visibilidad_nombre              nvarchar(255),
	precio_visibilidad  numeric(10,2),
	porcentaje_venta    numeric(10,2),

	UNIQUE (visibilidad_nombre),
	PRIMARY KEY (id_visibilidad)
)

go

create table CHAR_DE_30.ESTADO_PUBLICACION
(
	id_estado  numeric(10,0) identity (1,1),
	estado_nombre     nvarchar(255),

	PRIMARY KEY (id_estado)
)

go

create table CHAR_DE_30.TIPO_PUBLICACION
(
	id_tipo  numeric(10,0) identity (1,1),
	tipo     nvarchar(255),
	
	PRIMARY KEY (id_tipo)
)

go

CREATE TABLE CHAR_DE_30.FACTURA
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

CREATE TABLE CHAR_DE_30.ITEM_FACTURA
(
	id_item			 numeric(10,0) identity (1,1), 
	id_factura		 numeric(10,0) NOT NULL,
	cantidad_vendida numeric(10,0) NOT NULL,
	precio_unitario  numeric(10,2) NOT NULL,
	precio_envio     numeric(10,2),
	
	PRIMARY KEY (id_item),
	FOREIGN KEY(id_factura) REFERENCES CHAR_DE_30.FACTURA(id_factura)
)

go

create table CHAR_DE_30.PUBLICACION
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
	FOREIGN KEY (visibilidad)           references CHAR_DE_30.VISIBILIDAD(id_visibilidad),
	FOREIGN KEY	(estado_publicacion)    references CHAR_DE_30.ESTADO_PUBLICACION(id_estado),
	FOREIGN KEY (tipo_publicacion)      references CHAR_DE_30.TIPO_PUBLICACION(id_tipo),
	FOREIGN KEY	(usuario_responsable)   references CHAR_DE_30.USUARIO(id_usuario),
	FOREIGN KEY (rubro)                 references CHAR_DE_30.RUBRO(id_rubro),
	FOREIGN KEY (factura)  references CHAR_DE_30.FACTURA(id_factura)
)

go

create table CHAR_DE_30.OFERTA
(
	id_oferta      numeric(10,0) identity (1,1),
	ofertante      numeric(10,0),
	publicacion    numeric(10,0),
	fecha_oferta   datetime,
	concretada     bit,
	monto_ofertado numeric(10,2),
	precio_envio   int,

	PRIMARY KEY (id_oferta),
	FOREIGN KEY (ofertante)	  references CHAR_DE_30.USUARIO(id_usuario),
	FOREIGN KEY (publicacion) references CHAR_DE_30.PUBLICACION(id_publicacion)

)

go

create table CHAR_DE_30.CALIFICACION
(
	id_calificacion     numeric(10,0) identity (1,1),
	calif_estrellas     int           NULL, 
	calif_detalle       nvarchar(255) NULL,

	PRIMARY KEY (id_calificacion)
)

go

CREATE TABLE CHAR_DE_30.COMPRA
(
	id_compra		   numeric(10,0) identity (1,1),
	comprador	       numeric(10,0) NOT NULL,
	publicacion	       numeric(10,0) NOT NULL,
	fecha_operacion	   datetime	     NOT NULL,
	monto		       numeric(10,2) NOT NULL,
    cantidad           int,
	calificacion	   numeric(10,0) NULL, 
	
	PRIMARY KEY (id_compra),
	FOREIGN KEY (comprador)	  references CHAR_DE_30.USUARIO(id_usuario),
	FOREIGN KEY (publicacion)  references CHAR_DE_30.PUBLICACION(id_publicacion),
	FOREIGN KEY (calificacion) references CHAR_DE_30.CALIFICACION(id_calificacion)
)

go

/********************************************************************************************************************************/
/*FUNCION HASH Y TRIGGER PARA LA CONTRASEÑA*/
/********************************************************************************************************************************/

--funcion
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


--trigger
if EXISTS (SELECT * FROM sysobjects WHERE name='tg_hashear_pass') 
drop trigger CHAR_DE_30.tg_hashear_pass

go

create trigger CHAR_DE_30.tg_hashear_pass  
on CHAR_DE_30.USUARIO  
instead of insert  
as begin  
    
  insert into CHAR_DE_30.USUARIO  
    select  
      nick,  
      CHAR_DE_30.fn_hashear_pass(pass),  
      intentos_login,  
      primer_ingreso,  
      baja_logica,  
      fecha_alta_sistema,  
      fecha_nacimiento,  
      mail,  
      telefono,  
      calle,  
      numero_calle,  
      numero_piso,  
      departamento,  
      localidad,  
      codigo_postal  
    from inserted   

end  
 
go  

--trigger
if EXISTS (SELECT * FROM sysobjects WHERE name='tg_hashear_pass_update') 
drop trigger CHAR_DE_30.tg_hashear_pass_update

go

create trigger CHAR_DE_30.tg_hashear_pass_update  
on CHAR_DE_30.USUARIO  
after update
as
begin
declare @id_usuario_insertado numeric(18,0);  
 
  select @id_usuario_insertado = id_usuario  
  from inserted

  if(update(pass))
  begin
	update CHAR_DE_30.USUARIO  
    set pass = CHAR_DE_30.fn_hashear_pass(pass)  
	where id_usuario = @id_usuario_insertado 
  end
 
end
 
go  
/********************************************************************************************************************************/
/*CLIENTE*/
/********************************************************************************************************************************/

--creo vista para recorrer
create view CHAR_DE_30.vista_usuarios_clientes_filtrados as 
select distinct
	Publ_Cli_Dni as dni, 
	Publ_Cli_Apeliido as apellido, 
	Publ_Cli_Nombre as nombre, 
	Publ_Cli_Fecha_Nac as nacimiento, 
	Publ_Cli_Mail as mail, 
	Publ_Cli_Dom_Calle as calle, 
	Publ_Cli_Nro_Calle as calle_numero, 
	Publ_Cli_Piso as piso,
	Publ_Cli_Depto as depto,
	Publ_Cli_Cod_Postal as postal
from gd_esquema.Maestra
where 
	Publ_Empresa_Cuit is null and
	Cli_Dni is null;

go

--creo procedimiento
create procedure CHAR_DE_30.MIGRAR_TABLA_USUARIO_CLIENTE
as begin 

	insert into CHAR_DE_30.USUARIO
		select dni, dni, 0, 0, 0, GETDATE(), nacimiento, mail, null, UPPER(calle), calle_numero, piso, depto, null, postal
		from vista_usuarios_clientes_filtrados;
	
	insert into CHAR_DE_30.CLIENTE
		select u.id_usuario, v.nombre, UPPER(v.apellido), v.dni, 'DNI'
		from vista_usuarios_clientes_filtrados as v
		inner join USUARIO as u
		on u.nick = v.dni;
end

go

--ejecuto procedimiento
exec CHAR_DE_30.MIGRAR_TABLA_USUARIO_CLIENTE

go

--libero todo
drop view CHAR_DE_30.vista_usuarios_clientes_filtrados;
drop procedure CHAR_DE_30.MIGRAR_TABLA_USUARIO_CLIENTE;

go

/********************************************************************************************************************************/
/*EMPRESA*/
/********************************************************************************************************************************/

--creo vista para recorrer
create view CHAR_DE_30.vista_usuarios_empresas_filtrados
as
select distinct
	Publ_Empresa_Razon_Social as razon_social,
	Publ_Empresa_Cuit as cuit,
	Publ_Empresa_Fecha_Creacion as nacimiento,
	Publ_Empresa_Mail as mail,
	Publ_Empresa_Dom_Calle as calle,
	Publ_Empresa_Nro_Calle as calle_numero,
	Publ_Empresa_Piso as piso,
	Publ_Empresa_Depto as depto,
	Publ_Empresa_Cod_Postal as postal
from gd_esquema.Maestra
where
	Publ_Cli_Dni is null and 
	Cli_Dni is null

go

--creo vista para la reputacion
create view CHAR_DE_30.vista_suma_y_cantidad_de_calificaciones_por_cuit
as
select 
	Publ_Empresa_Cuit as cuit,
	sum(Calificacion_Cant_Estrellas) as suma, 
	count(Calificacion_Cant_Estrellas) as cantidad
from gd_esquema.Maestra
where 
	Publ_Cli_Dni is null and
	Calificacion_Cant_Estrellas is not null
group by Publ_Empresa_Cuit

go

--creo procedimiento
create procedure CHAR_DE_30.MIGRAR_TABLA_USUARIO_EMPRESA
as begin 

	insert into CHAR_DE_30.USUARIO
		select cuit, cuit, 0, 0, 0, GETDATE(), nacimiento, mail, null, UPPER(calle), calle_numero, piso, depto, null, postal
		from vista_usuarios_empresas_filtrados;
	
	insert into CHAR_DE_30.EMPRESA
		select u.id_usuario, v.razon_social, v.cuit, null, null, s.suma, null, s.cantidad
		from vista_usuarios_empresas_filtrados as v
		inner join USUARIO as u
		on u.nick = v.cuit
		inner join CHAR_DE_30.vista_suma_y_cantidad_de_calificaciones_por_cuit as s
		on v.cuit = s.cuit;
end

go

--ejecuto procedimiento
exec CHAR_DE_30.MIGRAR_TABLA_USUARIO_EMPRESA

go

--libero todo
drop view CHAR_DE_30.vista_usuarios_empresas_filtrados;
drop view CHAR_DE_30.vista_suma_y_cantidad_de_calificaciones_por_cuit;
drop procedure CHAR_DE_30.MIGRAR_TABLA_USUARIO_EMPRESA;

go

/********************************************************************************************************************************/
/*VISIBILIDAD*/
/********************************************************************************************************************************/

insert into CHAR_DE_30.VISIBILIDAD
	values
		('GRATIS', 0, 0),
		('BRONCE', 60, 0.30),	
		('PLATA', 100, 0.20),
		('ORO', 140, 0.15),
		('PLATINO', 180, 0.10);
go

/********************************************************************************************************************************/
/*ESTADO_PUBLICACION*/
/********************************************************************************************************************************/

insert into CHAR_DE_30.ESTADO_PUBLICACION
	values 
		('BORRADOR'),
		('ACTIVA'),
		('PAUSADA'),
		('FINALIZADA');
go

/********************************************************************************************************************************/
/*TIPO_PUBLICACION*/
/********************************************************************************************************************************/

insert into CHAR_DE_30.TIPO_PUBLICACION
	values 
		('COMPRA INMEDIATA'),
		('SUBASTA');
go

/********************************************************************************************************************************/
/*RUBRO*/
/********************************************************************************************************************************/

insert into CHAR_DE_30.RUBRO
	select distinct UPPER(Publicacion_Rubro_Descripcion), null
	from gd_esquema.Maestra
	where 
		Publ_Empresa_Cuit is null and
		Cli_Dni is null and
		Item_Factura_Monto is null;

go

/********************************************************************************************************************************/
/*CALIFICACION*/
/********************************************************************************************************************************/

--agrego un campo necesario para las demas migraciones que voy a eliminar al final
alter table CHAR_DE_30.CALIFICACION 
add codigo_calificacion numeric(18,0); 

go

--creo vista para recorrer la CALIFICACION y la COMPRA
create view CHAR_DE_30.vista_calificaciones
as
select
	Calificacion_Codigo as codigo,
	case 
		when Calificacion_Cant_Estrellas % 2 = 1 
			then (Calificacion_Cant_Estrellas+1)/2		
		else Calificacion_Cant_Estrellas/2
	end	as estrellas,
	Calificacion_Descripcion as descripcion 
from gd_esquema.Maestra
where 
	Compra_Fecha is not null and
	Calificacion_Codigo is not null;

go

insert into CHAR_DE_30.CALIFICACION
	select estrellas, descripcion, codigo
	from CHAR_DE_30.vista_calificaciones

go

--borro todo
drop view CHAR_DE_30.vista_calificaciones

go

/********************************************************************************************************************************/
/*FACTURA*/
/********************************************************************************************************************************/

--agrego campo que necesito para la migracion, al final la elimino
alter table CHAR_DE_30.FACTURA
add factura_numero numeric(18,0);

go

--creo vista para recorrer
create view CHAR_DE_30.vista_facturas
as
select distinct
	UPPER(Forma_Pago_Desc) as forma_pago,
	UPPER(Publicacion_Visibilidad_Desc) as vis_descripcion,
	Factura_Fecha as fecha,
	Factura_Nro as factura_numero,
	Factura_Total as total_factura
from gd_esquema.Maestra
where 
	Factura_Nro is not null;

go

insert into CHAR_DE_30.FACTURA
	select v.forma_pago, v.vis_descripcion, VISIBILIDAD.precio_visibilidad, v.fecha, v.total_factura, v.factura_numero
	from CHAR_DE_30.vista_facturas as v
	inner join CHAR_DE_30.VISIBILIDAD 
	on v.vis_descripcion = VISIBILIDAD.visibilidad_nombre

go

--borro todo
drop view CHAR_DE_30.vista_facturas;

go

/********************************************************************************************************************************/
/*ITEM_FACTURA*/
/********************************************************************************************************************************/

--creo vista de items porque la necesito ahora
create view CHAR_DE_30.vista_items_factura
as
select 
	Item_Factura_Cantidad as cantidad,
	Item_Factura_Monto as precio,
	Factura_Nro as factura_numero
from gd_esquema.Maestra
where 
	Item_Factura_Monto is not null;

go

--creo procedimiento
create procedure CHAR_DE_30.MIGRAR_TABLA_ITEM_FACTURA
as begin

	insert into CHAR_DE_30.ITEM_FACTURA
		select f.id_factura, v.cantidad, v.precio, 0
		from CHAR_DE_30.vista_items_factura as v
		inner join CHAR_DE_30.FACTURA as f
		on v.factura_numero = f.factura_numero;

end

go

--ejecuto procedimiento
exec CHAR_DE_30.MIGRAR_TABLA_ITEM_FACTURA;

go

--borro todo
drop view CHAR_DE_30.vista_items_factura;
drop procedure CHAR_DE_30.MIGRAR_TABLA_ITEM_FACTURA;

go

/********************************************************************************************************************************/
/*PUBLICACIONES*/
/********************************************************************************************************************************/

--agrego un campo necesario para las demas migraciones que voy a eliminar al final
alter table CHAR_DE_30.PUBLICACION 
add codigo_publicacion numeric(18,0); 

go

--creo vista para recorrer
create view CHAR_DE_30.vista_publicaciones
as
select distinct
	Publ_Cli_Dni as dni,
	Publ_Empresa_Cuit as cuit,	
	Publicacion_Cod as codigo,
	Publicacion_Descripcion as descripcion,
	Publicacion_Stock as stock,
	Publicacion_Fecha as creacion,
	Publicacion_Fecha_Venc as vencimiento,
	Publicacion_Precio as precio,
	UPPER(Publicacion_Tipo) as tipo,
	UPPER(Publicacion_Visibilidad_Desc) as vis_nombre,
	Publicacion_Visibilidad_Precio as vis_precio,
	Publicacion_Visibilidad_Porcentaje as vis_porcentaje,
	'ACTIVA' as estado,
	UPPER(Publicacion_Rubro_Descripcion) as rubro,
	Factura_Nro as numero_factura
from gd_esquema.Maestra
where 
	Cli_Dni is null and 
	Factura_Nro is not null;

go

--creo procedimiento
create procedure CHAR_DE_30.MIGRAR_PUBLICACIONES
as begin 

	insert into CHAR_DE_30.PUBLICACION
		select v.descripcion, v.stock, v.creacion, v.vencimiento, v.precio, RUBRO.id_rubro, vis.id_visibilidad, 2, u.id_usuario, tp.id_tipo, 0, fa.id_factura,v.codigo
		from vista_publicaciones as v
		inner join CHAR_DE_30.RUBRO
		on v.rubro = RUBRO.descripción_corta
		inner join CHAR_DE_30.VISIBILIDAD as vis
		on v.vis_nombre = vis.visibilidad_nombre
		inner join CHAR_DE_30.USUARIO as u
		on 
			case 
				when v.dni is not null then CAST(v.dni as nvarchar(255))
				else CAST(v.cuit as nvarchar(255))
			end
			 = u.nick
		inner join CHAR_DE_30.TIPO_PUBLICACION as tp
		on v.tipo = tp.tipo
		inner join CHAR_DE_30.FACTURA as fa
		on v.numero_factura = fa.factura_numero

end

go

--ejecuto procedimiento
exec CHAR_DE_30.MIGRAR_PUBLICACIONES;

go

--libero todo
drop view CHAR_DE_30.vista_publicaciones;
drop procedure CHAR_DE_30.MIGRAR_PUBLICACIONES;

go

/********************************************************************************************************************************/
/*COMPRAS*/
/********************************************************************************************************************************/

--creo vista necesaria, todas las compras estan calificadas
create view CHAR_DE_30.vista_compras_calificadas
as
select  
	Cli_Dni as dni,
	Publicacion_Cod as codigo_publicacion,
	Compra_Fecha as fecha,
	Compra_Cantidad as cantidad,
	Calificacion_Codigo as codigo_calificacion
from gd_esquema.Maestra
where 
	Compra_Fecha is not null and
	Calificacion_Codigo is not null

go

--creo procedimiento
create procedure CHAR_DE_30.MIGRAR_COMPRAS_CALIFICADAS
as begin 

	insert into CHAR_DE_30.COMPRA 
		select u.id_usuario, p.id_publicacion, v.fecha, p.precio, v.cantidad, c.id_calificacion
		from vista_compras_calificadas as v
		inner join CHAR_DE_30.USUARIO as u
		on CAST(v.dni as nvarchar(255)) = u.nick
		inner join CHAR_DE_30.PUBLICACION as p
		on v.codigo_publicacion = p.codigo_publicacion
		inner join CHAR_DE_30.CALIFICACION as c
		on v.codigo_calificacion = c.codigo_calificacion

end

go

--ejecuto procedimiento
exec CHAR_DE_30.MIGRAR_COMPRAS_CALIFICADAS;

go

--libero todo
drop view CHAR_DE_30.vista_compras_calificadas;
drop procedure CHAR_DE_30.MIGRAR_COMPRAS_CALIFICADAS;

go


/********************************************************************************************************************************/
/*OFERTAS*/ --preguntar precio de envio que es un int
/********************************************************************************************************************************/

--vista de maximos montos para el calculo del campo concretada
create view CHAR_DE_30.vista_montos_maximos
as
select 
	Publicacion_Cod as codigo_publicacion,
	MAX(Oferta_Monto) as monto_maximo
from gd_esquema.Maestra 
where
	Oferta_Fecha is not null
group by Publicacion_Cod;

go

--vista a recorrer
create view CHAR_DE_30.vista_ofertas
as
select 
	Publ_Cli_Dni as dni,
	Publ_Empresa_Cuit as cuit,
	Publicacion_Cod as codigo_publicacion,
	Oferta_Fecha as fecha, 
	case 
		when (select vm.monto_maximo from CHAR_DE_30.vista_montos_maximos as vm where vm.codigo_publicacion = Publicacion_Cod and vm.monto_maximo = Oferta_Monto) is null then 0
		else 1
	end as concretado,
	Oferta_Monto as monto
from gd_esquema.Maestra 
where
	Oferta_Fecha is not null;

go 

--creo procedimiento
create procedure CHAR_DE_30.MIGRAR_OFERTAS
as begin 

	insert into CHAR_DE_30.OFERTA
		select u.id_usuario, p.id_publicacion, v.fecha, v.concretado, v.monto, 0
		from vista_ofertas as v
		inner join CHAR_DE_30.USUARIO as u
		on
			case 
				when v.dni is not null then CAST(v.dni as nvarchar(255))
				else CAST(v.cuit as nvarchar(255))
			end
			= u.nick
		inner join PUBLICACION as p
		on v.codigo_publicacion = p.codigo_publicacion;
end

go

--ejecuto procedimiento
exec CHAR_DE_30.MIGRAR_OFERTAS;

go

--libero todo
drop view CHAR_DE_30.vista_montos_maximos;
drop view CHAR_DE_30.vista_ofertas;
drop procedure CHAR_DE_30.MIGRAR_OFERTAS;

go


/********************************************************************************************************************************/
/*ROLES*/
/********************************************************************************************************************************/

insert into CHAR_DE_30.ROL
values
	('EMPRESA', 1),
	('CLIENTE', 1),
	('ADMINISTRATIVO', 1);

go

/********************************************************************************************************************************/
/*FUNCIONALIDAD*/
/********************************************************************************************************************************/

insert into CHAR_DE_30.FUNCIONALIDAD
values
	('ABM_USUARIO', 1), --1
	('ABM_ROL', 1),     --2
	('ABM_RUBRO', 1),   --3
	('ABM_VISIBILIDAD', 1), --4
	('GENERAR_PUBLICACION', 1),--5
	('COMPRAR/OFERTAR', 1),--6
	('HISTORIAL_CLIENTE', 1),--7
	('CALIFICAR_VENDEDOR', 1),--8
	('FACTURAS_REALIZADAS', 1),--9
	('ESTADISTICAS', 1),--10
	('CAMBIAR_PASSWORD', 1);--11

go

/********************************************************************************************************************************/
/*FUNCIONALIDAD POR ROL*/
/********************************************************************************************************************************/
--administrador
insert into CHAR_DE_30.FUNCIONALIDAD_POR_ROL
values
	(1,3),
	(2,3),
	(3,3),
	(4,3),
	(9,3),
	(10,3),
	(11,3);

go

--cliente
insert into CHAR_DE_30.FUNCIONALIDAD_POR_ROL
values
	
	(6,2),
	(7,2),
	(8,2),
	(11,2);

go

--empresa
insert into CHAR_DE_30.FUNCIONALIDAD_POR_ROL
values
	(5,1),
	(11,1);

go

/********************************************************************************************************************************/
/*ELIMINACION DE CAMPOS INNECESARIOS*/
/********************************************************************************************************************************/

--estos campos son agregados para la migracios de los datos usandolos con inner join,
--en el modelo actual son reemplazados por sus respectivos id's

alter table CHAR_DE_30.PUBLICACION 
drop column codigo_publicacion;

go

alter table CHAR_DE_30.FACTURA
drop column factura_numero;

go

alter table CHAR_DE_30.CALIFICACION 
drop column codigo_calificacion;

go

/********************************************************************************************************************************/
/*CREACION DE USUARIO INICIAL*/
/********************************************************************************************************************************/

insert into CHAR_DE_30.USUARIO
values
	('admin','w23e', 0, 1, 0, GETDATE(), null, null, null, null, null, null, null, null, null);

go

--le doy los 3 roles como se pide en el enunciado
insert into CHAR_DE_30.ROL_POR_USUARIO
values
	(96,3),
	(96,2),
	(96,1);

go

/********************************************************************************************************************************/
/*CREACION DE OBJETOS PARA LA APLICACION*/
/********************************************************************************************************************************/

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

      select @cant= count(*)
	  from CHAR_DE_30.COMPRA inner join CHAR_DE_30.CALIFICACION on id_calificacion =calificacion
	  where @id_cliente = comprador and calif_estrellas is null


	  if (@cant >= 3)
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
			p.usuario_responsable=@idUsuario and p.estado_publicacion=4

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
			p.usuario_responsable=@idUsuario and  p.estado_publicacion=4

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
