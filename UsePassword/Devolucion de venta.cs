using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UsePassword
{
    public partial class Devolucion_de_venta : Form
    {

        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;

        public Devolucion_de_venta()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            FormMenuEmpleado MEM = new FormMenuEmpleado();
            MEM.Show();
            this.Close();
        }

        private void Devolucion_de_venta_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                this.Close();
                limpiar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            limpiar();
        }

        public void limpiar()
        {
            Folio.Text = "";
            Importe.Text = "";
            Total.Text = "";
            Cajero.Text = "";
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
