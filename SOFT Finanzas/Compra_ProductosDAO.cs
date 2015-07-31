using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT_Finanzas
{
    class Compra_ProductosDAO
    {
        public static MySqlDataReader llenardgvCompra_Productos()
        {
            MySqlConnection con;
            con = conexion.conectar();
            MySqlDataReader consulta;

            MySqlCommand Query = new MySqlCommand();

            Query.CommandText = "Select * from compra_productos where StatusCP = 'Pendiente'";
            Query.Connection = con;
            consulta = Query.ExecuteReader();
            return consulta;
        }
        public static MySqlDataReader llenardgvCompra_ProductosSol()
        {
            MySqlConnection con;
            con = conexion.conectar();
            MySqlDataReader consulta;

            MySqlCommand Query = new MySqlCommand();

            Query.CommandText = "Select * from compra_productos where StatusCP = 'Pendiente' and Precio = 0";
            Query.Connection = con;
            consulta = Query.ExecuteReader();
            return consulta;
        }
        public static bool Editar(Compra_Producto CP)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string update = string.Format("update compra_productos set  Nombre = '" + CP.Nombre + "', Cantidad = '" + CP.Cantidad + "', Precio = '" + CP.Precio + "', Costo = '"+CP.Costo+"', StatusCP = '" + CP.Status + "' where id = '" + CP.id + "'");
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
        public static bool Insertar(Compra_Producto CP)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string update = string.Format("INSERT INTO compra_productos values(null,'"+CP.Nombre+"','"+CP.Cantidad+"',null,'"+CP.Costo+"',(Select current_date()),'Pendiente')");
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
        public static bool Delete(Compra_Producto CP)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string delete = string.Format("DELETE FROM compra_productos where id = '" + CP.id + "'");
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
