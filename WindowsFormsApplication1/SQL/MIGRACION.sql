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
		('PLATA', 100, 0.20),
		('BRONCE', 60, 0.30),
		('PLATINO', 180, 0.10),
		('ORO', 140, 0.15),
		('GRATIS', 0, 0);
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
	select distinct Publicacion_Rubro_Descripcion, null
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
	Calificacion_Cant_Estrellas as estrellas,
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
/*FACTURA*/ --preguntar por el costo de visibilidad
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
	Factura_Nro as factura_numero
from gd_esquema.Maestra
where 
	Factura_Nro is not null;

go

insert into FACTURA
	select v.forma_pago, v.vis_descripcion, VISIBILIDAD.precio_visibilidad, v.fecha, 0, v.factura_numero
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
/*
/********************************************************************************************************************************/
/*COMPRAS*/
/********************************************************************************************************************************/

--creo vista necesaria
create view vista_compras_calificadas
as
select  
	Cli_Dni as dni,
	Publicacion_Cod as codigo_publicacion,
	Compra_Fecha as fecha,
	/*el monto lo obtengo sumando las facturas*/
	Compra_Cantidad as cantidad,
	Calificacion_Codigo as codigo_calificacion,
	Calificacion_Cant_Estrellas as estrellas,
	Calificacion_Descripcion as descripcion 
from gd_esquema.Maestra
where 
	Compra_Fecha is not null and
	Calificacion_Codigo is not null


--creo procedimiento
create procedure MIGRAR_COMPRAS_CALIFICADAS
as begin 

	insert into COMPRA /*POR AHORA METO EL MONTO EN 0*/
		select USUARIO.id_usuario, PUBLICACION.id_publicacion, v.fecha, 0, v.cantidad, CALIFICACION.id_calificacion
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

go*/