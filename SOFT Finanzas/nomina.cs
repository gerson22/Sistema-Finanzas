using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT_Finanzas
{
    class nomina
    {
        public int id { set; get; }
        public double sueldo { set; get; }
        public double infonavit { set; get; }
        public double seguro { set; get; }
        public double prestaciones { set; get; }
        public double incentivos { set; get; }
        public double ISR { set; get; }
        public double sueldo_t { set; get; }
        public string fecha { set; get; }
        public int idEmp { set; get; }
        public string TipoEmp { set; get; }
        public string Tipo_Pago { set; get; }
    }
}
