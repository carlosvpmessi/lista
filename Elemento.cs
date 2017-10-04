using System;

namespace lista
{
    public class Elemento
    {

        private string nombre;

        public string Id { get; set; }
        public string Nombre { get { return nombre; } set { nombre = value.ToUpper(); } }
      
        public DateTime Agregado { get; set; }

        public override string ToString()
        {
            return $"Elemento:{Nombre} Agregado:{Agregado}";
        }

    }
}