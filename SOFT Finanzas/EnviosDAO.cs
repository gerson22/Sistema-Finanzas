using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT_Finanzas
{
    class EnviosDAO
    {
        public static MySqlDataReader dgvEnvios()
        {
            MySqlConnection con;
            con = conexion.conectar();
            MySqlDataReader consulta;

            MySqlCommand Query = new MySqlCommand();

            Query.CommandText = "Select * from envios";
            Query.Connection = con;
            consulta = Query.ExecuteReader();
            return consulta;
        }
        public static bool Insertar(envios env)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string insert = string.Format("INSERT INTO envios VALUES(null,'"+env.gas+"','"+env.incidentes+"','"+env.destino+"',(Select current_date()))");
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
        public static bool Editar(envios env)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string editar = string.Format("UPDATE envios SET Gas = '"+env.gas+"', Incidentes = '"+env.incidentes+"', Destino = '"+env.destino+"' where id = '"+env.id+"'");
            MySqlCommand comando = new MySqlCommand(editar, con);
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
