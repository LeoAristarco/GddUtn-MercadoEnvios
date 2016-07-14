
drop procedure CHAR_DE_30.st_buscar_publicaciones

drop procedure CHAR_DE_30.st_actualizar_Estado_Publicacion_a_Finalizado

drop PROCEDURE CHAR_DE_30.sp_AgregarOferta

drop procedure CHAR_DE_30.st_insertarCompraSubasta

drop function CHAR_DE_30.mas_de_tres_sin_calificar

drop function CHAR_DE_30.publicacion_en_estado_pausado

drop procedure CHAR_DE_30.st_validacion_de_compra_oferta

drop procedure CHAR_DE_30.st_agregarCalificacion

drop trigger CHAR_DE_30.tr_insertarCompra

drop procedure CHAR_DE_30.st_buscar_publicaciones_ULTIMA_PAGINA


drop procedure CHAR_DE_30.st_mostrarPublicacionesSinCalificar

drop procedure CHAR_DE_30.st_insertarCalificacion

drop procedure CHAR_DE_30.st_resumenDeEstrellasDadas

drop procedure CHAR_DE_30.st_ultimas5compras


drop procedure CHAR_DE_30.st_cantidadDeOperacionesSinCalificar
drop procedure CHAR_DE_30.st_subastasDeCliente
drop procedure CHAR_DE_30.st_comprasDeCliente
drop procedure CHAR_DE_30.st_cantidadPaginasSubastasDeCliente
drop procedure CHAR_DE_30.st_cantidadPaginasComprasDeCliente


drop PROCEDURE CHAR_DE_30.sp_AgregarVisibilidad

drop PROCEDURE CHAR_DE_30.sp_EditarVisibilidad

drop PROCEDURE CHAR_DE_30.sp_EliminarVisibilidad


drop function CHAR_DE_30.fu_nombre_visibilidad

drop function CHAR_DE_30.fu_precio_visibilidad

drop PROCEDURE CHAR_DE_30.sp_AgregarPublicacion

drop procedure CHAR_DE_30.sp_AgregarPublicacionGratiss


drop procedure CHAR_DE_30.st_top5_vendedores_mayor_facturas

drop procedure CHAR_DE_30.st_top5_vendedores_menos_venta

drop procedure CHAR_DE_30.st_top5_clientes_mas_compras

drop procedure CHAR_DE_30.st_top5_vendedores_mayor_monto_facturado



drop procedure CHAR_DE_30.st_buscar_clientes

drop procedure CHAR_DE_30.st_agregar_cliente

drop procedure CHAR_DE_30.st_modificar_cliente


drop procedure CHAR_DE_30.st_buscar_empresas

drop procedure CHAR_DE_30.st_agregar_empresa

drop procedure CHAR_DE_30.st_modificar_empresa


drop procedure CHAR_DE_30.st_obtenerFacturasVendedorPorPaginas

drop procedure CHAR_DE_30.st_obtenerMaximaPaginaFacturasFiltradas




drop PROCEDURE CHAR_DE_30.st_actualizar_publicaciones_vencidas




--ASI SE BORRAN LAS COSAS, ANTES DE LA ENTREGA ESTO VA A IR A PARAR EN EL SCRIPT DE CREACION
--EN LA PARTE DE BORRADO, SI ROMPE ALGUN BORRADO, ROMPE EL ESQUEMA Y ROMPE EL SCRIPT ENTERO
--ASI QUE OJO
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
