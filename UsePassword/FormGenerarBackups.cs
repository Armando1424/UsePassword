using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UsePassword
{
    public partial class FormGenerarBackups : Form
    {
        int MValX, MValY;
        bool TogMove;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog1;
        private Conexion con = new Conexion();

        public FormGenerarBackups()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormMenu fom = new FormMenu();
            fom.Show();
            this.Close();
        }

        private void FormGenerarBackups_Load(object sender, EventArgs e)
        {

        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void label5_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = false;
        }

        private void btnSaveBack_Click(object sender, EventArgs e)
        {           
            folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog1.Description = "** Selecciona una carpeta **";

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lblRouteBack.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnSaveRes_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.DefaultExt = "bak";
            openFileDialog1.Filter = "bak files (*.bak)|*.bak";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblRouteRes.Text = openFileDialog1.FileName;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {

            try
            {
                if (!txtName.Text.Equals(string.Empty))
                {
                    lblRouteBack.Text = lblRouteBack.Text + @"\" + txtName.Text + ".bak";
                    cmd = new SqlCommand(@"exec BackUpDB '" + lblRouteBack.Text + "'", new Conexion().con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se respaldo correctamente la base de datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Ingrese un nombre para el archivo", "Algo fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (!lblRouteRes.Text.Equals("Ruta"))
            {
                try
                {
                    con.CloseCon();
                    con.OpenWithWindows(con.Myserv,"master");
                    cmd = new SqlCommand("exec RestoreDB '" + lblRouteRes.Text + "'", new Conexion().con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se restauro correctamente la base de datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.OpenWithWindows(con.Myserv, "BimyouMeraki");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No has selecionado nigun archivo","Algo fallo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = true;
            MValX = e.X;
            MValY = e.Y;
        }
    }
}
