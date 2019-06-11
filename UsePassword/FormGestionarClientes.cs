using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UsePassword
{
    public partial class FormGestionarClientes : Form
    {       
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;

        Validar val = new Validar();
        int opc = 0, sale = 0, i = 0;
        int MValX, MValY;
        bool TogMove,acces=false;
        bool mayu = true, espa = false, punto = true, minu =false;

        public FormGestionarClientes()
        {
            InitializeComponent();
            btCancelarCliente.Visible = false;
            btGuardarCliente.Visible = false;
            txtID_Cliente.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormMenu fm = new FormMenu();
            fm.Show();
            this.Close();
        }

        private void FormGestionarClientes_Load(object sender, EventArgs e)
        {

        }

        private void label8_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void label8_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void btAgregarCliente_Click(object sender, EventArgs e)
        {
            if (txtNombre_Cliente.Text != string.Empty && txtAP_C.Text != string.Empty
                && txtCalle_C.Text!= string.Empty && txtColonia_C.Text != string.Empty && txtNumero_C.Text != string.Empty &&
                txtTel_C.Text != string.Empty && DTP_C.Text != string.Empty)
            {
                btGuardarCliente.Visible = true;
                btCancelarCliente.Visible = true;
                opc = 1;
                cmd = new SqlCommand("Select indent_currrent('Cliente');", new Conexion().con);
                // txtID_Empleado.Text = Convert.ToString(Convert.ToInt32(cmd.ExecuteScalar()) + 1);
                txtID_Cliente.ReadOnly = false;
                i = 0;
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
                cmd = new SqlCommand("Execute insertarCliente '" + txtNombre_Cliente.Text + "','" + txtAP_C.Text + "','" + txtAM_C.Text + "','" +
                txtCalle_C.Text + "','" + txtColonia_C.Text + "'," + txtNumero_C.Text + "," + txtTel_C.Text + ",'" + DTP_C.Value.ToString("dd/MM/yy") + "'", new Conexion().con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Se agrego correctamente el Cliente");

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se agrego el cliente", ex.Message);
            }

        }
        private void btModificarCliente_Click(object sender, EventArgs e)
        {
            if (txtNombre_Cliente.Text != string.Empty && txtAP_C.Text != string.Empty
                && txtCalle_C.Text!= string.Empty && txtColonia_C.Text != string.Empty && txtNumero_C.Text != string.Empty &&
                txtTel_C.Text != string.Empty && DTP_C.Text != string.Empty)
            {
                btGuardarCliente.Visible = true;
                btCancelarCliente.Visible = true;
                opc = 2;
                txtID_Cliente.Focus();
                Enabled_T();
                acces = false;
                txtID_Cliente.Enabled = false;
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
                cmd = new SqlCommand("Execute actualizarCliente " + txtID_Cliente.Text + " , '" + txtNombre_Cliente.Text + "' , '" + txtAP_C.Text + "' , '" + txtAM_C.Text + "' , '" +
                txtCalle_C.Text + "' , '" + txtColonia_C.Text + "', " + txtNumero_C.Text + " ," + txtTel_C.Text + ",'" + DTP_C.Value.ToString("dd/MM/yy") + "'", new Conexion().con);
                
                cmd.ExecuteNonQuery();

                MessageBox.Show("Se actualizo el Cliente");
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se actualizo el Cliente", ex.Message);

            }

        }

        private void label8_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = false;
        }

        private void btConsultarCliente_Click(object sender, EventArgs e)
        {
            if (txtNombre_Cliente.Text == string.Empty && txtAP_C.Text == string.Empty && txtAM_C.Text == string.Empty
                && txtCalle_C.Text == string.Empty && txtColonia_C.Text == string.Empty && txtNumero_C.Text == string.Empty &&
                txtTel_C.Text == string.Empty)
            {
                txtID_Cliente.Enabled = true;
                btGuardarCliente.Visible = false;
                btCancelarCliente.Visible = true;
                acces = true;
                txtID_Cliente.Focus();
                Enabled_F();
                i = 0;

            }
            else
            { 
                MessageBox.Show("Error, Los campos tienen que estar en limpios");
                btCancelarCliente.Visible = true;   
            }
            
        }
        

        private void btEliminarCliente_Click(object sender, EventArgs e)
        {
            if (txtNombre_Cliente.Text == string.Empty && txtAP_C.Text == string.Empty && txtAM_C.Text == string.Empty
               && txtCalle_C.Text == string.Empty && txtColonia_C.Text == string.Empty && txtNumero_C.Text == string.Empty &&
               txtTel_C.Text == string.Empty)
            {
                MessageBox.Show("Tienes que consultar");
            }
            else
            {
                btGuardarCliente.Visible= true;
                btCancelarCliente.Visible = true;
                opc = 3;
            }
        }

        private void Eliminar(string idCliente)
        {
            DialogResult result = MessageBox.Show("Se eliminara: " + txtNombre_Cliente.Text, "¡Atencion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
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

        private void txtID_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void txtNombre_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 32)
            {
                val.Letras(e);
            }
            else
            {
                e.Handled = true;
            }
           
        }

        private void txtAP_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && minu == false)
            {
                e.Handled = false;
                minu = false;
                punto = false;
                espa = true;
            }
            else
            {
                if (e.KeyChar == 46 && punto == false)
                {

                    e.Handled = false;
                    espa = true;
                    punto = true;
                    minu = true;

                }
                else
                {
                    if (e.KeyChar == 32 && espa == true)
                    {
                        e.Handled = false;

                        minu = false;
                        espa = false;
                        punto = true;
                    }
                    else
                    {
                        if (char.IsControl(e.KeyChar))
                        {
                            e.Handled = false;
                            Return_var();

                        }
                        else
                        {
                            e.Handled = true;


                        }
                    }
                }

            }
        }

        private void txtAM_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && minu == false)
            {
                e.Handled = false;
                minu = false;
                punto = false;
                espa = true;
            }
            else
            {
                if (e.KeyChar == 46 && punto == false)
                {

                    e.Handled = false;
                    espa = true;
                    punto = true;
                    minu = true;

                }
                else
                {
                    if (e.KeyChar == 32 && espa == true)
                    {
                        e.Handled = false;

                        minu = false;
                        espa = false;
                        punto = true;
                    }
                    else
                    {
                        if (char.IsControl(e.KeyChar))
                        {
                            e.Handled = false;
                            Return_var();

                        }
                        else
                        {
                            e.Handled = true;


                        }
                    }
                }

            }
        }

        private void txtNumero_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void txtColonia_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Letras(e);
        }

        private void txtCalle_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Letras(e);
        }

        private void btGuardarCliente_Click(object sender, EventArgs e)
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

        private void txtID_Cliente_TextChanged(object sender, EventArgs e)
        {
            if (txtID_Cliente.Text==String.Empty)
            {
                Lim2();

            }
            else
            {
                if (!string.IsNullOrEmpty(txtID_Cliente.Text) && txtID_Cliente.Focused)
                {
                    String id = txtID_Cliente.Text;
                    int num = Convert.ToInt32(id);
                    try
                    {
                        cmd = new SqlCommand("exec consultarCliente " + num, new Conexion().con);
                        SqlDataReader consu = cmd.ExecuteReader();
                        if (consu.Read() == true)
                        {
                            txtAP_C.Text = consu["AP_C"].ToString();
                            txtAM_C.Text = consu["AM_C"].ToString();
                            txtCalle_C.Text = consu["Calle_C"].ToString();
                            txtColonia_C.Text = consu["Colonia_C"].ToString();
                            txtNombre_Cliente.Text = consu["Nombre_Ci"].ToString();
                            txtNumero_C.Text = consu["Numero_C"].ToString();
                            txtTel_C.Text = consu["Telefono_C"].ToString();
                            DTP_C.Text = consu["Fecha_Registro"].ToString();
                        }
                        consu.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }

                }

            }


        }
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

        private void txtTel_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void btCancelarCliente_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtID_Cliente.Enabled = false;
            btGuardarCliente.Visible = false;
            btCancelarCliente.Visible = false;
            acces = false;
            Enabled_T();
            i = 0;

        }

        private void txtNombre_Cliente_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre_Cliente.Text == string.Empty && acces)
            {
                Limpiar();
            }
            else
            {
                if (txtNombre_Cliente.SelectedIndex != -1)
                {
                    txtNombre_Cliente.SelectedIndex = txtNombre_Cliente.SelectedIndex;
                }


            }
        }

        private void txtNombre_Cliente_TextUpdate(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNombre_Cliente.Text) && this.txtNombre_Cliente.Focused && acces)
            {
                try
                {
                    da = new SqlDataAdapter("exec ConsultarNombreCliente2 '" + txtNombre_Cliente.Text + "'", new Conexion().con);
                    dt = new DataTable();
                    da.Fill(dt);
                    txtNombre_Cliente.Items.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        foreach (DataColumn dc in dt.Columns)
                        {
                            txtNombre_Cliente.Items.Add(dr[dc.ColumnName].ToString());
                        }
                    }
                    txtNombre_Cliente.DroppedDown = true;
                    txtNombre_Cliente.SelectAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al consultar");
                }
            }
        }

        private void txtNumero_C_TextChanged(object sender, EventArgs e)
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

        private void txtColonia_C_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            val.Letras(e);
        }

        private void txtCalle_C_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            val.Letras(e);
        }

        private void txtColonia_C_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtColonia_C.SelectedValue.ToString() != null)
            {
                int cp = Convert.ToInt32(txtNumero_C.Text);
                string asentamiento = txtColonia_C.Text;
                BEstado(cp, asentamiento);
            }
        }

        private void txtNombre_Cliente_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && minu == false)
            {
                e.Handled = false;
                minu = false;
                punto = false;
                espa = true;
            }
            else
            {
                if (e.KeyChar == 46 && punto == false)
                {

                    e.Handled = false;
                    espa = true;
                    punto = true;
                    minu = true;

                }
                else
                {
                    if (e.KeyChar == 32 && espa == true)
                    {
                        e.Handled = false;

                        minu = false;
                        espa = false;
                        punto = true;
                    }
                    else
                    {
                        if (char.IsControl(e.KeyChar))
                        {
                            e.Handled = false;
                            Return_var();

                        }
                        else
                        {
                            e.Handled = true;


                        }
                    }
                }

            }
        }
        public void Return_var()
        {
            minu = false; espa = true; punto = false;
        }
        private void txtNombre_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (txtNombre_Cliente.Focused && acces)
                {
                    try
                    {
                        cmd = new SqlCommand("exec ConsultarNombreCliente '" + txtNombre_Cliente.Text + "'", new Conexion().con);
                        SqlDataReader consu = cmd.ExecuteReader();

                        if (consu.Read() == true)
                        {
                            txtAP_C.Text = consu["AP_C"].ToString();
                            txtAM_C.Text = consu["AM_C"].ToString();
                            txtCalle_C.Text = consu["Calle_C"].ToString();
                            txtColonia_C.Text = consu["Colonia_C"].ToString();
                            txtNombre_Cliente.Text = consu["Nombre_Ci"].ToString();
                            txtNumero_C.Text = consu["Numero_C"].ToString();
                            txtTel_C.Text = consu["Telefono_C"].ToString();
                            DTP_C.Text = consu["Fecha_Registro"].ToString();
                            txtID_Cliente.Text = consu["id_cliente"].ToString();

                    }
                        consu.Close();
                        txtNombre_Cliente.SelectAll();
                    }
                    catch (Exception ex)
                    {


                    }

                }

            }

        public void Limpiar()
        {
            txtID_Cliente.Text = string.Empty;
            txtNombre_Cliente.Text = string.Empty;
            txtAP_C.Text = string.Empty;
            txtAM_C.Text = string.Empty;
            txtCalle_C.Text = string.Empty;
            txtColonia_C.Text = string.Empty;
            txtNumero_C.Text = string.Empty;
            txtTel_C.Text= string.Empty;
        }
        private void Lim2()
        {
            txtNombre_Cliente.Text = string.Empty;
            txtAP_C.Text = string.Empty;
            txtAM_C.Text = string.Empty;
            txtCalle_C.Text = string.Empty;
            txtColonia_C.Text = string.Empty;
            txtNumero_C.Text = string.Empty;
            txtTel_C.Text = string.Empty;

        }
        public void Enabled_T()
        {
            txtAP_C.Enabled = true;
            txtAM_C.Enabled = true;
            txtCalle_C.Enabled = true;
            txtColonia_C.Enabled = true;
            txtNumero_C.Enabled = true;
            txtTel_C.Enabled = true;
            DTP_C.Enabled = true;
        }
        public void Enabled_F()
        {
            txtAP_C.Enabled = false;
            txtAM_C.Enabled = false;
            txtCalle_C.Enabled = false;
            txtColonia_C.Enabled = false;
            txtNumero_C.Enabled = false;
            txtTel_C.Enabled = false;
            DTP_C.Enabled = false;
        }
    }
}
