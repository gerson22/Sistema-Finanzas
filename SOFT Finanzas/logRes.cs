using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SOFT_Finanzas
{
    class logRes
    {
        public static MySqlDataReader LogRespuesta(string User, string Contraseña)
        {
            MySqlConnection con;
            con = conexion.conectar();
            MySqlDataReader consulta;

            MySqlCommand Query = new MySqlCommand();

            Query.CommandText = "Select (Select Nombre FROM tipo_emp where Tipo_Emp_id = id) as 'tipo',empleados.Nombre,empleados.Apellidos,id from empleados where usuarios = '" + User + "' and pass = '" + Contraseña + "' and status = 'Activo'";
            Query.Connection = con;
            consulta = Query.ExecuteReader();
            return consulta;
        }
    }
}
