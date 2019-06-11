using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using UsePassword.Librerias;

namespace UsePassword
{
    public partial class FormObtenerReportes : Form
    {
        private int MValX, MValY;
        private bool TogMove;
        ViewRepot repot = new ViewRepot();
        SqlDataAdapter da;
        DataTable dt;
        private SqlCommand cmd;


        public enum ReportType
        {
            Empleado,
            Clientes,
            Proveedores,
            Producto,
            Venta,
            Compra,
            VentaXProducto,
            VentaXFecha,
            CompraXProducto,
            CompraXFecha,
            ProductosXProveedor
        }

        public FormObtenerReportes()
        {
            InitializeComponent();
            dTPDate.Value = DateTime.Today;
            dtpDateF.Value = DateTime.Today;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormMenu mn = new FormMenu();
            mn.Show();
            this.Close();
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void label4_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = false;
        }

        private void cBOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cBOptions.SelectedIndex)
            {
                case (int)ReportType.VentaXFecha:
                    GbDate(true);
                    GbSpecific(false);
                    GbByProvider(false);
                    break;
                case (int)ReportType.CompraXFecha:
                    GbDate(true);
                    GbSpecific(false);
                    GbByProvider(false);
                    break;
                case (int)ReportType.VentaXProducto:
                    GbSpecific(true);
                    GbDate(false);
                    GbByProvider(false);
                    break;
                case (int)ReportType.CompraXProducto:
                    GbSpecific(true);
                    GbDate(false);
                    GbByProvider(false);
                    break;
                case (int)ReportType.ProductosXProveedor:
                    GbDate(false);
                    GbSpecific(false);
                    GbByProvider(true);
                    break;
                default:
                    dTPDate.Format = DateTimePickerFormat.Long;
                    GbSpecific(false);
                    GbDate(false);
                    GbByProvider(false);
                    break;
            }
            rBDay.Checked = rBMonth.Checked = rBYear.Checked = false;
        }

        private void GbDate(bool ok)
        {
            gbStartDate.Enabled = ok;
            gbFinallyDate.Enabled = ok;
        }

        private void GbSpecific(bool ok)
        {
            gbSpecificProducts.Enabled = ok;
        }

        private void GbByProvider(bool ok)
        {
            GbProByPro.Enabled = ok;
        }

        private void rBDay_CheckedChanged(object sender, EventArgs e)
        {
            FormatToDate("dd/MM/yyyy");
        }

        private void rBMonth_CheckedChanged(object sender, EventArgs e)
        {
            FormatToDate("MM/yyyy");
        }

        private void rBYear_CheckedChanged(object sender, EventArgs e)
        {
            FormatToDate("yyyy");
        }

        private void rbDayF_CheckedChanged(object sender, EventArgs e)
        {
            FormatToDateF("dd/MM/yyyy");
        }

        private void rbMonthF_CheckedChanged(object sender, EventArgs e)
        {
            FormatToDateF("MM/yyyy");
        }

        private void rbYearF_CheckedChanged(object sender, EventArgs e)
        {
            FormatToDateF("yyyy");
        }

        private void FormatToDate(string format)
        {
            try
            {
                dTPDate.CustomFormat = format;
                dTPDate.Format = DateTimePickerFormat.Custom;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void FormatToDateF(string format)
        {
            try
            {
                dtpDateF.CustomFormat = format;
                dtpDateF.Format = DateTimePickerFormat.Custom;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnCreateReports_Click(object sender, EventArgs e)
        {
            switch (cBOptions.SelectedIndex)
            {
                case (int)ReportType.Empleado:
                    string[] arrTitle0 = { "Id", "Calle", "Colonia", "Numero", "Nombre", "AP", "AM", "Edad", "Fecha de Ingreso", "Telefono" };
                    ConsultAnywhare("Empleado","Datos de los empleados",arrTitle0);
                    break;
                case (int)ReportType.Clientes:
                    string[] arrTitle1 = { "Id","Nombre","AP","AM","calle","Colonia","Numero","Telefono","Fecha de Registro" };
                    ConsultAnywhare("Clientes", "Datos de los clientes", arrTitle1);
                    break;
                case (int)ReportType.Proveedores:
                    string[] arrTitle2 = { "Id","Nombre","Telefono","Direccion" };
                    ConsultAnywhare("Proveedor", "Datos de los proveedores", arrTitle2);
                    break;
                case (int)ReportType.Producto:
                    string[] arrTitle3 = { "Id Producto","Nomvre","Tipo","Stock Maximo","Stock Minimo","Id Proveedor","Exixtencia","Precio proveedor","Precio Tienda"};
                    ConsultAnywhare("Producto", "Datos de los productos", arrTitle3);
                    break;
                case (int)ReportType.Venta:
                    string[] arrTitle4 = { "Id Venta","Fecha","Total" };
                    ConsultAnywhare("Venta", "Datos de las ventas", arrTitle4);
                    break;
                case (int)ReportType.Compra:
                    string[] arrTitle5 = { "Id Compra","Id Proveedor","Fecha","Precio" };
                    ConsultAnywhare("Compra", "Datos de las compras", arrTitle5);
                    break;
                case (int)ReportType.VentaXProducto:
                    string[] arrTitle6 = { "Id Venta","Id Producto","Nombre","Cantidad","Precio Tienda","Precio Total"};
                    ConsultSpecific("Datos_venta", "Datos de venta por producto", txtRIdProduct.Text, arrTitle6);
                    break;
                case (int)ReportType.CompraXProducto:
                    string[] arrTitle7 = { "Id Compra","Id Producto","Nombre","Cantidad","Precio Proveedor","Precio Tienda","Importe Total"};
                    ConsultSpecific("Datos_Compra", "Datos de compra por producto", txtRIdProduct.Text, arrTitle7);
                    break;
                case (int)ReportType.VentaXFecha:
                    string[] arrTitle8 = { "Id Venta", "Fecha", "Total" };
                    ConsultByDate("SaleByDate", "Ventas por fecha", arrTitle8);
                    break;
                case (int)ReportType.CompraXFecha:
                    string[] arrTitle9 = { "Id","Nombre del proveedor","Fecha","Precio" };
                    ConsultByDate("BuyByDate", "Compras por fecha", arrTitle9);
                    break;
                case (int)ReportType.ProductosXProveedor:
                    string[] arrTitle10 = { "Id Producto", "Nombre", "Tipo", "Stock Maximo", "Stock Minimo", "Id Proveedor", "Exixtencia", "Precio proveedor", "Precio Tienda" };
                    ConsultProductByProvider("Producto", "Productos por proveedor", txtRIdProvider.Text, arrTitle10);
                    break;
                default:
                    MessageBox.Show("Necesitas seleccionar una opcion de reporte", "Esto no puede ser posible", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private void ConsultAnywhare(string table, string NameOf, string[] arrTitle)
        {
            try
            {
                da = new SqlDataAdapter("select * from " + table, new Conexion().con);
                dt = new DataTable();
                da.Fill(dt);

                repot.CreateBasicReport(dt, NameOf, arrTitle);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo paso :(", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ConsultSpecific(string table, string NameOf, string IdProduct, string[] arrTitle)
        {
            try
            {
                if (IdProduct != string.Empty)
                {
                    da = new SqlDataAdapter("select * from " + table + " where id_producto = " + IdProduct, new Conexion().con);
                    dt = new DataTable();
                    da.Fill(dt);

                    repot.CreateBasicReport(dt, NameOf, arrTitle);
                }
                else
                {
                    MessageBox.Show("Ingrese un id :(","Que mal",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo paso :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultProductByProvider(string table, string NameOf, string IdProvider, string[] arrTitle)
        {
            try
            {
                if (IdProvider != string.Empty)
                {
                    da = new SqlDataAdapter("select * from " + table + " where id_proveedor = " + IdProvider, new Conexion().con);
                    dt = new DataTable();
                    da.Fill(dt);

                    repot.CreateBasicReport(dt, NameOf, arrTitle);
                }
                else
                {
                    MessageBox.Show("Ingrese un id :(", "Que mal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo paso :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRIdProduct_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRIdProduct.Text) && this.txtRIdProduct.Focused )
            {
                try
                {
                    cmd = new SqlCommand("exec consultarProducto " + txtRIdProduct.Text, new Conexion().con);

                    SqlDataReader consu = cmd.ExecuteReader();
                    if (consu.Read() == true)
                    {
                        cbRNameProduct.Text = consu["Nombre_P"].ToString();
                    }
                    else
                    {
                        cbRNameProduct.Text = string.Empty;
                    }
                    consu.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al consultar");
                }
            }
        }

        private void cbRNameProduct_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbRNameProduct.Text) && this.cbRNameProduct.Focused)
            {
                if (cbRNameProduct.SelectedIndex != -1)
                {
                    cbRNameProduct.SelectedIndex = cbRNameProduct.SelectedIndex;
                }
            }
        }

        private void cbRNameProduct_TextUpdate(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbRNameProduct.Text) && this.cbRNameProduct.Focused)
            {
                try
                {
                    da = new SqlDataAdapter("exec consultarProductoByName '" + cbRNameProduct.Text + "'", new Conexion().con);
                    dt = new DataTable();
                    da.Fill(dt);
                    cbRNameProduct.Items.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        foreach (DataColumn dc in dt.Columns)
                        {
                            cbRNameProduct.Items.Add(dr[dc.ColumnName].ToString());
                        }
                    }
                    cbRNameProduct.DroppedDown = true;
                    cbRNameProduct.Select(cbRNameProduct.Text.Length, 0);
                    //cbName.SelectionStart = cbName.Text.Length;
                    //cbName.SelectAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al consultar");
                }
            }
        }

        private void cbRNameProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRNameProduct.Focused)
            {
                try
                {
                    cmd = new SqlCommand("exec consultAllProductByName '" + cbRNameProduct.Text + "'", new Conexion().con);

                    SqlDataReader consu1 = cmd.ExecuteReader();
                    if (consu1.Read() == true)
                    {
                        txtRIdProduct.Text = consu1["id_producto"].ToString();
                    }
                    else
                    {
                        txtRIdProduct.Text = string.Empty;
                    }
                    consu1.Close();
                    cbRNameProduct.Select(cbRNameProduct.Text.Length, 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al consultar");
                }
            }
        }

        private void txtRIdProvider_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRIdProvider.Text) && this.txtRIdProvider.Focused)
            {
                try
                {
                    cmd = new SqlCommand("exec consultarProveedor " + txtRIdProvider.Text, new Conexion().con);

                    SqlDataReader consu = cmd.ExecuteReader();
                    if (consu.Read() == true)
                    {
                        cbNameProveedor.Text = consu["Nombre_pro"].ToString();
                    }
                    else
                    {
                        cbNameProveedor.Text = string.Empty;
                    }
                    consu.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al consultar");
                }
            }
        }

        private void cbNameProveedor_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbNameProveedor.Text) && this.cbNameProveedor.Focused)
            {
                if (cbNameProveedor.SelectedIndex != -1)
                {
                    cbNameProveedor.SelectedIndex = cbNameProveedor.SelectedIndex;
                }
            }
        }

        private void cbNameProveedor_TextUpdate(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbNameProveedor.Text) && this.cbNameProveedor.Focused)
            {
                try
                {
                    da = new SqlDataAdapter("exec ConsultarNombrePro2 '" + cbNameProveedor.Text + "'", new Conexion().con);
                    dt = new DataTable();
                    da.Fill(dt);
                    cbNameProveedor.Items.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        foreach (DataColumn dc in dt.Columns)
                        {
                            cbNameProveedor.Items.Add(dr[dc.ColumnName].ToString());
                        }
                    }
                    cbNameProveedor.DroppedDown = true;
                    cbNameProveedor.Select(cbNameProveedor.Text.Length, 0);
                    //cbName.SelectionStart = cbName.Text.Length;
                    //cbName.SelectAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al consultar");
                }
            }
        }

        private void cbNameProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNameProveedor.Focused)
            {
                try
                {
                    cmd = new SqlCommand("exec ConsultarNombrePro '" + cbNameProveedor.Text + "'", new Conexion().con);

                    SqlDataReader consu1 = cmd.ExecuteReader();
                    if (consu1.Read() == true)
                    {
                        txtRIdProvider.Text = consu1["id_proveedor"].ToString();
                    }
                    else
                    {
                        txtRIdProvider.Text = string.Empty;
                    }
                    consu1.Close();
                    cbNameProveedor.Select(cbNameProveedor.Text.Length, 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al consultar");
                }
            }
        }

        private void ConsultByDate(string NameProcedure,string NameOf, string[] arrTitle)
        {
            try
            {
                if (rBDay.Checked || rBMonth.Checked || rBYear.Checked)
                {
                    da = new SqlDataAdapter(NameProcedure, new Conexion().con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.Add("@StartDate", SqlDbType.VarChar).Value = "%" + dTPDate.Text;
                    da.SelectCommand.Parameters.Add("@FinalDate", SqlDbType.VarChar).Value = "%" + dtpDateF.Text;
                    dt = new DataTable();
                    da.Fill(dt);

                    repot.CreateBasicReport(dt, NameOf, arrTitle);
                }
                else
                {
                    MessageBox.Show("Necesitas seleccionar El dia o El mes o El año","Que Barbaridad", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo paso :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
