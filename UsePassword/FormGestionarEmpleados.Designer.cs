namespace UsePassword
{
    partial class FormGestionarEmpleados
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtID_Empleado = new System.Windows.Forms.TextBox();
            this.txtAPEmpleado = new System.Windows.Forms.TextBox();
            this.txtAMEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEdadEmpleado = new System.Windows.Forms.TextBox();
            this.txTelEmpleado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btAgregarEmpleado = new System.Windows.Forms.Button();
            this.btModificarEmpleado = new System.Windows.Forms.Button();
            this.btEliminarEmpleado = new System.Windows.Forms.Button();
            this.btBurcarEmpleado = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btGuardarEmpleado = new System.Windows.Forms.Button();
            this.btCancelarEmpleado = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtColoniaEMpleado = new System.Windows.Forms.ComboBox();
            this.txtCalleEmpleado = new System.Windows.Forms.ComboBox();
            this.dTPFecIng = new System.Windows.Forms.DateTimePicker();
            this.txtNombreEmpleado = new System.Windows.Forms.ComboBox();
            this.txtNPEmpleado = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Empleado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtID_Empleado
            // 
            this.txtID_Empleado.BackColor = System.Drawing.SystemColors.Window;
            this.txtID_Empleado.Location = new System.Drawing.Point(122, 62);
            this.txtID_Empleado.Name = "txtID_Empleado";
            this.txtID_Empleado.Size = new System.Drawing.Size(100, 20);
            this.txtID_Empleado.TabIndex = 1;
            this.txtID_Empleado.TextChanged += new System.EventHandler(this.txtID_Empleado_TextChanged);
            this.txtID_Empleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_Empleado_KeyPress);
            // 
            // txtAPEmpleado
            // 
            this.txtAPEmpleado.Location = new System.Drawing.Point(122, 163);
            this.txtAPEmpleado.MaxLength = 20;
            this.txtAPEmpleado.Name = "txtAPEmpleado";
            this.txtAPEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtAPEmpleado.TabIndex = 2;
            this.txtAPEmpleado.TextChanged += new System.EventHandler(this.txtAPEmpleado_TextChanged);
            this.txtAPEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAPEmpleado_KeyPress);
            // 
            // txtAMEmpleado
            // 
            this.txtAMEmpleado.Location = new System.Drawing.Point(122, 216);
            this.txtAMEmpleado.MaxLength = 20;
            this.txtAMEmpleado.Name = "txtAMEmpleado";
            this.txtAMEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtAMEmpleado.TabIndex = 3;
            this.txtAMEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAMEmpleado_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-3, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellido Paterno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-3, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Apellido Materno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(228, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cólonia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(222, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Código Postal:";
            // 
            // txtEdadEmpleado
            // 
            this.txtEdadEmpleado.Location = new System.Drawing.Point(334, 219);
            this.txtEdadEmpleado.MaxLength = 3;
            this.txtEdadEmpleado.Name = "txtEdadEmpleado";
            this.txtEdadEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtEdadEmpleado.TabIndex = 7;
            this.txtEdadEmpleado.TextChanged += new System.EventHandler(this.txtEdadEmpleado_TextChanged);
            this.txtEdadEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdadEmpleado_KeyPress);
            // 
            // txTelEmpleado
            // 
            this.txTelEmpleado.Location = new System.Drawing.Point(512, 68);
            this.txTelEmpleado.MaxLength = 9;
            this.txTelEmpleado.Name = "txTelEmpleado";
            this.txTelEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txTelEmpleado.TabIndex = 8;
            this.txTelEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txTelEmpleado_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(228, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Edad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(439, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Teléfono:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(472, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Fecha Ingreso:";
            // 
            // btAgregarEmpleado
            // 
            this.btAgregarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btAgregarEmpleado.BackgroundImage = global::UsePassword.Properties.Resources.botonAgregar;
            this.btAgregarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAgregarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAgregarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAgregarEmpleado.FlatAppearance.BorderSize = 0;
            this.btAgregarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btAgregarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btAgregarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregarEmpleado.ForeColor = System.Drawing.Color.Transparent;
            this.btAgregarEmpleado.Location = new System.Drawing.Point(28, 342);
            this.btAgregarEmpleado.Name = "btAgregarEmpleado";
            this.btAgregarEmpleado.Size = new System.Drawing.Size(55, 55);
            this.btAgregarEmpleado.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btAgregarEmpleado, "Agregar");
            this.btAgregarEmpleado.UseVisualStyleBackColor = false;
            this.btAgregarEmpleado.Click += new System.EventHandler(this.btAgregarEmpleado_Click);
            this.btAgregarEmpleado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btAgregarEmpleado_MouseClick);
            this.btAgregarEmpleado.MouseEnter += new System.EventHandler(this.btAgregarEmpleado_MouseEnter);
            this.btAgregarEmpleado.MouseLeave += new System.EventHandler(this.btBurcarEmpleado_MouseLeave);
            this.btAgregarEmpleado.MouseHover += new System.EventHandler(this.btAgregarEmpleado_MouseHover);
            // 
            // btModificarEmpleado
            // 
            this.btModificarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btModificarEmpleado.BackgroundImage = global::UsePassword.Properties.Resources.botonModificar;
            this.btModificarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btModificarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btModificarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btModificarEmpleado.FlatAppearance.BorderSize = 0;
            this.btModificarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btModificarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btModificarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModificarEmpleado.Location = new System.Drawing.Point(240, 342);
            this.btModificarEmpleado.Name = "btModificarEmpleado";
            this.btModificarEmpleado.Size = new System.Drawing.Size(55, 55);
            this.btModificarEmpleado.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btModificarEmpleado, "Modificar");
            this.btModificarEmpleado.UseVisualStyleBackColor = false;
            this.btModificarEmpleado.Click += new System.EventHandler(this.btModificarEmpleado_Click);
            this.btModificarEmpleado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            this.btModificarEmpleado.MouseEnter += new System.EventHandler(this.btModificarEmpleado_MouseEnter);
            this.btModificarEmpleado.MouseLeave += new System.EventHandler(this.btModificarEmpleado_MouseLeave);
            this.btModificarEmpleado.MouseHover += new System.EventHandler(this.btModificarEmpleado_MouseHover);
            // 
            // btEliminarEmpleado
            // 
            this.btEliminarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btEliminarEmpleado.BackgroundImage = global::UsePassword.Properties.Resources.botonAliminar;
            this.btEliminarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEliminarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEliminarEmpleado.FlatAppearance.BorderSize = 0;
            this.btEliminarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btEliminarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btEliminarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminarEmpleado.Location = new System.Drawing.Point(557, 342);
            this.btEliminarEmpleado.Name = "btEliminarEmpleado";
            this.btEliminarEmpleado.Size = new System.Drawing.Size(55, 55);
            this.btEliminarEmpleado.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btEliminarEmpleado, "Eliminar");
            this.btEliminarEmpleado.UseVisualStyleBackColor = false;
            this.btEliminarEmpleado.Click += new System.EventHandler(this.btEliminarEmpleado_Click);
            this.btEliminarEmpleado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btEliminarEmpleado_MouseClick);
            this.btEliminarEmpleado.MouseLeave += new System.EventHandler(this.btEliminarEmpleado_MouseLeave);
            this.btEliminarEmpleado.MouseHover += new System.EventHandler(this.btEliminarEmpleado_MouseHover);
            // 
            // btBurcarEmpleado
            // 
            this.btBurcarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btBurcarEmpleado.BackgroundImage = global::UsePassword.Properties.Resources.botonBuscar1;
            this.btBurcarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBurcarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBurcarEmpleado.FlatAppearance.BorderSize = 0;
            this.btBurcarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btBurcarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btBurcarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBurcarEmpleado.Location = new System.Drawing.Point(411, 342);
            this.btBurcarEmpleado.Name = "btBurcarEmpleado";
            this.btBurcarEmpleado.Size = new System.Drawing.Size(55, 55);
            this.btBurcarEmpleado.TabIndex = 23;
            this.toolTip1.SetToolTip(this.btBurcarEmpleado, "Consultar");
            this.btBurcarEmpleado.UseVisualStyleBackColor = false;
            this.btBurcarEmpleado.Click += new System.EventHandler(this.btBurcarEmpleado_Click);
            this.btBurcarEmpleado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btBurcarEmpleado_MouseClick);
            this.btBurcarEmpleado.MouseLeave += new System.EventHandler(this.btBurcarEmpleado_MouseLeave);
            this.btBurcarEmpleado.MouseHover += new System.EventHandler(this.btBurcarEmpleado_MouseHover);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::UsePassword.Properties.Resources.exit2;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.Location = new System.Drawing.Point(587, -2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(42, 48);
            this.button6.TabIndex = 26;
            this.toolTip1.SetToolTip(this.button6, "Salir");
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btGuardarEmpleado
            // 
            this.btGuardarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btGuardarEmpleado.BackgroundImage = global::UsePassword.Properties.Resources.Guardar;
            this.btGuardarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btGuardarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGuardarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btGuardarEmpleado.FlatAppearance.BorderSize = 0;
            this.btGuardarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btGuardarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btGuardarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardarEmpleado.ForeColor = System.Drawing.Color.Transparent;
            this.btGuardarEmpleado.Location = new System.Drawing.Point(475, 251);
            this.btGuardarEmpleado.Name = "btGuardarEmpleado";
            this.btGuardarEmpleado.Size = new System.Drawing.Size(55, 55);
            this.btGuardarEmpleado.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btGuardarEmpleado, "Guardar");
            this.btGuardarEmpleado.UseVisualStyleBackColor = false;
            this.btGuardarEmpleado.Click += new System.EventHandler(this.btGuardarEmpleado_Click);
            this.btGuardarEmpleado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btGuardarEmpleado_MouseClick);
            this.btGuardarEmpleado.MouseLeave += new System.EventHandler(this.btGuardarEmpleado_MouseLeave);
            this.btGuardarEmpleado.MouseHover += new System.EventHandler(this.btGuardarEmpleado_MouseHover);
            // 
            // btCancelarEmpleado
            // 
            this.btCancelarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btCancelarEmpleado.BackgroundImage = global::UsePassword.Properties.Resources.Cancelar3;
            this.btCancelarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancelarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btCancelarEmpleado.FlatAppearance.BorderSize = 0;
            this.btCancelarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btCancelarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btCancelarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelarEmpleado.ForeColor = System.Drawing.Color.Transparent;
            this.btCancelarEmpleado.Location = new System.Drawing.Point(562, 251);
            this.btCancelarEmpleado.Name = "btCancelarEmpleado";
            this.btCancelarEmpleado.Size = new System.Drawing.Size(55, 55);
            this.btCancelarEmpleado.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btCancelarEmpleado, "Cancelar");
            this.btCancelarEmpleado.UseVisualStyleBackColor = false;
            this.btCancelarEmpleado.Click += new System.EventHandler(this.btCancelarEmpleado_Click);
            this.btCancelarEmpleado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btCancelarEmpleado_MouseClick);
            this.btCancelarEmpleado.MouseLeave += new System.EventHandler(this.btCancelarEmpleado_MouseLeave);
            this.btCancelarEmpleado.MouseHover += new System.EventHandler(this.btCancelarEmpleado_MouseHover);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(0, -2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(594, 48);
            this.label11.TabIndex = 29;
            this.label11.Text = "GESTIONAR EMPLEADOS";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label11_MouseDown);
            this.label11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label11_MouseMove);
            this.label11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label11_MouseUp);
            // 
            // txtColoniaEMpleado
            // 
            this.txtColoniaEMpleado.FormattingEnabled = true;
            this.txtColoniaEMpleado.Location = new System.Drawing.Point(334, 162);
            this.txtColoniaEMpleado.Name = "txtColoniaEMpleado";
            this.txtColoniaEMpleado.Size = new System.Drawing.Size(100, 21);
            this.txtColoniaEMpleado.TabIndex = 6;
            this.txtColoniaEMpleado.SelectedIndexChanged += new System.EventHandler(this.txtColoniaEMpleado_SelectedIndexChanged);
            this.txtColoniaEMpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColoniaEMpleado_KeyPress);
            // 
            // txtCalleEmpleado
            // 
            this.txtCalleEmpleado.FormattingEnabled = true;
            this.txtCalleEmpleado.Location = new System.Drawing.Point(334, 115);
            this.txtCalleEmpleado.Name = "txtCalleEmpleado";
            this.txtCalleEmpleado.Size = new System.Drawing.Size(100, 21);
            this.txtCalleEmpleado.TabIndex = 5;
            this.txtCalleEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalleEmpleado_KeyPress);
            // 
            // dTPFecIng
            // 
            this.dTPFecIng.Location = new System.Drawing.Point(429, 138);
            this.dTPFecIng.MaxDate = new System.DateTime(2030, 5, 20, 0, 0, 0, 0);
            this.dTPFecIng.Name = "dTPFecIng";
            this.dTPFecIng.Size = new System.Drawing.Size(200, 20);
            this.dTPFecIng.TabIndex = 9;
            this.dTPFecIng.Value = new System.DateTime(2018, 5, 9, 0, 0, 0, 0);
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.FormattingEnabled = true;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(122, 109);
            this.txtNombreEmpleado.MaxLength = 40;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(100, 21);
            this.txtNombreEmpleado.TabIndex = 1;
            this.txtNombreEmpleado.SelectedIndexChanged += new System.EventHandler(this.txtNombreEmpleado_SelectedIndexChanged);
            this.txtNombreEmpleado.TextUpdate += new System.EventHandler(this.txtNombreEmpleado_TextUpdate);
            this.txtNombreEmpleado.TextChanged += new System.EventHandler(this.txtNombreEmpleado_TextChanged_1);
            this.txtNombreEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEmpleado_KeyPress_1);
            // 
            // txtNPEmpleado
            // 
            this.txtNPEmpleado.Location = new System.Drawing.Point(334, 69);
            this.txtNPEmpleado.MaxLength = 5;
            this.txtNPEmpleado.Name = "txtNPEmpleado";
            this.txtNPEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtNPEmpleado.TabIndex = 4;
            this.txtNPEmpleado.TextChanged += new System.EventHandler(this.txtNPEmpleado_TextChanged_2);
            this.txtNPEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNPEmpleado_KeyPress_1);
            // 
            // FormGestionarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UsePassword.Properties.Resources.menufondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 451);
            this.Controls.Add(this.txtNPEmpleado);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.dTPFecIng);
            this.Controls.Add(this.txtCalleEmpleado);
            this.Controls.Add(this.txtColoniaEMpleado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btCancelarEmpleado);
            this.Controls.Add(this.btGuardarEmpleado);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btBurcarEmpleado);
            this.Controls.Add(this.btEliminarEmpleado);
            this.Controls.Add(this.btModificarEmpleado);
            this.Controls.Add(this.btAgregarEmpleado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txTelEmpleado);
            this.Controls.Add(this.txtEdadEmpleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAMEmpleado);
            this.Controls.Add(this.txtAPEmpleado);
            this.Controls.Add(this.txtID_Empleado);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionarEmpleados";
            this.Text = "Gestionar Empleados";
            this.Load += new System.EventHandler(this.FormGestionarEmpleados_Load);
            this.MouseEnter += new System.EventHandler(this.FormGestionarEmpleados_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID_Empleado;
        private System.Windows.Forms.TextBox txtAPEmpleado;
        private System.Windows.Forms.TextBox txtAMEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEdadEmpleado;
        private System.Windows.Forms.TextBox txTelEmpleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btAgregarEmpleado;
        private System.Windows.Forms.Button btModificarEmpleado;
        private System.Windows.Forms.Button btEliminarEmpleado;
        private System.Windows.Forms.Button btBurcarEmpleado;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btGuardarEmpleado;
        private System.Windows.Forms.Button btCancelarEmpleado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txtColoniaEMpleado;
        private System.Windows.Forms.ComboBox txtCalleEmpleado;
        private System.Windows.Forms.DateTimePicker dTPFecIng;
        private System.Windows.Forms.ComboBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtNPEmpleado;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}