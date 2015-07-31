using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT_Finanzas
{
    class VentasDAO
    {
        public static bool Insertar(Ventas vent)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string insert = string.Format("INSERT INTO ventas VALUES(null,'"+vent.ganacias+"','"+vent.mermas+"','"+vent.fecha_inicio+"','"+vent.fecha_fin+"','"+vent.comentarios+"')");
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
        public static bool Editar(Ventas vent)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string insert = string.Format("Update ventas set Ganacia = '"+vent.ganacias+"' , Mermas = '"+vent.mermas+"', Fecha_inicio = '"+vent.fecha_inicio+"', Fecha_fin = '"+vent.fecha_fin+"', Comentarios = '"+vent.comentarios+"' where id = '"+vent.id+"'");
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
        public static MySqlDataReader llenardgvVent()
        {
            MySqlConnection con;
            con = conexion.conectar();
            MySqlDataReader consulta;

            MySqlCommand Query = new MySqlCommand();

            Query.CommandText = "Select * from ventas";
            Query.Connection = con;
            consulta = Query.ExecuteReader();
            return consulta;
        }
    }
}
