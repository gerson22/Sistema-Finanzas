using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT_Finanzas
{
    class Tipo_EmpDAO
    {
        public static MySqlDataReader dgvTipEmp()
        {
            MySqlConnection con;
            con = conexion.conectar();
            MySqlDataReader consulta;

            MySqlCommand Query = new MySqlCommand();

            Query.CommandText = "Select * from tipo_emp where pago_Minimo = 'null' and pago_Maximo = 'null' or pago_Maximo = 0";
            Query.Connection = con;
            consulta = Query.ExecuteReader();
            return consulta;
        }
        public static bool Editar(Tipo_Emp tipEmp)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string editar = string.Format("UPDATE tipo_emp SET pago_Minimo = '"+tipEmp.pago_min+"', pago_Maximo = '"+tipEmp.pago_max+"' where id = '" + tipEmp.id + "'");
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
