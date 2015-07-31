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
    public partial class Panel_Jefe_Area : MetroForm
    {
        public Panel_Jefe_Area()
        {
  
            InitializeComponent();
            llendgvCompraPro();
            llendgvCompraMat();

            
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            if (empPue.Text == "Jefe de Area")
            {
                dgvCompraMat.Visible = false;
                ID_CM.Visible = false;
                nomCM.Visible = false;
                cantCM.Visible = false;
                preCm.Visible = false;
                fechCM.Visible = false;
                change_statusCM.Visible = false;
                lblPermisos.Visible = true;
                cm1.Visible = false;
                cm2.Visible = false;
                cm3.Visible = false;
                cm4.Visible = false;
                cm5.Visible = false;
            }
            else
            {
                dgvCompra_Productos.Visible = false;
                idCP.Visible = false;
                nomCp.Visible = false;
                cantCp.Visible = false;
                precioCp.Visible = false;
                fechCp.Visible = false;
                changeStatCP.Visible = false;
                permisosCp.Visible = true;
                cp1.Visible = false;
                cp2.Visible = false;
                cp3.Visible = false;
                cp4.Visible = false;
                cp5.Visible = false;
                cp6.Visible = false;
            }
        }
        public void Iniciar()
        {
         
        }
        public void llendgvCompraPro()
        {
            
            MySqlDataReader reader;
            reader = Compra_ProductosDAO.llenardgvCompra_Productos();
            while (reader.Read())
            {
                dgvCompra_Productos.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5));
            }
            
        }

        private void changeStatCP_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro que deseas enviar ahora la solicitud","Atención",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Compra_Producto cp = new Compra_Producto();
                cp.Nombre = nomCp.Text;
                cp.Cantidad = int.Parse(cantCp.Text);
                cp.Costo = double.Parse(costoCp.Text);
                if (Compra_ProductosDAO.Insertar(cp))
                {
                    MessageBox.Show("Se ha enviado la solicitud de compra ", "Soicitud enviada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCompra_Productos.Rows.Clear();
                    llendgvCompraPro();
                }
                else
                {
                    MessageBox.Show("Ups! hubo un error en la inserción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void change_statusCM_Click(object sender, EventArgs e)
        {
            Compra_Material cm = new Compra_Material();
            cm.id = int.Parse(ID_CM.Text);
            cm.Nombre = nomCM.Text;
            cm.Cantidad = int.Parse(cantCM.Text);
            cm.Precio = double.Parse(preCm.Text);
            
                if (Compra_MaterialDAO.Insertar(cm))
                {
                    MessageBox.Show("Se ha enviado la solicitud de compra ", "Solicitud registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCompraMat.Rows.Clear();
                    llendgvCompraMat();
                }
                else
                {
                    MessageBox.Show("Ups! hubo un error en la inserción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        public void llendgvCompraMat()
        {
            MySqlDataReader reader;
            reader = Compra_MaterialDAO.llenardgvCompra_Material();
            while (reader.Read())
            {
                dgvCompraMat.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4));
            }
        }

        private void SoliCM_Click(object sender, EventArgs e)
        {
            if (empPue.Text == "Jefe de Area")
            {
                dgvCompraMat.Visible = false;
                ID_CM.Visible = false;
                nomCM.Visible = false;
                cantCM.Visible = false;
                precioCM.Visible = false;
                fechCM.Visible = false;
                change_statusCM.Visible = false;
                lblPermisos.Visible = true;
            }
        }
    }
}
