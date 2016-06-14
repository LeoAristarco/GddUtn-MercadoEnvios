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

- Como dice en el enunciado, cuando una publicacion pasa a estar activa se debe generar en ese mismo instante la facturacion correspondiente al tipo de visibilidad elejida (El total_facturar es el costo de la visibilidad, que al mismo se va a ir sumando comiciones por ventas, a medida q se realicen las compras). Entonces, cuando se realiza una venta , se crea un item_factura por la compra que se hizo, y el mismo item_factura pertenece a la factura propia de publicacion (a cada publicacion le corresponde un unica factura). 

-Además agregamos la funcionalidad de envío haciendo que se pueda elegir habilitar la opción desde la creación de la publicación y cada vez que se genera una compra u oferta elegir si es o no con envío. La comisión por el mismo la elegimos como un valor constante de $100.

###Migracion
-En el momento de la migración cambiamos los códigos de los clientes, las publicaciones, las visibilidades, etc. para resetearlos en el nuevo sistema.
-El rubro al cual se dedica la empresa lo tomamos aleatoriamente.
