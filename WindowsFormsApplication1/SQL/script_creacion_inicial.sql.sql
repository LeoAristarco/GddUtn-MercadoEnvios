USE GD1C2016

go

/********************************************************************************************************************************/
/*VERIFICO EXISTENCIA DE TABLAS ANTSES DE CREARLAS*/
/********************************************************************************************************************************/

if EXISTS (SELECT * FROM sysobjects WHERE name='FUNCIONALIDAD') 
drop table FUNCIONALIDAD

go

if EXISTS (SELECT * FROM sysobjects WHERE name='ROL') 
drop table ROL

go

if EXISTS (SELECT * FROM sysobjects WHERE name='FUNCIONALIDAD_POR_ROL') 
drop table FUNCIONALIDAD_POR_ROL

go

if EXISTS (SELECT * FROM sysobjects WHERE name='EMPRESA') 
drop table EMPRESA

go

if EXISTS (SELECT * FROM sysobjects WHERE name='CLIENTE') 
drop table CLIENTE

go

if EXISTS (SELECT * FROM sysobjects WHERE name='ROL_POR_USUARIO') 
drop table ROL_POR_USUARIO

go

if EXISTS (SELECT * FROM sysobjects WHERE name='RUBRO') 
drop table RUBRO

go

if EXISTS (SELECT * FROM sysobjects WHERE name='VISIBILIDAD') 
drop table VISIBILIDAD

go

if EXISTS (SELECT * FROM sysobjects WHERE name='ESTADO_PUBLICACION') 
drop table ESTADO_PUBLICACION

go

if EXISTS (SELECT * FROM sysobjects WHERE name='TIPO_PUBLICACION') 
drop table TIPO_PUBLICACION

go

if EXISTS (SELECT * FROM sysobjects WHERE name='FACTURA') 
drop table FACTURA

go

if EXISTS (SELECT * FROM sysobjects WHERE name='ITEM_FACTURA') 
drop table ITEM_FACTURA

go

if EXISTS (SELECT * FROM sysobjects WHERE name='PUBLICACION') 
drop table PUBLICACION

go

if EXISTS (SELECT * FROM sysobjects WHERE name='OFERTA') 
drop table OFERTA

go

if EXISTS (SELECT * FROM sysobjects WHERE name='CALIFICACION') 
drop table CALIFICACION

go

if EXISTS (SELECT * FROM sysobjects WHERE name='COMPRA') 
drop table COMPRA

go

/********************************************************************************************************************************/
/*CREACION DE TABLAS*/
/********************************************************************************************************************************/

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
	
	--PRIMARY KEY (id_funcionalidad, id_rol), 
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
	precio_envio   int,

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

go

/********************************************************************************************************************************/
/*FUNCION HASH Y TRIGGER PARA LA CONTRASEÑA*/
/********************************************************************************************************************************/

--funcion
if EXISTS (SELECT * FROM sysobjects WHERE name='fn_hashear_pass') 
drop function fn_hashear_pass

go

create function fn_hashear_pass (@pass nvarchar(255))
returns nvarchar(255)
as begin
	return(
		SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA2_256', @pass)), 3, 255)
	)
end

go


--trigger
if EXISTS (SELECT * FROM sysobjects WHERE name='tg_hashear_pass') 
drop trigger tg_hashear_pass

go

create trigger tg_hashear_pass  
on USUARIO  
instead of insert  
as begin  
    
  insert into USUARIO  
    select  
      nick,  
      dbo.fn_hashear_pass(pass),  
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
drop trigger tg_hashear_pass_update

go

create trigger tg_hashear_pass_update  
on USUARIO  
after update
as
begin
declare @id_usuario_insertado numeric(18,0);  
 
  select @id_usuario_insertado = id_usuario  
  from inserted

  if(update(pass))
  begin
	update USUARIO  
    set pass = dbo.fn_hashear_pass(pass)  
	where id_usuario = @id_usuario_insertado 
  end
 
end
 
go  
/********************************************************************************************************************************/
/*CLIENTE*/
/********************************************************************************************************************************/

--creo vista para recorrer
create view vista_usuarios_clientes_filtrados as 
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
create procedure MIGRAR_TABLA_USUARIO_CLIENTE
as begin 

	insert into USUARIO
		select dni, dni, 0, 0, 0, GETDATE(), nacimiento, mail, null, UPPER(calle), calle_numero, piso, depto, null, postal
		from vista_usuarios_clientes_filtrados;
	
	insert into CLIENTE
		select u.id_usuario, v.nombre, UPPER(v.apellido), v.dni, 'DNI'
		from vista_usuarios_clientes_filtrados as v
		inner join USUARIO as u
		on u.nick = v.dni;
end

go

--ejecuto procedimiento
exec MIGRAR_TABLA_USUARIO_CLIENTE

go

--libero todo
drop view vista_usuarios_clientes_filtrados;
drop procedure MIGRAR_TABLA_USUARIO_CLIENTE;

go

/********************************************************************************************************************************/
/*EMPRESA*/
/********************************************************************************************************************************/

--creo vista para recorrer
create view vista_usuarios_empresas_filtrados
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
create view vista_suma_y_cantidad_de_calificaciones_por_cuit
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
create procedure MIGRAR_TABLA_USUARIO_EMPRESA
as begin 

	insert into USUARIO
		select cuit, cuit, 0, 0, 0, GETDATE(), nacimiento, mail, null, UPPER(calle), calle_numero, piso, depto, null, postal
		from vista_usuarios_empresas_filtrados;
	
	insert into EMPRESA
		select u.id_usuario, v.razon_social, v.cuit, null, null, s.suma, null, s.cantidad
		from vista_usuarios_empresas_filtrados as v
		inner join USUARIO as u
		on u.nick = v.cuit
		inner join vista_suma_y_cantidad_de_calificaciones_por_cuit as s
		on v.cuit = s.cuit;
end

go

--ejecuto procedimiento
exec MIGRAR_TABLA_USUARIO_EMPRESA

go

--libero todo
drop view vista_usuarios_empresas_filtrados;
drop view vista_suma_y_cantidad_de_calificaciones_por_cuit;
drop procedure MIGRAR_TABLA_USUARIO_EMPRESA;

go

/********************************************************************************************************************************/
/*VISIBILIDAD*/
/********************************************************************************************************************************/

insert into VISIBILIDAD
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

insert into ESTADO_PUBLICACION
	values 
		('BORRADOR'),
		('ACTIVA'),
		('PAUSADA'),
		('FINALIZADA');
go

/********************************************************************************************************************************/
/*TIPO_PUBLICACION*/
/********************************************************************************************************************************/

insert into TIPO_PUBLICACION
	values 
		('COMPRA INMEDIATA'),
		('SUBASTA');
go

/********************************************************************************************************************************/
/*RUBRO*/
/********************************************************************************************************************************/

insert into RUBRO
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
alter table CALIFICACION 
add codigo_calificacion numeric(18,0); 

go

--creo vista para recorrer la CALIFICACION y la COMPRA
create view vista_calificaciones
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

insert into CALIFICACION
	select estrellas, descripcion, codigo
	from vista_calificaciones

go

--borro todo
drop view vista_calificaciones

go

/********************************************************************************************************************************/
/*FACTURA*/
/********************************************************************************************************************************/

--agrego campo que necesito para la migracion, al final la elimino
alter table FACTURA
add factura_numero numeric(18,0);

go

--creo vista para recorrer
create view vista_facturas
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

insert into FACTURA
	select v.forma_pago, v.vis_descripcion, VISIBILIDAD.precio_visibilidad, v.fecha, v.total_factura, v.factura_numero
	from vista_facturas as v
	inner join VISIBILIDAD 
	on v.vis_descripcion = VISIBILIDAD.visibilidad_nombre

go

--borro todo
drop view vista_facturas;

go

/********************************************************************************************************************************/
/*ITEM_FACTURA*/
/********************************************************************************************************************************/

--creo vista de items porque la necesito ahora
create view vista_items_factura
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
create procedure MIGRAR_TABLA_ITEM_FACTURA
as begin

	insert into ITEM_FACTURA
		select FACTURA.id_factura, '', v.cantidad, v.precio, 0
		from vista_items_factura as v
		inner join FACTURA
		on v.factura_numero = FACTURA.factura_numero;

end

go

--ejecuto procedimiento
exec MIGRAR_TABLA_ITEM_FACTURA;

go

--borro todo
drop view vista_items_factura;
drop procedure MIGRAR_TABLA_ITEM_FACTURA;

go

/********************************************************************************************************************************/
/*PUBLICACIONES*/
/********************************************************************************************************************************/

--agrego un campo necesario para las demas migraciones que voy a eliminar al final
alter table PUBLICACION 
add codigo_publicacion numeric(18,0); 

go

--creo vista para recorrer
create view vista_publicaciones
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
create procedure MIGRAR_PUBLICACIONES
as begin 

	insert into PUBLICACION
		select v.descripcion, v.stock, v.creacion, v.vencimiento, v.precio, RUBRO.id_rubro, VISIBILIDAD.id_visibilidad, 2, USUARIO.id_usuario, TIPO_PUBLICACION.id_tipo, 0, FACTURA.id_factura,v.codigo
		from vista_publicaciones as v
		inner join RUBRO
		on v.rubro = RUBRO.descripción_corta
		inner join VISIBILIDAD
		on v.vis_nombre = VISIBILIDAD.visibilidad_nombre
		inner join USUARIO
		on 
			case 
				when v.dni is not null then CAST(v.dni as nvarchar(255))
				else CAST(v.cuit as nvarchar(255))
			end
			 = USUARIO.nick
		inner join TIPO_PUBLICACION
		on v.tipo = TIPO_PUBLICACION.tipo
		inner join FACTURA
		on v.numero_factura = FACTURA.factura_numero

end

go

--ejecuto procedimiento
exec MIGRAR_PUBLICACIONES;

go

--libero todo
drop view vista_publicaciones;
drop procedure MIGRAR_PUBLICACIONES;

go

/********************************************************************************************************************************/
/*COMPRAS*/
/********************************************************************************************************************************/

--creo vista necesaria, todas las compras estan calificadas
create view vista_compras_calificadas
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
create procedure MIGRAR_COMPRAS_CALIFICADAS
as begin 

	insert into COMPRA 
		select USUARIO.id_usuario, PUBLICACION.id_publicacion, v.fecha, PUBLICACION.precio, v.cantidad, CALIFICACION.id_calificacion
		from vista_compras_calificadas as v
		inner join USUARIO
		on CAST(v.dni as nvarchar(255)) = USUARIO.nick
		inner join PUBLICACION
		on v.codigo_publicacion = PUBLICACION.codigo_publicacion
		inner join CALIFICACION
		on v.codigo_calificacion = CALIFICACION.codigo_calificacion

end

go

--ejecuto procedimiento
exec MIGRAR_COMPRAS_CALIFICADAS;

go

--libero todo
drop view vista_compras_calificadas;
drop procedure MIGRAR_COMPRAS_CALIFICADAS;

go


/********************************************************************************************************************************/
/*OFERTAS*/ --preguntar precio de envio que es un int
/********************************************************************************************************************************/

--vista de maximos montos para el calculo del campo concretada
create view vista_montos_maximos
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
create view vista_ofertas
as
select 
	Publ_Cli_Dni as dni,
	Publ_Empresa_Cuit as cuit,
	Publicacion_Cod as codigo_publicacion,
	Oferta_Fecha as fecha, 
	case 
		when (select vm.monto_maximo from vista_montos_maximos as vm where vm.codigo_publicacion = Publicacion_Cod and vm.monto_maximo = Oferta_Monto) is null then 0
		else 1
	end as concretado,
	Oferta_Monto as monto
from gd_esquema.Maestra 
where
	Oferta_Fecha is not null;

go 

--creo procedimiento
create procedure MIGRAR_OFERTAS
as begin 

	insert into OFERTA
		select USUARIO.id_usuario, PUBLICACION.id_publicacion, v.fecha, v.concretado, v.monto, 0
		from vista_ofertas as v
		inner join USUARIO
		on
			case 
				when v.dni is not null then CAST(v.dni as nvarchar(255))
				else CAST(v.cuit as nvarchar(255))
			end
			= USUARIO.nick
		inner join PUBLICACION
		on v.codigo_publicacion = PUBLICACION.codigo_publicacion;
end

go

--ejecuto procedimiento
exec MIGRAR_OFERTAS;

go

--libero todo
drop view vista_montos_maximos;
drop view vista_ofertas;
drop procedure MIGRAR_OFERTAS;

go


/********************************************************************************************************************************/
/*ROLES*/
/********************************************************************************************************************************/

insert into ROL
values
	('EMPRESA', 1),
	('CLIENTE', 1),
	('ADMINISTRATIVO', 1);

go

/********************************************************************************************************************************/
/*FUNCIONALIDAD*/
/********************************************************************************************************************************/

insert into FUNCIONALIDAD
values
	('ABM_USUARIO', 1),
	('ABM_ROL', 1),
	('ABM_RUBRO', 1),
	('ABM_VISIBILIDAD', 1),
	('GENERAR_PUBLICACION', 1),
	('COMPRAR/OFERTAR', 1),
	('HISTORIAL_CLIENTE', 1),
	('CALIFICAR_VENDEDOR', 1),
	('FACTURAS_REALIZADAS', 1),
	('ESTADISTICAS', 1);

go

/********************************************************************************************************************************/
/*FUNCIONALIDAD POR ROL*/
/********************************************************************************************************************************/
--administrador
insert into FUNCIONALIDAD_POR_ROL
values
	(1,3),
	(2,3),
	(3,3),
	(4,3),
	(10,3);

go

--cliente
insert into FUNCIONALIDAD_POR_ROL
values
	(5,2),
	(6,2),
	(7,2),
	(8,2);

go

--empresa
insert into FUNCIONALIDAD_POR_ROL
values
	(5,1),
	(9,1);

go

/********************************************************************************************************************************/
/*ELIMINACION DE CAMPOS INNECESARIOS*/
/********************************************************************************************************************************/

--estos campos son agregados para la migracios de los datos usandolos con inner join,
--en el modelo actual son reemplazados por sus respectivos id's

alter table PUBLICACION 
drop column codigo_publicacion;

go

alter table FACTURA
drop column factura_numero;

go

alter table CALIFICACION 
drop column codigo_calificacion;

go

/********************************************************************************************************************************/
/*CREACION DE USUARIO INICIAL*/
/********************************************************************************************************************************/

insert into USUARIO
values
	('admin','w23e', 0, 1, 0, GETDATE(), null, null, null, null, null, null, null, null, null);

go

--le doy los 3 roles como se pide en el enunciado
insert into ROL_POR_USUARIO
values
	(96,3),
	(96,2),
	(96,1);

go
