using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace UsePassword
{
    public partial class FormRegistrarCompra : Form
    {

        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;
        public double Total_importe, Do_precio,Do_cantidad, importe_final;
        public double venta, precio_V;        
        public int Ban=0,index, cantidad_total;
        public static String S_codigo, S_nombre, S_surtido, S_importe_total,S_precio,S_precio_venta;

        int MValX, MValY;
        bool TogMove;

        public FormRegistrarCompra()
        {
            InitializeComponent();
            
            //NO MUESTRA EL CAMPO PARA CONSULTA
            txtconsulta.Visible = false;
        }

        private void btSalirCompra_Click(object sender, EventArgs e)
        {
            FormMenuEmpleado ME = new FormMenuEmpleado();
            ME.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormRegistrarCompra_Load(object sender, EventArgs e)
        {

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void btAgregarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT IDENT_CURRENT ('Compra');", new Conexion().con);          
                    txtfolio.Text = Convert.ToString((Convert.ToInt32(cmd.ExecuteScalar()) + 1));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            txtproovedor.Enabled = true;          
            btGuardarCompra.Enabled = true;
            btCancelarCompra.Enabled = true;
            agregar.Enabled = true;
            editar.Enabled = true;
            Quitar.Enabled = true;
            btBuscarCompra.Enabled = false;
            btAgregarCompra.Enabled = false;


        }


        private void Agregar()
        {
            try
            {
                
                cmd = new SqlCommand("Execute insertarCompra '" + txtproovedor.Text + "','" + fecha.Value.ToString("dd/MM/yyyy") + "','" + txttotal_imp.Text + "'", new Conexion().con);
                cmd.ExecuteNonQuery();

                for (int fila = 0; fila <= Cuadro_Compras.Rows.Count - 1; fila++)
                {
                    string codigo = Cuadro_Compras.Rows[fila].Cells[0].Value.ToString();
                    string nombre = Cuadro_Compras.Rows[fila].Cells[1].Value.ToString();
                    string surtido = Cuadro_Compras.Rows[fila].Cells[2].Value.ToString();
                    string precio = Cuadro_Compras.Rows[fila].Cells[3].Value.ToString();
                    string precio_venta = Cuadro_Compras.Rows[fila].Cells[4].Value.ToString();
                    String total_importe_surtido = Cuadro_Compras.Rows[fila].Cells[5].Value.ToString();
                    int surtido1 = Convert.ToInt32(surtido);                   
                    int total_surtido = 0;
                    String cantidad_producto;      
                    cmd = new SqlCommand("Execute insertarDatos_Compra '" + txtfolio.Text + "','" + codigo + "','" + nombre + "','" + surtido + "','"+ precio +"','" + precio_venta + "','"   + total_importe_surtido + "'", new Conexion().con);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("select Cantidad_P from Producto where id_producto = '" + codigo + "'", new Conexion().con);
                    SqlDataReader consu = cmd.ExecuteReader();
                    if (consu.Read() == true)
                    {
                        cantidad_producto = consu["Cantidad_P"].ToString();
                        total_surtido = (surtido1 + (Convert.ToInt32(cantidad_producto)));
                    }
                    consu.Close();

                    cmd = new SqlCommand("Execute actualizarinventario '" + codigo + "'," + total_surtido + ",'" + precio + "','" + precio_venta + "'", new Conexion().con);
                    cmd.ExecuteNonQuery();


                }

                MessageBox.Show("Compra realizada.");                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void btGuardarCompra_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txttotal_uni.Text) != 0)
            {
                Agregar();
                Cuadro_Compras.Rows.Clear();
                desativar();
                limpiar();
                txttotal_uni.Text = "0";
                txttotal_imp.Text = "0";

            }
            else {
                MessageBox.Show("Favor de al menos tener productos registrados.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = false;
        }

        private void btCancelarCompra_Click(object sender, EventArgs e)
        {
            if (Ban == 0 || Ban==4)
            {
                if (Ban == 0)
                {
                    txtfolio.Text = "";                   
                    Cuadro_Compras.Rows.Clear();
                    desativar();
                    limpiar();
                    txttotal_uni.Text = "0";
                    txttotal_imp.Text = "0";
                }
                else {
                    txtfolio.Text = "";
                    Cuadro_Compras.DataSource = null;
                    ocultar(true);
                    desativar();
                    limpiar();
                    txttotal_uni.Text = "0";
                    txttotal_imp.Text = "0";
                    Ban = 0;
                }
                
            }
            else if (Ban == 1) {
                txtmercancia.Enabled = true;
                editar.Enabled = true;
                Quitar.Enabled = true;
                btGuardarCompra.Enabled = true;
                limpiar_agregar();
                Ban = 0;
            }
        }

        private void btBuscarCompra_Click(object sender, EventArgs e)
        {
            txtconsulta.Visible = true;
            txtfolio.Visible = false;
            btAgregarCompra.Enabled = false;
            btBuscarCompra.Enabled = false;
            btGuardarCompra.Enabled = false;
            btCancelarCompra.Enabled = true;
            Ban = 4;
            txtconsulta.Text = "";
            txtconsulta.Focus();

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            FormMenuEmpleado MEM = new FormMenuEmpleado();

            if (btCancelarCompra.Enabled == true)
            {
                MessageBox.Show("Usted no ha finalizado la consulta o no ha terminado la compra.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
            MEM.Show();
            this.Close();
            }
        }

        private void txtconsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtconsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) {
                try
                {
                    cmd = new SqlCommand("exec consultarCompra " + txtconsulta.Text, new Conexion().con);
                    SqlDataReader consu = cmd.ExecuteReader();
                    if (consu.Read() == true)
                    {
                        txtproovedor.Text = consu["id_proveedor"].ToString();
                        txttotal_imp.Text = consu["Precio_total"].ToString();
                        fecha.Text = consu["Fecha_compra"].ToString();

                    }
                    else
                    {
                        limpiar();
                    }

                    consu.Close();

                    cmd = new SqlCommand("exec consultarProveedor " + txtproovedor.Text, new Conexion().con);
                    SqlDataReader consuproveedor = cmd.ExecuteReader();
                    if (consuproveedor.Read() == true)
                    {
                        Des_proveedor.Text = consuproveedor["Nombre_pro"].ToString();

                    }
                    consuproveedor.Close();

                    da = new SqlDataAdapter("select Datos_Compra.id_producto, Datos_Compra.Nombre_P, Datos_Compra.Cantidad_p, Datos_Compra.importe_total from Datos_Compra where id_Compra=" + txtconsulta.Text, new Conexion().con);
                    dt = new DataTable();
                    da.Fill(dt);
                    ocultar(false);
                    Cuadro_Compras.DataSource = dt;
                    calcularconsulta();

                }
                catch (Exception ex)
            {
                    MessageBox.Show("No se encuentra Compra.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtproovedor.Text = "";
                    Des_proveedor.Text = "";
                    ocultar(true);
                    txtconsulta.SelectAll();
                }
            }





            //Validacion para puro Numero
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtproovedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter || (int)e.KeyChar== (int)Keys.Tab)
            {
                try
                {
                    cmd = new SqlCommand("select * from Proveedor where id_proveedor=" + txtproovedor.Text, new Conexion().con);
                    SqlDataReader consu = cmd.ExecuteReader();
                    if (consu.Read() == true)
                    {
                        Des_proveedor.Text = consu["Nombre_pro"].ToString();
                        txtproovedor.Enabled = false;
                        txtmercancia.Enabled = true;
                        txtmercancia.Focus();

                    }
                    else {
                        MessageBox.Show("No se encuentra Proveedor.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtproovedor.SelectAll();
                    }
                    consu.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }

            }
            
                

            

            //Validacion para puro Numero
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtmercancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtmercancia.Text=="")
                {
                    FormRealizarConsultas ConsultaProducto = new FormRealizarConsultas();
                    ConsultaProducto.ban = 1;
                    ConsultaProducto.id_foraneo = txtproovedor.Text;
                    ConsultaProducto.Show();

                }

                else { 
                try
                {
                    cmd = new SqlCommand("select Nombre_P from Producto where (producto.id_producto=" + txtmercancia.Text + ") AND (Producto.id_proveedor=" + txtproovedor.Text+ ")", new Conexion().con);


                    SqlDataReader consu = cmd.ExecuteReader();
                    if (consu.Read() == true)
                    {
                        Des_Mercancia.Text = consu["Nombre_P"].ToString();
                        SendKeys.Send("{TAB}");
                        txtcantidad.Enabled = true;
                        txtcantidad.Text = "1";                        
                        txtcantidad.SelectionStart = 0;
                        txtcantidad.SelectionLength = txtcantidad.Text.Length;
                    }
                    else {
                        MessageBox.Show("No se encuentra Producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Des_Mercancia.Text = "";
                        txtcantidad.Enabled = false;
                        txtcantidad.Text = "";
                        txtprecio.Text = "";
                        txtmercancia.SelectAll();
                        }
                    consu.Close();
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                }
            }


            //Validacion para puro Numero
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtcantidad.Text == "" || txtcantidad.Text == "0")
                {
                    MessageBox.Show("Debe almenos haber un producto para la compra.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcantidad.Text = "1";
                    txtcantidad.SelectionStart = 0;
                    txtcantidad.SelectionLength = txtcantidad.Text.Length;

                }

                else {
                    txtprecio.Text = "0";
                    txtprecio.Enabled = true;
                    SendKeys.Send("{TAB}");
                }
            }



                //Validacion para puro Numero
                if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {

        }
        //METODO PARA DESACTIVAR TEXTBOX Y BOTONES
        public void desativar() {
            txtproovedor.Enabled = false;
            txtmercancia.Enabled = false;
            txtcantidad.Enabled = false;
            btGuardarCompra.Enabled = false;
            btCancelarCompra.Enabled = false;
            agregar.Enabled = false;
            editar.Enabled = false;
            Quitar.Enabled = false;
            btBuscarCompra.Enabled = true;
            btAgregarCompra.Enabled = true;
            txtconsulta.Visible = false;
            txtfolio.Visible = true;
        }

        private void txtproovedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btModificarCompra_Click(object sender, EventArgs e)
        {

        }

        private void txtconsulta_TextChanged_1(object sender, EventArgs e)
        {
          
        }

        private void txtconsulta_KeyUp(object sender, KeyEventArgs e)
        {

        }
       
        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtprecio.Text == "" ||Convert.ToDouble(txtprecio.Text) == 0)
                {
                    MessageBox.Show("debe al menos costar algo el producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtprecio.Text = "0";
                    txtprecio.SelectAll();
                }

                else
                {
                    Do_cantidad = Convert.ToDouble(txtcantidad.Text);
                    txtprecio.Text = txtprecio.Text.Replace(".", ",");
                    Do_precio = Convert.ToDouble(txtprecio.Text);
                    precio_V = Do_precio + (Do_precio * 0.25);
                    
                    Total_importe = (Do_cantidad * Do_precio);
                    txtPrecio_total.Text = Convert.ToString(Total_importe).Replace(",", ".");
                   
                    SendKeys.Send("{TAB}");
                }
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtprecio.Text.Length; i++)
            {
                if (txtprecio.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
            
        }

      
        private void txtcantidad_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cuadro_Compras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) {

            }
            else
            {
                if (Ban == 0)
                {
                    index = e.RowIndex;
                    S_codigo = Cuadro_Compras.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                    S_nombre = Cuadro_Compras.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    S_surtido = Cuadro_Compras.Rows[e.RowIndex].Cells["Surtido"].Value.ToString();
                    S_importe_total = Cuadro_Compras.Rows[e.RowIndex].Cells["Importe_Total_C"].Value.ToString();
                    S_precio = Cuadro_Compras.Rows[e.RowIndex].Cells["Precio"].Value.ToString();
                }
                else {

                }
            }            
            
        }

        private void Quitar_Click(object sender, EventArgs e)
        {
            if (S_codigo == "" || S_codigo == null)
            {
                MessageBox.Show("Seleccione una fila.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                Cuadro_Compras.Rows.RemoveAt(index);
                calcular();
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (S_codigo == ""||S_codigo==null)
            {
                MessageBox.Show("Seleccione una fila.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else {
                
                        txtmercancia.Text = S_codigo;
                        Des_Mercancia.Text = S_nombre;
                        txtcantidad.Text = S_surtido;
                        txtPrecio_total.Text = S_importe_total;
                        txtprecio.Text = S_precio;
                        txtcantidad.Focus();
                        Ban = 1;
                        editar.Enabled = false;
                        Quitar.Enabled = false;
                        txtmercancia.Enabled = false;
                        btGuardarCompra.Enabled = false;
                        txtcantidad.Enabled = true;
                        txtprecio.Enabled = true;
                txtcantidad.Focus();

            }
                   

                

        }

        

        private void Cuadro_Compras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtmercancia_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (Ban ==0) { 
                if (txtmercancia.Text == "" || Des_Mercancia.Text == "" || txtcantidad.Text == "" || txtPrecio_total.Text == "") {
                MessageBox.Show("Favor de rellenar datos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Ban = 3;
                }
                else{
                    for (int fila = 0; fila <= Cuadro_Compras.Rows.Count - 1; fila++)
                        {                   
                        string valor = Cuadro_Compras.Rows[fila].Cells[0].Value.ToString();

                        if (txtmercancia.Text==valor) {
                            Ban = 2;
                        }

                    }

                }
            }
            if (Ban == 0)
            {
                Cuadro_Compras.Rows.Add(txtmercancia.Text, Des_Mercancia.Text, txtcantidad.Text,txtprecio.Text.Replace(",", "."), Convert.ToString(precio_V).Replace(",", "."), txtPrecio_total.Text.Replace(",", "."));
                calcular();
                limpiar_agregar();
                txtprecio.Enabled = false;
                txtcantidad.Enabled = false;
                txtmercancia.Focus();
            }
            else if (Ban == 1) {
                if (Convert.ToDouble(S_importe_total) != (Convert.ToDouble(txtPrecio_total.Text))) {
                    precio_V = Convert.ToDouble(txtprecio.Text)+ (Convert.ToDouble(txtprecio.Text) * 0.25);
                    String precio_v = Convert.ToString(precio_V);
                    precio_v=precio_v.Replace(",", ".");
                    Cuadro_Compras.Rows[index].Cells["Surtido"].Value = txtcantidad.Text;
                    Cuadro_Compras.Rows[index].Cells["Precio"].Value = txtprecio.Text.Replace(",", ".");
                    Cuadro_Compras.Rows[index].Cells["Importe_Total_C"].Value = txtPrecio_total.Text;
                    Cuadro_Compras.Rows[index].Cells["Precioventa"].Value = precio_v;

                    Ban = 0;
                    editar.Enabled = true;
                    Quitar.Enabled = true;
                    txtmercancia.Enabled = true;
                    btGuardarCompra.Enabled = true;
                    calcular();
                    limpiar_agregar();
                    txtprecio.Enabled = false;
                    txtcantidad.Enabled = false;
                    txtmercancia.Focus();
                }
                else {
                    MessageBox.Show("Favor de ejecutar enter en el cuadro de Cantidad.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcantidad.Focus();
                }
            }
            
            else if (Ban == 2)
            {
                MessageBox.Show("Ya existe una compra con este producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcantidad.Enabled = false;
                txtprecio.Enabled = false;
                limpiar_agregar();
                Ban = 0;
                txtmercancia.Focus();
            }
            else if (Ban==3) {
                Ban = 0;    
            }
        }

        //METODO PARA LIMPIAR TEXTBOX
        public void limpiar_agregar()
        {
            txtcantidad.Text = "";
            txtmercancia.Text = "";
            txtprecio.Text = "";
            txtPrecio_total.Text = "";
             Des_Mercancia.Text = "";            
        }

        public void limpiar()
        {
            txtcantidad.Text = "";
            txtproovedor.Text = "";
            txtmercancia.Text = "";
            txtprecio.Text = "";
            txtprecio.Text = "";
            txtPrecio_total.Text = "";
            Des_proveedor.Text = "";
            Des_Mercancia.Text = "";
            txttotal_imp.Text = "";
            txttotal_uni.Text = "";
        }

       
        public void ocultar(bool a) {
            Cuadro_Compras.Columns["Codigo"].Visible = a;
            Cuadro_Compras.Columns["Nombre"].Visible = a;
            Cuadro_Compras.Columns["Surtido"].Visible = a;
            Cuadro_Compras.Columns["Precio"].Visible = a;
            Cuadro_Compras.Columns["Precioventa"].Visible = a;
            Cuadro_Compras.Columns["Importe_Total_C"].Visible = a;                                  
        }

        public void calcularconsulta()
        {
            cantidad_total = 0;      
            for (int fila = 0; fila <= Cuadro_Compras.Rows.Count - 1; fila++)
            {              
                int valor = Convert.ToInt32(Cuadro_Compras.Rows[fila].Cells[2].Value);
                cantidad_total += valor;               
            }
            txttotal_uni.Text = Convert.ToString(cantidad_total);
        }

        public void calcular()
        {
            cantidad_total = 0;
            importe_final = 0;            
            for (int fila = 0; fila <= Cuadro_Compras.Rows.Count - 1; fila++)
            {
               String valor2 = Convert.ToString(Cuadro_Compras.Rows[fila].Cells[5].Value);
                valor2=valor2.Replace(".", ",");
                double valor1 = Convert.ToDouble(valor2);
                int valor = Convert.ToInt32(Cuadro_Compras.Rows[fila].Cells[2].Value);
                cantidad_total += valor;
                importe_final += valor1;
            }
            txttotal_uni.Text = Convert.ToString(cantidad_total);
            txttotal_imp.Text= Convert.ToString(importe_final).Replace(",", ".");
            
        }

    }
}
