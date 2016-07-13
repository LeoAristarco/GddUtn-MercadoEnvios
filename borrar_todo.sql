

drop procedure st_buscar_publicaciones

drop procedure st_actualizar_Estado_Publicacion_a_Finalizado

drop PROCEDURE sp_AgregarOferta

drop procedure st_insertarCompraSubasta

drop function mas_de_tres_sin_calificar

drop function publicacion_en_estado_pausado

drop procedure st_validacion_de_compra_oferta

drop procedure st_agregarCalificacion

drop trigger tr_insertarCompra

drop procedure st_buscar_publicaciones_ULTIMA_PAGINA


drop procedure st_mostrarPublicacionesSinCalificar

drop procedure st_insertarCalificacion

drop procedure st_resumenDeEstrellasDadas

drop procedure st_ultimas5compras


drop procedure st_cantidadDeOperacionesSinCalificar
drop procedure st_subastasDeCliente
drop procedure st_comprasDeCliente
drop procedure st_cantidadPaginasSubastasDeCliente
drop procedure st_cantidadPaginasComprasDeCliente


drop PROCEDURE sp_AgregarVisibilidad

drop PROCEDURE sp_EditarVisibilidad

drop PROCEDURE sp_EliminarVisibilidad


drop function fu_nombre_visibilidad

drop function fu_precio_visibilidad

drop PROCEDURE sp_AgregarPublicacion

drop procedure sp_AgregarPublicacionGratiss


drop procedure st_top5_vendedores_mayor_facturas

drop procedure st_top5_vendedores_menos_venta

drop procedure st_top5_clientes_mas_compras

drop procedure st_top5_vendedores_mayor_monto_facturado



drop procedure st_buscar_clientes

drop procedure st_agregar_cliente

drop procedure st_modificar_cliente


drop procedure st_buscar_empresas

drop procedure st_agregar_empresa

drop procedure st_modificar_empresa


drop procedure st_obtenerFacturasVendedorPorPaginas

drop procedure st_obtenerMaximaPaginaFacturasFiltradas




drop PROCEDURE st_actualizar_publicaciones_vencidas


--ASI SE BORRAN LAS COSAS, ANTES DE LA ENTREGA ESTO VA A IR A PARAR EN EL SCRIPT DE CREACION
--EN LA PARTE DE BORRADO, SI ROMPE ALGUN BORRADO, ROMPE EL ESQUEMA Y ROMPE EL SCRIPT ENTERO
--ASI QUE OJO
------------------------------------------------ LOGUIN----------------------------------------------------------------------

if EXISTS (SELECT * FROM sysobjects WHERE name='OBTENER_FUNCIONALIDADES_POR_ID_ROL') 
drop procedure VARCHAR_DE_30.OBTENER_FUNCIONALIDADES_POR_ID_ROL

go

if EXISTS (SELECT * FROM sysobjects WHERE name='OBTENER_ROLES_POR_ID_USUARIO') 
drop procedure VARCHAR_DE_30.OBTENER_ROLES_POR_ID_USUARIO

go

------------------------------------------------ SELECCION DE FUNCIONALIDADES----------------------------------------------------------------------

if EXISTS (SELECT * FROM sysobjects WHERE name='OBTENER_FUNCIONALIDADES_DEL_ROL') 
drop procedure VARCHAR_DE_30.VARCHAR_DE_30.OBTENER_FUNCIONALIDADES_DEL_ROL

go

if EXISTS (SELECT * FROM sysobjects WHERE name='INSERTAR_NUEVO_ROL') 
drop procedure VARCHAR_DE_30.VARCHAR_DE_30.INSERTAR_NUEVO_ROL

go

if EXISTS (SELECT * FROM sysobjects WHERE name='ACTUALIZAR_ROL') 
drop procedure VARCHAR_DE_30.VARCHAR_DE_30.ACTUALIZAR_ROL

go

if EXISTS (SELECT * FROM sysobjects WHERE name='ACTUALIZAR_FUNCIONALIDADES_DE_ROL') 
drop procedure VARCHAR_DE_30.VARCHAR_DE_30.ACTUALIZAR_FUNCIONALIDADES_DE_ROL

go

------------------------------------------------ ABM ROL----------------------------------------------------------------------
if EXISTS (SELECT * FROM sysobjects WHERE name='OBTENER_ROLES_POR_ID_USUARIO') 
drop procedure VARCHAR_DE_30.OBTENER_ROLES_POR_ID_USUARIO

go

if EXISTS (SELECT * FROM sysobjects WHERE name='OBTENER_USUARIOS_PARA_ABM_ROL') 
drop procedure VARCHAR_DE_30.OBTENER_USUARIOS_PARA_ABM_ROL

go

if EXISTS (SELECT * FROM sysobjects WHERE name='ACTUALIZAR_ROL_POR_USUARIO') 
drop procedure VARCHAR_DE_30.ACTUALIZAR_ROL_POR_USUARIO

go

if EXISTS (SELECT * FROM sysobjects WHERE name='OBTENER_FUNCIONALIDADES_DEL_ROL') 
drop procedure VARCHAR_DE_30.OBTENER_FUNCIONALIDADES_DEL_ROL

go

if EXISTS (SELECT * FROM sysobjects WHERE name='INSERTAR_NUEVO_ROL') 
drop procedure VARCHAR_DE_30.INSERTAR_NUEVO_ROL

go

if EXISTS (SELECT * FROM sysobjects WHERE name='ACTUALIZAR_ROL') 
drop procedure VARCHAR_DE_30.ACTUALIZAR_ROL

go

if EXISTS (SELECT * FROM sysobjects WHERE name='ACTUALIZAR_FUNCIONALIDADES_DE_ROL') 
drop procedure VARCHAR_DE_30.ACTUALIZAR_FUNCIONALIDADES_DE_ROL

go 
