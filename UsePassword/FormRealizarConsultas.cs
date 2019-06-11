using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UsePassword
{
    public partial class FormRealizarConsultas : Form
    {
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;
         public int index, ban=0;
        public string id_foraneo;
        int MValX, MValY;
        String codigo_consulta;
        bool TogMove;

        public FormRealizarConsultas()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            FormMenuEmpleado FM = new FormMenuEmpleado();
            FM.Show();
            this.Close();
        }

        private void FormRealizarConsultas_Load(object sender, EventArgs e)
        {
            String id = txtNombreProducto.Text;
            if (id != null && id.Length != 0)
            {
                if (ban == 1)
                {
                    try
                    {
                        da = new SqlDataAdapter("execute busquedaproductocompra " + id + ", " + id_foraneo, new Conexion().con);
                        dt = new DataTable();
                        da.Fill(dt);
                        consulta.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se encuentra resultado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                if (ban == 2) {
                    try
                    {
                        da = new SqlDataAdapter("execute busquedaproducto " + id, new Conexion().con);
                        dt = new DataTable();
                        da.Fill(dt);
                        consulta.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se encuentra resultado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                if (ban == 3)
                {
                    try
                    {
                        da = new SqlDataAdapter("execute busquedaproducto " + id, new Conexion().con);
                        dt = new DataTable();
                        da.Fill(dt);
                        consulta.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se encuentra resultado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            else
            {
                //dt.Clear();
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombreProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                
                    this.Close();               
            }
        }

        private void consulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0)
            {

            }
            else
            {
                if (ban == 1) {
                    index = e.RowIndex;
                    codigo_consulta = consulta.Rows[e.RowIndex].Cells[0].Value.ToString();                    
                    FormRegistrarCompra compra = Application.OpenForms.OfType<FormRegistrarCompra>().SingleOrDefault();
                    compra.txtmercancia.Text = codigo_consulta;
                    this.Close();

                }
                if (ban == 2) {
                    index = e.RowIndex;
                    codigo_consulta = consulta.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Form2 id = Application.OpenForms.OfType<Form2>().SingleOrDefault();
                    id.ID_Producto.Text = codigo_consulta;
                    this.Close();

                }
                
            }
        }

        private void consulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = false;
        }
    }
}
