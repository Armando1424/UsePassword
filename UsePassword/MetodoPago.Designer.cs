namespace UsePassword
{
    partial class MetodoPago
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
            this.label5 = new System.Windows.Forms.Label();
            this.Saldo = new System.Windows.Forms.TextBox();
            this.Tipo_pago = new System.Windows.Forms.TextBox();
            this.Nombre_pago = new System.Windows.Forms.TextBox();
            this.Monto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(283, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto";
            // 
            // Saldo
            // 
            this.Saldo.Enabled = false;
            this.Saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saldo.Location = new System.Drawing.Point(26, 116);
            this.Saldo.Name = "Saldo";
            this.Saldo.Size = new System.Drawing.Size(70, 22);
            this.Saldo.TabIndex = 5;
            // 
            // Tipo_pago
            // 
            this.Tipo_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipo_pago.Location = new System.Drawing.Point(102, 116);
            this.Tipo_pago.MaxLength = 1;
            this.Tipo_pago.Name = "Tipo_pago";
            this.Tipo_pago.Size = new System.Drawing.Size(70, 22);
            this.Tipo_pago.TabIndex = 6;
            this.Tipo_pago.TextChanged += new System.EventHandler(this.Tipo_pago_TextChanged);
            this.Tipo_pago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tipo_pago_KeyDown);
            this.Tipo_pago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tipo_pago_KeyPress);
            // 
            // Nombre_pago
            // 
            this.Nombre_pago.Enabled = false;
            this.Nombre_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_pago.Location = new System.Drawing.Point(178, 116);
            this.Nombre_pago.Name = "Nombre_pago";
            this.Nombre_pago.Size = new System.Drawing.Size(89, 22);
            this.Nombre_pago.TabIndex = 7;
            // 
            // Monto
            // 
            this.Monto.Enabled = false;
            this.Monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monto.Location = new System.Drawing.Point(273, 114);
            this.Monto.MaxLength = 7;
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(70, 22);
            this.Monto.TabIndex = 8;
            this.Monto.TextChanged += new System.EventHandler(this.MetodoPago_Load);
            this.Monto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Monto_KeyDown);
            this.Monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 40);
            this.label6.TabIndex = 9;
            this.label6.Text = "METODO DE PAGO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MetodoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UsePassword.Properties.Resources.menufondo2Empleado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(356, 153);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Monto);
            this.Controls.Add(this.Nombre_pago);
            this.Controls.Add(this.Tipo_pago);
            this.Controls.Add(this.Saldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MetodoPago";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.MetodoPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tipo_pago;
        private System.Windows.Forms.TextBox Nombre_pago;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox Saldo;
        public System.Windows.Forms.TextBox Monto;
    }
}