using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT_Finanzas
{
    class Solicitudes_de_aumentoDAO
    {
        public static MySqlDataReader dgvTipEmp()
        {
            MySqlConnection con;
            con = conexion.conectar();
            MySqlDataReader consulta;

            MySqlCommand Query = new MySqlCommand();

            Query.CommandText = "Select id,Empleados_id,Empleados_Tipo_Emp_id,Sueldo_Anterior,Sueldo_Propuesto,StatusAum  from solicitudes_de_aumento";
            Query.Connection = con;
            consulta = Query.ExecuteReader();
            return consulta;
        }
        public static bool Insertar(Solicitudes_de_aumento SA)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string editar = string.Format("Insert into solicitudes_de_aumento(Sueldo_Anterior,Sueldo_Propuesto,Empleados_id,Empleados_Tipo_Emp_id) values('"+SA.sueldo_anterior+"','"+SA.sueldo_propuesto+"','"+SA.empID+"','"+SA.tipEmp+"')");
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
