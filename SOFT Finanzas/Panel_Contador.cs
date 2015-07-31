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
    public partial class Panel_Contador : MetroForm
    {
        public Panel_Contador()
        {
            InitializeComponent();
            llendgvCompraPro();
        }

        private void Panel_Contador_Load(object sender, EventArgs e)
        {

        }

        private void changeStatCP_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("¿Seguro que deseas dar alta del costo","Atención",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Compra_Producto CP = new Compra_Producto();
                CP.id = int.Parse(idCP.Text);
                CP.Nombre = nomCp.Text;
                CP.Cantidad = int.Parse(cantCp.Text);
                CP.Precio = double.Parse(precioCp.Text);
                CP.Costo = double.Parse(costoCp.Text);
                CP.Status = "Pendiente";
;               if (Compra_ProductosDAO.Editar(CP))
               {
                    MessageBox.Show("Se ha dado de alta el precio en tienda", "Soicitud enviada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCompra_Productos.Rows.Clear();
                    llendgvCompraPro();
               }
              else
               {
                  MessageBox.Show("Ups! hubo un error en la inserción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }
            
        }
         public void llendgvCompraPro()
            {
                int i = 0;
                MySqlDataReader reader;
                reader = Compra_ProductosDAO.llenardgvCompra_Productos();
                while (reader.Read())
                {
                    string notif = reader.GetValue(3).ToString();
                    if(int.Parse(notif) == 0)
                    {
                        i = i + 1;
                    }
                    dgvCompra_Productos.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5));
                }
                if (i != 0)
                {
                    SoliCP.Text = "Solicitudes de compra de productos( " + i + " )";
                }
                else
                {
                    SoliCP.Text = "Solicitudes de compra de productos";
                }
            
            }

         private void dgvCompra_Productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
             DataGridViewRow dgv = dgvCompra_Productos.Rows[e.RowIndex];
             idCP.Text = dgv.Cells[0].Value.ToString();
             nomCp.Text = dgv.Cells[1].Value.ToString();
             cantCp.Text = dgv.Cells[2].Value.ToString();
             precioCp.Text = dgv.Cells[3].Value.ToString();
             costoCp.Text = dgv.Cells[4].Value.ToString();
             fechCp.Text = dgv.Cells[5].Value.ToString();
         }
    }
}
