using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;


namespace UsePassword
{
    public partial class MetodoPago : Form
    {

        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;
        //Variables para hacer comparaciones
        public double Monto_R = 0,Total_C=0, total_cambio=0;
        public String dinero_total;
        public String cambio;
        public MetodoPago()
        {
            InitializeComponent();
            
        }

        private void MetodoPago_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Funcion Enter
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                //Obtener valores de los textbox
                if (Monto.Text == "")
                {
                    MessageBox.Show("Debes ingresar dinero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Seleccionar si marca error la comparacion 
                    Monto.SelectAll();
                }
                else
                {

                    Monto_R = Double.Parse(Monto.Text.Replace(".", ","));
                    Total_C = Double.Parse(Saldo.Text.Replace(".", ","));

                    //Comparar
                    if (Monto_R < Total_C)
                    {
                        MessageBox.Show("Esta recibiendo un pago menor.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Seleccionar si marca error la comparacion 
                        Monto.SelectAll();
                    }
                    else
                    {

                        double dinero;
                        double dinero_tota;
                        cmd = new SqlCommand("select * from dinero ", new Conexion().con);
                        SqlDataReader consu = cmd.ExecuteReader();
                        if (consu.Read() == true)
                        {
                            dinero_total = consu["dinero"].ToString();
                            dinero_total = dinero_total.Replace(".", ",");
                            dinero = Convert.ToDouble(dinero_total);
                            dinero_tota = Convert.ToDouble(Saldo.Text.Replace(".", ","));
                            dinero = dinero + dinero_tota;
                            dinero_total = Convert.ToString(dinero);
                            dinero_total = dinero_total.Replace(",",".");
                        }
                        consu.Close();

                        cmd = new SqlCommand("execute actualizardinero '" + dinero_total + "'", new Conexion().con);
                        cmd.ExecuteNonQuery();


                        Form2 id = Application.OpenForms.OfType<Form2>().SingleOrDefault();
                        id.cobrar();
                                                
                        total_cambio = Monto_R - Total_C;
                         cambio = Convert.ToString(total_cambio);
                        cambio = cambio.Replace(",", ".");
                        MessageBox.Show("Su cambio total es de : " + cambio, "Atención", MessageBoxButtons.OK);
                        imprimir();
                        id.limpiarventa();
                        this.Close();


                    }

                }

            }

            //Validacion para puros numeros
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < Monto.Text.Length; i++)
            {
                if (Monto.Text[i] == '.')
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

        private void Tipo_pago_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validacion de la tecla Enter en el tipo de pago
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (Tipo_pago.Text == "1")
                {
                    Nombre_pago.Text = "Efectivo";
                    Monto.Enabled = true;
                    Monto.Text = Saldo.Text;
                    //Funcion para aplicar tabulador al presionar enter
                    SendKeys.Send("{TAB}");                   
                    Monto.SelectAll();
                }
                else {
                    MessageBox.Show("No existe forma de pago.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Seleccionar texto al recibir mensaje de error
                    Tipo_pago.SelectionStart = 0;
                    Tipo_pago.SelectionLength = Tipo_pago.Text.Length;
                    //metodo para limpiar textbox
                    limpiar();
                }
            }
            //Validacion para solo aceptar numeros
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

        private void Tipo_pago_KeyDown(object sender, KeyEventArgs e)
        {
            //Tecla de funcion para cerrar form con la tecla escape
            if (e.KeyCode == Keys.Escape)
            {

                this.Close();
                limpiar();
            }
        }

        

        private void Monto_KeyDown(object sender, KeyEventArgs e)
        {
            //Tecla de funcion para cerrar form con la tecla escape
            if (e.KeyCode == Keys.Escape)
            {

                this.Close();
                limpiar();
            }
        }

        private void Tipo_pago_TextChanged(object sender, EventArgs e)
        {

        }

        //Metodo para limpiar textbox
        public void limpiar()
        {
            Nombre_pago.Text = "";
            Monto.Text = "";
        }

        public void imprimir()
        {
            Form2 venta = new Form2();
            CrearTicket ticket = new CrearTicket();

            ticket.TextoCentro("ABARROTES CARITA FELIZ");
            ticket.TextoIzquierda("EXPEDIDO EN: SUCURSAL");
            ticket.TextoIzquierda("DIRECCION: MATLALCUEYTL #3");
            ticket.TextoIzquierda("TELEFONO: 4125436");
            ticket.TextoIzquierda("EMAIL: ABARROTES@HOTMAIL.COM");
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("CAJA #1", "TICKET #" + venta.Folio_venta.Text);
            ticket.lineasAsteriscos();

            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ATENDIO: " + venta.Nombre_Cajero.Text);
            ticket.TextoIzquierda("CLIENTE: DIVERSOS");
            ticket.TextoExtremos("FECHA : ", venta.fechaventa.Text);
            ticket.lineasAsteriscos();

            ticket.encavezadoVenta();
            ticket.lineasAsteriscos();
            foreach (DataGridViewRow fila in venta.venta.Rows)
            {
                ticket.AgregarArticulos((fila.Cells[2].Value.ToString()), int.Parse(fila.Cells[3].Value.ToString()), decimal.Parse(fila.Cells[4].Value.ToString()), decimal.Parse(fila.Cells[5].Value.ToString()));

            }

            ticket.AgregarTotales("       TOTAL.....$", decimal.Parse(venta.TotalPagar.Text));
            ticket.AgregarTotales("       EFECTIVO..$", decimal.Parse(Monto.Text));
            ticket.AgregarTotales("       CAMBIO....$", decimal.Parse(cambio));

            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ARTICULOS VENDIDOS :" + venta.textBox5.Text);
            ticket.TextoIzquierda("");
            ticket.TextoCentro("GRACIAS POR SU COMPRA");
            ticket.CortarTicket();
            ticket.ImprimirTicket("Microsoft XPS Document Writer");
        }
    }
}

