using System;
using System.Linq;

namespace lista
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ListaContext())
            {

                Console.WriteLine("Ingresa un comando (+ Elemento, - Elemento, o -- para eliminar la lista)):");

                /// Se asegura que la BD esté creada
                db.Database.EnsureCreated();


                /// Busca y regresa el primer el elemento en la BD que cumpla con la condición
                /// si no lo encuentra devuelve null
                var e = db.Elementos.FirstOrDefault(x => x.Nombre == "PLATANOS");


                /// Si no es nulo, quiere decir que si encontró el elemento y lo puede borrar
                if (e != null)
                {
                    ///Borra dicho elemento de la BD
                    db.Elementos.Remove(e);
                }

                /// Agrega un nuevo elemento a la table "Elementos" con los datos proporcionados
                /// db.NombreDeLaTabla.Add
                db.Elementos.Add(new Elemento { Nombre = "Platanos", Agregado = DateTime.Now });

                /// Guarda los cambios en la base de datos
                /// pasando este momento se reflejan los cambios en la BD
                var count = db.SaveChanges();

                Console.WriteLine("{0} registros guardados en la base de datos", count);


                Console.WriteLine("Todos los elementos en la base: ");


                /// Regresa todos los elementos en la tabla especificada en este caso Elementos
                /// db.NombreDeLaTabla
                var ListaElementos = db.Elementos;




                count = db.SaveChanges();
                Console.WriteLine($"Se eliminó el siguiente elemento: {e} ");



                /// Borra toda ell archivo de la Base de Datos
                // db.Database.EnsureDeleted();

            }
        }
    }
}
