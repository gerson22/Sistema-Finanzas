using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT_Finanzas
{
    class Liquidacion
    {
        public double antiguedad { set; get; }
        public double liquidacion_año { set; get; }
        public int idEmp { set; get; }
        public string TipoEmp { set; get; }
        public double Total { set; get; }
    }
}
