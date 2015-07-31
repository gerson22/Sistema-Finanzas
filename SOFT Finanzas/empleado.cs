using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT_Finanzas
{
    class empleado
    {
        string password;
        public int id { set; get; }
        public string Nombre { set; get; }
        public string Apellidos { set; get; }
        public string Direccion { set; get; }
        public double sueldo_base { set; get; }
        public double Tipo { set; get; }
        public string usuario { set; get; }

        public void setPassword(string password)
        {
            this.password = password;
        }
        public string getPassword()
        {
            return password;
        }
        public string status { set; get; }

    }
}
