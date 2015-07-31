using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT_Finanzas
{
    class CapacitacionDAO
    {
        public static bool Insertar(Capacitacion cap)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string insert = string.Format("INSERT capacitacion(Nombre,Pago_capacitador,Material,Fecha,Capacitadores_id) VALUES('" + cap.Nombre + "','" + cap.Pago_Capacitador + "','" + cap.Material + "',(Select current_date()),'" + cap.Capacitador + "')");
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
        public static bool Actualizar(Capacitacion cap)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string update = string.Format("UPDATE capacitacion SET Nombre = '" + cap.Nombre + "', Pago_capacitador = '" + cap.Pago_Capacitador + "',Material= '" + cap.Material + "',Capacitadores_id ='" + cap.Capacitador + "' where id = '"+cap.id+"'");
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
        public static bool Eliminar(Capacitacion cap)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string update = string.Format("DELETE FROM capacitacion where id = '"+cap.id+"'");
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
        public static MySqlDataReader datosdgvCapacitacion()
        {
            MySqlConnection con;
            con = conexion.conectar();
            MySqlDataReader consulta;

            MySqlCommand Query = new MySqlCommand();

            Query.CommandText = "Select * from capacitacion";
            Query.Connection = con;
            consulta = Query.ExecuteReader();
            return consulta;
        }
    }
}
