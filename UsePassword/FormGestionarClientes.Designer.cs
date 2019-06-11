namespace UsePassword
{
    partial class FormGestionarClientes
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
            this.components = new System.ComponentModel.Container();
            this.txtID_Cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAP_C = new System.Windows.Forms.TextBox();
            this.txtAM_C = new System.Windows.Forms.TextBox();
            this.txtNumero_C = new System.Windows.Forms.TextBox();
            this.btAgregarCliente = new System.Windows.Forms.Button();
            this.btModificarCliente = new System.Windows.Forms.Button();
            this.btConsultarCliente = new System.Windows.Forms.Button();
            this.btEliminarCliente = new System.Windows.Forms.Button();
            this.btCancelarCliente = new System.Windows.Forms.Button();
            this.btGuardarCliente = new System.Windows.Forms.Button();
            this.btRegresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DTP_C = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTel_C = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombre_Cliente = new System.Windows.Forms.ComboBox();
            this.txtColonia_C = new System.Windows.Forms.ComboBox();
            this.txtCalle_C = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtID_Cliente
            // 
            this.txtID_Cliente.Location = new System.Drawing.Point(121, 56);
            this.txtID_Cliente.MaxLength = 9;
            this.txtID_Cliente.Name = "txtID_Cliente";
            this.txtID_Cliente.Size = new System.Drawing.Size(100, 20);
            this.txtID_Cliente.TabIndex = 0;
            this.txtID_Cliente.TextChanged += new System.EventHandler(this.txtID_Cliente_TextChanged);
            this.txtID_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_Cliente_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Cliente:";
            // 
            // txtAP_C
            // 
            this.txtAP_C.Location = new System.Drawing.Point(121, 134);
            this.txtAP_C.MaxLength = 20;
            this.txtAP_C.Name = "txtAP_C";
            this.txtAP_C.Size = new System.Drawing.Size(100, 20);
            this.txtAP_C.TabIndex = 2;
            this.txtAP_C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAP_C_KeyPress);
            // 
            // txtAM_C
            // 
            this.txtAM_C.Location = new System.Drawing.Point(121, 178);
            this.txtAM_C.MaxLength = 20;
            this.txtAM_C.Name = "txtAM_C";
            this.txtAM_C.Size = new System.Drawing.Size(100, 20);
            this.txtAM_C.TabIndex = 3;
            this.txtAM_C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAM_C_KeyPress);
            // 
            // txtNumero_C
            // 
            this.txtNumero_C.Location = new System.Drawing.Point(340, 56);
            this.txtNumero_C.MaxLength = 5;
            this.txtNumero_C.Name = "txtNumero_C";
            this.txtNumero_C.Size = new System.Drawing.Size(100, 20);
            this.txtNumero_C.TabIndex = 4;
            this.txtNumero_C.TextChanged += new System.EventHandler(this.txtNumero_C_TextChanged);
            this.txtNumero_C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_C_KeyPress);
            // 
            // btAgregarCliente
            // 
            this.btAgregarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btAgregarCliente.BackgroundImage = global::UsePassword.Properties.Resources.botonAgregar;
            this.btAgregarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAgregarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btAgregarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btAgregarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregarCliente.Location = new System.Drawing.Point(60, 323);
            this.btAgregarCliente.Name = "btAgregarCliente";
            this.btAgregarCliente.Size = new System.Drawing.Size(55, 55);
            this.btAgregarCliente.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btAgregarCliente, "Agregar");
            this.btAgregarCliente.UseVisualStyleBackColor = false;
            this.btAgregarCliente.Click += new System.EventHandler(this.btAgregarCliente_Click);
            // 
            // btModificarCliente
            // 
            this.btModificarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btModificarCliente.BackgroundImage = global::UsePassword.Properties.Resources.botonModificar;
            this.btModificarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btModificarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btModificarCliente.FlatAppearance.BorderSize = 0;
            this.btModificarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btModificarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModificarCliente.Location = new System.Drawing.Point(211, 323);
            this.btModificarCliente.Name = "btModificarCliente";
            this.btModificarCliente.Size = new System.Drawing.Size(55, 55);
            this.btModificarCliente.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btModificarCliente, "Modificar");
            this.btModificarCliente.UseVisualStyleBackColor = false;
            this.btModificarCliente.Click += new System.EventHandler(this.btModificarCliente_Click);
            // 
            // btConsultarCliente
            // 
            this.btConsultarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btConsultarCliente.BackgroundImage = global::UsePassword.Properties.Resources.botonBuscar;
            this.btConsultarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConsultarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btConsultarCliente.FlatAppearance.BorderSize = 0;
            this.btConsultarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btConsultarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btConsultarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultarCliente.Location = new System.Drawing.Point(361, 323);
            this.btConsultarCliente.Name = "btConsultarCliente";
            this.btConsultarCliente.Size = new System.Drawing.Size(55, 55);
            this.btConsultarCliente.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btConsultarCliente, "Consultar");
            this.btConsultarCliente.UseVisualStyleBackColor = false;
            this.btConsultarCliente.Click += new System.EventHandler(this.btConsultarCliente_Click);
            // 
            // btEliminarCliente
            // 
            this.btEliminarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btEliminarCliente.BackgroundImage = global::UsePassword.Properties.Resources.botonAliminar;
            this.btEliminarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEliminarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btEliminarCliente.FlatAppearance.BorderSize = 0;
            this.btEliminarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btEliminarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminarCliente.Location = new System.Drawing.Point(493, 323);
            this.btEliminarCliente.Name = "btEliminarCliente";
            this.btEliminarCliente.Size = new System.Drawing.Size(55, 55);
            this.btEliminarCliente.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btEliminarCliente, "Eliminar");
            this.btEliminarCliente.UseVisualStyleBackColor = false;
            this.btEliminarCliente.Click += new System.EventHandler(this.btEliminarCliente_Click);
            // 
            // btCancelarCliente
            // 
            this.btCancelarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btCancelarCliente.BackgroundImage = global::UsePassword.Properties.Resources.Cancelar3;
            this.btCancelarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancelarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btCancelarCliente.FlatAppearance.BorderSize = 0;
            this.btCancelarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btCancelarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btCancelarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelarCliente.Location = new System.Drawing.Point(572, 223);
            this.btCancelarCliente.Name = "btCancelarCliente";
            this.btCancelarCliente.Size = new System.Drawing.Size(55, 55);
            this.btCancelarCliente.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btCancelarCliente, "Cancelar");
            this.btCancelarCliente.UseVisualStyleBackColor = false;
            this.btCancelarCliente.Click += new System.EventHandler(this.btCancelarCliente_Click);
            // 
            // btGuardarCliente
            // 
            this.btGuardarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btGuardarCliente.BackgroundImage = global::UsePassword.Properties.Resources.Guardar;
            this.btGuardarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btGuardarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btGuardarCliente.FlatAppearance.BorderSize = 0;
            this.btGuardarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btGuardarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btGuardarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardarCliente.Location = new System.Drawing.Point(493, 223);
            this.btGuardarCliente.Name = "btGuardarCliente";
            this.btGuardarCliente.Size = new System.Drawing.Size(55, 55);
            this.btGuardarCliente.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btGuardarCliente, "Guardar");
            this.btGuardarCliente.UseVisualStyleBackColor = false;
            this.btGuardarCliente.Click += new System.EventHandler(this.btGuardarCliente_Click);
            // 
            // btRegresar
            // 
            this.btRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btRegresar.BackgroundImage = global::UsePassword.Properties.Resources.exit2;
            this.btRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRegresar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btRegresar.FlatAppearance.BorderSize = 0;
            this.btRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegresar.Location = new System.Drawing.Point(578, 1);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(49, 48);
            this.btRegresar.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btRegresar, "Salir");
            this.btRegresar.UseVisualStyleBackColor = false;
            this.btRegresar.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Apellido Materno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(227, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Código Postal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(227, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Cólonia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(479, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Fecha Registro";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(-1, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(584, 48);
            this.label8.TabIndex = 26;
            this.label8.Text = "GESTIONAR CLIENTES";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label8_MouseDown);
            this.label8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label8_MouseMove);
            this.label8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label8_MouseUp);
            // 
            // DTP_C
            // 
            this.DTP_C.Location = new System.Drawing.Point(446, 92);
            this.DTP_C.MaxDate = new System.DateTime(2030, 5, 9, 0, 0, 0, 0);
            this.DTP_C.Name = "DTP_C";
            this.DTP_C.Size = new System.Drawing.Size(200, 20);
            this.DTP_C.TabIndex = 8;
            this.DTP_C.Value = new System.DateTime(2018, 5, 9, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(226, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Estado:";
            // 
            // txtTel_C
            // 
            this.txtTel_C.Location = new System.Drawing.Point(340, 183);
            this.txtTel_C.MaxLength = 10;
            this.txtTel_C.Name = "txtTel_C";
            this.txtTel_C.Size = new System.Drawing.Size(100, 20);
            this.txtTel_C.TabIndex = 7;
            this.txtTel_C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_C_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(227, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "Teléfono  Cell";
            // 
            // txtNombre_Cliente
            // 
            this.txtNombre_Cliente.FormattingEnabled = true;
            this.txtNombre_Cliente.Location = new System.Drawing.Point(121, 97);
            this.txtNombre_Cliente.Name = "txtNombre_Cliente";
            this.txtNombre_Cliente.Size = new System.Drawing.Size(100, 21);
            this.txtNombre_Cliente.TabIndex = 1;
            this.txtNombre_Cliente.SelectedIndexChanged += new System.EventHandler(this.txtNombre_Cliente_SelectedIndexChanged);
            this.txtNombre_Cliente.TextUpdate += new System.EventHandler(this.txtNombre_Cliente_TextUpdate);
            this.txtNombre_Cliente.TextChanged += new System.EventHandler(this.txtNombre_Cliente_TextChanged);
            this.txtNombre_Cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_Cliente_KeyPress_1);
            // 
            // txtColonia_C
            // 
            this.txtColonia_C.FormattingEnabled = true;
            this.txtColonia_C.Location = new System.Drawing.Point(340, 134);
            this.txtColonia_C.Name = "txtColonia_C";
            this.txtColonia_C.Size = new System.Drawing.Size(100, 21);
            this.txtColonia_C.TabIndex = 6;
            this.txtColonia_C.SelectedIndexChanged += new System.EventHandler(this.txtColonia_C_SelectedIndexChanged);
            this.txtColonia_C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColonia_C_KeyPress_1);
            // 
            // txtCalle_C
            // 
            this.txtCalle_C.FormattingEnabled = true;
            this.txtCalle_C.Location = new System.Drawing.Point(340, 97);
            this.txtCalle_C.Name = "txtCalle_C";
            this.txtCalle_C.Size = new System.Drawing.Size(100, 21);
            this.txtCalle_C.TabIndex = 5;
            this.txtCalle_C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalle_C_KeyPress_1);
            // 
            // FormGestionarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UsePassword.Properties.Resources.menufondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 451);
            this.Controls.Add(this.txtCalle_C);
            this.Controls.Add(this.txtColonia_C);
            this.Controls.Add(this.txtNombre_Cliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTel_C);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DTP_C);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btRegresar);
            this.Controls.Add(this.btGuardarCliente);
            this.Controls.Add(this.btCancelarCliente);
            this.Controls.Add(this.btEliminarCliente);
            this.Controls.Add(this.btConsultarCliente);
            this.Controls.Add(this.btModificarCliente);
            this.Controls.Add(this.btAgregarCliente);
            this.Controls.Add(this.txtNumero_C);
            this.Controls.Add(this.txtAM_C);
            this.Controls.Add(this.txtAP_C);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID_Cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionarClientes";
            this.Text = ":D";
            this.Load += new System.EventHandler(this.FormGestionarClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID_Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAP_C;
        private System.Windows.Forms.TextBox txtAM_C;
        private System.Windows.Forms.TextBox txtNumero_C;
        private System.Windows.Forms.Button btAgregarCliente;
        private System.Windows.Forms.Button btModificarCliente;
        private System.Windows.Forms.Button btConsultarCliente;
        private System.Windows.Forms.Button btEliminarCliente;
        private System.Windows.Forms.Button btCancelarCliente;
        private System.Windows.Forms.Button btGuardarCliente;
        private System.Windows.Forms.Button btRegresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DTP_C;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTel_C;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txtNombre_Cliente;
        private System.Windows.Forms.ComboBox txtColonia_C;
        private System.Windows.Forms.ComboBox txtCalle_C;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}