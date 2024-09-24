using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2.Data
{
    public partial class Prdctos
    {
        public string Nombre {  get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }
        public Catdelproducto categoria { get; set; }

        public Prdctos(string Nombre, decimal precio, int cantidad, Catdelproducto categoria)
        {
            this.Nombre = Nombre;
            this.precio = precio;
            this.cantidad = cantidad;
            this.categoria = categoria;
        }

        public enum Catdelproducto 
        {
            Electronica,
            Ropa,
            Alimentos,
            Hogar,
            Otros
        }
    }

    
}
