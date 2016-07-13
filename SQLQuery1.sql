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
