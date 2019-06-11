namespace UsePassword
{
    partial class FormGestionarProveedores
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
            this.btAgregarProveedor = new System.Windows.Forms.Button();
            this.btModificarProveedor = new System.Windows.Forms.Button();
            this.btConsultarProveedor = new System.Windows.Forms.Button();
            this.btEliminarProveedor = new System.Windows.Forms.Button();
            this.btGuardarProveedor = new System.Windows.Forms.Button();
            this.btCancelarProveedor = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID_Pr = new System.Windows.Forms.TextBox();
            this.txtTel_Pr = new System.Windows.Forms.TextBox();
            this.txtDireccion_Pr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre_Pr = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btAgregarProveedor
            // 
            this.btAgregarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btAgregarProveedor.BackgroundImage = global::UsePassword.Properties.Resources.botonAgregar;
            this.btAgregarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAgregarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAgregarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAgregarProveedor.FlatAppearance.BorderSize = 0;
            this.btAgregarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btAgregarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btAgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregarProveedor.Location = new System.Drawing.Point(15, 334);
            this.btAgregarProveedor.Name = "btAgregarProveedor";
            this.btAgregarProveedor.Size = new System.Drawing.Size(55, 55);
            this.btAgregarProveedor.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btAgregarProveedor, "Agregar");
            this.btAgregarProveedor.UseVisualStyleBackColor = false;
            this.btAgregarProveedor.Click += new System.EventHandler(this.btAgregarProveedor_Click);
            // 
            // btModificarProveedor
            // 
            this.btModificarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btModificarProveedor.BackgroundImage = global::UsePassword.Properties.Resources.botonModificar;
            this.btModificarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btModificarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btModificarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btModificarProveedor.FlatAppearance.BorderSize = 0;
            this.btModificarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btModificarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btModificarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModificarProveedor.Location = new System.Drawing.Point(198, 334);
            this.btModificarProveedor.Name = "btModificarProveedor";
            this.btModificarProveedor.Size = new System.Drawing.Size(55, 55);
            this.btModificarProveedor.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btModificarProveedor, "Modificar");
            this.btModificarProveedor.UseVisualStyleBackColor = false;
            this.btModificarProveedor.Click += new System.EventHandler(this.btModificarProveedor_Click);
            // 
            // btConsultarProveedor
            // 
            this.btConsultarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btConsultarProveedor.BackgroundImage = global::UsePassword.Properties.Resources.botonBuscar;
            this.btConsultarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConsultarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConsultarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btConsultarProveedor.FlatAppearance.BorderSize = 0;
            this.btConsultarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btConsultarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btConsultarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultarProveedor.Location = new System.Drawing.Point(385, 334);
            this.btConsultarProveedor.Name = "btConsultarProveedor";
            this.btConsultarProveedor.Size = new System.Drawing.Size(55, 55);
            this.btConsultarProveedor.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btConsultarProveedor, "Buscar");
            this.btConsultarProveedor.UseVisualStyleBackColor = false;
            this.btConsultarProveedor.Click += new System.EventHandler(this.btConsultarProveedor_Click);
            // 
            // btEliminarProveedor
            // 
            this.btEliminarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btEliminarProveedor.BackgroundImage = global::UsePassword.Properties.Resources.botonAliminar;
            this.btEliminarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEliminarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEliminarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btEliminarProveedor.FlatAppearance.BorderSize = 0;
            this.btEliminarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btEliminarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btEliminarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminarProveedor.Location = new System.Drawing.Point(562, 334);
            this.btEliminarProveedor.Name = "btEliminarProveedor";
            this.btEliminarProveedor.Size = new System.Drawing.Size(55, 55);
            this.btEliminarProveedor.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btEliminarProveedor, "Eliminar");
            this.btEliminarProveedor.UseVisualStyleBackColor = false;
            this.btEliminarProveedor.Click += new System.EventHandler(this.btEliminarProveedor_Click);
            // 
            // btGuardarProveedor
            // 
            this.btGuardarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btGuardarProveedor.BackgroundImage = global::UsePassword.Properties.Resources.Guardar;
            this.btGuardarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btGuardarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGuardarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btGuardarProveedor.FlatAppearance.BorderSize = 0;
            this.btGuardarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btGuardarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btGuardarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardarProveedor.Location = new System.Drawing.Point(435, 202);
            this.btGuardarProveedor.Name = "btGuardarProveedor";
            this.btGuardarProveedor.Size = new System.Drawing.Size(55, 55);
            this.btGuardarProveedor.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btGuardarProveedor, "Guardar");
            this.btGuardarProveedor.UseVisualStyleBackColor = false;
            this.btGuardarProveedor.Click += new System.EventHandler(this.btGuardarProveedor_Click);
            // 
            // btCancelarProveedor
            // 
            this.btCancelarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btCancelarProveedor.BackgroundImage = global::UsePassword.Properties.Resources.Cancelar3;
            this.btCancelarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancelarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btCancelarProveedor.FlatAppearance.BorderSize = 0;
            this.btCancelarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btCancelarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btCancelarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelarProveedor.Location = new System.Drawing.Point(509, 202);
            this.btCancelarProveedor.Name = "btCancelarProveedor";
            this.btCancelarProveedor.Size = new System.Drawing.Size(55, 55);
            this.btCancelarProveedor.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btCancelarProveedor, "Eliminar");
            this.btCancelarProveedor.UseVisualStyleBackColor = false;
            this.btCancelarProveedor.Click += new System.EventHandler(this.btCancelarProveedor_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = global::UsePassword.Properties.Resources.exit2;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(580, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 48);
            this.button7.TabIndex = 7;
            this.toolTip1.SetToolTip(this.button7, "Salir");
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Proveedor:";
            // 
            // txtID_Pr
            // 
            this.txtID_Pr.Location = new System.Drawing.Point(147, 68);
            this.txtID_Pr.MaxLength = 9;
            this.txtID_Pr.Name = "txtID_Pr";
            this.txtID_Pr.Size = new System.Drawing.Size(129, 20);
            this.txtID_Pr.TabIndex = 1;
            this.txtID_Pr.TextChanged += new System.EventHandler(this.txtID_Pr_TextChanged);
            this.txtID_Pr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_Pr_KeyPress);
            // 
            // txtTel_Pr
            // 
            this.txtTel_Pr.Location = new System.Drawing.Point(147, 173);
            this.txtTel_Pr.MaxLength = 10;
            this.txtTel_Pr.Name = "txtTel_Pr";
            this.txtTel_Pr.Size = new System.Drawing.Size(129, 20);
            this.txtTel_Pr.TabIndex = 3;
            this.txtTel_Pr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_Pr_KeyPress);
            // 
            // txtDireccion_Pr
            // 
            this.txtDireccion_Pr.Location = new System.Drawing.Point(147, 220);
            this.txtDireccion_Pr.MaxLength = 20;
            this.txtDireccion_Pr.Name = "txtDireccion_Pr";
            this.txtDireccion_Pr.Size = new System.Drawing.Size(129, 20);
            this.txtDireccion_Pr.TabIndex = 4;
            this.txtDireccion_Pr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_Pr_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre Proveedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Teléfono Proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Dirección Proveedor";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-4, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(591, 48);
            this.label6.TabIndex = 23;
            this.label6.Text = "GESTIONAR PROVEEDOR";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label6_MouseDown);
            this.label6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label6_MouseMove);
            this.label6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label6_MouseUp);
            // 
            // txtNombre_Pr
            // 
            this.txtNombre_Pr.FormattingEnabled = true;
            this.txtNombre_Pr.Location = new System.Drawing.Point(147, 123);
            this.txtNombre_Pr.MaxLength = 40;
            this.txtNombre_Pr.Name = "txtNombre_Pr";
            this.txtNombre_Pr.Size = new System.Drawing.Size(129, 21);
            this.txtNombre_Pr.TabIndex = 2;
            this.txtNombre_Pr.SelectedIndexChanged += new System.EventHandler(this.txtNombre_Pr_SelectedIndexChanged);
            this.txtNombre_Pr.TextUpdate += new System.EventHandler(this.txtNombre_Pr_TextUpdate);
            this.txtNombre_Pr.TextChanged += new System.EventHandler(this.txtNombre_Pr_TextChanged);
            this.txtNombre_Pr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_Pr_KeyPress_1);
            // 
            // FormGestionarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UsePassword.Properties.Resources.menufondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 447);
            this.Controls.Add(this.txtNombre_Pr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDireccion_Pr);
            this.Controls.Add(this.txtTel_Pr);
            this.Controls.Add(this.txtID_Pr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btCancelarProveedor);
            this.Controls.Add(this.btGuardarProveedor);
            this.Controls.Add(this.btEliminarProveedor);
            this.Controls.Add(this.btConsultarProveedor);
            this.Controls.Add(this.btModificarProveedor);
            this.Controls.Add(this.btAgregarProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionarProveedores";
            this.Text = "Gestionar Proveedores";
            this.Load += new System.EventHandler(this.FormGestionarProveedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAgregarProveedor;
        private System.Windows.Forms.Button btModificarProveedor;
        private System.Windows.Forms.Button btConsultarProveedor;
        private System.Windows.Forms.Button btEliminarProveedor;
        private System.Windows.Forms.Button btGuardarProveedor;
        private System.Windows.Forms.Button btCancelarProveedor;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID_Pr;
        private System.Windows.Forms.TextBox txtTel_Pr;
        private System.Windows.Forms.TextBox txtDireccion_Pr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtNombre_Pr;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}