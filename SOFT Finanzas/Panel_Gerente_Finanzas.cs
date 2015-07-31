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
using MySql.Data.MySqlClient;
using MetroFramework;

namespace SOFT_Finanzas
{
    public partial class Panel_Gerente_Finanzas : MetroForm
    {
        //Primeramente al inicializar el panel debemos ocultar algunos elementos como parte de la estetica
        public Panel_Gerente_Finanzas()
        {
            InitializeComponent();
            LlenardgvEmp();
            LlenardgvSol();
            DatEmp();
            LlenardgvViaticos();
            LlenardgvCapacitacion();
            LlenarComboboxCap();
            hora.Enabled = true;
            btnAct_via.Enabled = false;
            btnAct_serv.Enabled = false;
            LlenardgvServicios();
            apr_sueldo.Visible = false;
            btnEnviarSolAum.Visible = false;
            btnEnvEmp.Visible = false;
            dat_Emp.Visible = false;
            btnLiquidar.Visible = false;
            idEmp_aum.Visible = false;
            pueEmp_aum.Visible = false;
            suel_aum.Visible = false;
            metroPanel3.Visible = false;
            metroPanel1.Visible = false;
            btnActCap_gf.Enabled = false;
            btnEliCap_gf.Enabled = false;
            LlendgvNomina();
            LlendgvVentas();
            editVent.Enabled = false;
            llendgvCompraMat();
            llendgvCompraPro();
            dgvCompra_Productos.ReadOnly = true;
            btnEditEnv.Enabled = false;
            LlendgvTipEmp();
            LlendgvEnvios();
        }

        private void Panel_Gerente_Finanzas_Load(object sender, EventArgs e)
        {
           // System.Security.Cryptography.MD5 md5;
          //  md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        //Metodo para llenar el datagridview qu se encarga de mostrar las solicitudes de aumentos de sueldos
        public void LlenardgvSol()
        {
            int i = 0;
            MySqlDataReader reader; //Este codigo nos sirve para instanciar la clase datareader de mysql para poder obtener los datos de la consulta
            reader = empleadoDAO.datSolAct();// Nos dice de donde leera los datos
            while(reader.Read())//Mientras el la lectura del reader es true entonces se seguiran creando renglones en el datagrid
            {
                i = i + 1;
                dgvSoliAum.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4));
            }
            if (i != 0)
            {
                pestAum.Text = "Aumentos Sueldo( " + i + " )";
            }
        }
        public void LlenardgvEmp()
        {
            int i = 0;
            MySqlDataReader reader; //Este codigo nos sirve para instanciar la clase datareader de mysql para poder obtener los datos de la consulta
            reader = empleadoDAO.datEmp();// Nos dice de donde leera los datos
            while (reader.Read())//Mientras el la lectura del reader es true entonces se seguiran creando renglones en el datagrid
            {
                i = i + 1;
                dgvEmpTotal.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4));
            }
            if (i != 0)
            {
                pestBajas.Text = "Bajas Empleados( "+i+" )";
            }
        }
        public void DatEmp()
        {
            int i = 0;
            MySqlDataReader reader;
            reader = empleadoDAO.Empleados();
            while (reader.Read())
            {
                i = i + 1;
                dgvEmpleados.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5), reader.GetValue(6), reader.GetValue(7));
            }
            if (i != 0)
            {
                pestAlt.Text = "Altas Empleados( " + i + " )";
            }
        }
        private void aumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvSoliAum.Visible = true;
            dgvEmpleados.Visible = false;
        }

        private void materialOficinaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void solicitudesToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnEnvEmp_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tip_Click(object sender, EventArgs e)
        {

        }

        private void nomEmp_Click(object sender, EventArgs e)
        {

        }

        private void solicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvEmpleados.Visible = true;
            dgvSoliAum.Visible = false;
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            Hour.Text = DateTime.Now.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviarSolAum_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvSoliAum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void apr_sueldo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow ren in dgvEmpTotal.Rows)
            {
                if (ren.Cells[0].Value != null)
                {
                    if (ren.Cells[0].Value.ToString() == buscarEmp.Text)
                    {
                        idElim.Text = ren.Cells[0].Value.ToString();
                        nomElim.Text = ren.Cells[1].Value.ToString();
                        apeElim.Text = ren.Cells[2].Value.ToString();
                        tipElim.Text = ren.Cells[3].Value.ToString();
                        btnLiquidar.Visible = true;
                    }
                }
            }
        }

        private void dgvEmpTotal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dgvEmpTotal.Rows[e.RowIndex];
            idElim.Text = dgv.Cells[0].Value.ToString();
            nomElim.Text = dgv.Cells[1].Value.ToString();
            apeElim.Text = dgv.Cells[2].Value.ToString();
            tipElim.Text = dgv.Cells[3].Value.ToString();
            txtbass_sueldo.Text = dgv.Cells[4].Value.ToString();
            btnLiquidar.Visible = true;
        }

        private void cabeceraPanelGF_Click(object sender, EventArgs e)
        {

        }

        private void pestabañas_Click(object sender, EventArgs e)
        {

        }

        private void buscarEmp_Click(object sender, EventArgs e)
        {

        }

        private void buscarEmp_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (DataGridViewRow ren in dgvEmpTotal.Rows)
            {
                if (ren.Cells[0].Value != null)
                {
                    if (ren.Cells[0].Value.ToString() == buscarEmp.Text)
                    {
                        idElim.Text = ren.Cells[0].Value.ToString();
                        nomElim.Text = ren.Cells[1].Value.ToString();
                        apeElim.Text = ren.Cells[2].Value.ToString();
                        tipElim.Text = ren.Cells[3].Value.ToString();
                        txtbass_sueldo.Text = ren.Cells[4].Value.ToString();
                        btnLiquidar.Visible = true;
                    }
                }
            }
        }

        private void buscarEmp_KeyDown(object sender, KeyEventArgs e)
        {
            idElim.Text = "";
            nomElim.Text = "";
            apeElim.Text = "";
            tipElim.Text = "";
            txtbass_sueldo.Text = "";
            btnLiquidar.Visible = false;
        }

        private void btnLiquidar_Click(object sender, EventArgs e)
        {
            LiqForm FormLiquid = new LiqForm();
            FormLiquid.FocusMe();
            FormLiquid.txtID.Text = idElim.Text;
            FormLiquid.txtTip.Text = tipElim.Text;
            double liq = Convert.ToDouble(txtbass_sueldo.Text) * 12;
            FormLiquid.txt_Total_Liq.Text = liq.ToString();
            FormLiquid.Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void dgvSoliAum_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            apr_sueldo.Visible = true;
            btnEnviarSolAum.Visible = true;
            metroPanel3.Visible = true;
            metroPanel1.Visible = true;
            DataGridViewRow dgv = dgvSoliAum.Rows[e.RowIndex];
            idEmp_aum.Text = dgv.Cells[3].Value.ToString();
            suel_aum.Text = dgv.Cells[2].Value.ToString();
            pueEmp_aum.Text = dgv.Cells[4].Value.ToString();
            idEmp_aum.Visible = true;
            suel_aum.Visible = true;
            pueEmp_aum.Visible = true;
        }

        private void dgvEmpleados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Este nos funciona para que cuando seleccionemos algun renglon nas mande los datos a un label y al mismo tiempo los haga visbles
            if (MessageBox.Show("Seguro que deseas realizar un cambio en el status del empleado justo ahora", "A T E N C I O N", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewRow dgv = dgvEmpleados.Rows[e.RowIndex];
                ID.Text = dgv.Cells[0].Value.ToString();
                nomEmp.Text = dgv.Cells[1].Value.ToString();
                apellido.Text = dgv.Cells[2].Value.ToString();
                direc.Text = dgv.Cells[3].Value.ToString();
                suelbas.Text = dgv.Cells[4].Value.ToString();
                tip.Text = dgv.Cells[5].Value.ToString();
                usuario.Text = dgv.Cells[6].Value.ToString();

                ID.Visible = true;
                nomEmp.Visible = true;
                apellido.Visible = true;
                direc.Visible = true;
                tip.Visible = true;
                suelbas.Visible = true;
                usuario.Visible = true;
                status_Update.Visible = true;
                btnEnvEmp.Visible = true;
                dat_Emp.Visible = true;
            }
        }

        private void btnEnvEmp_Click_1(object sender, EventArgs e)
        {
            //Crea la condicion de si el combobox de nombre 'status_Update.Text' = "Activo" 
            //realizara el cambio en el status del empleado y asi se vuelve un empleado activo de la empresa
            if (status_Update.Text == "Activo")
            {
                try
                {

                    MySqlConnection cnx;
                    cnx = conexion.conectar();


                    if (empleadoDAO.Actualizar(status_Update.Text, Convert.ToInt32(ID.Text)) == false)
                    {
                        MetroMessageBox.Show(this, "Error en la inserción");
                    }
                    else
                    {

                        MetroMessageBox.Show(this, "Datos actualizados exitosamente","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        //Con este foreach hacemos que se recorra el dgv y poder eliminar la solicitud por que ya se convierte en un activo
                        foreach (DataGridViewRow ren in dgvEmpleados.Rows)
                        {
                            if (ren.Cells[0].Value != null)
                            {
                                if (ren.Cells[0].Value.ToString() == ID.Text)
                                {
                                    dgvEmpleados.Rows.Remove(ren);
                                }
                            }
                        }
                        ID.Visible = false;
                        nomEmp.Visible = false;
                        apellido.Visible = false;
                        direc.Visible = false;
                        tip.Visible = false;
                        suelbas.Visible = false;
                        usuario.Visible = false;
                        btnEnvEmp.Visible = false;
                        status_Update.Visible = false;
                        dat_Emp.Visible = false;

                    }
                    cnx.Close();
                }
                catch
                {
                    MetroMessageBox.Show(this, "Error en los valores de los datos");
                }
            }
            else//Si no es activo significa que se rechaza la solicitud 
            {
                //Se hace una segunda cuestion para confirmar su opcion
                if (MetroMessageBox.Show(this, "Seguro que deseas rechazar la solicitud (RECUERDA QUE LOS DATOS DEL EMPLEADO SE ELIMINARAN)", "A T E N C I O N", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    MySqlConnection cnx;
                    cnx = conexion.conectar();
                    //Se manda llamar de la clase empleadoDAO el metodo eliminar
                    if (empleadoDAO.Eliminar(Convert.ToInt32(idEmp_aum.Text)) == true)
                    {
                        MetroMessageBox.Show(this, "El empleado ha sido rechazado", "Empleado eliminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        foreach (DataGridViewRow ren in dgvEmpleados.Rows)
                        {
                            if (ren.Cells[0].Value != null)
                            {
                                if (ren.Cells[0].Value.ToString() == ID.Text)
                                {
                                    dgvEmpleados.Rows.Remove(ren);
                                }
                            }
                        }
                    }
                    ID.Visible = false;
                    nomEmp.Visible = false;
                    apellido.Visible = false;
                    direc.Visible = false;
                    tip.Visible = false;
                    suelbas.Visible = false;
                    usuario.Visible = false;
                    btnEnvEmp.Visible = false;
                    status_Update.Visible = false;
                    dat_Emp.Visible = false;
                    cnx.Close();
                }
            }
        }

        private void btnEnviarSolAum_Click_1(object sender, EventArgs e)
        {
            MySqlDataReader reader;
            reader = Sueldo.RangoSueldo(pueEmp_aum.Text);//Se buscan  el rangos del sueldo que puede tener ese tipo de empleado//
            if (reader.Read())//si devuelve valores se realizara una comparativa para saber si el aumneto queda entre los rangos establecido
            {
                double pagomax = Convert.ToDouble(reader.GetValue(1));
                double pagomin = Convert.ToDouble(reader.GetValue(0));

                {
                    if (apr_sueldo.Text == "Aprobar")//Si el sueldo se aprueba se realizara el update en el sueldo base del empleado
                    {
                        if (Convert.ToDouble(suel_aum.Text) <= pagomax && Convert.ToDouble(suel_aum.Text) >= pagomin)
                        {
                            MySqlConnection cnx;
                            cnx = conexion.conectar();


                            if (empleadoDAO.Actualizar_Sueldo(Convert.ToDouble(suel_aum.Text), Convert.ToInt32(idEmp_aum.Text)) == false)//Se manda la actualizacion
                            {
                                MetroMessageBox.Show(this, "Error en la inserción");
                            }
                            else
                            {
                                if (Sueldo.Eliminar_sol_suel(Convert.ToInt32(idEmp_aum)) == true)
                                {

                                    MetroMessageBox.Show(this, "Datos actualizados exitosamente");
                                    dgvSoliAum.Rows.Clear();
                                    LlenardgvSol();
                                }
                            }
                            apr_sueldo.Visible = false;
                            btnEnviarSolAum.Visible = false;
                            cnx.Close();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Error el sueldo que quiere ingresar no se encuentra en el rango de sueldo especificados para este tipo de empleado", "A T E N C I O N", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        if (MetroMessageBox.Show(this,"Seguro que deseas rechazar la solicitud", "A T E N C I O N", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            MySqlConnection cnx;
                            cnx = conexion.conectar();

                            if (Sueldo.Eliminar_sol_suel(Convert.ToInt32(idEmp_aum.Text)) == true)
                            {
                                MetroMessageBox.Show(this, "El sueldo del empleado ha sido rechazado", "Solicitud eliminada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                dgvSoliAum.Rows.Clear();
                                LlenardgvSol();
                            }
                            apr_sueldo.Visible = false;
                            btnEnviarSolAum.Visible = false;
                            cnx.Close();
                        }
                    }
                }
            }
        }

        private void btnServ_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this,"Seguro que desea registrar este pago de servicio, recuerda que producirá un gasto oficial para la empresa y no se puede eliminarse, solo editarse", "A T E N C I O N", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                servicios serv = new servicios();
                serv.nombre = txtNombre_serv.Text;
                serv.costo = double.Parse(txtCosto_serv.Text);
                if (serviciosDAO.Insertar(serv))
                {
                    MessageBox.Show("Servicio Registrado", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvServicios.Rows.Clear();
                    LlenardgvServicios();

                }
            }
        }
        public void LlenardgvServicios()
        {
            MySqlConnection cnx;
            cnx = conexion.conectar();
            MySqlDataReader reader; //Este codigo nos sirve para instanciar la clase datareader de mysql para poder obtener los datos de la consulta
            reader = serviciosDAO.llenardgvServ();// Nos dice de donde leera los datos
            while (reader.Read())//Mientras el la lectura del reader es true entonces se seguiran creando renglones en el datagrid
            {
                dgvServicios.Rows.Add(reader.GetValue(0), reader.GetValue(1).ToString(), reader.GetValue(2), reader.GetValue(3));
            }
            cnx.Close();
        }

        private void dgvServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow ren = dgvServicios.Rows[e.RowIndex];
            idServ.Text = ren.Cells[0].Value.ToString();
            txtFecha_serv.Text = ren.Cells[1].Value.ToString();
            txtNombre_serv.Text = ren.Cells[2].Value.ToString();
            txtCosto_serv.Text = ren.Cells[3].Value.ToString();
            btnServ.Enabled = false;
            btnAct_serv.Enabled = true;
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAct_serv_Click(object sender, EventArgs e)
        {
            MySqlConnection cnx;
            cnx = conexion.conectar();
            servicios serv = new servicios();
            serv.nombre = txtNombre_serv.Text;
            serv.costo = double.Parse(txtCosto_serv.Text);
            serv.id = int.Parse(idServ.Text);
            if(serviciosDAO.Actualizar(serv))
            {
                MetroMessageBox.Show(this, "Servicio Actualizado ", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvServicios.Rows.Clear();
                LlenardgvServicios();
                btnServ.Enabled = true;
                btnAct_serv.Enabled = false;
                txtNombre_serv.Text = "";
                txtCosto_serv.Text = "";
                idServ.Text = "Autogenerado";
                txtFecha_serv.Text = "Autogenerado";
            }
            cnx.Close();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnRegViat_Click(object sender, EventArgs e)
        {
            MySqlConnection cnx;
            cnx = conexion.conectar();
            Viaticos via = new Viaticos();
            via.Hospedaje = double.Parse(hosvia.Text);
            via.Alimentos = double.Parse(aliVia.Text);
            via.Transporte = double.Parse(traVia.Text);
            via.lugarDestino = lugDes_via.Text;
            via.Total = via.Hospedaje + via.Alimentos + via.Transporte;
            via.empID = int.Parse(idEmp_via.Text);
            via.Puesto = pueEmp_via.Text;
            MySqlDataReader reader; //Este codigo nos sirve para instanciar la clase datareader de mysql para poder obtener los datos de la consulta
            reader = ViaticosDAO.validacionEmp(via);// Nos dice de donde leera los datos
            if(reader.Read())
            {
                string emp = reader.GetValue(0).ToString();
                if (int.Parse(emp) < 1)
                {
                    MetroMessageBox.Show(this, "El empleado no existe o sido dado de baja", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ViaticosDAO.Insertar(via))
                    {
                        MetroMessageBox.Show(this, "Se ha dado de alta el viatico", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvViatico.Rows.Clear();
                        LlenardgvViaticos();
                    }
                }
            }
            cnx.Close();
        }
        public void LlenardgvViaticos()
        {
            MySqlConnection cnx;
            cnx = conexion.conectar();
            MySqlDataReader reader; //Este codigo nos sirve para instanciar la clase datareader de mysql para poder obtener los datos de la consulta
            reader = ViaticosDAO.dgvViatico();// Nos dice de donde leera los datos
            while (reader.Read())//Mientras el la lectura del reader es true entonces se seguiran creando renglones en el datagrid
            {
                dgvViatico.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5),reader.GetValue(6),reader.GetValue(7),reader.GetValue(8));
            }
            cnx.Close();
        }

        private void dgvViatico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow dgv = dgvViatico.Rows[e.RowIndex];
            id_via.Text = dgv.Cells[0].Value.ToString();
            hosvia.Text = dgv.Cells[1].Value.ToString();
            aliVia.Text = dgv.Cells[2].Value.ToString();
            traVia.Text = dgv.Cells[3].Value.ToString();
            lugDes_via.Text = dgv.Cells[4].Value.ToString();
            fecVia.Text = dgv.Cells[5].Value.ToString();
            totVia.Text = dgv.Cells[6].Value.ToString();
            idEmp_via.Text = dgv.Cells[7].Value.ToString();
            pueEmp_via.Text = dgv.Cells[8].Value.ToString();
            btnRegViat.Enabled = false;
            btnAct_via.Enabled = true;
        }

        private void btnAct_via_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cnx;
                cnx = conexion.conectar();
                Viaticos via = new Viaticos();
                via.Hospedaje = double.Parse(hosvia.Text);
                via.Alimentos = double.Parse(aliVia.Text);
                via.Transporte = double.Parse(traVia.Text);
                via.lugarDestino = lugDes_via.Text;
                via.Total = via.Hospedaje + via.Alimentos + via.Transporte;
                via.empID = int.Parse(idEmp_via.Text);
                via.Puesto = pueEmp_via.Text;
                via.id = int.Parse(id_via.Text);
                MySqlDataReader reader; //Este codigo nos sirve para instanciar la clase datareader de mysql para poder obtener los datos de la consulta
                reader = ViaticosDAO.validacionEmp(via);// Nos dice de donde leera los datos
                if (reader.Read())
                {
                    string emp = reader.GetValue(0).ToString();
                    if (int.Parse(emp) < 1)
                    {
                        MessageBox.Show("El empleado no existe o sido dado de baja", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (ViaticosDAO.Actualizar(via))
                        {
                            MessageBox.Show("Se ha actualizado exitosamente el viatico", "Registro Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvViatico.Rows.Clear();
                            LlenardgvViaticos();
                            btnAct_via.Enabled = false;
                            btnRegViat.Enabled = true;
                        }
                    }
               }
                cnx.Close();
            }
            catch
            {  
               MessageBox.Show("Error en los datos ingresalos de forma correcta!");
              
            }
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }
        private DataTable Cargar()
        {
            MySqlConnection con;
            con = conexion.conectar();
            
                DataTable dt = new DataTable();
                string query = "SELECT * FROM capacitadores";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
        }


        public void LlenarComboboxCap()
        {


            combobox_Capacitador.DataSource = Cargar();
            combobox_Capacitador.DisplayMember = "id";
                
        }


        private void btnAltCap_gf_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cnx;
                cnx = conexion.conectar();
                Capacitacion cap = new Capacitacion();
                cap.Nombre = nomCap_gf.Text;
                cap.Pago_Capacitador = double.Parse(pago_Capacitador.Text);
                cap.Material = double.Parse(matCap.Text);
                cap.Capacitador = int.Parse(combobox_Capacitador.Text);

                if (CapacitacionDAO.Insertar(cap))
                {
                    MessageBox.Show("La capacitacion se ha dado de alta", "Regristro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCapacitacion.Rows.Clear();
                    LlenardgvCapacitacion();
                }
                else
                {

                    MessageBox.Show("Error en la inserción de la capacitacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                cnx.Close();
            }
            catch
            {
                MessageBox.Show("Error en los valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
               
        }
        public void LlenardgvCapacitacion()
        {
            MySqlConnection cnx;
            cnx = conexion.conectar();
            MySqlDataReader reader;
            reader = CapacitacionDAO.datosdgvCapacitacion();
            while(reader.Read())
            {
                dgvCapacitacion.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5));
            }
            cnx.Close();
        }

        private void dgvCapacitacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dgvCapacitacion.Rows[e.RowIndex];
            idCap_gf.Text = dgv.Cells[0].Value.ToString();
            nomCap_gf.Text = dgv.Cells[1].Value.ToString();
            pago_Capacitador.Text = dgv.Cells[2].Value.ToString();
            fechCap.Text = dgv.Cells[4].Value.ToString();
            matCap.Text = dgv.Cells[3].Value.ToString();
            combobox_Capacitador.Text = dgv.Cells[5].Value.ToString();
            btnActCap_gf.Enabled = true;
            btnEliCap_gf.Enabled = true;
            btnAltCap_gf.Enabled = false;
        }

        private void dataSet1_Initialized(object sender, EventArgs e)
        {

        }
        
        private void combobox_Capacitador_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void btnActCap_gf_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cnx;
                cnx = conexion.conectar();
                Capacitacion cap = new Capacitacion();
                cap.Nombre = nomCap_gf.Text;
                cap.Pago_Capacitador = double.Parse(pago_Capacitador.Text);
                cap.Material = double.Parse(matCap.Text);
                cap.Capacitador = int.Parse(combobox_Capacitador.Text);
                cap.id = int.Parse(idCap_gf.Text);
                if (CapacitacionDAO.Actualizar(cap))
                {
                    MetroMessageBox.Show(this, "La capacitacion se ha actualizado", "Regristro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCapacitacion.Rows.Clear();
                    LlenardgvCapacitacion();
                    btnActCap_gf.Enabled = false;
                    btnEliCap_gf.Enabled = false;
                    btnAltCap_gf.Enabled = true;
                }
                else
                {

                    MetroMessageBox.Show(this, "Error en la inserción de la capacitacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnActCap_gf.Enabled = false;
                    btnEliCap_gf.Enabled = false;
                    btnAltCap_gf.Enabled = true;

                }
                cnx.Close();
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, "Error en los valores " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnEliCap_gf_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "¿Seguro que deseas eliminar la capacitación?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Capacitacion cap = new Capacitacion();
                    cap.id = int.Parse(idCap_gf.Text);
                    if (CapacitacionDAO.Eliminar(cap))
                    {
                        MessageBox.Show("La capacitacion se ha eliminado", "Eliminacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvCapacitacion.Rows.Clear();
                        LlenardgvCapacitacion();
                        btnActCap_gf.Enabled = false;
                        btnEliCap_gf.Enabled = false;
                        btnAltCap_gf.Enabled = true;
                    }
                    else
                    {

                        MessageBox.Show("Error en la inserción de la capacitacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnActCap_gf.Enabled = false;
                        btnEliCap_gf.Enabled = false;
                        btnAltCap_gf.Enabled = true;

                    }
                }
                catch
                {
                    MessageBox.Show("Error en los valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_3(object sender, EventArgs e)
        {

        }

        private void btnRegNom_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("¿Seguro que deseas generar la nomina?","A T E N C I O N", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    nomina nom = new nomina();
                    nom.seguro = double.Parse(seguroNom.Text);
                    nom.prestaciones = double.Parse(PrestNom.Text);
                    nom.incentivos = double.Parse(IncentNom.Text);
                    nom.Tipo_Pago = tipPagNom.Text;
                    nom.idEmp = int.Parse(idEmpNom.Text);
                    nom.TipoEmp = tipEmpNom.Text;
                    nom.sueldo = double.Parse(sueldoEmpNom.Text);
                    /*Percepciones*/
                    nom.sueldo_t = nom.sueldo + nom.incentivos + nom.prestaciones;
                    /*Retenciones*/
                    nom.ISR = nom.sueldo_t * .35;
                    if (infoNom.Text == "Positivo")
                    {
                        nom.infonavit = 0.25 * nom.sueldo;
                        nom.sueldo_t = nom.sueldo_t - nom.ISR - nom.infonavit - nom.seguro;
                    }
                    else
                    {
                        nom.infonavit = 0;
                        nom.sueldo_t = nom.sueldo_t - nom.ISR - nom.infonavit - nom.seguro;
                    }
                    if (nominaDAO.Insertar(nom))
                    {
                        MessageBox.Show("Nomina registrada", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvNomina.Rows.Clear();
                        LlendgvNomina();
                    }
                    else
                    {
                        MessageBox.Show("Ups! hubo un error en el registro", "E R R O R ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error en los datos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public void LlendgvNomina()
        {
            MySqlConnection cnx;
            cnx = conexion.conectar();
            MySqlDataReader reader;
            reader = nominaDAO.dgvNominaDat();
            while (reader.Read())
            {
                dgvNomina.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5), reader.GetValue(6), reader.GetValue(7), reader.GetValue(8), reader.GetValue(9), reader.GetValue(10), reader.GetValue(11));
            }
            cnx.Close();
        }

        private void idEmpNom_KeyUp(object sender, KeyEventArgs e)
        {
            if(idEmpNom.Text != "")
            {
                MySqlConnection cnx;
                cnx = conexion.conectar();
                MySqlDataReader reader;
                reader = empleadoDAO.DatNomEmp(int.Parse(idEmpNom.Text));
                if (reader.Read())
                {
                    sueldoEmpNom.Text = reader.GetValue(0).ToString();
                    tipEmpNom.Text = reader.GetValue(1).ToString();
                }
                cnx.Close();

            }

        }

        private void idEmpNom_KeyDown(object sender, KeyEventArgs e)
        {
            sueldoEmpNom.Text = "";
            tipEmpNom.Text = "";
            
        }

        private void infonaNom_KeyUp(object sender, KeyEventArgs e)
        {
            

        }

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }
        public void LlendgvVentas()
        {
            MySqlConnection cnx;
            cnx = conexion.conectar();
            MySqlDataReader reader;
            reader = VentasDAO.llenardgvVent();
            while (reader.Read())
            {
                dgvVentas.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3).ToString(), reader.GetValue(4).ToString(), reader.GetValue(5));
            }
            cnx.Close();
        }

        private void metroButton1_Click_4(object sender, EventArgs e)
        {

        }

        private void RegVent_Click(object sender, EventArgs e)
        {
            
                Ventas vent = new Ventas();
                vent.ganacias = double.Parse(gananciasVent.Text);
                vent.mermas = double.Parse(mermasVent.Text);
                vent.fecha_inicio = fecha_inicioVent.Text;
                vent.fecha_fin = fecha_finVent.Text;
                vent.comentarios = comentVentas.Text;
                if (VentasDAO.Insertar(vent))
                {
                    MetroMessageBox.Show(this,"Se ha registrado el informe de venta exitosamente", "R E G I S T R O     E X I T O S O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvVentas.Rows.Clear();
                    LlendgvVentas();
                }
                else
                {
                    MetroMessageBox.Show(this, "Ups! hubo un error en el registro", "E R R O R ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
          
            
        }

        private void comentVentas_Click(object sender, EventArgs e)
        {

        }

        private void gananciasVent_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Ventas vent = new Ventas();
                vent.ganacias = double.Parse(gananciasVent.Text);
            }
            catch
            {
                gananciasVent.Text = "";
            }
        }

        private void mermasVent_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Ventas vent = new Ventas();
                vent.mermas = double.Parse(mermasVent.Text);
            }
            catch
            {
                mermasVent.Text = "";
            }
        }

        private void editVent_Click(object sender, EventArgs e)
        {
            Ventas vent = new Ventas();
            vent.id = int.Parse(IDvent.Text);
            vent.ganacias = double.Parse(gananciasVent.Text);
            vent.mermas = double.Parse(mermasVent.Text);
            vent.fecha_inicio = fecha_inicioVent.Text;
            vent.fecha_fin = fecha_finVent.Text;
            vent.comentarios = comentVentas.Text;
            if(VentasDAO.Editar(vent))
            {
                MessageBox.Show("Se ha editado el informe de venta exitosamente", "R E G I S T R O     E X I T O S O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvVentas.Rows.Clear();
                RegVent.Enabled = true;
                editVent.Enabled = false;
                LlendgvVentas();
            }
            else
            {
                MessageBox.Show("Ups! hubo un error en el registro", "E R R O R ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            editVent.Enabled = true;
            RegVent.Enabled = false;
            DataGridViewRow dgv = dgvVentas.Rows[e.RowIndex];
            IDvent.Text = dgv.Cells[0].Value.ToString();
            gananciasVent.Text = dgv.Cells[1].Value.ToString();
            mermasVent.Text = dgv.Cells[2].Value.ToString();
            fecha_inicioVent.Text = dgv.Cells[3].Value.ToString();
            fecha_finVent.Text = dgv.Cells[4].Value.ToString();
            comentVentas.Text = dgv.Cells[5].Value.ToString();
        }
        public void llendgvCompraMat()
        {
            int i = 0;
            MySqlDataReader reader;
            reader = Compra_MaterialDAO.llenardgvCompra_Material();
            while (reader.Read())
            {
                i = i + 1;
                dgvCompraMat.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5));
            }
            if(i != 0)
            {
                pestMateriales.Text = "Compra Material( "+i+" )";
            }

        }

        private void metroButton1_Click_5(object sender, EventArgs e)
        {

        }

        private void change_statusCM_Click(object sender, EventArgs e)
        {
            Compra_Material cm = new Compra_Material();
            cm.id = int.Parse(ID_CM.Text);
            cm.Nombre = nomCM.Text;
            cm.Cantidad = int.Parse(cantCM.Text);
            cm.Precio = double.Parse(preCm.Text);
            cm.Status = comboStatCM.Text;
            if(comboStatCM.Text == "Financear")
            {
                if (Compra_MaterialDAO.Editar(cm))
                {
                    MessageBox.Show("Se ha registrado como compra activa","Compra registrada",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    dgvCompraMat.Rows.Clear();
                    llendgvCompraMat();
                }
                else
                {
                    MessageBox.Show("Ups! hubo un error en la inserción","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                if(Compra_MaterialDAO.Delete(cm))
                {
                    MessageBox.Show("Se ha eliminado la solicitud de compra", "Eliminacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCompraMat.Rows.Clear();
                    llendgvCompraMat();
                    limpiezaCM();
                }
                else
                {
                    MessageBox.Show("Ups! hubo un error intentalo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvCompraMat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dgvCompraMat.Rows[e.RowIndex];
            ID_CM.Text = dgv.Cells[0].Value.ToString();
            nomCM.Text = dgv.Cells[1].Value.ToString();
            cantCM.Text = dgv.Cells[2].Value.ToString();
            preCm.Text = dgv.Cells[3].Value.ToString();
            fechCM.Text = dgv.Cells[4].Value.ToString();
        }
        public void limpiezaCM()
        {
            ID_CM.Text = "";
            nomCM.Text = "";
            cantCM.Text = "";
            preCm.Text = "";
            fechCM.Text = "";

        }
        public void llendgvCompraPro()
        {
            int i = 0;
            MySqlDataReader reader;
            reader = Compra_ProductosDAO.llenardgvCompra_ProductosSol();
            while (reader.Read())
            {
                i = i + 1;
                dgvCompra_Productos.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5),reader.GetValue(6));
            }
            pestProduts.Text = "Compra Productos( " + i + " )";
        }

        private void changeStatCP_Click(object sender, EventArgs e)
        {
            Compra_Producto CP = new Compra_Producto();
            CP.id = int.Parse(idCP.Text);
            CP.Nombre = nomCp.Text;
            CP.Cantidad = int.Parse(cantCp.Text);
            CP.Precio = double.Parse(precioCp.Text);
            CP.Costo = double.Parse(costoCp.Text);
            CP.Status = statusCp.Text;
            if (statusCp.Text == "Financear")
            {
                if (Compra_ProductosDAO.Editar(CP))
                {
                    MessageBox.Show("Se ha registrado como compra activa", "Compra registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCompra_Productos.Rows.Clear();
                    llendgvCompraPro();
                    LimpiarDatCP();
                }
                else
                {
                    MessageBox.Show("Ups! hubo un error en la inserción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (Compra_ProductosDAO.Delete(CP))
                {
                    MessageBox.Show("Se ha eliminado la solicitud de compra", "Solicitud eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCompra_Productos.Rows.Clear();
                    llendgvCompraPro();
                    LimpiarDatCP();
          
                }
                else
                {
                    MessageBox.Show("Ups! hubo un error intentalo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            statusCp.Text = dgv.Cells[6].Value.ToString();
            
        }
        public void LimpiarDatCP()
        {
            idCP.Text = "";
            nomCp.Text = "";
            cantCp.Text = "";
            precioCp.Text = "";
            costoCp.Text = "";
            fechCp.Text = "";
            statusCp.Text = "";
        }
        public void LlendgvEnvios()
        {
            MySqlDataReader reader;
            reader = EnviosDAO.dgvEnvios();
            while (reader.Read())
            {
                dgvEnvios.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4));
            }
        }

        private void btnGuardarEnv_Click(object sender, EventArgs e)
        {
            envios env = new envios();
            env.gas = double.Parse(gasEnv.Text);
            env.incidentes = double.Parse(incidentEnv.Text);
            env.destino = destEnv.Text;
            if(EnviosDAO.Insertar(env))
            {
                MessageBox.Show("Se ha registrado el envio","Registro Exitoso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dgvEnvios.Rows.Clear();
                LlendgvEnvios();
            }
            else
            {
                MessageBox.Show("Error en  el envio", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvEnvios.Rows.Clear();
                LlendgvEnvios();
            }
        }

        private void dgvEnvios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dgvEnvios.Rows[e.RowIndex];
            idEnv.Text = dgv.Cells[0].Value.ToString();
            gasEnv.Text = dgv.Cells[1].Value.ToString();
            incidentEnv.Text = dgv.Cells[2].Value.ToString();
            destEnv.Text = dgv.Cells[3].Value.ToString();
            fechEnv.Text = dgv.Cells[4].Value.ToString();
            btnEditEnv.Enabled = true;
            btnGuardarEnv.Enabled = false;
        }

        private void btnEditEnv_Click(object sender, EventArgs e)
        {
            envios env = new envios();
            env.id = int.Parse(idEnv.Text);
            env.gas = double.Parse(gasEnv.Text);
            env.incidentes = double.Parse(incidentEnv.Text);
            env.destino = destEnv.Text;
            if (EnviosDAO.Editar(env))
            {
                MessageBox.Show("Se ha registrado el envio", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvEnvios.Rows.Clear();
                LlendgvEnvios();
                btnGuardarEnv.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error en  el envio", "E R R O R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvEnvios.Rows.Clear();
                LlendgvEnvios();
            }
        }
        public void LlendgvTipEmp()
        {
            int i = 0;
            MySqlDataReader reader;
            reader = Tipo_EmpDAO.dgvTipEmp();
            while (reader.Read())
            {
                i = i + 1;
                dgvTipEmp.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3));
            }
            if(i != 0)
            {
                pestTipEmp.Text = "Nuevos Tipos Empleados( " + i + " )";
            }
        }

        private void dgvTipEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dgvTipEmp.Rows[e.RowIndex];
            Id_TipEmp.Text = dgv.Cells[0].Value.ToString();
            nomTipEmp.Text = dgv.Cells[1].Value.ToString();
        }

        private void regTipEmp_Click(object sender, EventArgs e)
        {
            Tipo_Emp tipEmp = new Tipo_Emp();
            tipEmp.pago_min = double.Parse(pagMinTipEmp.Text);
            tipEmp.pago_max = double.Parse(pagMinTipEmp.Text);
            tipEmp.id = int.Parse(Id_TipEmp.Text);
            if(Tipo_EmpDAO.Editar(tipEmp))
            {
                MetroMessageBox.Show(this,"Tipo de empleado guardado oficialmente","Guardado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dgvTipEmp.Rows.Clear();
                LlendgvTipEmp();
            }
            else
            {
                MessageBox.Show("Se ha producido un error en la inserción","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void GenRepIngEgr_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_6(object sender, EventArgs e)
        {

        }

    }
}
