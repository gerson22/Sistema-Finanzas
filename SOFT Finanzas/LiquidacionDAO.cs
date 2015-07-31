using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT_Finanzas
{
    class LiquidacionDAO
    {
        public static bool Insertar(Liquidacion liq)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string insert = string.Format("Insert into liquidacion(antiguedad,liquidacion,Empleados_id,Empleados_Tipo_Emp_id,Total) VALUES('"+liq.antiguedad+"','"+liq.liquidacion_año+"','"+liq.idEmp+"',(Select id from tipo_emp where Nombre = '"+ liq.TipoEmp +"'),'"+liq.Total+"')");
            MySqlCommand comando = new MySqlCommand(insert, con);
            int i = comando.ExecuteNonQuery();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
