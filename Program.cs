using System;
using System.Linq;

namespace lista
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ///Crea una conexión con la BD
            using (var bd = new ListaContext())
            {

                Console.WriteLine("Ingresa un comando (+ Elemento, - Elemento, o -- para eliminar la lista)):");

                /// Se asegura que la BD esté creada
                bd.Database.EnsureCreated();


                /// Busca y regresa el primer el elemento en la BD que cumpla con la condición
                /// si no lo encuentra devuelve null
                var e = bd.Elementos.FirstOrDefault(x => x.Nombre == "PLATANOS");
                
                /// Filtra los elementos que contenga el argumento buscado y lo convierte en una Lista (List<Elemento> la collección)
                /// si no se ecuentra crea una lista vacia o sea con cero elementos
                var eWhere = bd.Elementos
                                .Where( x => x.Nombre.Contains("PLATA"))
                                .ToList();


                /// Si no es nulo, quiere decir que si encontró el elemento y lo puede borrar
                if (e != null)
                {
                    ///Borra dicho elemento de la BD
                    bd.Elementos.Remove(e);
                }

                /// Agrega un nuevo elemento a la table "Elementos" con los datos proporcionados
                /// db.NombreDeLaTabla.Add
                bd.Elementos.Add(new Elemento { Nombre = "Platanos", Agregado = DateTime.Now });

                /// Guarda los cambios en la base de datos
                /// pasando este momento se reflejan los cambios en la BD
                var count = bd.SaveChanges();

                Console.WriteLine("{0} registros guardados en la base de datos", count);


                Console.WriteLine("Todos los elementos en la base: ");


                /// Regresa todos los elementos en la tabla especificada en este caso Elementos
                /// db.NombreDeLaTabla
                var ListaElementos = bd.Elementos;




                count = bd.SaveChanges();
                Console.WriteLine($"Se eliminó el siguiente elemento: {e} ");



                /// Borra toda ell archivo de la Base de Datos
                // db.Database.EnsureDeleted();

            }
        }
    }
}
