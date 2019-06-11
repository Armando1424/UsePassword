namespace UsePassword
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btGestionarProveedores = new System.Windows.Forms.Button();
            this.btGenerarBackups = new System.Windows.Forms.Button();
            this.btGestionarClientes = new System.Windows.Forms.Button();
            this.btGestionarEmpleados = new System.Windows.Forms.Button();
            this.btObtenerReportes = new System.Windows.Forms.Button();
            this.btGestionarInventarios = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btCerrarMenu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "GENERAR BACKUPS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "GESTIONAR EMPLEADOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "GESTIONAR CLIENTES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(501, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "GESTIONAR PROVEEDORES";
            // 
            // btGestionarProveedores
            // 
            this.btGestionarProveedores.BackColor = System.Drawing.Color.Transparent;
            this.btGestionarProveedores.BackgroundImage = global::UsePassword.Properties.Resources.botonProveedor;
            this.btGestionarProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btGestionarProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGestionarProveedores.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btGestionarProveedores.FlatAppearance.BorderSize = 0;
            this.btGestionarProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btGestionarProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btGestionarProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGestionarProveedores.ForeColor = System.Drawing.Color.Transparent;
            this.btGestionarProveedores.Location = new System.Drawing.Point(551, 129);
            this.btGestionarProveedores.Name = "btGestionarProveedores";
            this.btGestionarProveedores.Size = new System.Drawing.Size(82, 63);
            this.btGestionarProveedores.TabIndex = 6;
            this.btGestionarProveedores.UseVisualStyleBackColor = false;
            this.btGestionarProveedores.Click += new System.EventHandler(this.button4_Click);
            this.btGestionarProveedores.MouseLeave += new System.EventHandler(this.btGestionarProveedores_MouseLeave);
            this.btGestionarProveedores.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btGestionarProveedores_MouseMove);
            // 
            // btGenerarBackups
            // 
            this.btGenerarBackups.BackColor = System.Drawing.Color.Transparent;
            this.btGenerarBackups.BackgroundImage = global::UsePassword.Properties.Resources.botonGBackups;
            this.btGenerarBackups.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btGenerarBackups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGenerarBackups.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btGenerarBackups.FlatAppearance.BorderSize = 0;
            this.btGenerarBackups.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btGenerarBackups.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btGenerarBackups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGenerarBackups.ForeColor = System.Drawing.Color.Transparent;
            this.btGenerarBackups.Location = new System.Drawing.Point(29, 131);
            this.btGenerarBackups.Name = "btGenerarBackups";
            this.btGenerarBackups.Size = new System.Drawing.Size(85, 61);
            this.btGenerarBackups.TabIndex = 0;
            this.btGenerarBackups.UseVisualStyleBackColor = false;
            this.btGenerarBackups.Click += new System.EventHandler(this.btGenerarBackups_Click);
            this.btGenerarBackups.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btGenerarBackups_MouseClick);
            this.btGenerarBackups.MouseLeave += new System.EventHandler(this.btGenerarBackups_MouseLeave);
            this.btGenerarBackups.MouseHover += new System.EventHandler(this.btGenerarBackups_MouseHover);
            // 
            // btGestionarClientes
            // 
            this.btGestionarClientes.BackColor = System.Drawing.Color.Transparent;
            this.btGestionarClientes.BackgroundImage = global::UsePassword.Properties.Resources.Cliente2;
            this.btGestionarClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btGestionarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGestionarClientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btGestionarClientes.FlatAppearance.BorderSize = 0;
            this.btGestionarClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btGestionarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btGestionarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGestionarClientes.ForeColor = System.Drawing.Color.Transparent;
            this.btGestionarClientes.Location = new System.Drawing.Point(389, 134);
            this.btGestionarClientes.Name = "btGestionarClientes";
            this.btGestionarClientes.Size = new System.Drawing.Size(85, 61);
            this.btGestionarClientes.TabIndex = 4;
            this.btGestionarClientes.UseVisualStyleBackColor = false;
            this.btGestionarClientes.Click += new System.EventHandler(this.button3_Click);
            this.btGestionarClientes.MouseLeave += new System.EventHandler(this.btGestionarClientes_MouseLeave);
            this.btGestionarClientes.MouseHover += new System.EventHandler(this.btGestionarClientes_MouseHover);
            // 
            // btGestionarEmpleados
            // 
            this.btGestionarEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.btGestionarEmpleados.BackgroundImage = global::UsePassword.Properties.Resources.botonGEmpleados;
            this.btGestionarEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btGestionarEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGestionarEmpleados.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btGestionarEmpleados.FlatAppearance.BorderSize = 0;
            this.btGestionarEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btGestionarEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btGestionarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGestionarEmpleados.ForeColor = System.Drawing.Color.Transparent;
            this.btGestionarEmpleados.Location = new System.Drawing.Point(196, 132);
            this.btGestionarEmpleados.Name = "btGestionarEmpleados";
            this.btGestionarEmpleados.Size = new System.Drawing.Size(85, 64);
            this.btGestionarEmpleados.TabIndex = 2;
            this.btGestionarEmpleados.UseVisualStyleBackColor = false;
            this.btGestionarEmpleados.Click += new System.EventHandler(this.button2_Click);
            this.btGestionarEmpleados.MouseLeave += new System.EventHandler(this.btGestionarEmpleados_MouseLeave);
            this.btGestionarEmpleados.MouseHover += new System.EventHandler(this.btGestionarEmpleados_MouseHover);
            this.btGestionarEmpleados.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // btObtenerReportes
            // 
            this.btObtenerReportes.BackColor = System.Drawing.Color.Transparent;
            this.btObtenerReportes.BackgroundImage = global::UsePassword.Properties.Resources.botonObtenerReportes;
            this.btObtenerReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btObtenerReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btObtenerReportes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btObtenerReportes.FlatAppearance.BorderSize = 0;
            this.btObtenerReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btObtenerReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btObtenerReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btObtenerReportes.ForeColor = System.Drawing.Color.Transparent;
            this.btObtenerReportes.Location = new System.Drawing.Point(196, 239);
            this.btObtenerReportes.Name = "btObtenerReportes";
            this.btObtenerReportes.Size = new System.Drawing.Size(85, 61);
            this.btObtenerReportes.TabIndex = 7;
            this.btObtenerReportes.UseVisualStyleBackColor = false;
            this.btObtenerReportes.Click += new System.EventHandler(this.btObtenerReportes_Click);
            this.btObtenerReportes.MouseLeave += new System.EventHandler(this.btObtenerReportes_MouseLeave);
            this.btObtenerReportes.MouseHover += new System.EventHandler(this.btObtenerReportes_MouseHover);
            // 
            // btGestionarInventarios
            // 
            this.btGestionarInventarios.BackColor = System.Drawing.Color.Transparent;
            this.btGestionarInventarios.BackgroundImage = global::UsePassword.Properties.Resources.BotonInventarios;
            this.btGestionarInventarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btGestionarInventarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGestionarInventarios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btGestionarInventarios.FlatAppearance.BorderSize = 0;
            this.btGestionarInventarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btGestionarInventarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btGestionarInventarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGestionarInventarios.ForeColor = System.Drawing.Color.Transparent;
            this.btGestionarInventarios.Location = new System.Drawing.Point(389, 239);
            this.btGestionarInventarios.Name = "btGestionarInventarios";
            this.btGestionarInventarios.Size = new System.Drawing.Size(85, 61);
            this.btGestionarInventarios.TabIndex = 8;
            this.btGestionarInventarios.UseVisualStyleBackColor = false;
            this.btGestionarInventarios.Click += new System.EventHandler(this.btGestionarInventarios_Click);
            this.btGestionarInventarios.MouseLeave += new System.EventHandler(this.btGestionarInventarios_MouseLeave);
            this.btGestionarInventarios.MouseHover += new System.EventHandler(this.btGestionarInventarios_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(165, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "OBTENER REPORTES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(353, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "GESTIONAR INVENTARIOS";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btCerrarMenu
            // 
            this.btCerrarMenu.BackColor = System.Drawing.Color.Transparent;
            this.btCerrarMenu.BackgroundImage = global::UsePassword.Properties.Resources.off;
            this.btCerrarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCerrarMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCerrarMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btCerrarMenu.FlatAppearance.BorderSize = 0;
            this.btCerrarMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btCerrarMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btCerrarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCerrarMenu.ForeColor = System.Drawing.Color.Transparent;
            this.btCerrarMenu.Location = new System.Drawing.Point(645, 0);
            this.btCerrarMenu.Name = "btCerrarMenu";
            this.btCerrarMenu.Size = new System.Drawing.Size(49, 38);
            this.btCerrarMenu.TabIndex = 11;
            this.btCerrarMenu.UseVisualStyleBackColor = false;
            this.btCerrarMenu.Click += new System.EventHandler(this.btCerrarMenu_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(653, 38);
            this.label7.TabIndex = 12;
            this.label7.Text = "ADMINISTRADOR";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label7_MouseDown);
            this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label7_MouseMove);
            this.label7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label7_MouseUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(148, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(410, 55);
            this.label8.TabIndex = 13;
            this.label8.Text = "BIMYOU MERAKI";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::UsePassword.Properties.Resources.menufondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(706, 381);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btCerrarMenu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btGestionarInventarios);
            this.Controls.Add(this.btObtenerReportes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btGestionarProveedores);
            this.Controls.Add(this.btGenerarBackups);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btGestionarClientes);
            this.Controls.Add(this.btGestionarEmpleados);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.TransparencyKey = System.Drawing.Color.Teal;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGenerarBackups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGestionarEmpleados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btGestionarClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btGestionarProveedores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btObtenerReportes;
        private System.Windows.Forms.Button btGestionarInventarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btCerrarMenu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}