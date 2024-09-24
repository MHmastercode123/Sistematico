using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2.Data
{
    public static class metodoExtenciion
    {
        public static decimal impuestos(this Prdctos producto, decimal impst)
        {
            return (producto.precio * impst) / 100;
        }
    }
}
