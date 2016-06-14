USE GD1C2016

insert into USUARIO(nick)
values('pepe49')


insert into FUNCIONALIDAD(funcionalidad_nombre)
values('COMPRAR/OFERTAR')



	   insert into VISIBILIDAD(visibilidad_nombre,precio_visibilidad,porcentaje_venta)
    values('Gratis',0,0)

		insert into VISIBILIDAD(visibilidad_nombre,precio_visibilidad,porcentaje_venta)
    values('Bronze',60,0.30)

		insert into VISIBILIDAD(visibilidad_nombre,precio_visibilidad,porcentaje_venta)
    values('Plata',100,0.20)

		insert into VISIBILIDAD(visibilidad_nombre,precio_visibilidad,porcentaje_venta)
    values('Oro',140,0.15)

		insert into VISIBILIDAD(visibilidad_nombre,precio_visibilidad,porcentaje_venta)
    values('Platino',160,0.10)

	
	
	insert into RUBRO (descripción_larga)
	values('Carpinteria')
	
		insert into RUBRO (descripción_larga)
	values('Gastronomia')
		insert into RUBRO (descripción_larga)
	values('Gardineria')

		insert into RUBRO (descripción_larga)
	values('Indumentaria')
	
	

	insert into ESTADO_PUBLICACION(estado_nombre)
	values('Borrador')
	
	insert into ESTADO_PUBLICACION(estado_nombre)
	values('Activa')

	insert into ESTADO_PUBLICACION(estado_nombre)
	values('Pausado')
	
	insert into ESTADO_PUBLICACION(estado_nombre)
	values('Finalizado')

	insert into TIPO_PUBLICACION(tipo)
	values('Compra')

	insert into TIPO_PUBLICACION(tipo)
	values('Subasta')
	
	
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

	insert into CLIENTE(id_usuario,nombre,dni)
	values(1,'Barcangel',666)

	
insert into OFERTA(ofertante,publicacion)
values(1,1)

insert into OFERTA(ofertante,publicacion)
values(1,5)