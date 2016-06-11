/********************************************************************************************************************************/
/*CLIENTE*/
/********************************************************************************************************************************/

--creo vista para recorrer
create view vista_usuarios_clientes_filtrados as 
select distinct
	Publ_Cli_Dni, 
	Publ_Cli_Apeliido, 
	Publ_Cli_Nombre, 
	Publ_Cli_Fecha_Nac, 
	Publ_Cli_Mail, 
	Publ_Cli_Dom_Calle, 
	Publ_Cli_Nro_Calle, 
	Publ_Cli_Piso,
	Publ_Cli_Depto,
	Publ_Cli_Cod_Postal
from gd_esquema.Maestra
where 
	Publ_Empresa_Cuit is null and
	Cli_Dni is null;

go

--creo cursor para recorrer la vista
declare cursor_vista_usuarios cursor for
	select *
	from vista_usuarios_clientes_filtrados;

go

--creo una funcion que voy a necesitar despues
create function obtener_id_usuario_por_usuername(@username nvarchar(255))
returns numeric(10,0)
as begin
	return (
		select id_usuario
		from USUARIO
		where username = @username)
end

go

--creo procedimiento
create procedure MIGRAR_TABLA_USUARIO_CLIENTE
as begin 
	declare 
		@dni as nvarchar(255),
		@apellido as nvarchar(255),
		@nombre as nvarchar(255),
		@fecha_nacimiento as date,
		@mail as nvarchar(255),
		@calle_domicilio as nvarchar(255),
		@calle_numero as nvarchar(255),
		@piso as nvarchar(255),
		@departamento as nvarchar(255),
		@codigo_postal as nvarchar(255);
	
	open cursor_vista_usuarios;
		
	while (@@FETCH_STATUS = 0) begin
		
		fetch next from cursor_vista_usuarios
			into @dni, @apellido, @nombre, @fecha_nacimiento, @mail, @calle_domicilio, @calle_numero, @piso, @departamento, @codigo_postal;

		insert into USUARIO 
			(username, contrasenia, intentos_login, primer_ingreso, baja_logica, fecha_creacion, mail, telefono, calle, numero_piso, departamento, localidad, codigo_postal)
		values 
			(@dni, @dni, 0, 0, 0, GETDATE(), @mail, null, UPPER(@calle_domicilio), @piso, UPPER(@departamento), null, @codigo_postal);
		
		insert into CLIENTE
		values 
			(dbo.obtener_id_usuario_por_usuername(@dni), @nombre, UPPER(@apellido), @dni, 'DNI', @fecha_nacimiento);
	end

	close cursor_vista_usuarios;
end

go

--ejecuto procedimiento
exec MIGRAR_TABLA_USUARIO_CLIENTE

go

--libero todo
deallocate cursor_vista_usuarios;
drop view vista_usuarios_clientes_filtrados;
drop function obtener_id_usuario_por_usuername;
drop procedure MIGRAR_TABLA_USUARIO_CLIENTE;


/*falta ver lo del numero de calle*/