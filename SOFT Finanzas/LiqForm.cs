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

namespace SOFT_Finanzas
{
    public partial class LiqForm : MetroForm 
    {
        public LiqForm()
        {
            InitializeComponent();
        }

        private void LiqForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Liquidacion liq = new Liquidacion();
            liq.antiguedad = double.Parse(txtAntiguedad.Text);
            liq.liquidacion_año = double.Parse(txt_Total_Liq.Text);
            liq.idEmp = int.Parse(txtID.Text);
            liq.TipoEmp = txtTip.Text;
            liq.Total = liq.antiguedad * liq.liquidacion_año;
            if(LiquidacionDAO.Insertar(liq))
            {
                if(empleadoDAO.Eliminar(liq.idEmp))
                MessageBox.Show("Se ha realizado la liquidación exitosamente", "Liquidacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
