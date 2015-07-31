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
    public partial class Panel_Rec_Humanos : MetroForm
    {
        public Panel_Rec_Humanos()
        {
            InitializeComponent();
            LlenardgvCapacitadores();
            hora.Enabled = true;
            btnActCap.Enabled = false;
            btnEliCap.Enabled = false;
            LlendgvAumemto();
        }

        private void Panel_Rec_Humanos_Load(object sender, EventArgs e)
        {

        }

        private void btnEliCap_MouseHover(object sender, EventArgs e)
        {
        }
        public void LimpiarInput()
        {
            idCap_rec.Text = "Autogenerado";
            nomCap_rec.Text = "";
            apeCap_rec.Text = "";
            telCap_rec.Text = "";
        }
        private void btnAltCap_Click(object sender, EventArgs e)
        {
            Capacitadores cap = new Capacitadores();
            cap.Nombre = nomCap_rec.Text;
            cap.Apellidos = apeCap_rec.Text;
            cap.Telefono = telCap_rec.Text;
            if(CapacitadoresDAO.Insertar(cap))
            {
                MessageBox.Show("Capacitador registrado con exito", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarInput();
                dgvCapacitadores.Rows.Clear();
                LlenardgvCapacitadores();
            }
            else
            {
                MessageBox.Show("Ocurrio un error en la insercion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                LimpiarInput();
            }
        }
        public void LlenardgvCapacitadores()
        {
            MySqlDataReader reader; //Este codigo nos sirve para instanciar la clase datareader de mysql para poder obtener los datos de la consulta
            reader = CapacitadoresDAO.llenardgvCap(); // Nos dice de donde leera los datos
            while (reader.Read())//Mientras el la lectura del reader es true entonces se seguiran creando renglones en el datagrid
            {
               dgvCapacitadores.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3));
            }
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            Hour.Text = DateTime.Now.ToString();
        }

        private void dgvCapacitadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dgvCapacitadores.Rows[e.RowIndex];
            idCap_rec.Text = dgv.Cells[0].Value.ToString();
            nomCap_rec.Text = dgv.Cells[1].Value.ToString();
            apeCap_rec.Text = dgv.Cells[2].Value.ToString();
            telCap_rec.Text = dgv.Cells[3].Value.ToString();

            btnActCap.Enabled = true;
            btnEliCap.Enabled = true;
            btnAltCap.Enabled = false;
        }

        private void btnActCap_Click(object sender, EventArgs e)
        {
            Capacitadores cap = new Capacitadores();
            cap.id = int.Parse(idCap_rec.Text);
            cap.Nombre = nomCap_rec.Text;
            cap.Apellidos = apeCap_rec.Text;
            cap.Telefono = telCap_rec.Text;
            if(CapacitadoresDAO.Actualizar(cap))
            {
                MessageBox.Show("Actulizáción del capacitador  con exito", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarInput();
                dgvCapacitadores.Rows.Clear();
                LlenardgvCapacitadores();
                btnActCap.Enabled = false;
                btnEliCap.Enabled = false;
                btnAltCap.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ocurrio un error en la actualización", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                LimpiarInput();
                btnActCap.Enabled = false;
                btnEliCap.Enabled = false;
                btnAltCap.Enabled = true;
            }
        }

        private void btnEliCap_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro que deseas eliminar a este capacitador?", "A T E N C I O N ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Capacitadores cap = new Capacitadores();
                cap.id = int.Parse(idCap_rec.Text);
                if (CapacitadoresDAO.Eliminar(cap))
                {
                    MessageBox.Show("Capacitador eliminado  con exito", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarInput();
                    dgvCapacitadores.Rows.Clear();
                    LlenardgvCapacitadores();
                    btnActCap.Enabled = false;
                    btnEliCap.Enabled = false;
                    btnAltCap.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error en la eliminación del capacitador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    LimpiarInput();
                    btnActCap.Enabled = false;
                    btnEliCap.Enabled = false;
                    btnAltCap.Enabled = true;
                }
            }

        }

        private void ideEmpAum_KeyUp(object sender, KeyEventArgs e)
        {
            if (ideEmpAum.Text != "")
            {
                try
                {
                    Solicitudes_de_aumento sa = new Solicitudes_de_aumento();
                    sa.empID = int.Parse(ideEmpAum.Text);
                    MySqlConnection cnx;
                    cnx = conexion.conectar();
                    MySqlDataReader reader;
                    reader = empleadoDAO.DatNomEmp(sa.empID);
                    if (reader.Read())
                    {
                        sueldAnterior.Text = reader.GetValue(0).ToString();
                        tipAum.Text = reader.GetValue(1).ToString();
                    }
                    cnx.Close();
                }
                catch
                {
                    ideEmpAum.Text = "";
                }

            }
        }

        private void ideEmpAum_KeyDown(object sender, KeyEventArgs e)
        {
            sueldAnterior.Text = "";
            tipAum.Text = "";
;
        }
        public void LlendgvAumemto()
        {
            MySqlConnection cnx;
            cnx = conexion.conectar();
            MySqlDataReader reader;
            reader = Solicitudes_de_aumentoDAO.dgvTipEmp();
            while (reader.Read())
            {
                dgvTipEmp.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4),reader.GetValue(5));
            }
            cnx.Close();
        }

        private void guardAum_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader;
            reader = Sueldo.RangoSueldo(tipAum.Text);//Se buscan  el rangos del sueldo que puede tener ese tipo de empleado//
            if (reader.Read())//si devuelve valores se realizara una comparativa para saber si el aumneto queda entre los rangos establecido
            {
                double pagomax = Convert.ToDouble(reader.GetValue(1));
                double pagomin = Convert.ToDouble(reader.GetValue(0));

                {
                    
                     if (Convert.ToDouble(sueldPropuest.Text) <= pagomax && Convert.ToDouble(sueldPropuest.Text) >= pagomin)
                     {
                          MySqlConnection cnx;
                          cnx = conexion.conectar();
                          Solicitudes_de_aumento SA = new Solicitudes_de_aumento();
                          SA.empID = int.Parse(ideEmpAum.Text);
                          SA.tipEmp = int.Parse(tipAum.Text);
                          SA.sueldo_anterior = double.Parse(sueldAnterior.Text);
                          SA.sueldo_propuesto = double.Parse(sueldPropuest.Text);
                          if (Solicitudes_de_aumentoDAO.Insertar(SA))
                          {
                              MessageBox.Show("Se ha enviado la solicitud exitosamente (Recuerda que cuando Finanazas acepte o rechaze la solicitud el registro será eliminado)", "Solicitud enviada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                              dgvTipEmp.Rows.Clear();
                              LlendgvAumemto();
                          }
                          else
                          {
                              MessageBox.Show("Ha ocurrido un error en la inserción", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                          }
                     }
                     else
                     {
                         MessageBox.Show("El sueldo propuesto esta fuera del rango permitido", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                     }
                    
                }
            }
            else
            {
                MessageBox.Show("El tipo de empleado no tiene establecido sus rangos de sueldo y no puedes dar aumentos");
            }
        }

        private void btnAbrirSolComMat_Click(object sender, EventArgs e)
        {
            Panel_Jefe_Area PanJefAr = new Panel_Jefe_Area();
            PanJefAr.lblNom.Text = lblNom.Text;
            PanJefAr.empPue.Text = empPue.Text;
            PanJefAr.idemp.Text = idemp.Text;
            PanJefAr.ShowDialog();
            
        }
    }
}
