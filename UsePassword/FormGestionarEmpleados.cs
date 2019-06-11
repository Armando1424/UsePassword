using System;
using System.Data;
using System.Windows.Forms;
using UsePassword.Properties;
using System.Data.SqlClient;
namespace UsePassword
{
    public partial class FormGestionarEmpleados : Form
    {

        int MValX, MValY;
        bool TogMove, acces = false, entrar = true;
        bool espa=false,punto =true,minu=false;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;
        public int opc = 0, cont = 0,sale=0,i=0;


        Validar val = new Validar();
        public FormGestionarEmpleados()
        {
            InitializeComponent();
            btGuardarEmpleado.Visible = false;
            btCancelarEmpleado.Visible = false;
            txtID_Empleado.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormMenu Mn = new FormMenu();
            Mn.Show();
            this.Close();
        }

        private void btAgregarEmpleado_MouseEnter(object sender, EventArgs e)
        {

        }

        private void FormGestionarEmpleados_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btAgregarEmpleado_Click(object sender, EventArgs e)
        {

            if (txtAMEmpleado.Text != string.Empty && txtAMEmpleado.Text != string.Empty && txtAPEmpleado.Text != string.Empty && txtCalleEmpleado.Text != string.Empty
                && txtColoniaEMpleado.Text != string.Empty && txtEdadEmpleado.Text != string.Empty && txTelEmpleado.Text != string.Empty && txtNPEmpleado.Text != string.Empty && txtNombreEmpleado.Text != String.Empty)
            {
                Return_var();
                btGuardarEmpleado.Visible = true;
                btCancelarEmpleado.Visible = true;
                opc = 1;
                cmd = new SqlCommand("Select indent_currrent('Empleado');", new Conexion().con);
                // txtID_Empleado.Text = Convert.ToString(Convert.ToInt32(cmd.ExecuteScalar()) + 1);
                txtID_Empleado.ReadOnly = false;
                entrar = true;
                
            }
            else
            {
                MessageBox.Show("Existe un campo sin información");
            }


        }

        private void btAgregarEmpleado_MouseHover(object sender, EventArgs e)
        {
            btAgregarEmpleado.BackgroundImage = Resources.botonAgregar2;
        }

        private void btAgregarEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btAgregarEmpleado.BackgroundImage = Resources.botonAgregar3;
        }

        private void btAgregarEmpleado_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            btModificarEmpleado.BackgroundImage = Resources.botonModificar3;
        }

        private void btModificarEmpleado_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btModificarEmpleado_MouseHover(object sender, EventArgs e)
        {
            btModificarEmpleado.BackgroundImage = Resources.botonModificar2;
        }

        private void btModificarEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btModificarEmpleado.BackgroundImage = Resources.botonModificar;
        }

        private void btEliminarEmpleado_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btEliminarEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btEliminarEmpleado.BackgroundImage = Resources.botonAliminar;
        }

        private void btEliminarEmpleado_MouseHover(object sender, EventArgs e)
        {
            btEliminarEmpleado.BackgroundImage = Resources.botonAliminar2;
        }

        private void btBurcarEmpleado_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btBurcarEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btBurcarEmpleado.BackgroundImage = Resources.botonBuscar;
        }

        private void btBurcarEmpleado_MouseHover(object sender, EventArgs e)
        {
            btBurcarEmpleado.BackgroundImage = Resources.botonBuscar2;
        }

        private void btGuardarEmpleado_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btGuardarEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btGuardarEmpleado.BackgroundImage = Resources.Guardar;
        }

        private void btGuardarEmpleado_MouseHover(object sender, EventArgs e)
        {
            btGuardarEmpleado.BackgroundImage = Resources.Guardar2;
        }

        private void btCancelarEmpleado_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btCancelarEmpleado_MouseHover(object sender, EventArgs e)
        {
            btCancelarEmpleado.BackgroundImage = Resources.Cancelar21;
        }

        private void btCancelarEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btCancelarEmpleado.BackgroundImage = Resources.Cancelar3;
        }

        private void FormGestionarEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (txtAMEmpleado.Text != string.Empty && txtAMEmpleado.Text != string.Empty && txtAPEmpleado.Text != string.Empty && txtCalleEmpleado.Text != string.Empty
                && txtColoniaEMpleado.Text != string.Empty && txtEdadEmpleado.Text != string.Empty && txTelEmpleado.Text != string.Empty && txtNPEmpleado.Text != string.Empty && txtNombreEmpleado.Text != String.Empty)
            {
                btCancelarEmpleado.Visible = true;
                btGuardarEmpleado.Visible = true;
                entrar = false;
                opc = 3;
            }
            else
            {
                MessageBox.Show("Tienes que contultar");
            }



        }

        private void Eliminar(string idEmpleado)
        {
            DialogResult result = MessageBox.Show("Se eliminara: " + txtNombreEmpleado.Text, "¡Atencion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                SqlCommand consulta2 = new SqlCommand("exec eliminarEmpleado " + idEmpleado, new Conexion().con);

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

        private void btBurcarEmpleado_Click(object sender, EventArgs e)
        {
            if (txtAMEmpleado.Text != string.Empty && txtAMEmpleado.Text != string.Empty && txtAPEmpleado.Text != string.Empty && txtCalleEmpleado.Text != string.Empty
                && txtColoniaEMpleado.Text != string.Empty && txtEdadEmpleado.Text != string.Empty && txTelEmpleado.Text != string.Empty && txtNPEmpleado.Text != string.Empty && txtNombreEmpleado.Text != String.Empty)
            {
                MessageBox.Show("Error, Los campos tienen que estar en limpios");
                btCancelarEmpleado.Visible = true;
            }
            else
            {
                btGuardarEmpleado.Visible = false;
                btCancelarEmpleado.Visible = true;
                txtID_Empleado.Enabled = true;
                acces = true;
                txtID_Empleado.Focus();
                Enabled_False();
                Return_var();
            }

        }

        public void Limpiar()
        {
            txtAMEmpleado.Text = string.Empty;
            txtAPEmpleado.Text = string.Empty;
            txtCalleEmpleado.Text = string.Empty;
            txtColoniaEMpleado.Text = string.Empty;
            txtEdadEmpleado.Text = string.Empty;
            txTelEmpleado.Text = string.Empty;
            txtID_Empleado.Text = string.Empty;
            txtNombreEmpleado.Text = string.Empty;
            txtNPEmpleado.Text = string.Empty;
        }
        private void lim()
        {
            txtAMEmpleado.Text = string.Empty;
            txtAPEmpleado.Text = string.Empty;
            txtCalleEmpleado.Text = string.Empty;
            txtColoniaEMpleado.Text = string.Empty;
            txtEdadEmpleado.Text = string.Empty;
            txTelEmpleado.Text = string.Empty;
            txtNombreEmpleado.Text = string.Empty;
            txtNPEmpleado.Text = string.Empty;

        }

        public void Enabled_True()
        {
            txtAMEmpleado.Enabled = true;
            txtAPEmpleado.Enabled = true;
            txtCalleEmpleado.Enabled = true;
            txtColoniaEMpleado.Enabled = true;
            txtEdadEmpleado.Enabled = true;
            txTelEmpleado.Enabled = true;
            txtNPEmpleado.Enabled = true;
            dTPFecIng.Enabled = true;
        }

        public void Enabled_False()
        {
            txtAMEmpleado.Enabled = false;
            txtAPEmpleado.Enabled = false;
            txtCalleEmpleado.Enabled = false;
            txtColoniaEMpleado.Enabled = false;
            txtEdadEmpleado.Enabled = false;
            txTelEmpleado.Enabled = false;
            txtNPEmpleado.Enabled = false;
            dTPFecIng.Enabled = false;
        }

        private void label11_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void label11_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = false;
        }

        private void btModificarEmpleado_Click(object sender, EventArgs e)
        {

            if (txtAMEmpleado.Text != string.Empty && txtAMEmpleado.Text != string.Empty && txtAPEmpleado.Text != string.Empty && txtCalleEmpleado.Text != string.Empty
                && txtColoniaEMpleado.Text != string.Empty && txtEdadEmpleado.Text != string.Empty && txTelEmpleado.Text != string.Empty && txtID_Empleado.
                Text != string.Empty && txtNPEmpleado.Text != string.Empty && txtNombreEmpleado.Text != String.Empty)
            {
                btCancelarEmpleado.Visible = true;
                btGuardarEmpleado.Visible = true;
                txtID_Empleado.Enabled = false;
                opc = 2;
                txtID_Empleado.Focus();
                Enabled_True();
                entrar = true;
                acces = false;
            }
            else
            {
                MessageBox.Show("Tienes que consultar");
            }
        }

        private void Modificar()
        {
            try
            {
                cmd = new SqlCommand("Execute actualizarEmpleado  " + txtID_Empleado.Text + ",'" + txtCalleEmpleado.Text + "','" + txtColoniaEMpleado.Text + "', " + txtNPEmpleado.Text + ",'" + txtNombreEmpleado.Text + "','" +
                txtAPEmpleado.Text + "','" + txtAMEmpleado.Text + "'," + txtEdadEmpleado.Text + ",'" + dTPFecIng.Value.ToString("dd/MM/yy") + "'," + txTelEmpleado.Text, new Conexion().con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se actualizo el empleado");
                opc = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se actualizo el empleado", ex.Message);

            }
        }

        private void btGuardarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                switch (opc)
                {
                    case 1:
                        {
                            Agregar();

                        }
                        break;

                    case 2:
                        {
                            Modificar();

                        }
                        break;

                    case 3:
                        {
                            if (txtID_Empleado.Text != string.Empty)
                            {

                                Eliminar(txtID_Empleado.Text);
                            }

                        }
                        break;

                }
                acces = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);

            }
        }

        private void Agregar()
        {
            try
            {
                cmd = new SqlCommand("Execute insertarEmpleado '" + txtCalleEmpleado.Text + "','" + txtColoniaEMpleado.Text + "', '" + txtNPEmpleado.Text + "','" + txtNombreEmpleado.Text + "','" + txtAPEmpleado.Text + "','" + txtAMEmpleado.Text + "'," +
                txtEdadEmpleado.Text + ",'" + dTPFecIng.Value.ToString("dd/MM/yy") + "'," + txTelEmpleado.Text, new Conexion().con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Se agrego correctemente el empleado");
                opc = 1;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtNPEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {

            val.numeros(e);

        }

        private void txtNPEmpleado_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtEdadEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);

        }

        private void txTelEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void txtID_Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);

        }

        private void txtNombreEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {

            // val.NameOfPerson(txtNombreEmpleado.Text,e);
        

        }

        private void txtAPEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAMEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtColoniaEMpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Letras(e);
        }

        private void txtCalleEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Letras(e);
        }

        private void txtEdadEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtEdadEmpleado.Text))
            {
                int edad = Convert.ToInt32(txtEdadEmpleado.Text);
                if (edad > 0 && edad <=100)
                {

                }
                else
                {
                    txtEdadEmpleado.Text = string.Empty;
                }
            }


        }

        private void txtNombreEmpleado_TextChanged_1(object sender, EventArgs e)
        {
            if (txtNombreEmpleado.Text==String.Empty && acces)
            {
                Limpiar();
            }
            else
            {
                if (txtNombreEmpleado.SelectedIndex != -1)
                {
                    txtNombreEmpleado.SelectedIndex = txtNombreEmpleado.SelectedIndex;
                }

            }
            
            

        }

        private void txtNombreEmpleado_TextUpdate(object sender, EventArgs e)
        {
           if (!string.IsNullOrEmpty(txtNombreEmpleado.Text) && this.txtNombreEmpleado.Focused && acces)
            {
                try
                {
                    da = new SqlDataAdapter("exec buscarNombre3 '" + txtNombreEmpleado.Text +"'", new Conexion().con);
                    dt = new DataTable();
                    da.Fill(dt);
                    txtNombreEmpleado.Items.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        foreach (DataColumn dc in dt.Columns)
                        {
                            txtNombreEmpleado.Items.Add(dr[dc.ColumnName].ToString());
                        }
                    }
                    txtNombreEmpleado.DroppedDown = true;
                    txtNombreEmpleado.SelectAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al consultar");
                }
            }
        }

        private void txtNombreEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txtNombreEmpleado.Focused && acces)
            {
                try
                {
                    cmd = new SqlCommand("exec buscarNombreEmpleado '" + txtNombreEmpleado.Text + "'", new Conexion().con);
                    SqlDataReader consu1 = cmd.ExecuteReader();
                    if (consu1.Read() == true)
                    {
                        txTelEmpleado.Text = consu1["Telefono_E"].ToString();
                        txtEdadEmpleado.Text = consu1["Edad"].ToString();
                        txtCalleEmpleado.Text = consu1["Calle_E"].ToString();
                        txtColoniaEMpleado.Text = consu1["Colonia_E"].ToString();
                        txtNPEmpleado.Text = consu1["Numero_E"].ToString();
                        txtAMEmpleado.Text = consu1["AM_E"].ToString();
                        txtAPEmpleado.Text = consu1["AP_E"].ToString();
                        txtNombreEmpleado.Text = consu1["Nombre_EM"].ToString();
                        dTPFecIng.Text = consu1["Fecha_ingreso"].ToString();
                        txtID_Empleado.Text = consu1["id_empleado"].ToString();
                    }
                    consu1.Close();
                    txtNombreEmpleado.SelectAll();
                }
                catch (Exception ex)
                {
                  MessageBox.Show(ex.Message);
                }
            }
            
        }

        public void BColonia(int cp)
        {
            cmd = new SqlCommand("exec BuscarCP " +cp ,new Conexion().con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtColoniaEMpleado.ValueMember = "asentamiento";
            txtColoniaEMpleado.DataSource = dt;

        }

        public void BEstado(int cp, string asentamiento)
        {
            cmd = new SqlCommand("exec BuscarUCP '" +cp+"','"+ asentamiento+"'", new Conexion().con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtCalleEmpleado.ValueMember = "estado";
            txtCalleEmpleado.DataSource = dt;
        }
        
        private void txtNPEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNPEmpleado_TextChanged_1(object sender, EventArgs e)
        {
            

        }

        private void txtNPEmpleado_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
           
        }

        private void txtNPEmpleado_TextUpdate(object sender, EventArgs e)
        {
           
        }

        private void txtNPEmpleado_TextChanged_2(object sender, EventArgs e)
        {
            try
            {
                if (entrar == true)
                { 
                    if (txtNPEmpleado.Text != null)
                    {
                        int cp = Convert.ToInt32(txtNPEmpleado.Text);
                        BColonia(cp);

                    }
                    
                    
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void txtColoniaEMpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (entrar== true)
            {
                if (txtColoniaEMpleado.SelectedValue.ToString() != null)
                {
                    int cp = Convert.ToInt32(txtNPEmpleado.Text);
                    string asentamiento = txtColoniaEMpleado.Text;
                    BEstado(cp, asentamiento);

                }
            }
            
           
        }

        private void txtNombreEmpleado_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtAPEmpleado_TextChanged(object sender, EventArgs e)
        {
           
        }
        public void  Return_var()
        {
            minu = false; espa = true; punto = false;
        }
       
        private void txtNombreEmpleado_TextChanged(object sender, EventArgs e)
        {




        }

        private void txtID_Empleado_TextChanged(object sender, EventArgs e)
        {   
                String id = txtID_Empleado.Text;
            if (txtID_Empleado.Text == String.Empty)
            {
                lim();
            }
            else
            {
                if (!string.IsNullOrEmpty(txtID_Empleado.Text) && txtID_Empleado.Focused)
                {
                    int num = Convert.ToInt32(id);
                    try
                    {
                        cmd = new SqlCommand("exec consultarEmpleado " + num, new Conexion().con);
                        SqlDataReader consu = cmd.ExecuteReader();
                        if (consu.Read() == true)
                        {
                            txTelEmpleado.Text = consu["Telefono_E"].ToString();
                            txtEdadEmpleado.Text = consu["Edad"].ToString();
                            txtCalleEmpleado.Text = consu["Calle_E"].ToString();
                            txtColoniaEMpleado.Text = consu["Colonia_E"].ToString();
                            txtNPEmpleado.Text = consu["Numero_E"].ToString();
                            txtAMEmpleado.Text = consu["AM_E"].ToString();
                            txtAPEmpleado.Text = consu["AP_E"].ToString();
                            txtNombreEmpleado.Text = consu["Nombre_EM"].ToString();
                            dTPFecIng.Text = consu["Fecha_ingreso"].ToString();
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

        private void btCancelarEmpleado_Click(object sender, EventArgs e)
        {
            Limpiar();
            btGuardarEmpleado.Visible = false;
            btCancelarEmpleado.Visible = false;
            txtID_Empleado.Enabled = false;
            acces = false;
            Enabled_True();
            Return_var();
        }

        private void label11_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = true;
            MValX = e.X;
            MValY = e.Y;
        }
    }
}
