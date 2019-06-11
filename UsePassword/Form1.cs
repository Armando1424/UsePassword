using System;
using System.Windows.Forms;
using UsePassword.Properties;

namespace UsePassword
{
    public partial class Form1 : Form
    {
        int MValX, MValY;
        bool TogMove;
        private Validar val = new Validar();
        Conexion con = new Conexion();
        private string path;
        private string[] vsLogin;

        enum loginWith
        {
            ADMINISTRADOR, EMPLEADO
        }

        public Form1()
        {
            InitializeComponent();
            path = con.CreateDirectoryMyDocuments("BimyouMeraki");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btEntrar_MouseHover(object sender, EventArgs e)
        {
            btEntrar.BackgroundImage = Resources.Sin_título_3;
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            con.CloseCon();
            if (!string.IsNullOrEmpty(txtUsuario.Text))
            {
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    if (!string.IsNullOrEmpty(txtServer.Text))
                    {
                        if (Cmb.SelectedIndex != -1)
                        {
                            if (con.CanCreateOrExist(ProggressConection,txtServer.Text, "BimyouMeraki", path, Resources.script))
                            {
                                if (con.MyServerManual)
                                {
                                    con.CreateFile(path, "SysWin32.bym", txtServer.Text);
                                    con.Myserv = txtServer.Text;
                                }

                                if (con.OpenWithWindows(txtServer.Text, "BimyouMeraki"))
                                {
                                    if (Cmb.SelectedIndex == (int)loginWith.ADMINISTRADOR)
                                    {
                                        if (vsLogin[0].Equals(txtUsuario.Text))
                                        {
                                            if (vsLogin[1].Equals(txtPassword.Text))
                                            {
                                                FormMenu men = new FormMenu();
                                                this.Visible = false;
                                                men.Show();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Contraseña incorrecta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Usuario incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else if (Cmb.SelectedIndex == (int)loginWith.EMPLEADO)
                                    {
                                        if (vsLogin[2].Equals(txtUsuario.Text))
                                        {
                                            if (vsLogin[3].Equals(txtPassword.Text))
                                            {
                                                FormMenuEmpleado MUE = new FormMenuEmpleado();
                                                this.Visible = false;
                                                MUE.Show();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Contraseña incorrecta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Usuario incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    txtServer.Visible = false;
                                    label1.Visible = false;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Selecciona una opción: ADMINISTRADOR O EMPLEADO", "Algo paso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingresa un servidor", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Ingresa la cotranseña", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingresa un usuario", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btSalirSesion_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Hasta pronto","Adios",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            Application.Exit();
        }

        private void btEntrar_MouseLeave(object sender, EventArgs e)
        {
            btEntrar.BackgroundImage = Resources.Puerta;

        }

        private void btSalirSesion_MouseLeave(object sender, EventArgs e)
        {
            btSalirSesion.BackgroundImage = Resources.sal;
        }

        private void btSalirSesion_MouseHover(object sender, EventArgs e)
        {
            btSalirSesion.BackgroundImage = Resources.sal2;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Letras(e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Letras(e);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

            vsLogin = con.SavePass(path, "SQLServer2018.bym", "ADMINISTRADOR,administrador,EMPLEADO,empleado");
            con.SearchServer(ProggressConection, txtServer, label1, btEntrar, path, "SysWin32.bym", "master");
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
