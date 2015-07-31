using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT_Finanzas
{
    class Compra_MaterialDAO
    {
        public static MySqlDataReader llenardgvCompra_Material()
        {
            MySqlConnection con;
            con = conexion.conectar();
            MySqlDataReader consulta;

            MySqlCommand Query = new MySqlCommand();

            Query.CommandText = "Select * from compra_material where StatusCM = 'Pendiente'";
            Query.Connection = con;
            consulta = Query.ExecuteReader();
            return consulta;
        }
        public static bool Editar(Compra_Material CM)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string update = string.Format("update compra_material set  Nombre = '"+CM.Nombre+"', Cantidad = '"+CM.Cantidad+"', Precio = '"+CM.Precio+"', StatusCM = '"+CM.Status+"' where id = '"+CM.id+"'");
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
        public static bool Insertar(Compra_Material CM)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string update = string.Format("INSERT INTO compra_material values(null,'"+CM.Nombre+"','"+CM.Cantidad+"','"+CM.Precio+"',(Select current_date()),null)");
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
        public static bool Delete(Compra_Material CM)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string delete = string.Format("DELETE FROM compra_material where id = '"+CM.id+"'");
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
