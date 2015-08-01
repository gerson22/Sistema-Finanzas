using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFT_Finanzas
{
    public partial class Panel_Reporte : MetroForm
    {
        public Panel_Reporte()
        {
            InitializeComponent();
        }

        private void Panel_Reporte_Load(object sender, EventArgs e)
        {
            
        }
        public static MySqlDataReader GenerarReport(string fechaInicio,string fechafin)
        {
            MySqlConnection con;
            con = conexion.conectar();
            MySqlDataReader consulta;

            MySqlCommand Query = new MySqlCommand();

            Query.CommandText = "Select sum(EGRESOS.EgresosCap+EGRESOS.EgresosCM+EGRESOS.EgresosCP+EGRESOS.EgresosEnv+EGRESOS.EgresosLiq+EGRESOS.EgresosNom+EGRESOS.EgresosServ+EGRESOS.EgresosViat) as 'Egresos',Ingresos.Ingresos from (Select (Select sum(Pago_capacitador+material) as 'Egreso Total' from capacitacion where Fecha between  '"+fechaInicio+"' and '"+fechafin+"') as EgresosCap, (select sum(Cantidad * Precio) as 'Egreso Total' FROM  compra_material  where Fecha between  '"+fechaInicio+"' and '"+fechafin+"') as EgresosCM,(select sum(Cantidad * precio) as 'Egreso Total' from compra_productos where Fecha between  '"+fechaInicio+"' and '"+fechafin+"')  as EgresosCP,(select sum(Gas + Incidentes) as 'Egreso Total' from envios where Fecha between  '"+fechaInicio+"' and '"+fechafin+"')  as EgresosEnv,(Select sum(Total) as 'Egreso Total' from  liquidacion where fecha between  '"+fechaInicio+"' and '"+fechafin+"')  as EgresosLiq,(Select sum(Sueldo_Total) as 'Egreso Total' from nomina where  Fecha between  '"+fechaInicio+"' and '"+fechafin+"')  as EgresosNom ,(select sum(Costo) as 'Egreso Total' from servicios where Fecha between  '"+fechaInicio+"' and '"+fechafin+"')  as EgresosServ,(select sum(Total_viatico) as 'Egreso Total' from viaticos)  as EgresosViat) as EGRESOS,(select sum(Ganacia) as 'Ingresos' from ventas where Fecha_inicio between  '"+fechaInicio+"' and '"+fechafin+"' or Fecha_fin between  '"+fechaInicio+"' and '"+fechafin+"' )  as Ingresos";
            Query.Connection = con;
            consulta = Query.ExecuteReader();
            return consulta;
        }

        private void bntGenerarReporte_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader;
            reader = GenerarReport(fecha_inicioVent.Text, fechaFinRep.Text);
            Reportes rep = new Reportes();
            if (reader.Read())
            {
                rep.lblEgresos.Text = reader.GetValue(0).ToString();
                rep.lblIngresos.Text = reader.GetValue(1).ToString();
                if(rep.lblEgresos.Text == "")
                {
                    rep.lblEgresos.Text = "0";
                }
                if(rep.lblIngresos.Text == "")
                {
                    rep.lblIngresos.Text = "0";
                }
            }
            rep.fecha_inicio_report.Text = fecha_inicioVent.Text;
            rep.fechaFin_report.Text = fechaFinRep.Text;
            rep.FocusMe();
            rep.ShowDialog();
        }
    }
}
