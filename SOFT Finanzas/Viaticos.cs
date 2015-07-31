using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT_Finanzas
{
    class Viaticos
    {
        public int id { set; get; }
        public double Hospedaje { set; get; }
        public double Alimentos { set; get; }
        public double Transporte { set; get; }
        public string lugarDestino { set; get; }
        public int empID { set; get; }
        public string Puesto { set; get; }
        public string Fecha { set; get; }
        public double Total { set; get; }

    }
}
