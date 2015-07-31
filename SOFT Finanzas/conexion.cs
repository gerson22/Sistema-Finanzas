using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SOFT_Finanzas
{
    class conexion
    {
        public static MySqlConnection conectar()
        {
            try
            {
                string cadena = "server = 127.0.0.1; database = finanzas; uid = root; pwd = 1qaz2wsx;";
                MySqlConnection con = new MySqlConnection(cadena);
                con.Open();

                return con;
            }
            catch
            {
                MessageBox.Show("Error en la conexion","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);   
            }
            return null;
        }
    }
}
