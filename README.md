#Estrategias

###Visibilidad:

-Tomamos los nombres de las visibilidades, los precios y los porcentajes como se encontraban en la tabla maestra:

*Visibilidad: Gratis,  Precio: Gratis, Porcentaje:0.00
*Visibilidad: Bronze,  Precio: 60,     Porcentaje:0.30
*Visibilidad: Plata,   Precio: 100,    Porcentaje:0.20
*Visibilidad: Oro,     Precio: 140,    Porcentaje:0.15
*Visibilidad: Platino, Precio: 160,    Porcentaje:0.10

-Además agregamos la funcionalidad de envío haciendo que se pueda elegir habilitar la opción desde la creación de la publicación y cada vez que se genera una compra u oferta elegir si es o no con envío.
-La comisión por el mismo la elegimos como un valor constante de $50.
-Decidimos que cuando se crea una publicación el costo de visibilidad se factura si se vende el producto, dicho costo se sumara al total de la factura una vez fanalizada la publicacion o cuando se agote el stock
-Con respecto al ABM de visibilidad decidimos hacer una baja logica de la misma.

###Facturacion:

- Como dice en el enunciado, cuando una factura pasa a estar activa se debe generar en ese mismo instante la facturacion correspondiente al tipo de visibilidad elejida
