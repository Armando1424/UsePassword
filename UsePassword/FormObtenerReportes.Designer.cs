namespace UsePassword
{
    partial class FormObtenerReportes
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
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cBOptions = new System.Windows.Forms.ComboBox();
            this.gBReports = new System.Windows.Forms.GroupBox();
            this.GbProByPro = new System.Windows.Forms.GroupBox();
            this.cbNameProveedor = new System.Windows.Forms.ComboBox();
            this.txtRIdProvider = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbSpecificProducts = new System.Windows.Forms.GroupBox();
            this.cbRNameProduct = new System.Windows.Forms.ComboBox();
            this.txtRIdProduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbFinallyDate = new System.Windows.Forms.GroupBox();
            this.dtpDateF = new System.Windows.Forms.DateTimePicker();
            this.rbYearF = new System.Windows.Forms.RadioButton();
            this.rbMonthF = new System.Windows.Forms.RadioButton();
            this.rbDayF = new System.Windows.Forms.RadioButton();
            this.gbStartDate = new System.Windows.Forms.GroupBox();
            this.dTPDate = new System.Windows.Forms.DateTimePicker();
            this.rBYear = new System.Windows.Forms.RadioButton();
            this.rBMonth = new System.Windows.Forms.RadioButton();
            this.rBDay = new System.Windows.Forms.RadioButton();
            this.btnCreateReports = new System.Windows.Forms.Button();
            this.gBReports.SuspendLayout();
            this.GbProByPro.SuspendLayout();
            this.gbSpecificProducts.SuspendLayout();
            this.gbFinallyDate.SuspendLayout();
            this.gbStartDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::UsePassword.Properties.Resources.exit2;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(670, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 48);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-5, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(681, 48);
            this.label4.TabIndex = 7;
            this.label4.Text = "OBTENER REPORTE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDown);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label4_MouseMove);
            this.label4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label4_MouseUp);
            // 
            // cBOptions
            // 
            this.cBOptions.FormattingEnabled = true;
            this.cBOptions.Items.AddRange(new object[] {
            "Empleado",
            "Clientes",
            "Proveedores",
            "Producto",
            "Venta",
            "Compra",
            "Venta Por Producto",
            "Venta Por Fecha",
            "Compra Por Producto",
            "Compra Por Fecha",
            "ProductosXProveedor"});
            this.cBOptions.Location = new System.Drawing.Point(24, 38);
            this.cBOptions.Name = "cBOptions";
            this.cBOptions.Size = new System.Drawing.Size(133, 21);
            this.cBOptions.TabIndex = 8;
            this.cBOptions.Text = "Reporte De ";
            this.cBOptions.SelectedIndexChanged += new System.EventHandler(this.cBOptions_SelectedIndexChanged);
            // 
            // gBReports
            // 
            this.gBReports.Controls.Add(this.GbProByPro);
            this.gBReports.Controls.Add(this.gbSpecificProducts);
            this.gBReports.Controls.Add(this.gbFinallyDate);
            this.gBReports.Controls.Add(this.gbStartDate);
            this.gBReports.Controls.Add(this.btnCreateReports);
            this.gBReports.Controls.Add(this.cBOptions);
            this.gBReports.Location = new System.Drawing.Point(30, 63);
            this.gBReports.Name = "gBReports";
            this.gBReports.Size = new System.Drawing.Size(658, 360);
            this.gBReports.TabIndex = 9;
            this.gBReports.TabStop = false;
            this.gBReports.Text = "Generador de reportes";
            // 
            // GbProByPro
            // 
            this.GbProByPro.Controls.Add(this.cbNameProveedor);
            this.GbProByPro.Controls.Add(this.txtRIdProvider);
            this.GbProByPro.Controls.Add(this.label3);
            this.GbProByPro.Controls.Add(this.label5);
            this.GbProByPro.Enabled = false;
            this.GbProByPro.Location = new System.Drawing.Point(196, 240);
            this.GbProByPro.Name = "GbProByPro";
            this.GbProByPro.Size = new System.Drawing.Size(425, 90);
            this.GbProByPro.TabIndex = 13;
            this.GbProByPro.TabStop = false;
            this.GbProByPro.Text = "Productos por proveedor";
            // 
            // cbNameProveedor
            // 
            this.cbNameProveedor.FormattingEnabled = true;
            this.cbNameProveedor.Location = new System.Drawing.Point(221, 48);
            this.cbNameProveedor.Name = "cbNameProveedor";
            this.cbNameProveedor.Size = new System.Drawing.Size(182, 21);
            this.cbNameProveedor.TabIndex = 3;
            this.cbNameProveedor.SelectedIndexChanged += new System.EventHandler(this.cbNameProveedor_SelectedIndexChanged);
            this.cbNameProveedor.TextUpdate += new System.EventHandler(this.cbNameProveedor_TextUpdate);
            this.cbNameProveedor.TextChanged += new System.EventHandler(this.cbNameProveedor_TextChanged);
            // 
            // txtRIdProvider
            // 
            this.txtRIdProvider.Location = new System.Drawing.Point(14, 48);
            this.txtRIdProvider.Name = "txtRIdProvider";
            this.txtRIdProvider.Size = new System.Drawing.Size(189, 20);
            this.txtRIdProvider.TabIndex = 2;
            this.txtRIdProvider.TextChanged += new System.EventHandler(this.txtRIdProvider_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre del proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID proveedor";
            // 
            // gbSpecificProducts
            // 
            this.gbSpecificProducts.Controls.Add(this.cbRNameProduct);
            this.gbSpecificProducts.Controls.Add(this.txtRIdProduct);
            this.gbSpecificProducts.Controls.Add(this.label2);
            this.gbSpecificProducts.Controls.Add(this.label1);
            this.gbSpecificProducts.Enabled = false;
            this.gbSpecificProducts.Location = new System.Drawing.Point(201, 121);
            this.gbSpecificProducts.Name = "gbSpecificProducts";
            this.gbSpecificProducts.Size = new System.Drawing.Size(425, 90);
            this.gbSpecificProducts.TabIndex = 12;
            this.gbSpecificProducts.TabStop = false;
            this.gbSpecificProducts.Text = "Productos especificos";
            // 
            // cbRNameProduct
            // 
            this.cbRNameProduct.FormattingEnabled = true;
            this.cbRNameProduct.Location = new System.Drawing.Point(222, 50);
            this.cbRNameProduct.Name = "cbRNameProduct";
            this.cbRNameProduct.Size = new System.Drawing.Size(182, 21);
            this.cbRNameProduct.TabIndex = 3;
            this.cbRNameProduct.SelectedIndexChanged += new System.EventHandler(this.cbRNameProduct_SelectedIndexChanged);
            this.cbRNameProduct.TextUpdate += new System.EventHandler(this.cbRNameProduct_TextUpdate);
            this.cbRNameProduct.TextChanged += new System.EventHandler(this.cbRNameProduct_TextChanged);
            // 
            // txtRIdProduct
            // 
            this.txtRIdProduct.Location = new System.Drawing.Point(15, 50);
            this.txtRIdProduct.Name = "txtRIdProduct";
            this.txtRIdProduct.Size = new System.Drawing.Size(189, 20);
            this.txtRIdProduct.TabIndex = 2;
            this.txtRIdProduct.TextChanged += new System.EventHandler(this.txtRIdProduct_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID producto";
            // 
            // gbFinallyDate
            // 
            this.gbFinallyDate.Controls.Add(this.dtpDateF);
            this.gbFinallyDate.Controls.Add(this.rbYearF);
            this.gbFinallyDate.Controls.Add(this.rbMonthF);
            this.gbFinallyDate.Controls.Add(this.rbDayF);
            this.gbFinallyDate.Enabled = false;
            this.gbFinallyDate.Location = new System.Drawing.Point(417, 19);
            this.gbFinallyDate.Name = "gbFinallyDate";
            this.gbFinallyDate.Size = new System.Drawing.Size(210, 91);
            this.gbFinallyDate.TabIndex = 11;
            this.gbFinallyDate.TabStop = false;
            this.gbFinallyDate.Text = "Fecha Final";
            // 
            // dtpDateF
            // 
            this.dtpDateF.Location = new System.Drawing.Point(6, 57);
            this.dtpDateF.Name = "dtpDateF";
            this.dtpDateF.Size = new System.Drawing.Size(198, 20);
            this.dtpDateF.TabIndex = 3;
            this.dtpDateF.Value = new System.DateTime(2018, 4, 30, 23, 12, 48, 0);
            // 
            // rbYearF
            // 
            this.rbYearF.AutoSize = true;
            this.rbYearF.Location = new System.Drawing.Point(144, 19);
            this.rbYearF.Name = "rbYearF";
            this.rbYearF.Size = new System.Drawing.Size(44, 17);
            this.rbYearF.TabIndex = 2;
            this.rbYearF.TabStop = true;
            this.rbYearF.Text = "Año";
            this.rbYearF.UseVisualStyleBackColor = true;
            this.rbYearF.CheckedChanged += new System.EventHandler(this.rbYearF_CheckedChanged);
            // 
            // rbMonthF
            // 
            this.rbMonthF.AutoSize = true;
            this.rbMonthF.Location = new System.Drawing.Point(75, 19);
            this.rbMonthF.Name = "rbMonthF";
            this.rbMonthF.Size = new System.Drawing.Size(45, 17);
            this.rbMonthF.TabIndex = 1;
            this.rbMonthF.TabStop = true;
            this.rbMonthF.Text = "Mes";
            this.rbMonthF.UseVisualStyleBackColor = true;
            this.rbMonthF.CheckedChanged += new System.EventHandler(this.rbMonthF_CheckedChanged);
            // 
            // rbDayF
            // 
            this.rbDayF.AutoSize = true;
            this.rbDayF.Location = new System.Drawing.Point(6, 19);
            this.rbDayF.Name = "rbDayF";
            this.rbDayF.Size = new System.Drawing.Size(41, 17);
            this.rbDayF.TabIndex = 0;
            this.rbDayF.TabStop = true;
            this.rbDayF.Text = "Dia";
            this.rbDayF.UseVisualStyleBackColor = true;
            this.rbDayF.CheckedChanged += new System.EventHandler(this.rbDayF_CheckedChanged);
            // 
            // gbStartDate
            // 
            this.gbStartDate.Controls.Add(this.dTPDate);
            this.gbStartDate.Controls.Add(this.rBYear);
            this.gbStartDate.Controls.Add(this.rBMonth);
            this.gbStartDate.Controls.Add(this.rBDay);
            this.gbStartDate.Enabled = false;
            this.gbStartDate.Location = new System.Drawing.Point(201, 19);
            this.gbStartDate.Name = "gbStartDate";
            this.gbStartDate.Size = new System.Drawing.Size(210, 91);
            this.gbStartDate.TabIndex = 10;
            this.gbStartDate.TabStop = false;
            this.gbStartDate.Text = "Fecha inicial";
            // 
            // dTPDate
            // 
            this.dTPDate.Location = new System.Drawing.Point(6, 57);
            this.dTPDate.Name = "dTPDate";
            this.dTPDate.Size = new System.Drawing.Size(198, 20);
            this.dTPDate.TabIndex = 3;
            this.dTPDate.Value = new System.DateTime(2018, 4, 30, 23, 12, 48, 0);
            // 
            // rBYear
            // 
            this.rBYear.AutoSize = true;
            this.rBYear.Location = new System.Drawing.Point(144, 19);
            this.rBYear.Name = "rBYear";
            this.rBYear.Size = new System.Drawing.Size(44, 17);
            this.rBYear.TabIndex = 2;
            this.rBYear.TabStop = true;
            this.rBYear.Text = "Año";
            this.rBYear.UseVisualStyleBackColor = true;
            this.rBYear.CheckedChanged += new System.EventHandler(this.rBYear_CheckedChanged);
            // 
            // rBMonth
            // 
            this.rBMonth.AutoSize = true;
            this.rBMonth.Location = new System.Drawing.Point(75, 19);
            this.rBMonth.Name = "rBMonth";
            this.rBMonth.Size = new System.Drawing.Size(45, 17);
            this.rBMonth.TabIndex = 1;
            this.rBMonth.TabStop = true;
            this.rBMonth.Text = "Mes";
            this.rBMonth.UseVisualStyleBackColor = true;
            this.rBMonth.CheckedChanged += new System.EventHandler(this.rBMonth_CheckedChanged);
            // 
            // rBDay
            // 
            this.rBDay.AutoSize = true;
            this.rBDay.Location = new System.Drawing.Point(6, 19);
            this.rBDay.Name = "rBDay";
            this.rBDay.Size = new System.Drawing.Size(41, 17);
            this.rBDay.TabIndex = 0;
            this.rBDay.TabStop = true;
            this.rBDay.Text = "Dia";
            this.rBDay.UseVisualStyleBackColor = true;
            this.rBDay.CheckedChanged += new System.EventHandler(this.rBDay_CheckedChanged);
            // 
            // btnCreateReports
            // 
            this.btnCreateReports.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateReports.BackgroundImage = global::UsePassword.Properties.Resources.Reporte_Mensual;
            this.btnCreateReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateReports.Location = new System.Drawing.Point(54, 157);
            this.btnCreateReports.Name = "btnCreateReports";
            this.btnCreateReports.Size = new System.Drawing.Size(77, 76);
            this.btnCreateReports.TabIndex = 9;
            this.btnCreateReports.UseVisualStyleBackColor = false;
            this.btnCreateReports.Click += new System.EventHandler(this.btnCreateReports_Click);
            // 
            // FormObtenerReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UsePassword.Properties.Resources.menufondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 486);
            this.Controls.Add(this.gBReports);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormObtenerReportes";
            this.gBReports.ResumeLayout(false);
            this.GbProByPro.ResumeLayout(false);
            this.GbProByPro.PerformLayout();
            this.gbSpecificProducts.ResumeLayout(false);
            this.gbSpecificProducts.PerformLayout();
            this.gbFinallyDate.ResumeLayout(false);
            this.gbFinallyDate.PerformLayout();
            this.gbStartDate.ResumeLayout(false);
            this.gbStartDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBOptions;
        private System.Windows.Forms.GroupBox gBReports;
        private System.Windows.Forms.GroupBox gbStartDate;
        private System.Windows.Forms.RadioButton rBYear;
        private System.Windows.Forms.RadioButton rBMonth;
        private System.Windows.Forms.RadioButton rBDay;
        private System.Windows.Forms.Button btnCreateReports;
        private System.Windows.Forms.DateTimePicker dTPDate;
        private System.Windows.Forms.GroupBox gbFinallyDate;
        private System.Windows.Forms.DateTimePicker dtpDateF;
        private System.Windows.Forms.RadioButton rbYearF;
        private System.Windows.Forms.RadioButton rbMonthF;
        private System.Windows.Forms.RadioButton rbDayF;
        private System.Windows.Forms.GroupBox gbSpecificProducts;
        private System.Windows.Forms.ComboBox cbRNameProduct;
        private System.Windows.Forms.TextBox txtRIdProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbProByPro;
        private System.Windows.Forms.ComboBox cbNameProveedor;
        private System.Windows.Forms.TextBox txtRIdProvider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}