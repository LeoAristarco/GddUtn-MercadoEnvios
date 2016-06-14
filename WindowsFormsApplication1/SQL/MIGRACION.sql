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
/*VISIBILIDAD, ESTADO_PUBLICACION, TIPO_PUBLICACION Y RUBRO*/
/********************************************************************************************************************************/

insert into VISIBILIDAD
	values 
		('PLATA', 100, 0.20),
		('BRONCE', 60, 0.30),
		('PLATINO', 180, 0.10),
		('ORO', 140, 0.15),
		('GRATIS', 0, 0);
go

insert into ESTADO_PUBLICACION
	values 
		('BORRADOR'),
		('ACTIVA'),
		('PAUSADA'),
		('FINALIZADA');
go

insert into TIPO_PUBLICACION
	values 
		('COMPRA INMEDIATA'),
		('SUBASTA');
go

insert into RUBRO
	select distinct Publicacion_Rubro_Descripcion, null
	from gd_esquema.Maestra
	where 
		Publ_Empresa_Cuit is null and
		Cli_Dni is null and
		Item_Factura_Monto is null;

go

/********************************************************************************************************************************/
/*PUBLICACIONES DE CLIENTES*/
/********************************************************************************************************************************/

--creo vista para recorrer
create view vista_publicaciones_de_clientes
as
select 
	Publ_Cli_Dni as dni,
	Publicacion_Cod as codigo,
	Publicacion_Descripcion as descripcion,
	Publicacion_Stock as stock,
	Publicacion_Fecha as creacion,
	Publicacion_Fecha_Venc as vencimiento,
	Publicacion_Precio as precio,
	Publicacion_Tipo as tipo,
	UPPER(Publicacion_Visibilidad_Desc) as vis_nombre,
	Publicacion_Visibilidad_Precio as vis_precio,
	Publicacion_Visibilidad_Porcentaje as vis_porcentaje,
	Publicacion_Estado as estado,
	Publicacion_Rubro_Descripcion as rubro
from gd_esquema.Maestra
where 
	Publ_Empresa_Cuit is null and
	Cli_Dni is null and
	Item_Factura_Monto is null;

go

--creo procedimiento
create procedure MIGRAR_PUBLICACIONES_DE_CLIENTES
as begin 

	insert into PUBLICACION
		select v.descripcion, v.stock, v.creacion, v.vencimiento, v.precio, RUBRO.id_rubro, VISIBILIDAD.id_visibilidad, CAST(2 as decimal(10,2)), USUARIO.id_usuario, TIPO_PUBLICACION.id_tipo, 0
		from vista_publicaciones_de_clientes as v
		inner join RUBRO
		on v.rubro = RUBRO.descripción_corta
		inner join VISIBILIDAD
		on v.vis_nombre = VISIBILIDAD.visibilidad_nombre
		inner join USUARIO
		on CAST(v.dni as nvarchar(255)) = USUARIO.nick
		inner join TIPO_PUBLICACION
		on v.tipo = TIPO_PUBLICACION.tipo

end

go

--ejecuto procedimiento
exec MIGRAR_PUBLICACIONES_DE_CLIENTES;

go

--libero todo
drop view vista_publicaciones_de_clientes;
drop procedure MIGRAR_PUBLICACIONES_DE_CLIENTES;

go

/********************************************************************************************************************************/
/*PUBLICACIONES DE EMPRESAS*/
/********************************************************************************************************************************/

--creo vista para recorrer
create view vista_publicaciones_de_empresas
as
select 
	Publ_Empresa_Cuit as cuit,	
	Publicacion_Cod as codigo,
	Publicacion_Descripcion as descripcion,
	Publicacion_Stock as stock,
	Publicacion_Fecha as creacion,
	Publicacion_Fecha_Venc as vencimiento,
	Publicacion_Precio as precio,
	Publicacion_Tipo as tipo,
	UPPER(Publicacion_Visibilidad_Desc) as vis_nombre,
	Publicacion_Visibilidad_Precio as vis_precio,
	Publicacion_Visibilidad_Porcentaje as vis_porcentaje,
	Publicacion_Estado as estado,
	Publicacion_Rubro_Descripcion as rubro
from gd_esquema.Maestra
where 
	Publ_Cli_Dni is null and
	Cli_Dni is null and
	Item_Factura_Monto is null;

go

--creo procedimiento
create procedure MIGRAR_PUBLICACIONES_DE_EMPRESAS
as begin 

	insert into PUBLICACION
		select v.descripcion, v.stock, v.creacion, v.vencimiento, v.precio, RUBRO.id_rubro, VISIBILIDAD.id_visibilidad, CAST(2 as decimal(10,2)), USUARIO.id_usuario, TIPO_PUBLICACION.id_tipo, 0
		from vista_publicaciones_de_empresas as v
		inner join RUBRO
		on v.rubro = RUBRO.descripción_corta
		inner join VISIBILIDAD
		on v.vis_nombre = VISIBILIDAD.visibilidad_nombre
		inner join USUARIO
		on v.cuit = USUARIO.nick
		inner join TIPO_PUBLICACION
		on v.tipo = TIPO_PUBLICACION.tipo;

end

go

--ejecuto procedimiento
exec MIGRAR_PUBLICACIONES_DE_EMPRESAS;

go

--libero todo
drop view vista_publicaciones_de_empresas;
drop procedure MIGRAR_PUBLICACIONES_DE_EMPRESAS;

go