using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT_Finanzas
{
    class empleadoDAO
    {
        public static bool Eliminar(int id)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string delete = string.Format("Delete from empleados where id = " + id + "");
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
        public static bool Actualizar(string status,int id,double sueldo)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string update = string.Format("Update empleados set  status =  '"+ status + "' sueldo_Base = '"+sueldo+"' where id = " + id + "");
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
        public static bool Actualizar_Sueldo(double sueldo, int id)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string update = string.Format("Update empleados set  sueldo_Base =  '" + sueldo + "' where id = '" + id + "'");
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
        public static MySqlDataReader datEmp()
        {
            MySqlConnection con;
            con = conexion.conectar();
            MySqlDataReader consulta;

            MySqlCommand Query = new MySqlCommand();

            Query.CommandText = "Select id,Nombre,Apellidos,(Select Nombre FROM tipo_emp where Tipo_Emp_id = id) as 'tipo',sueldo_Base from empleados";
            Query.Connection = con;
            consulta = Query.ExecuteReader();
            return consulta;
        }
        public static MySqlDataReader datSolAct()
        {
            MySqlConnection con;
            con = conexion.conectar();
            MySqlDataReader consulta;

            MySqlCommand Query = new MySqlCommand();

            Query.CommandText = "SELECT id,Sueldo_Anterior,Sueldo_Propuesto,empleados_id,empleados_Tipo_Emp_id FROM solicitudes_de_aumento";
            Query.Connection = con;
            consulta = Query.ExecuteReader();
            return consulta;
        }
        public static MySqlDataReader Empleados()
        {
            MySqlConnection con;
            con = conexion.conectar();
            MySqlDataReader consulta;

            MySqlCommand Query = new MySqlCommand();

            Query.CommandText = "SELECT id,Nombre,Apellidos,Direccion,sueldo_Base,(Select Nombre FROM tipo_emp where Tipo_Emp_id = id) as 'tipo',usuarios,status FROM empleados where status = 'Pendiente'";
            Query.Connection = con;
            consulta = Query.ExecuteReader();
            return consulta;
        }
        public string md5(string password)//Metodo para realizar la encriptacion a MD5 y realizar la consulta para acceso al sistema
        {
            //Declaraciones
            System.Security.Cryptography.MD5 md5;
            md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();

            //Conversion
            Byte[] encodedBytes = md5.ComputeHash(ASCIIEncoding.Default.GetBytes(password));  //genero el hash a partir de la password original

            //Resultado

            //return BitConverter.ToString(encodedBytes);      //esto, devuelve el hash con "-" cada 2 char
            return System.Text.RegularExpressions.Regex.Replace(BitConverter.ToString(encodedBytes).ToLower(), @"-", "");     //devuelve el hash continuo y en minuscula. (igual que en php)
        }
        public static MySqlDataReader DatNomEmp(int id)
        {
            MySqlConnection con;
            con = conexion.conectar();
            MySqlDataReader consulta;

            MySqlCommand Query = new MySqlCommand();

            Query.CommandText = "select Sueldo_base,Tipo_Emp_id from empleados where id = '"+id+"'";
            Query.Connection = con;
            consulta = Query.ExecuteReader();
            return consulta;
        }

    }
}
