select * FROM PUBLICACION

select * FROM COMPRA

select * FROM CALIFICACION

select * FROM FACTURA

select * FROM ITEM_FACTURA




insert into USUARIO(nick)
values('lobo93_kpo_de_kung_fu')

insert into ROL
values
	('EMPRESA', 1),
	('CLIENTE', 1),
	('ADMINISTRATIVO', 1);

go


insert into FUNCIONALIDAD(funcionalidad_nombre)
values('COMPRAR/OFERTAR')



insert into VISIBILIDAD
	values
		('GRATIS', 0, 0),
		('BRONCE', 60, 0.30),	
		('PLATA', 100, 0.20),
		('ORO', 140, 0.15),
		('PLATINO', 180, 0.10);



	
	
	insert into RUBRO (descripción_larga)
	values('Carpinteria')
	
		insert into RUBRO (descripción_larga)
	values('Gastronomia')
		insert into RUBRO (descripción_larga)
	values('Gardineria')

		insert into RUBRO (descripción_larga)
	values('Indumentaria')
	
	

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
	
	
	insert into PUBLICACION(descripcion,stock,fecha_inicio,fecha_vencimiento,precio,
rubro,visibilidad,estado_publicacion,usuario_responsable,tipo_publicacion)
values('maquinita de fideos',6,getdate(),getdate(),500,2,1,2,1,1)

	insert into PUBLICACION(descripcion,stock,fecha_inicio,fecha_vencimiento,precio,
rubro,visibilidad,estado_publicacion,usuario_responsable,tipo_publicacion)
values('maquinita de cortar pasto',6,getdate(),getdate(),500,3,2,2,1,1)

	insert into PUBLICACION(descripcion,stock,fecha_inicio,fecha_vencimiento,precio,
rubro,visibilidad,estado_publicacion,usuario_responsable,tipo_publicacion)
values('maquinita de cortar madera',6,getdate(),getdate(),500,1,3,2,1,1)
	
	insert into PUBLICACION(descripcion,stock,fecha_inicio,fecha_vencimiento,precio,
rubro,visibilidad,estado_publicacion,usuario_responsable,tipo_publicacion)
values('maquinita de cortar ropa',6,getdate(),getdate(),500,4,4,2,1,1)

insert into PUBLICACION(descripcion,stock,fecha_inicio,fecha_vencimiento,precio,
rubro,visibilidad,estado_publicacion,usuario_responsable,tipo_publicacion)
values('Subasta de manaos',6,getdate(),getdate(),500,4,4,2,1,1)
	
	
	insert into CALIFICACION(calif_estrellas)
values(5)
	
		insert into COMPRA ( comprador, publicacion, fecha_operacion,monto, cantidad,calificacion )
	values (  1 , 1 , getdate() , 79 ,1, 1 )

	insert into COMPRA( comprador, publicacion, fecha_operacion,monto, cantidad,calificacion )
	values (1, 2, getdate(),5,1,1)






insert into USUARIO(nick)
values('Ricardios')


insert into CLIENTE(id_usuario,nombre,dni)
values(1,'Barcangel',666)

insert into PUBLICACION(descripcion)
values('Placa de video GeForce')

insert into COMPRA(comprador,calificacion,publicacion,fecha_operacion,monto)
values(1,1,1,GETDATE(),10000)

insert into COMPRA(comprador,calificacion,publicacion,fecha_operacion,monto)
values(1,2,1,GETDATE(),10000)

insert into COMPRA(comprador,calificacion,publicacion,fecha_operacion,monto)
values(1,3,1,GETDATE(),10000)

insert into COMPRA(comprador,calificacion,publicacion,fecha_operacion,monto)
values(1,5,1,GETDATE(),10000)

select * from COMPRA


insert into CALIFICACION(calif_estrellas,calif_detalle)
values(5,'La mejor plaqueta de video')

insert into CALIFICACION(calif_estrellas,calif_detalle)
values(1,'Viene con Windows')

insert into CALIFICACION(calif_estrellas,calif_detalle)
values(5,'Linus')

insert into CALIFICACION(calif_estrellas,calif_detalle)
values(5,'Ubuntu')

select * from CLIENTE
select * from USUARIO
select * from COMPRA
select * from CALIFICACION
	
insert into OFERTA(ofertante,publicacion)
values(1,1)

insert into OFERTA(ofertante,publicacion)
values(1,5)

