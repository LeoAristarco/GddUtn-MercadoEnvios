#Estrategias

###Hipotesis inicial:
-Seteamos la fecha de inicio del sistema como la máxima encontrada en la tabla maestra.

###Visibilidad:

-Tomamos los nombres de las visibilidades, los precios y los porcentajes como se encontraban en la tabla maestra:

- Visibilidad: Gratis,  Precio: Gratis, Porcentaje:0.00
- Visibilidad: Bronze,  Precio: 60,     Porcentaje:0.30
- Visibilidad: Plata,   Precio: 100,    Porcentaje:0.20
- Visibilidad: Oro,     Precio: 140,    Porcentaje:0.15
- Visibilidad: Platino, Precio: 160,    Porcentaje:0.10


###Facturacion:

 Los campos “total_facturar” y “forma_pago” serán nulos a lo largo de todo el ciclo del sistemas, ya que el enunciado dice :“Tener en cuenta que solo deberá generarse la facturación dado que el pago de facturas no compete a este trabajo práctico” (a cada publicación le corresponde un única factura). Como dice en el enunciado, cuando una publicación pasa a estar activa se debe generar en ese mismo instante la facturación correspondiente al tipo de visibilidad elegida (lo hacemos en la Tabla FACTURA). Despues, cuando se realiza una venta , se crea un item_factura por la compra que se hizo, y el mismo item_factura pertenece a la factura propia de publicación (en la tabla ITEM_FACTURA facturamos el envio,la cantidad y el precio unitario).

-Además agregamos la funcionalidad de envío haciendo que se pueda elegir habilitar la opción desde la creación de la publicación y cada vez que se genera una compra u oferta elegir si es o no con envío. La comisión por el mismo la elegimos como un valor constante de $100.

###Migracion
-En el momento de la migración cambiamos los códigos de los clientes, las publicaciones, las visibilidades, etc. para resetearlos en el nuevo sistema.
-El rubro al cual se dedica la empresa lo tomamos aleatoriamente.
