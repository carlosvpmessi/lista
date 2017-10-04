# Lista
## TL;DR
Implementar un programa que permita al usuario administrar una lista de elementos. Puede ser una lista de comestibles, lista de Pendientes, etc. Consulte si es necesario para ver cómo implementar un bucle infinito. Cada vez que pase por el bucle, pida al usuario que realice una operación y luego muestre el contenido actual de su lista. Las operaciones disponibles deben ser Agregar, Eliminar y Borrar. La sintaxis debe ser la siguiente:
 
```
 + algún elemento

 - algún elemento

 --
```
Su programa debe leer en la entrada del usuario y determinar si comienza con un "+" o "-", o si es simplemente "-". En los dos primeros casos, su programa debe agregar o quitar la cadena dada ("algún elemento" en el ejemplo). Si el usuario introduce sólo "-" entonces el programa debe borrar la lista actual. Su programa puede iniciar cada iteración a través de su bucle con la siguiente instrucción: Console.WriteLine("Ingresa un comando (+ Elemento, - Elemento, o -- para eliminar la lista)):");