using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UsePassword
{
    public partial class FormGestionarProveedores : Form
    {
        int MValX, MValY;
        bool TogMove,acces=false;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;
        int opc = 0, sale = 0, i = 0;
        bool  espa = false, punto = true, minu = false;

        Validar val = new Validar();
        public FormGestionarProveedores()
        {
            InitializeComponent();
            txtID_Pr.Enabled = false;
            btCancelarProveedor.Visible = false;
            btGuardarProveedor.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormMenu mn = new FormMenu();
            mn.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void label6_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = false;
        }

        private void btAgregarProveedor_Click(object sender, EventArgs e)
        {
            if (txtDireccion_Pr.Text != string.Empty && txtNombre_Pr.Text != string.Empty && txtTel_Pr.Text != string.Empty)
            {
                btGuardarProveedor.Visible = true;
                btCancelarProveedor.Visible = true;
                opc = 1;

            }
            else
            {
                MessageBox.Show("Faltan Campos por llenar");
            }
            

        }
        private void agregarP()
        {
            try
            {
                cmd = new SqlCommand("Execute insertarProveedor '" + txtNombre_Pr.Text + "'," + txtTel_Pr.Text + ",'" + txtDireccion_Pr.Text+"'", new Conexion().con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Se agrego correctamente el Proveedor");

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se agrego el Proveedor", ex.Message);
            }

        }
        private void btModificarProveedor_Click(object sender, EventArgs e)
        {
            if (txtDireccion_Pr.Text != string.Empty && txtNombre_Pr.Text != string.Empty && txtTel_Pr.Text != string.Empty)
            {
                btCancelarProveedor.Visible = true;
                btGuardarProveedor.Visible = true;
                txtID_Pr.Enabled = true;
                opc = 2;
                Enabled_T();
                txtID_Pr.Enabled = false;
                acces = false;
               
            }
            else
            {
                MessageBox.Show("Tienes que consultar");
            }
        }
        private void ModificarP()
        {
            try
            {
                cmd = new SqlCommand("Execute actualizarProveedor " + txtID_Pr.Text + ",'" + txtNombre_Pr.Text + "'," + txtTel_Pr.Text + ",'" + txtDireccion_Pr.Text+"'", new Conexion().con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se Actualizo el proveedor correctamente el Proveedor");
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se actualizo el Proveedor", ex.Message);
            }
        }

        private void btEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (txtDireccion_Pr.Text != string.Empty && txtNombre_Pr.Text != string.Empty && txtTel_Pr.Text != string.Empty)
              {
                btCancelarProveedor.Visible = true;
                btGuardarProveedor.Visible = true;
                opc = 3;

            }
            else
            {
                MessageBox.Show("Tienes que consultar");
            }
        }
        private void Eliminar(string idProvedor)
        {
            DialogResult result = MessageBox.Show("Se eliminara: " + txtNombre_Pr.Text, "¡Atencion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                SqlCommand consulta2 = new SqlCommand("exec eliminarProveedor " + idProvedor, new Conexion().con);

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
        private void FormGestionarProveedores_Load(object sender, EventArgs e)
        {

        }

        private void btConsultarProveedor_Click(object sender, EventArgs e)
        {
            if (txtDireccion_Pr.Text == string.Empty && txtNombre_Pr.Text == string.Empty && txtTel_Pr.Text == string.Empty)
               {
                btCancelarProveedor.Visible = true;
                btGuardarProveedor.Visible = false;
                txtID_Pr.Enabled = true;
                acces = true;
                txtID_Pr.Focus();
                Enabled_F();
            }
            else
            {
                MessageBox.Show("Error, Los campos tienes que estar limpios");
                btCancelarProveedor.Visible = true;
            }
        }
        
        private void txtID_Pr_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void txtNombre_Pr_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTel_Pr_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void txtDireccion_Pr_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Letras(e);
        }

        private void btGuardarProveedor_Click(object sender, EventArgs e)
        {
            switch (opc)
            {
                case 1:
                      {
                        agregarP(); ;
                      }
                    break;
                case 2:
                      {
                        ModificarP();
                      }
                    break;
                case 3:
                      {
                        if (txtID_Pr.Text != String.Empty)
                        {
                            Eliminar(txtID_Pr.Text);
                        }
                    }
                    break;
            }
        }

        private void txtNombre_Pr_KeyPress_1(object sender, KeyPressEventArgs e)
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
        private void btCancelarProveedor_Click(object sender, EventArgs e)
        {
            Limpiar();
            btGuardarProveedor.Visible = false;
            btCancelarProveedor.Visible = false;
            acces = false;
            txtID_Pr.Enabled = false;
            Enabled_T();
        }

        private void txtID_Pr_TextChanged(object sender, EventArgs e)
        {
            String id = txtID_Pr.Text;
            if (txtID_Pr.Text==String.Empty)
            {
                lim2();
            }
            else
            {
                if (!string.IsNullOrEmpty(txtID_Pr.Text) && txtID_Pr.Focused)
                {
                    int num = Convert.ToInt32(id);
                    try
                    {
                        cmd = new SqlCommand("exec consultarProveedor " + num, new Conexion().con);
                        SqlDataReader consu = cmd.ExecuteReader();
                        if (consu.Read() == true)
                        {
                            txtDireccion_Pr.Text = consu["Direccion_pro"].ToString();
                            txtNombre_Pr.Text = consu["Nombre_pro"].ToString();
                            txtTel_Pr.Text = consu["Telefono_pro"].ToString();

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

        private void txtNombre_Pr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtNombre_Pr.Focused && acces)
            {
                try
                {
                    cmd = new SqlCommand("exec ConsultarNombrePro '" + txtNombre_Pr.Text + "'", new Conexion().con);
                    SqlDataReader consu = cmd.ExecuteReader();

                    if (consu.Read() == true)
                    {
                        txtDireccion_Pr.Text = consu["Direccion_pro"].ToString();
                        txtNombre_Pr.Text = consu["Nombre_pro"].ToString();
                        txtTel_Pr.Text = consu["Telefono_pro"].ToString();
                        txtID_Pr.Text = consu["id_proveedor"].ToString();

                    }
                    consu.Close();
                    txtNombre_Pr.SelectAll();


                }
                catch (Exception ex)
                {


                }

            }
        }

        private void txtNombre_Pr_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre_Pr.Text == string.Empty && acces)
            {
                Limpiar();
            }
            else
            {
                if (txtNombre_Pr.SelectedIndex != -1)
                {
                    txtNombre_Pr.SelectedIndex =txtNombre_Pr.SelectedIndex;
                }


            }
        }

        private void txtNombre_Pr_TextUpdate(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre_Pr.Text) && this.txtNombre_Pr.Focused && acces)
            {
                try
                {
                    da = new SqlDataAdapter("exec ConsultarNombrePro2 '" + txtNombre_Pr.Text + "'", new Conexion().con);
                    dt = new DataTable();
                    da.Fill(dt);
                    txtNombre_Pr.Items.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        foreach (DataColumn dc in dt.Columns)
                        {
                            txtNombre_Pr.Items.Add(dr[dc.ColumnName].ToString());
                        }
                    }
                    txtNombre_Pr.DroppedDown = true;
                    txtNombre_Pr.SelectAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al consultar");
                }
            }
        }

        private void Limpiar()
        {
            txtNombre_Pr.Text = String.Empty;
            txtDireccion_Pr.Text = string.Empty;
            txtTel_Pr.Text = String.Empty;
            txtID_Pr.Text = string.Empty;
        }
        private void lim2()
        {
            txtNombre_Pr.Text = String.Empty;
            txtDireccion_Pr.Text = string.Empty;
            txtTel_Pr.Text = String.Empty;
        }
        public void Enabled_T()
        {
    
            txtDireccion_Pr.Enabled = true;
            txtTel_Pr.Enabled = true;

        }
        public void Enabled_F()
        {
            txtDireccion_Pr.Enabled = false;
            txtTel_Pr.Enabled = false;
        }

    }
}
