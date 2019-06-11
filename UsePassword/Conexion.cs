using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using UsePassword.Librerias;
using System.Net;
using UsePassword.Properties;
using System.Threading;

namespace UsePassword
{

    public class Conexion
    {
        private static SqlConnection connection = new SqlConnection();

        public SqlConnection con
        {
            get { return connection; }
            set { connection = value; }
        }

        private bool serverManual = false;

        public bool MyServerManual
        {
            get { return serverManual; }
            set { serverManual = value; }
        }

        private string serv;

        public string Myserv
        {
            get { return serv; }
            set { serv = value; }
        }


        public bool OpenWithWindows(string Server, string DataBase)
        {
            try
            {
                connection.ConnectionString = @"server = " + Server + "; database=" + DataBase + ";  integrated security= true";
                connection.Open();
                Console.WriteLine("Conexion a base de datos Exitosa");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LLama al Desarrollador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool testConnection(string Server, string DataBase)
        {
            try
            {
                connection.ConnectionString = @"server = " + Server + "; database=" + DataBase + ";  integrated security= true";
                connection.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool OpenWithSqlUser(string Server, string DataBase, string User, string Pass)
        {
            try
            {
                connection.ConnectionString = @"Persist Security Info=True;User ID=" + User + ";Password=" + Pass + ";Initial Catalog=" + DataBase + ";Server=" + Server;
                connection.Open();
                Console.WriteLine("Conexion a base de datos Exitosa");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LLama al Desarrollador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool CloseCon()
        {
            try
            {
                connection.Close();
                Console.WriteLine("Conexion a base de datos cerrada");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LLama al Desarrollador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void ExecuteConsole(string myServer, string file)
        {
            ProcessStartInfo cmd = new ProcessStartInfo("sqlcmd", @" -S " + myServer + " -i " + file);
            cmd.UseShellExecute = false;
            cmd.CreateNoWindow = true;
            cmd.RedirectStandardOutput = true;

            Process ejecutar = new Process();
            ejecutar.StartInfo = cmd;
            ejecutar.Start();
        }

        public void ExecuteQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        private bool test(ProgressBar ProggressConection, TextBox txtServer, Button btEntrar, string path, string nameWithExtention, string dataDaseName)
        {
            List<string> listServer = new List<string>();
            bool pato = false;
            listServer.Add(@".\SQLEXPRESS");
            listServer.Add(Dns.GetHostName() + @"\SQLEXPRESS");
            listServer.Add(Dns.GetHostName());
            listServer.Add(".");
            listServer.Add(@"VICIO-PC\VICIOXD");
            listServer.Add("localhost");
            listServer.Add(@"localhost\SQLEXPRESS");
            listServer.Add("(local)");
            listServer.Add(@"(local)\SQLEXPRESS");
            int inc = 100 / listServer.Count;
            ProggressConection.Visible = true;
            for (int i = 0; i < listServer.Count; i++)
            {
                ProggressConection.Value += inc;
                if (testConnection(listServer[i], dataDaseName))
                {
                    pato = true;
                    txtServer.Text = listServer[i];
                    string file1 = CreateFile(path, nameWithExtention, txtServer.Text);
                    ProggressConection.Value = 100;
                    ProggressConection.Visible = false;
                    btEntrar.Enabled = true;
                    CloseCon();
                    break;
                }
                else
                {
                    pato = false;
                }
            }
            return pato;
        }

        public void SearchServer(ProgressBar ProggressConection, TextBox txtServer, Label label1, Button btEntrar, string path, string nameWithExtention, string dataDaseName)
        {
            try
            {

                string file = path + @"\" + nameWithExtention;

                if (!File.Exists(file))
                {
                    if (!test(ProggressConection, txtServer, btEntrar,path, nameWithExtention, dataDaseName))
                    {
                        ProggressConection.Value = 100;
                        MessageBox.Show("Ingrese un servidor manualmente");
                        txtServer.Visible = true;
                        label1.Visible = true;
                        ProggressConection.Enabled = false;
                        ProggressConection.Visible = false;
                        btEntrar.Enabled = true;
                        serverManual = true;
                    }
                }
                else
                {
                    btEntrar.Enabled = true;
                    ProggressConection.Visible = false;
                    txtServer.Text = File.ReadAllText(file);
                    serv = File.ReadAllText(file);
                    if (string.IsNullOrEmpty(txtServer.Text))
                    {
                        serverManual = true;
                    }
                }
                if (!serverManual)
                {
                    CloseCon();
                    CanCreateOrExist(ProggressConection,txtServer.Text, "BimyouMeraki", path, Resources.script);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            
        }

        public string CreateFile(string path, string nameWithExtention, string text)
        {
            try
            {
                path += @"\" + nameWithExtention;
                File.WriteAllText(path, text);
                serverManual = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("The process failed: {0}", ex.ToString());
            }
            return path;
        }

        public string CreateDirectoryMyDocuments(string name)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += @"\"+name;
            // Determine whether the directory exists.
            if (!Directory.Exists(path))
            {
                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);

                // Delete the directory.
                //di.Delete();
            }
            return path;
        }

        public string[] SavePass(string path, string nameWithExtention, string text)
        {
            Cifrado x = new Cifrado();
            string[] vsLogin = { };
            string cadena;
            x.IniciarAES("LlaveSimetrica");
            string file2 = CreateFile(path, nameWithExtention, x.Cifrar(text));
            if (File.Exists(file2))
            {
                cadena = x.Decifrar(File.ReadAllText(file2));

                vsLogin = cadena.Split(',');
            }

            return vsLogin;
        }

        public bool CanCreateOrExist(ProgressBar ProggressConection, string server, string NameDataBase, string path, string query)
        {
            try
            {
                if (testConnection(server,"master"))
                {
                    CloseCon();
                    if (!testConnection(server, NameDataBase))
                    {
                        OpenWithWindows(server, "master");
                        string file = CreateFile(path,"temp.sql",query);
                        ExecuteConsole(server,file);
                        ProggressConection.Visible = true;
                        for (int i = 1; i <= 100; i++)
                        {
                            ProggressConection.Value = i;
                            Thread.Sleep(200);
                        }
                        ProggressConection.Visible = false;
                        File.Delete(file);
                    }
                    CloseCon();
                    return true;
                }
                else
                {
                    MessageBox.Show("El servidor no es valido para establecer una conexion", "Servidor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("The process failed: {0}", ex.ToString());
                return false;
            }
        }
    }
}
