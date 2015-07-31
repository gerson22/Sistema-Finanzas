using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT_Finanzas
{
    class Ventas
    {
        public int id { set; get; }
        public double ganacias { set; get; }
        public double mermas { set; get; }
        public string fecha_inicio { set; get; }
        public string fecha_fin { set; get; }

        public string comentarios { set; get; }

    }
}
