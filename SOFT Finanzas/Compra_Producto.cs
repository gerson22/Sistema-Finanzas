using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT_Finanzas
{
    class Compra_Producto
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Costo { get; set; }
        public string Fecha { get; set; }
        public string Status { get; set; }
    }
}
