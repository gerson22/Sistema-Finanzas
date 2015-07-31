using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT_Finanzas
{
    class serviciosDAO
    {
        public static bool Insertar(servicios serv)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string insert = string.Format("INSERT INTO servicios(Fecha,Nombre,Costo) VALUES((SELECT current_date()),'"+serv.nombre+"','"+serv.costo+"')");
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
        public static bool Actualizar(servicios serv)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string update = string.Format("Update servicios set  Nombre = '"+serv.nombre+"' , Costo = '"+serv.costo+"' where id = '"+serv.id+"'");
            MySqlCommand comando = new MySqlCommand(update, con);
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
        public static MySqlDataReader llenardgvServ()
        {
            MySqlConnection con;
            con = conexion.conectar();
            MySqlDataReader consulta;

            MySqlCommand Query = new MySqlCommand();

            Query.CommandText = "Select * from servicios";
            Query.Connection = con;
            consulta = Query.ExecuteReader();
            return consulta;
        }
    }
}
