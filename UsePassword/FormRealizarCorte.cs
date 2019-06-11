using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace UsePassword
{
    public partial class FormRealizarCorte : Form
    {
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;

        int MValX, MValY;
        bool TogMove;

        public FormRealizarCorte()
        {
            InitializeComponent();
               textBox12.Enabled = false;
            textBox13.Enabled = false;

        }

        public void numeros(KeyPressEventArgs e)
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
                MessageBox.Show(ex.Message);
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            FormMenuEmpleado MEM = new FormMenuEmpleado();
            MEM.Show();
            this.Close();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.RootFolder = Environment.SpecialFolder.Desktop;
            folder.Description = "** Selecciona una carpeta **";

            if (folder.ShowDialog() == DialogResult.OK)
            {
                DateTime fecha = DateTime.Now;

                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(folder.SelectedPath + "\\REPOR.pdf", FileMode.Create));
                doc.Open();
                Paragraph para = new Paragraph("                                                                                                Corte del dia: " + fecha + "\n\n                                                                       BYMYOUMERAKY\n\n                     \n\n  Acontinuacion se precenta la cantidad de dinero                     \n\n  Vendida durante el día.                \n\n    \n\n    TOTAL DE EFECTIVO ACUMULADO: " + textBox13.Text);
                doc.Add(para);
                doc.Close();
                MessageBox.Show("Reporte generado corectamente","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty
               && textBox4.Text != string.Empty && textBox5.Text != string.Empty && textBox6.Text != string.Empty &&
               textBox7.Text != string.Empty && textBox8.Text != string.Empty && textBox9.Text != string.Empty && textBox10.Text != string.Empty
               && textBox11.Text != string.Empty && textBox15.Text != string.Empty && textBox16.Text != string.Empty && textBox17.Text != string.Empty)
            {
                double a = 0, b = 0;
                try
                {
                    a = 500 * (Convert.ToDouble(textBox1.Text));
                    a = a + (200 * (Convert.ToDouble(textBox2.Text)));
                    a = a + (100 * (Convert.ToDouble(textBox3.Text)));
                    a = a + (50 * (Convert.ToDouble(textBox4.Text)));
                    a = a + (20 * (Convert.ToDouble(textBox5.Text)));
                    a = a + (100 * (Convert.ToDouble(textBox6.Text)));
                    a = a + (50 * (Convert.ToDouble(textBox7.Text)));
                    a = a + (10 * (Convert.ToDouble(textBox8.Text)));
                    a = a + (5 * (Convert.ToDouble(textBox9.Text)));
                    a = a + (2 * (Convert.ToDouble(textBox10.Text)));
                    a = a + (Convert.ToDouble(textBox11.Text));
                    a = a + (0.5 * (Convert.ToDouble(textBox15.Text)));
                    a = a + (0.2 * (Convert.ToDouble(textBox16.Text)));
                    a = a + (0.1 * (Convert.ToDouble(textBox17.Text)));
                    try
                    {
                        cmd = new SqlCommand("select sum(Total_venta) from Venta where Fecha_vent = convert(varchar(20),getdate(),103);", new Conexion().con);
                        textBox12.Text = Convert.ToString((Convert.ToInt32(cmd.ExecuteScalar())));

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    b = Convert.ToDouble(textBox12.Text);
                    a = b - a;
                    textBox13.Text = ("" + a);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese valores", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No deves de dejar espacios en blanco sino ubo nada coloca sero");
            }   
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(e);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(e);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(e);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(e);
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(e);
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(e);
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            numeros(e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = false;
        }
    }
}