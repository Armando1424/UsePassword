namespace UsePassword
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.ProggressConection = new System.Windows.Forms.ProgressBar();
            this.btEntrar = new System.Windows.Forms.Button();
            this.btSalirSesion = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Cmb = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::UsePassword.Properties.Resources.EntrarL;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtServer);
            this.panel1.Controls.Add(this.ProggressConection);
            this.panel1.Controls.Add(this.btEntrar);
            this.panel1.Controls.Add(this.btSalirSesion);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.Cmb);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 168);
            this.panel1.TabIndex = 0;
            this.panel1.VisibleChanged += new System.EventHandler(this.btSalirSesion_MouseHover);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Servidor";
            this.label1.Visible = false;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(94, 138);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(129, 20);
            this.txtServer.TabIndex = 8;
            this.txtServer.Visible = false;
            // 
            // ProggressConection
            // 
            this.ProggressConection.Location = new System.Drawing.Point(4, 3);
            this.ProggressConection.Name = "ProggressConection";
            this.ProggressConection.Size = new System.Drawing.Size(330, 35);
            this.ProggressConection.Step = 1;
            this.ProggressConection.TabIndex = 7;
            // 
            // btEntrar
            // 
            this.btEntrar.BackColor = System.Drawing.Color.Transparent;
            this.btEntrar.BackgroundImage = global::UsePassword.Properties.Resources.Puerta;
            this.btEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEntrar.Enabled = false;
            this.btEntrar.FlatAppearance.BorderSize = 0;
            this.btEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEntrar.Location = new System.Drawing.Point(324, 117);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(40, 48);
            this.btEntrar.TabIndex = 2;
            this.btEntrar.UseVisualStyleBackColor = false;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            this.btEntrar.MouseLeave += new System.EventHandler(this.btEntrar_MouseLeave);
            this.btEntrar.MouseHover += new System.EventHandler(this.btEntrar_MouseHover);
            // 
            // btSalirSesion
            // 
            this.btSalirSesion.BackColor = System.Drawing.Color.Transparent;
            this.btSalirSesion.BackgroundImage = global::UsePassword.Properties.Resources.sal;
            this.btSalirSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSalirSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalirSesion.FlatAppearance.BorderSize = 0;
            this.btSalirSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btSalirSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btSalirSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalirSesion.Location = new System.Drawing.Point(339, 3);
            this.btSalirSesion.Name = "btSalirSesion";
            this.btSalirSesion.Size = new System.Drawing.Size(21, 21);
            this.btSalirSesion.TabIndex = 4;
            this.btSalirSesion.UseVisualStyleBackColor = false;
            this.btSalirSesion.Click += new System.EventHandler(this.btSalirSesion_Click);
            this.btSalirSesion.MouseLeave += new System.EventHandler(this.btSalirSesion_MouseLeave);
            this.btSalirSesion.MouseHover += new System.EventHandler(this.btSalirSesion_MouseHover);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(94, 95);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(129, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // Cmb
            // 
            this.Cmb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cmb.FormattingEnabled = true;
            this.Cmb.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "EMPLEADO"});
            this.Cmb.Location = new System.Drawing.Point(247, 63);
            this.Cmb.Name = "Cmb";
            this.Cmb.Size = new System.Drawing.Size(113, 21);
            this.Cmb.TabIndex = 3;
            this.Cmb.SelectedIndexChanged += new System.EventHandler(this.Cmb_SelectedIndexChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(94, 64);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(129, 20);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 172);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ingresar Usuario y Contrasena";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Cmb;
        private System.Windows.Forms.Button btSalirSesion;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.ProgressBar ProggressConection;
        public System.Windows.Forms.Button btEntrar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtServer;
    }
}

