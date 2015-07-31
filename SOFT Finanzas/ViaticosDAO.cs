using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFT_Finanzas
{
    class ViaticosDAO
    {
        public static bool Insertar(Viaticos via)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string insert = string.Format("INSERT INTO viaticos(Hospedaje,Alimentos,Transporte,Lugar_destino,Fecha,Total_viatico,Empleados_id,Empleados_Tipo_Emp_id) VALUES('"+via.Hospedaje+"','"+via.Alimentos+"','"+via.Transporte+"','"+via.lugarDestino+"',(SELECT current_date()),'"+via.Total+"','"+via.empID+"',(SELECT Tipo_Emp_id from empleados where id = '"+via.empID+"'))");
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
        public static bool Actualizar(Viaticos via)
        {
            MySqlConnection con;
            con = conexion.conectar();

            string insert = string.Format("UPDATE viaticos set Hospedaje = '" + via.Hospedaje + "',Alimentos = '" + via.Alimentos + "',Transporte = '" + via.Transporte + "',Lugar_destino= '" + via.lugarDestino + "', Total_viatico = '" + via.Total + "', Empleados_id = '" + via.empID + "',Empleados_Tipo_Emp_id = (SELECT Tipo_Emp_id from empleados where id = '" + via.empID + "') where id = '"+via.id+"'");
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
        public static MySqlDataReader dgvViatico()
        {
            MySqlConnection con;
            con = conexion.conectar();
            MySqlDataReader consulta;

            MySqlCommand Query = new MySqlCommand();

            Query.CommandText = "Select * from viaticos";
            Query.Connection = con;
            consulta = Query.ExecuteReader();
            return consulta;
        }
        public static MySqlDataReader validacionEmp(Viaticos via)
        {
            MySqlConnection con;
            con = conexion.conectar();
            MySqlDataReader consulta;

            MySqlCommand Query = new MySqlCommand();

            Query.CommandText = "Select count(id) from empleados where id = '"+via.empID+"'";
            Query.Connection = con;
            consulta = Query.ExecuteReader();
            return consulta;
        }
    }
}
