using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT_Finanzas
{
    class Solicitudes_de_aumento
    {
        public int id { set; get; }
        public double sueldo_anterior { set; get; }
        public double sueldo_propuesto { set; get; }
        public string status { set; get; }
        public int empID { set; get; }
        public int tipEmp { set; get; }

    }
}
