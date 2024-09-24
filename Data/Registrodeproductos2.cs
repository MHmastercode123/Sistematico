using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prueba2.Data
{
    public partial class Prdctos
    {
        public override string ToString()
        {
            return $"{Nombre} - {precio:C} - {cantidad} unidades - Categoría: {categoria}";
        }
    }
}
