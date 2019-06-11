using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace UsePassword
{
    public partial class FormGestionarInventarios : Form
    {
        int MValX, MValY, donde = 0;
        bool TogMove, acces = false;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        Validar val = new Validar();

        public FormGestionarInventarios()
        {
            InitializeComponent();         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormMenu mn = new FormMenu();
            mn.Show();
            this.Close();
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //cmd = new SqlCommand("SELECT IDENT_CURRENT ('Producto');", new Conexion().con);
                //txtID.Text = Convert.ToString(Convert.ToInt32(cmd.ExecuteScalar()));
                if (NoEmpty())
                {
                    btnCancel.Visible = true;
                    btnSave.Visible = true;
                    txtID.Enabled = true;
                    cbName.Enabled = true;
                    SoloLeer(false);
                    donde = 1;
                    cbName.Focus();
                }
                else
                {
                    MessageBox.Show("Existe un campo sin información");
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void Add()
        {
            try
            {
                if (Convert.ToInt32(txtStokMax.Text) > Convert.ToInt32(txtStokMin.Text))
                {
                    cmd = new SqlCommand("exec insertarProducto " + txtID.Text + ",'" + cbName.Text + "','" + cbType.Text + "'," + txtStokMax.Text + "," + txtStokMin.Text + "," + txtID_Pro.Text, new Conexion().con);
                    cmd.ExecuteNonQuery();
                    btnCancel_Click(new object(), new EventArgs());
                    MessageBox.Show("Se agrego correctemente el Producto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    donde = 1;
                }
                else
                {
                    MessageBox.Show("El stok Maximo debe ser mas grande que el stock Minimo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"No se agrego al inventario");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (NoEmpty())
            {
                SoloLeer(false);
                cbName.Enabled = true;
                txtID.Enabled = false;
                btnSave.Visible = true;
                btnCancel.Visible = true;
                donde = 2;
                btnSave.Focus();
            }
            else
            {
                MessageBox.Show("Tienes que consultar");
            }
        }

        private void MyUpdate()
        {
            try
            {
                cmd = new SqlCommand("exec actualizarProducto " + txtID.Text + ",'" + cbName.Text + "','" + cbType.Text + "'," + txtStokMax.Text + "," + txtStokMin.Text + "," + txtID_Pro.Text, new Conexion().con);
                cmd.ExecuteNonQuery();
                btnCancel_Click(new object(), new EventArgs());
                MessageBox.Show("Se Actualizo correctemente el Producto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se actualizo el inventario");
            }
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            if (NoEmpty())
            {
                MessageBox.Show("Error, Los campos tienen que estar en limpios");
                btnCancel.Visible = true;
            }
            else
            {
                btnSave.Visible = false;
                btnCancel.Visible = true;
                txtID.Enabled = true;
                cbName.Enabled = true;
                acces = true;
                SoloLeer(true);
                btnCancel.Focus();
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (NoEmpty())
            {
                SoloLeer(true);
                cbName.Enabled = false;
                txtID.Enabled = false;
                btnCancel.Visible = true;
                btnSave.Visible = true;
                donde = 3;
                btnSave.Focus();
            }
            else
            {
                MessageBox.Show("Tienes que contultar");
            }
        }

        private void Delete()
        {
            try
            {
                DialogResult result = MessageBox.Show("Se eliminara: " + cbName.Text, "¡Atencion!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    SqlCommand cmd = new SqlCommand("exec eliminarProducto " + txtID.Text, new Conexion().con);
                    cmd.ExecuteNonQuery();
                    btnCancel_Click(new object(), new EventArgs());
                    MessageBox.Show("Registro eliminado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"No se elimino del inventario");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (donde)
            {
                case 1:
                    Add();
                    break;
                case 2:
                    MyUpdate();
                    break;
                case 3:
                    Delete();
                    break;
                default:
                    MessageBox.Show("No se encontro registro","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    break;                    
            }
            txtID_Pro.Focus();
            acces = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            btnCancel.Visible = false;
            txtID.Enabled = true;
            cbName.Enabled = true;
            acces = false;
            txtID_Pro.Focus();
            SoloLeer(false);
            Limpiar();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) && this.txtID.Focused && acces)
            {
                Limpiar();
            }
            else
            {
                if (!string.IsNullOrEmpty(txtID.Text) && this.txtID.Focused && acces)
                {
                    try
                    {
                        cmd = new SqlCommand("exec consultarProducto " + txtID.Text, new Conexion().con);

                        SqlDataReader consu = cmd.ExecuteReader();
                        if (consu.Read() == true)
                        {
                            txtID_Pro.Text = consu["id_proveedor"].ToString();
                            cbName.Text = consu["Nombre_P"].ToString();
                            cbType.Text = consu["Tipo_P"].ToString();
                            txtStokMax.Text = consu["StockMax"].ToString();
                            txtStokMin.Text = consu["StockMin"].ToString();
                        }
                        else
                        {
                            clearWithoutID();
                        }
                        consu.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error al consultar");
                    }
                }
            }
        }

        private void cbName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbName.Text) && this.cbName.Focused && acces)
            {
                Limpiar();
            }
            else
            {
                if (cbName.SelectedIndex != -1)
                {
                    cbName.SelectedIndex = cbName.SelectedIndex;
                }
            }
        }

        private void cbName_TextUpdate(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbName.Text) && this.cbName.Focused && acces)
            {
                try
                {
                    da = new SqlDataAdapter("exec consultarProductoByName '" + cbName.Text + "'", new Conexion().con);
                    dt = new DataTable();
                    da.Fill(dt);
                    cbName.Items.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        foreach (DataColumn dc in dt.Columns)
                        {
                            cbName.Items.Add(dr[dc.ColumnName].ToString());
                        }
                    }
                    cbName.DroppedDown = true;
                    cbName.Select(cbName.Text.Length, 0);
                    //cbName.SelectionStart = cbName.Text.Length;
                    //cbName.SelectAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al consultar");
                }
            }
        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbName.Focused && acces)
            {
                try
                {
                    cmd = new SqlCommand("exec consultAllProductByName '" + cbName.Text + "'", new Conexion().con);

                    SqlDataReader consu1 = cmd.ExecuteReader();
                    if (consu1.Read() == true)
                    {
                        txtID.Text = consu1["id_producto"].ToString();
                        txtID_Pro.Text = consu1["id_proveedor"].ToString();
                        cbType.Text = consu1["Tipo_P"].ToString();
                        txtStokMax.Text = consu1["StockMax"].ToString();
                        txtStokMin.Text = consu1["StockMin"].ToString();
                    }
                    else
                    {
                        clearWithoutName();
                    }
                    consu1.Close();
                    cbName.Select(cbName.Text.Length, 0);
                    //cbName.SelectAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al consultar");
                }
            }
        }

        private void label4_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = false;
        }

        public void Limpiar()
        {
            txtID.Text = string.Empty;
            cbName.Text = string.Empty;
            txtID_Pro.Text = string.Empty;            
            cbType.Text = string.Empty;
            txtStokMax.Text = string.Empty;
            txtStokMin.Text = string.Empty;
        }

        public void clearWithoutID()
        {
            cbName.Text = string.Empty;
            txtID_Pro.Text = string.Empty;
            cbType.Text = string.Empty;
            txtStokMax.Text = string.Empty;
            txtStokMin.Text = string.Empty;
        }

        public void clearWithoutName()
        {
            txtID.Text = string.Empty;
            txtID_Pro.Text = string.Empty;
            cbType.Text = string.Empty;
            txtStokMax.Text = string.Empty;
            txtStokMin.Text = string.Empty;
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void txtType_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Letras(e);
        }

        private void cbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.NumbersAndLetters(cbName.Text,e);
        }

        private void cbType_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("exec consultTypesOfProduct '" + cbType.Text + "'", new Conexion().con);
                dt = new DataTable();
                da.Fill(dt);
                cbType.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        cbType.Items.Add(dr[dc.ColumnName].ToString());
                    }
                }
                cbType.DroppedDown = true;
                cbType.Select(cbType.Text.Length, 0);
                //cbType.SelectionStart = cbName.Text.Length;
                //cbType.SelectionLength = cbName.Text.Length;
                //cbType.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al consultar");
            }
        }

        private void cbType_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Letras(e);
        }

        private void txtStokMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void txtStokMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        private void txtID_Pro_KeyPress_1(object sender, KeyPressEventArgs e)
        {
        }

        private void txtID_Pro_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
        }

        public void SoloLeer(bool ok)
        {
            txtID_Pro.ReadOnly = ok;
            txtStokMax.ReadOnly = ok;
            txtStokMin.ReadOnly = ok;
            cbType.Enabled = !ok;
        }

        public bool NoEmpty()
        {
            if ( !txtID.Text.Equals(string.Empty) && !txtID_Pro.Text.Equals(string.Empty) && !cbName.Text.Equals(string.Empty) && !cbType.Text.Equals(string.Empty) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
