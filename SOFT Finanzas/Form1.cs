using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace SOFT_Finanzas
{
    public partial class Form1 : MetroForm
    {
        int anim = 1;
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(anim)
            {
                case 1:
                    anim = anim + 1;
                    break;
                case 2:
                    label1.Visible=true;
                    anim = anim + 1;
                    break;
                case 3:
                    anim = anim + 1;
                    break;
                case 4:
                    anim = anim + 1;
                    break;
                case 5:
                    label4.Visible=true;
                    anim = anim + 1;
                    break;
                case 6:
                    anim = anim + 1;
                    break;
                case 7:
                    anim = anim + 1;
                    break;
                case 8:
                    label5.Visible=true;
                    anim = anim + 1;
                    break;
                case 9:
                    anim = anim + 1;
                    break;
                case 10:
                    label6.Visible = true;
                    anim = anim + 1;
                    break;
            }
            if(progresso.Value < 100)
            {
                progresso.Value = progresso.Value + 10;
                labCarga.Text = "Cargando... " + progresso.Value + "%";
            }
            else
            {
                this.Hide();
                timer1.Enabled = false;
                Login pan = new Login();
                pan.FocusMe();
                pan.ShowDialog();
                
             }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Panel_Jefe_Area pan = new Panel_Jefe_Area();
            pan.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Panel_Jefe_Area panel = new Panel_Jefe_Area();
            panel.Show();
        }

        private void progresso_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void progresso_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
