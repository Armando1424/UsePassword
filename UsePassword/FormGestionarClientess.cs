using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UsePassword
{

    public partial class FormGestionarClientess : Form
    {
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;


        int opc = 0,sum=1, sale = 0, i = 0;
        int MValX, MValY;
        bool TogMove, acces = false;
        bool mayu = true, espa = false, punto = true, minu = true;
        public FormGestionarClientess()
        {
            InitializeComponent();
            btCancelarCliente.Visible = false;
            btGuardarCliente.Visible = false;
            txtID_Cliente.Enabled = false;
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            FormMenuEmpleado fm = new FormMenuEmpleado();
            fm.Show();
            this.Close();
        }

        
        

        public void Numeros(KeyPressEventArgs e)
        {

            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void Letras(KeyPressEventArgs e) {
            int a = Convert.ToInt32(e.KeyChar);
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                    sum++;
                }
                     else if (Char.IsControl(e.KeyChar))
                    {
                        sum--;
                        e.Handled = false;
                    }
                else if (sum==2)
                {
                    if (a==46)
                    {

                        sum++;
                        e.Handled = false;
                    }
                }
                else if (sum == 3) {
                    if (Char.IsSeparator(e.KeyChar))
                    {
                        sum++;
                        e.Handled = false;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void FormGestionarClientess_Load(object sender, EventArgs e)
        {

        }

        private void Label8_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void Label8_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = false;
        }

        

        private void TxtID_ClienteEmpleado_TextChanged(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrEmpty(txtID_Cliente.Text) && this.txtID_Cliente.Focused)
            {
               
                try
                {
                    cmd = new SqlCommand("select * from Clientes where id_Cliente=" + txtID_Cliente.Text, new Conexion().con);
                    SqlDataReader consu = cmd.ExecuteReader();
                    if (consu.Read() == true)
                    {
                        txtAP_C.Text = consu["AP_C"].ToString();
                        txtAM_C.Text = consu["AM_C"].ToString();
                        txtCalle_C.Text = consu["Calle_C"].ToString();
                        txtColonia_C.Text = consu["Colonia_C"].ToString();
                        comboNombre.Text = consu["Nombre_Ci"].ToString();
                        txtNumero_C.Text = consu["Numero_C"].ToString();
                        txtTel_C.Text = consu["Telefono_C"].ToString();
                        DTP_C.Text = consu["Fecha_Registro"].ToString();

                    }
                    else
                    {
                        Lim2();
                    }
                    consu.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
            
        }

        

       

        private void BtModificarEmpleadoC_Click(object sender, EventArgs e)
        {
            if (comboNombre.Text != string.Empty && txtAP_C.Text != string.Empty && txtAM_C.Text != string.Empty
               && txtCalle_C.Text != string.Empty && txtColonia_C.Text != string.Empty && txtNumero_C.Text != string.Empty &&
               txtTel_C.Text != string.Empty && DTP_C.Text != string.Empty)
            {
                btGuardarCliente.Visible = true;
                btCancelarCliente.Visible = true;
                opc = 2;
                txtID_Cliente.Focus();
                i = 0;

            }
            else
            {
                MessageBox.Show("Tienes que consultar");

            }

        }
        private void ModificarC()
        {
            try
            {
                cmd = new SqlCommand("Execute actualizarCliente " + txtID_Cliente.Text + ",'" + comboNombre.Text + "','" + txtAP_C.Text + "','" + txtAM_C.Text + "','" +
                txtCalle_C.Text + "','" + txtColonia_C.Text + "'," + txtNumero_C.Text + ",'" + txtTel_C.Text + "','" + DTP_C.Value.ToString("dd/MM/yy") + "'", new Conexion().con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Se actualizo el Cliente");
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se actualizo el Cliente", ex.Message);

            }

        }

        private void BtConsultarEmpleadoC_Click(object sender, EventArgs e)
        {
            if (comboNombre.Text == string.Empty && txtAP_C.Text == string.Empty && txtAM_C.Text == string.Empty
               && txtCalle_C.Text == string.Empty && txtColonia_C.Text == string.Empty && txtNumero_C.Text == string.Empty &&
               txtTel_C.Text == string.Empty)
            {
                txtID_Cliente.Enabled = true;
                comboNombre.Enabled = true;
                btGuardarCliente.Visible = false;
                btCancelarCliente.Visible = true;
                txtID_Cliente.Focus();
                acces = true;
            }
            else
            {

                MessageBox.Show("Error, Los campos tienen que estar en limpios");
                btCancelarCliente.Visible = true;

            }

        }

        private void BtEliminarEmpleadoC_Click(object sender, EventArgs e)
        {
            if (comboNombre.Text == string.Empty && txtAP_C.Text == string.Empty && txtAM_C.Text == string.Empty
               && txtCalle_C.Text == string.Empty && txtColonia_C.Text == string.Empty && txtNumero_C.Text == string.Empty &&
               txtTel_C.Text == string.Empty)
            {
                MessageBox.Show("Tienes que consultar");
            }
            else
            {
                btGuardarCliente.Visible = true;
                btCancelarCliente.Visible = true;
                opc = 3;
                acces = false;
            }
        }
        private void Eliminar(string idCliente)
        {
            DialogResult result = MessageBox.Show("Se eliminara: " + comboNombre.Text, "¡Atencion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                // SqlCommand consulta1 = new SqlCommand("delete from Datos_venta where id_empleado=" + idEmpleado, new Conexion().con);
                // consulta1.ExecuteNonQuery();
                SqlCommand consulta2 = new SqlCommand("exec eliminarCliente " + idCliente, new Conexion().con);

                if (consulta2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Registro eliminado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Registro No encontrado", "Algo fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        private void BtGuardarEmpleadoC_Click(object sender, EventArgs e)
        {
            switch (opc)
            {
                case 1:
                    {
                        AgregarC();
                    }
                    break;
                case 2:
                    {
                        ModificarC();
                    }
                    break;
                case 3:
                    {
                        if (txtID_Cliente.Text != string.Empty)
                        {
                            Eliminar(txtID_Cliente.Text);
                        }
                    }
                    break;

            }
        }

        private void BtCancelarEmpleadoC_Click(object sender, EventArgs e)
        {
            /*******************************CANCELAR******************/
            Limpiar();
            txtID_Cliente.Enabled = false;
            btGuardarCliente.Visible = false;
            btCancelarCliente.Visible = false;
            i = 0;
            acces = false;
        }
        public void Limpiar()
        {
            txtID_Cliente.Text = string.Empty;
            comboNombre.Text = string.Empty;
            txtAP_C.Text = string.Empty;
            txtAM_C.Text = string.Empty;
            txtCalle_C.Text = string.Empty;
            txtColonia_C.Text = string.Empty;
            txtNumero_C.Text = string.Empty;
            txtTel_C.Text = string.Empty;
        }
        private void Lim2()
        {
            comboNombre.Text = string.Empty;
            txtAP_C.Text = string.Empty;
            txtAM_C.Text = string.Empty;
            txtCalle_C.Text = string.Empty;
            txtColonia_C.Text = string.Empty;
            txtNumero_C.Text = string.Empty;
            txtTel_C.Text = string.Empty;

        }
        private void Lim3()
        {
            txtID_Cliente.Text = string.Empty;
            txtAP_C.Text = string.Empty;
            txtAM_C.Text = string.Empty;
            txtCalle_C.Text = string.Empty;
            txtColonia_C.Text = string.Empty;
            txtNumero_C.Text = string.Empty;
            txtTel_C.Text = string.Empty;

        }
        private void BtAgregarEmpleadoC_Click(object sender, EventArgs e)
        {
            if (comboNombre.Text != string.Empty && txtAP_C.Text != string.Empty && txtAM_C.Text != string.Empty
               && txtCalle_C.Text != string.Empty && txtColonia_C.Text != string.Empty && txtNumero_C.Text != string.Empty &&
               txtTel_C.Text != string.Empty && DTP_C.Text != string.Empty)
            {
                btGuardarCliente.Visible = true;
                btCancelarCliente.Visible = true;
                opc = 1;
                cmd = new SqlCommand("Select indent_currrent('Clientes');", new Conexion().con);
                // txtID_Empleado.Text = Convert.ToString(Convert.ToInt32(cmd.ExecuteScalar()) + 1);
                txtID_Cliente.ReadOnly = false;

            }
            else
            {
                MessageBox.Show("Falta información por llenar");
            }
        }
        private void AgregarC()
        {
            try
            {
                cmd = new SqlCommand("Execute insertarCliente '" + comboNombre.Text + "','" + txtAP_C.Text + "','" + txtAM_C.Text + "','" +
                txtCalle_C.Text + "','" + txtColonia_C.Text + "'," + txtNumero_C.Text + "," + txtTel_C.Text + ",'" + DTP_C.Value.ToString("dd/MM/yy") + "'", new Conexion().con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Se agrego correctamente el Cliente");

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se agrego el cliente", ex.Message);
            }

        }

        private void TxtID_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*********************+++++++++++++++++++++++**************/
            Numeros(e);
        }

        private void ComboNombre_TextChanged(object sender, EventArgs e)
        {
            if (comboNombre.SelectedIndex!=-1)
            {
                comboNombre.SelectedIndex = comboNombre.SelectedIndex;

            }
        }

        private void ComboNombre_TextUpdate(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboNombre.Text) && this.comboNombre.Focused && acces)
            {
                try
                {
                    da = new SqlDataAdapter("exec busNombre '" + comboNombre.Text + "'", new Conexion().con);
                    dt = new DataTable();
                    da.Fill(dt);
                    comboNombre.Items.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        foreach (DataColumn dc in dt.Columns)
                        {
                            comboNombre.Items.Add(dr[dc.ColumnName].ToString());
                        }
                    }
                    comboNombre.DroppedDown = true;
                    comboNombre.SelectAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al consultar");
                }
            }
        }

        private void ComboNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboNombre.Focused && acces)
            {
                try
                {
                    cmd = new SqlCommand("exec consCliente '" + comboNombre.Text + "'", new Conexion().con);

                    SqlDataReader consu1 = cmd.ExecuteReader();
                    if (consu1.Read() == true)
                    {
                        txtAP_C.Text = consu1["AP_C"].ToString();
                        txtAM_C.Text = consu1["AM_C"].ToString();
                        txtCalle_C.Text = consu1["Calle_C"].ToString();
                        txtColonia_C.Text = consu1["Colonia_C"].ToString();
                        txtID_Cliente.Text = consu1["id_cliente"].ToString();
                        txtNumero_C.Text = consu1["Numero_C"].ToString();
                        txtTel_C.Text = consu1["Telefono_C"].ToString();
                        DTP_C.Text = consu1["Fecha_Registro"].ToString();
                    }
                   
                    consu1.Close();
                    comboNombre.SelectAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al consultar");
                }
            }
        }

        private void TxtNombre_Cliente_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void TxtNumero_C_TextChanged(object sender, EventArgs e)
        {

        }
        //  
        public void BColonia(int cp)
        {
            cmd = new SqlCommand("exec BuscarCP " + cp, new Conexion().con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtColonia_C.ValueMember = "asentamiento";
            txtColonia_C.DataSource = dt;

        }

        public void BEstado(int cp, string asentamiento)
        {
            cmd = new SqlCommand("exec BuscarUCP '" + cp + "','" + asentamiento + "'", new Conexion().con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtCalle_C.ValueMember = "estado";
            txtCalle_C.DataSource = dt;
        }

        private void TxtNumero_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeros(e);
        }

        private void TxtTel_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeros(e);
        }

        private void TxtAP_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            Letras(e);
        }

        private void TxtAM_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            Letras(e);
        }

        private void TxtColonia_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            Letras(e);
        }

        private void TxtCalle_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            Letras(e);
        }

        private void TxtTel_C_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCalle_C_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtNumero_C_TextChanged_2(object sender, EventArgs e)
        {
            try
            {
                if (txtNumero_C.Text != null)
                {
                    int cp = Convert.ToInt32(txtNumero_C.Text);
                    BColonia(cp);
                }
            }
            catch (Exception)
            {


            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtColonia_C.SelectedValue.ToString() != null)
            {
                int cp = Convert.ToInt32(txtNumero_C.Text);
                string asentamiento = txtColonia_C.Text;
                BEstado(cp, asentamiento);
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void DTP_C_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ComboNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90 && mayu == true))
            {
                if (i < 9)
                {
                    e.Handled = false;
                    minu = false;
                    punto = false;
                    mayu = false;
                    espa = true;
                    sale = 1;
                    i++;
                }

            }
            else
            {
                if ((e.KeyChar >= 97 && e.KeyChar <= 122 && minu == false))
                {
                    if (i < 9)
                    {
                        e.Handled = false;
                        minu = false;
                        punto = false;
                        mayu = false;
                        espa = true;
                        sale = 2;
                        i++;
                    }


                }
                else
                {
                    if (e.KeyChar == 46 && punto == false)
                    {
                        if (i < 9)
                        {
                            e.Handled = false;
                            espa = true;
                            punto = true;
                            minu = true;
                            mayu = false;
                            sale = 3;
                            i++;
                        }

                    }
                    else
                    {
                        if (e.KeyChar == 32 && espa == true)
                        {
                            if (i < 9)
                            {
                                e.Handled = false;
                                mayu = true;
                                minu = true;
                                espa = false;
                                punto = true;
                                sale = 4;
                                i++;
                            }

                        }
                        else
                        {
                            if (char.IsControl(e.KeyChar))
                            {
                                ///utilzar tecla borrar
                                e.Handled = false;
                                if (sale == 1)
                                {
                                    ////Mayusculas//
                                    if (i <= 9)
                                    {
                                        mayu = true;
                                        minu = true;
                                        punto = true;
                                        espa = false;
                                        i--;
                                        if (i == 1)
                                        {
                                            sale = 1;
                                        }
                                    }


                                }
                                else
                                {/////minusculas///
                                    if (sale == 2)
                                    {
                                        if (i <= 9)
                                        {
                                            mayu = false;
                                            minu = false;
                                            espa = true;
                                            punto = false;
                                            i--;
                                            if (i == 1)
                                            {
                                                sale = 1;
                                            }
                                        }

                                    }
                                    else
                                    {
                                        ///Punto///
                                        if (sale == 3)
                                        {
                                            if (i <= 9)
                                            {
                                                espa = true;
                                                punto = true;
                                                minu = false;
                                                mayu = false;
                                                i--;

                                                if (i == 1)
                                                {
                                                    sale = 1;
                                                }

                                            }


                                        }
                                        else
                                        {
                                            ///Espacio///
                                            if (sale == 4)
                                            {
                                                if (i <= 9)
                                                {
                                                    espa = true;
                                                    punto = true;
                                                    minu = false;
                                                    mayu = false;
                                                    i--;

                                                    if (i == 1)
                                                    {
                                                        sale = 1;
                                                    }
                                                }

                                            }

                                            {

                                            }

                                        }
                                    }
                                }

                            }
                            else
                            {
                                e.Handled = true;
                            }
                        }
                    }

                }
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TxtNombre_ClientesEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Letras(e); 
        }

        private void Label8_MouseMove(object sender, MouseEventArgs e)
        {            
            if (TogMove)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }
    }
}
