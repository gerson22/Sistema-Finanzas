using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT_Finanzas
{
    class Sueldo
    {
        public static MySqlDataReader RangoSueldo(string puesto)
        {
            MySqlConnection con;
            con = conexion.conectar();
            MySqlDataReader consulta;

            MySqlCommand Query = new MySqlCommand();
            Query.CommandText = "SELECT Pago_Minimo,Pago_Maximo FROM finanzas.tipo_emp where id = '" + puesto + "' and Pago_Minimo != 'null' and Pago_Minimo != 0 and  Pago_Maximo != 'null'";
            Query.Connection = con;
            consulta = Query.ExecuteReader();
            return consulta;
        }
        public static MySqlDataReader RangoSueldoAlta(string puesto)
        {
            MySqlConnection con;
            con = conexion.conectar();
            MySqlDataReader consulta;

            MySqlCommand Query = new MySqlCommand();
            Query.CommandText = "SELECT Pago_Minimo,Pago_Maximo FROM finanzas.tipo_emp where id = (Select id from Nombre = '"+puesto+"') and Pago_Minimo != 'null' and Pago_Minimo != 0 and  Pago_Maximo != 'null'";
            Query.Connection = con;
            consulta = Query.ExecuteReader();
            return consulta;
        }
        public static bool Eliminar_sol_suel(int id)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string delete = string.Format("Delete from solicitudes_de_aumento where id = '"+ id +"'");
            MySqlCommand comando = new MySqlCommand(delete, con);
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
