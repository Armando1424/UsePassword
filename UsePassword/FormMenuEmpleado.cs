using System;
using System.Windows.Forms;
using UsePassword.Properties;

namespace UsePassword
{
    public partial class FormMenuEmpleado : Form
    {
        int MValX, MValY;
        bool TogMove;

        public FormMenuEmpleado()
        {
            InitializeComponent();            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormGestionarClientess GCL = new FormGestionarClientess();
            GCL.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Close();
            
            
        }

        private void FormMenuEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btRealizarVenta_Click(object sender, EventArgs e)
        {
            Form2 Rv = new Form2();
            Rv.Show();
            this.Close();
        }

        private void BtRealizarConsulta_Click(object sender, EventArgs e)
        {
            FormRealizarConsultas consulta = new FormRealizarConsultas();
            consulta.ban = 2;
            FormRealizarConsultas Rc = new FormRealizarConsultas();
            Rc.Show();
        }

        private void BtRegistrarCompra_Click(object sender, EventArgs e)
        {
            FormRegistrarCompra RComp = new FormRegistrarCompra();
            RComp.Show();
            this.Close();
        }

        private void BtRealizarCorte_Click(object sender, EventArgs e)
        {
            FormRealizarCorte RCOR = new FormRealizarCorte();
            RCOR.Show();
            this.Close();
        }

        private void btRealizarVenta_MouseMove(object sender, MouseEventArgs e)
        {
            btRealizarVenta.BackgroundImage = Resources.RealizarVenta2;
        }

        private void btRealizarVenta_MouseLeave(object sender, EventArgs e)
        {
            btRealizarVenta.BackgroundImage = Resources.RealizarVenta;
        }

        private void BtRealizarConsulta_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void BtRealizarConsulta_MouseHover(object sender, EventArgs e)
        {
            BtRealizarConsulta.BackgroundImage = Resources.RealizarConsulta2;
        }

        private void BtRealizarConsulta_MouseLeave(object sender, EventArgs e)
        {
            BtRealizarConsulta.BackgroundImage = Resources.RealizarConsulta;
        }

        private void BtRegistrarCompra_MouseHover(object sender, EventArgs e)
        {
            BtRegistrarCompra.BackgroundImage = Resources.RealizarCompra2;
        }

        private void BtRegistrarCompra_MouseLeave(object sender, EventArgs e)
        {
            BtRegistrarCompra.BackgroundImage = Resources.RealizarCompra;
        }

        private void BtRealizarCorte_MouseHover(object sender, EventArgs e)
        {
            BtRealizarCorte.BackgroundImage = Resources.RealizarCorte2;
        }

        private void BtRealizarCorte_MouseLeave(object sender, EventArgs e)
        {
            BtRealizarCorte.BackgroundImage = Resources.RealizarCorte;
        }

        private void BtGestionarClientesE_MouseHover(object sender, EventArgs e)
        {
            BtGestionarClientesE.BackgroundImage = Resources.RealizarCliente2;
        }

        private void BtGestionarClientesE_MouseLeave(object sender, EventArgs e)
        {
            BtGestionarClientesE.BackgroundImage = Resources.RealizarCliente;
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
    }
}
