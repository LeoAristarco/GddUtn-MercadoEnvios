--Al iniciar la aplicación se tiene que barrer la base de datos para saber que publicaciones
--estan vencidas, a las q estan vencidas hay que finalizarlas y cerrar la factura
--Las subasta vencidas hay q hacer lo mismo, y tambien insertar esa oferta como compra
create procedure st_actualizar_publicaciones_vencidas
@fechaDelSistema datetime

AS BEGIN
declare @id_publicacion numeric(10,0), @tipo_publicacion numeric(10,0), @factura numeric(10,0),@precio numeric(10,2),
@descripcion nvarchar(255),
@ofertante numeric(10,0),@precio_envio numeric(10,2)

set @ofertante =null

declare miCursor cursor
 for select id_publicacion,tipo_publicacion,
            factura,precio,descripcion 
 FROM PUBLICACION
 where  year(fecha_vencimiento) < 2016 and
 estado_publicacion <> 1 AND --distinto de borrador
 estado_publicacion <> 4     --distinto de finalizado
 

open miCursor

fetch next from miCursor into @id_publicacion,@tipo_publicacion,@factura,@precio,@descripcion

while @@fetch_status=0

UPDATE PUBLICACION  
 SET estado_publicacion = 4 --finalizado
 where id_publicacion= @id_publicacion
       
UPDATE FACTURA  
 SET factura_fecha = @fechaDelSistema --cierro la factura
 where id_factura =@factura

begin
       if(@tipo_publicacion =2)
       begin
	       select @ofertante=ofertante,@precio_envio=precio_envio
	       from OFERTA
	       where publicacion =@id_publicacion and
	       monto_ofertado = @precio

	       if(@ofertante is not null) --valido que alguien oferto por lo menos una vez
	       begin
	            exec st_insertarCompraSubasta @ofertante,@id_publicacion ,@fechaDelSistema, @precio, 
                              1 ,@precio_envio ,@factura ,@descripcion 
           end
       end

       fetch next from miCursor into @id_publicacion,@tipo_publicacion,@factura,@precio,@descripcion  
end

close miCursor

deallocate miCursor

end
