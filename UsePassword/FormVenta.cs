using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UsePassword
{
    public partial class Form2 : Form
    {

        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;
        int index, ban_v=0;
        int MValX, MValY;
        bool TogMove;


        //Total a pagar cuenta
        int total_pedido;
        public double Total_Pagar=0.00;


        public Form2()
        {
            InitializeComponent();
            //Mostrar para el textBox
            TotalPagar.Text = Total_Pagar.ToString("0.00");
            try
            {
                cmd = new SqlCommand("SELECT IDENT_CURRENT ('Venta');", new Conexion().con);
                Folio_venta.Text = Convert.ToString((Convert.ToInt32(cmd.ExecuteScalar()) + 1));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        


        }

        public void cobrar()
        {
            try
            {
                cmd = new SqlCommand("Execute insertarVenta'" + fechaventa.Value.ToString("dd/MM/yyyy") + "'," + TotalPagar.Text.Replace(",", "."), new Conexion().con);
                cmd.ExecuteNonQuery();

     


                for (int fila = 0; fila <= venta.Rows.Count - 1; fila++)
                {
                    string codigo = venta.Rows[fila].Cells[0].Value.ToString();
                    string nombre = venta.Rows[fila].Cells[1].Value.ToString();
                    string surtido = venta.Rows[fila].Cells[2].Value.ToString();
                    string precio = venta.Rows[fila].Cells[3].Value.ToString();
                    precio = precio.Replace(",", ".");
                    String total_venta = venta.Rows[fila].Cells[4].Value.ToString();
                    total_venta = total_venta.Replace(",", ".");
                    int surtido1 = Convert.ToInt32(surtido);
                    int total_surtido = 0;
                    String cantidad_producto;
                    cmd = new SqlCommand("Execute insertarDatos_Venta '" + Folio_venta.Text + "','" + codigo + "','" + nombre + "','" + surtido + "','" + precio + "','" + total_venta +"'", new Conexion().con);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("select Cantidad_P from Producto where id_producto = '" + codigo + "'", new Conexion().con);
                    SqlDataReader consu = cmd.ExecuteReader();
                    if (consu.Read() == true)
                    {
                        cantidad_producto = consu["Cantidad_P"].ToString();
                        total_surtido = ((Convert.ToInt32(cantidad_producto))- surtido1);
                    }
                    consu.Close();

                    cmd = new SqlCommand("Execute actualizarinventarioventa '" + codigo + "'," + total_surtido + ",'" + precio + "'", new Conexion().con);
                    cmd.ExecuteNonQuery();


                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void limpiarventa() {
            try
            {
                cmd = new SqlCommand("SELECT IDENT_CURRENT ('Venta');", new Conexion().con);
                Folio_venta.Text = Convert.ToString((Convert.ToInt32(cmd.ExecuteScalar()) + 1));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            venta.Rows.Clear();
            TotalPagar.Text = "0,00";
            cantidad.Text = "1";
            textBox5.Text = "0";
            ID_Producto.Focus();

        }




        private void btSalir_Click(object sender, EventArgs e)
        {
            //Regresar al menu del empleado
            FormMenuEmpleado MEM = new FormMenuEmpleado();
            MEM.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Funcion con la tecla enter
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (ID_Producto.Text == "") {
                    FormRealizarConsultas metodopago = new FormRealizarConsultas();
                    metodopago.ban = 2;
                    metodopago.Show();
                }
                else
                {
                    ban_v = 0;
                    try
                    {
                        cmd = new SqlCommand("ConsultarProducto " + ID_Producto.Text, new Conexion().con);
                        SqlDataReader consu = cmd.ExecuteReader();
                        String descripcion, precio,codigo;
                        double total;
                        if (consu.Read() == true)
                        {
                            for (int fila = 0; fila <= venta.Rows.Count - 1; fila++)
                            {
                                string codigo_co = venta.Rows[fila].Cells[0].Value.ToString();
                                string pedido_co = venta.Rows[fila].Cells[2].Value.ToString();
                                string precio_co = venta.Rows[fila].Cells[3].Value.ToString();
                                int valor_total;
                                if (ID_Producto.Text == codigo_co)
                                {
                                    valor_total = (Convert.ToInt32(pedido_co) + Convert.ToInt32(cantidad.Text));
                                    total = (valor_total * Convert.ToDouble(precio_co));
                                    venta.Rows[fila].Cells[2].Value = Convert.ToString(valor_total);
                                    venta.Rows[fila].Cells[4].Value = Convert.ToString(total);
                                    calcular();
                                    ID_Producto.Text = "";
                                    cantidad.Text = "1";
                                    ban_v = 1;
                                }

                            }
                            if (ban_v == 0) {
                                codigo = consu["id_producto"].ToString();
                                descripcion = consu["Nombre_P"].ToString();
                                precio = consu["precio_Tienda"].ToString();
                                total = (Convert.ToDouble(precio) * Convert.ToInt32(cantidad.Text));
                                venta.Rows.Add(codigo, descripcion, cantidad.Text, precio, total);
                                ID_Producto.Text = "";
                                cantidad.Text = "1";
                                calcular();
                            }

                        }
                        else
                        {
                            MessageBox.Show("No se encuentra Producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ID_Producto.Text = "";
                            ID_Producto.Focus();
                        }
                        consu.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }


                    
                }
            }
            //Validacion para puros numeros
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //Validacion para multiplicar la cantidad de productos
            else if( e.KeyChar == '*') {
                if (ID_Producto.Text == "")
                {
                    e.Handled = true;
                }
                else
                {
                    cantidad.Text = ID_Producto.Text;
                    e.Handled = true;
                    ID_Producto.Text = ("");
                }
            }
            //parte de la validacion de numeros
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {

            }
            else
            {
                index = e.RowIndex;
            }
        }

        private void venta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {

                venta.Rows.RemoveAt(index);
                calcular();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String dinero;
            cmd = new SqlCommand("select * from dinero ", new Conexion().con);
            SqlDataReader consu = cmd.ExecuteReader();
            if (consu.Read() == true)
            {
                dinero = consu["dinero"].ToString();
                MessageBox.Show("Dinero disponible " + dinero , "Atención", MessageBoxButtons.OK);

            }
           
            consu.Close();
        
                    
}

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            //Funcion de la tecla f12 para metodo de pago
            if (Total_Pagar > 0) { 
            if (e.KeyCode == Keys.F12)
            {

                MetodoPago metodopago = new MetodoPago();

                    metodopago.Saldo.Text = TotalPagar.Text;              
                    metodopago.Show();


            }
            }
            //Funcion para la tecla f10 para devolucion de compra
            if (e.KeyCode == Keys.F10)
            {

                Devolucion_de_venta Devolucion = new Devolucion_de_venta();
                Devolucion.Show();


            }
            
           

        }


        public void calcular()
        {
            Total_Pagar = 0;
            total_pedido = 0;
            for (int fila = 0; fila <= venta.Rows.Count - 1; fila++)
            {
                double valor1 = Convert.ToDouble(venta.Rows[fila].Cells[4].Value);
                int valor = Convert.ToInt32( venta.Rows[fila].Cells[2].Value);
                total_pedido += valor;
                Total_Pagar += valor1;
            }
            textBox5.Text = Convert.ToString(total_pedido);
            TotalPagar.Text = Convert.ToString(Total_Pagar).Replace(",",".");
        }

    }
}
