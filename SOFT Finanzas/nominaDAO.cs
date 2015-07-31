using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT_Finanzas
{
    class nominaDAO
    {
        public static MySqlDataReader dgvNominaDat()
        {
            MySqlConnection con;
            con = conexion.conectar();
            MySqlDataReader consulta;

            MySqlCommand Query = new MySqlCommand();

            Query.CommandText = "Select id,Sueldo,Infonnavit,Seguro,Prestaciones,Incentivos,ISR,Sueldo_Total,Fecha,Empledos_id,(Select Nombre from tipo_emp where id = Empledos_Tipo_Emp_id),Tipo_pago from nomina";
            Query.Connection = con;
            consulta = Query.ExecuteReader();
            return consulta;
        }
        public static bool Insertar(nomina nom)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string insert = string.Format("INSERT INTO nomina(Sueldo,Infonnavit,Seguro,Prestaciones,Incentivos,ISR,Sueldo_Total,Fecha,Empledos_id,nomina.Empledos_Tipo_Emp_id,Tipo_pago) VALUES((Select sueldo_Base from empleados where id = '" + nom.idEmp + "'),'" + nom.infonavit + "','" + nom.seguro + "','" + nom.prestaciones + "','" + nom.incentivos + "','" + nom.ISR + "','" + nom.sueldo_t + "',(Select current_date()),'" + nom.idEmp + "','" + nom.TipoEmp + "','" + nom.Tipo_Pago + "')");
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
        public static bool Actualizar(nomina nom)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string update = string.Format("UPDATE nomina SET Sueldo = '" + nom.sueldo + "',Infonnavit = '" + nom.infonavit + "',Seguro = (Select sueldo_Base from empleados where id = '"+nom.idEmp+"'),Prestaciones = '" + nom.prestaciones + "',Incentivos = '" + nom.incentivos + "',ISR = '" + nom.ISR + "',Sueldo_Total = '" + nom.sueldo_t + "',Empleados_id = '" + nom.idEmp + "',Empleados_Tipo_Emp_id = (Select Empleados_Tipo_Emp_id from empleados where id = '" + nom.idEmp + "') ,Tipo_pago = '" + nom.Tipo_Pago + "' ");
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
        public static MySqlDataReader buscarSueldo(nomina nom)
        {
            MySqlConnection con;
            con = conexion.conectar();
            MySqlDataReader consulta;

            MySqlCommand Query = new MySqlCommand();

            Query.CommandText = "Select sueldo_Base from empleados where id = '" + nom.idEmp + "'";
            Query.Connection = con;
            consulta = Query.ExecuteReader();
            return consulta;
        }
       
    }

}
