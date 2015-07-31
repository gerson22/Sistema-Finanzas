using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT_Finanzas
{
    class CapacitadoresDAO
    {
        public static bool Insertar(Capacitadores cap)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string insert = string.Format("INSERT INTO capacitadores(nombre,apellidos,telefono) VALUES('"+cap.Nombre+"','"+cap.Apellidos+"','"+cap.Telefono+"')");
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
        public static bool Actualizar(Capacitadores cap)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string update = string.Format("UPDATE capacitadores SET Nombre = '"+cap.Nombre+"', Apellidos = '"+cap.Apellidos+"', Telefono = '"+cap.Telefono+"' where id = '"+cap.id+"'");
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
        public static bool Eliminar(Capacitadores cap)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string delete = string.Format("DELETE FROM capacitadores where id = '"+cap.id+"'");
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
        public static MySqlDataReader llenardgvCap()
        {
            MySqlConnection con;
            con = conexion.conectar();
            MySqlDataReader consulta;

            MySqlCommand Query = new MySqlCommand();

            Query.CommandText = "Select * from capacitadores";
            Query.Connection = con;
            consulta = Query.ExecuteReader();
            return consulta;
        }
        
    }
}
