using System;
using System.Windows.Forms;
using UsePassword.Properties;

namespace UsePassword
{
    public partial class FormMenu : Form
    {
        int MValX, MValY;
        bool TogMove;

        public FormMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            FormGestionarEmpleados GE = new FormGestionarEmpleados();
            GE.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormGestionarProveedores GP = new FormGestionarProveedores();
            GP.Show();
            this.Close();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormGestionarClientes GC = new FormGestionarClientes();
            GC.Show();
            this.Close();
        }

        private void btCerrarMenu_Click(object sender, EventArgs e)
        {
            new Conexion().CloseCon();
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void btGenerarBackups_Click(object sender, EventArgs e)
        {
            FormGenerarBackups BK = new FormGenerarBackups();
            BK.Show();
            this.Close();
           
        }

        private void btObtenerReportes_Click(object sender, EventArgs e)
        {
            FormObtenerReportes OR = new FormObtenerReportes();
            OR.Show();
            this.Close();
        }

        private void btGestionarInventarios_Click(object sender, EventArgs e)
        {
            FormGestionarInventarios GI = new FormGestionarInventarios();
            GI.Show();
            this.Close();
        }

        private void btGenerarBackups_MouseClick(object sender, MouseEventArgs e)
        {
            btGenerarBackups.BackgroundImage = Resources.botonGBackups3;
        }

        private void btGenerarBackups_MouseHover(object sender, EventArgs e)
        {
            btGenerarBackups.BackgroundImage = Resources.botonGBackups2;
        }

        private void btGenerarBackups_MouseLeave(object sender, EventArgs e)
        {
            btGenerarBackups.BackgroundImage = Resources.botonGBackups;
        }

        private void btGestionarEmpleados_MouseHover(object sender, EventArgs e)
        {
            btGestionarEmpleados.BackgroundImage = Resources.botonGEmpleados2;
        }

        private void btGestionarEmpleados_MouseLeave(object sender, EventArgs e)
        {
            btGestionarEmpleados.BackgroundImage = Resources.botonGEmpleados;
        }

        private void btGestionarClientes_MouseHover(object sender, EventArgs e)
        {
            btGestionarClientes.BackgroundImage = Resources.Cliente22;
        }

        private void btGestionarClientes_MouseLeave(object sender, EventArgs e)
        {
            btGestionarClientes.BackgroundImage = Resources.Cliente2;
        }

        private void btGestionarProveedores_MouseMove(object sender, MouseEventArgs e)
        {
            btGestionarProveedores.BackgroundImage = Resources.botonProveedor2;
        }

        private void btGestionarProveedores_MouseLeave(object sender, EventArgs e)
        {
            btGestionarProveedores.BackgroundImage = Resources.botonProveedor;
        }

        private void btObtenerReportes_MouseLeave(object sender, EventArgs e)
        {
            btObtenerReportes.BackgroundImage = Resources.botonObtenerReportes;
        }

        private void btObtenerReportes_MouseHover(object sender, EventArgs e)
        {
            btObtenerReportes.BackgroundImage = Resources.botonObtenerReportes2;
        }

        private void btGestionarInventarios_MouseHover(object sender, EventArgs e)
        {
            btGestionarInventarios.BackgroundImage = Resources.BotonInventarios2;
        }

        private void btGestionarInventarios_MouseLeave(object sender, EventArgs e)
        {
            btGestionarInventarios.BackgroundImage = Resources.BotonInventarios;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void label7_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = false;
        }
    }
}
