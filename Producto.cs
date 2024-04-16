using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Producto
    {
        public string Nombre { get; set; }
        public int Tamaño { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public int Precio { get; set; }
        public float Peso { get; set; }


        public void ProductoDeTela(string Nombre, int Tamaño, string Material, string Color, int Precio)
        {
            this.Nombre = Nombre;
            this.Tamaño = Tamaño;
            this.Material = Material;
            this.Color = Color;
            this.Precio = Precio;
        }
        public void ProductoDeArcilla(string Nombre, int Peso, string Material, string Color, int Precio)
        {
            this.Nombre = Nombre;
            this.Peso = Peso;
            this.Material = Material;
            this.Color = Color;
            this.Precio = Precio;
        }

    }
}
