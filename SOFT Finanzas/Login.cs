using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SOFT_Finanzas
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {

            MySqlDataReader reader;
            MySqlConnection con = new MySqlConnection();
            reader = logRes.LogRespuesta(usuEmp.Text,conEmp.Text);
            if(reader.Read() == true)
            {
                switch(reader.GetValue(0).ToString())
                {
                    case "Gerente Finanzas":
                    this.Hide();
                    Panel_Gerente_Finanzas panGerFin = new Panel_Gerente_Finanzas();
                    panGerFin.lblNom.Text = reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString();
                    panGerFin.empPue.Text = reader.GetValue(0).ToString();
                    panGerFin.idemp.Text = reader.GetValue(3).ToString();
                    FocusMe();
                    panGerFin.ShowDialog(); 
                    break;
                    case "Contador":
                    this.Hide();
                    Panel_Contador panCont = new Panel_Contador();
                    panCont.lblNom.Text = reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString();
                    panCont.empPue.Text = reader.GetValue(0).ToString();
                    panCont.idemp.Text = reader.GetValue(3).ToString();
                    FocusMe();
                    panCont.ShowDialog();
                    break;
                    case "Recursos Humanos":
                    this.Hide();
                    Panel_Rec_Humanos panRec = new Panel_Rec_Humanos();
                    panRec.lblNom.Text = reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString();
                    panRec.empPue.Text = reader.GetValue(0).ToString();
                    panRec.idemp.Text = reader.GetValue(3).ToString();
                    panRec.ShowDialog();
                    break;
                    case "Jefe de Area":
                    this.Hide();
                    Panel_Jefe_Area PanJefAr = new Panel_Jefe_Area();
                    PanJefAr.lblNom.Text = reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString();
                    PanJefAr.empPue.Text = reader.GetValue(0).ToString();
                    PanJefAr.idemp.Text = reader.GetValue(3).ToString();
                    PanJefAr.ShowDialog();
                    break;
                }
            }
            else
            {
                MessageBox.Show("Usuario invalido","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                con.Close();
            }
                
            
        }

        private void conEmp_Click(object sender, EventArgs e)
       {

        }

        private void metroLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Enter(object sender, EventArgs e)
        {

        }
    }
}
