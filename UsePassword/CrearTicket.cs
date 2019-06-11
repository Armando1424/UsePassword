using System;
using System.Text;
using System.Runtime.InteropServices;
namespace UsePassword
{
    class CrearTicket
    {
        StringBuilder linea = new StringBuilder();
        int maxCar = 40, cortar;


        public string lineasGuio() {
            string lineasGuion = "";
            for (int i = 0; i < maxCar; i++) {

                lineasGuion += "-";
            }
            return linea.AppendLine(lineasGuion).ToString();
        }


        public string lineasAsteriscos() {
            string lineasAsterico = "";
            for (int i=0; i<maxCar;i++) {
                lineasAsterico += "*";
            }
            return linea.AppendLine(lineasAsterico).ToString();
        }

        public string lineasIgual()
        {
            string lineasIgual = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasIgual += "=";
            }
            return linea.AppendLine(lineasIgual).ToString();
        }

        public void encavezadoVenta() {
            linea.AppendLine("ARTICULO              |CANT|PRECIO |IMPORTE");
        }

        public void TextoIzquierda(String texto) {
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                linea.AppendLine(texto.Substring(caracterActual, texto.Length - caracterActual));

            }
            else {
                linea.AppendLine(texto);
            }
        }


        public void TextoDerecho(String texto) {
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                String espacios = "";
                for (int i=0; i<(maxCar-texto.Substring(caracterActual,texto.Length-caracterActual).Length); i++) {
                    espacios += " ";
                }

                linea.AppendLine(texto.Substring(caracterActual, texto.Length - caracterActual));

            }
            else
            {
                String espacios = "";
                for (int i=0; i< (maxCar-texto.Length);i++) {
                    espacios += " ";
                }
                linea.AppendLine(espacios + texto);
            }

        }


        public void TextoCentro(String texto) {
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                String espacios = "";

                int centrar = (maxCar - texto.Substring(caracterActual, texto.Length - caracterActual).Length) / 2;
                for (int i = 0; i<centrar;i++)
                {
                    espacios += " ";
                }

                linea.AppendLine(texto.Substring(caracterActual, texto.Length - caracterActual));

            }
            else
            {
                String espacios = "";
                int centrar = (maxCar - texto.Length) / 2;
                for (int i = 0; i < centrar ; i++)
                {
                    espacios += " ";
                }
                linea.AppendLine(espacios + texto);
            }
        }


        public void TextoExtremos(String textoIzquierdo,String textoDerecho) {
            String textoIzq, textoDer, textoCompleto = "", espacios = "";

            if (textoIzquierdo.Length > 18)
            {
                cortar = textoIzquierdo.Length - 18;
                textoIzq = textoIzquierdo.Remove(18, cortar);

            }
            else {
                textoIzq = textoIzquierdo;
            }
            if (textoDerecho.Length > 20)
            {
                cortar = textoDerecho.Length - 20;
                textoDer = textoDerecho.Remove(20, cortar);
            }
            else {
                textoDer = textoDerecho;
            }
            int nroEspacios = maxCar - (textoIzq.Length + textoDer.Length);
            for (int i=0; i<nroEspacios;i++) {
                espacios += " ";

            }
            textoCompleto += espacios + textoDerecho;
            linea.AppendLine(textoCompleto);
        }


        public void AgregarTotales(String texto, decimal total) {
            String resumen, valor, textoCompleto, espacios = "";
            if (texto.Length > 25)
            {
                cortar = texto.Length - 25;
                resumen = texto.Remove(25, cortar);
            }
            else {
                resumen = texto;
            }

            textoCompleto = resumen;
            valor = total.ToString("#,#.00");

            int nroEspacios = maxCar - (resumen.Length + valor.Length);
            for (int i=0; i<nroEspacios;i++) {
                espacios += " ";
            }
            textoCompleto += espacios + valor;
            linea.AppendLine(textoCompleto);
        }

        public void AgregarArticulos(String articulo, int cant, decimal precio, decimal importe) {
            if (cant.ToString().Length <= 5 && precio.ToString().Length <= 7 && importe.ToString().Length <= 8)
            {
                String elemento = "", espacios = "";
                bool bandera = false;
                int nroEspacios = 0;

                if (articulo.Length > 20)
                {
                    nroEspacios = (5 - cant.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + cant.ToString();

                    nroEspacios = (7 - precio.ToString().Length);
                    espacios = "";

                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += " ";

                    nroEspacios = (8 - importe.ToString().Length);
                    espacios = " ";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + importe.ToString();
                    int caracterActual = 0;

                    for (int longitudTexto = articulo.Length; longitudTexto > 20; longitudTexto -= 20)
                    {
                        if (bandera == false)
                        {
                            linea.AppendLine(articulo.Substring(caracterActual, 20) + elemento);
                            bandera = true;
                        }

                        else
                        {
                            linea.AppendLine(articulo.Substring(caracterActual, 20));
                            caracterActual += 20;
                        }
                    }
                    linea.AppendLine(articulo.Substring(caracterActual, articulo.Length - caracterActual));

                }
                else
                {
                    for (int i = 0; i < (20 - articulo.Length); i++)
                    {
                        espacios += " ";
                    }
                    elemento = articulo + espacios;
                    nroEspacios = (5 - cant.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + cant.ToString();

                    nroEspacios = (7 - precio.ToString().Length);
                    espacios = " ";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + precio.ToString();
                    nroEspacios = (8 - importe.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + importe.ToString();

                    linea.AppendLine(elemento);

                }


            }
            else {

                linea.AppendLine("Los valores ingresados para esta fila ");
                linea.AppendLine(" superan las columnas soportadas por este.");
                throw new Exception("Los valores ingresados para algunas filas del ticket\n superan las columnas soportadas");
            }
        }

        public void CortarTicket() {
            linea.AppendLine("\x1B" + "m");
            linea.AppendLine("\x1B" + "d"+ "\x09");
        }

        public void ImprimirTicket(String impresora) {
            RawPrinterHelper.SendStringToPrinter(impresora, linea.ToString());
            linea.Clear();
        }

        public class RawPrinterHelper
        {
            // Structure and API declarions:
            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
            public class DOCINFOA
            {
                [MarshalAs(UnmanagedType.LPStr)]
                public string pDocName;
                [MarshalAs(UnmanagedType.LPStr)]
                public string pOutputFile;
                [MarshalAs(UnmanagedType.LPStr)]
                public string pDataType;
            }
            [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

            [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool ClosePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

            [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool EndDocPrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool StartPagePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool EndPagePrinter(IntPtr hPrinter);

            [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
            public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

            // SendBytesToPrinter()
            // When the function is given a printer name and an unmanaged array
            // of bytes, the function sends those bytes to the print queue.
            // Returns true on success, false on failure.
            public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
            {
                Int32 dwError = 0, dwWritten = 0;
                IntPtr hPrinter = new IntPtr(0);
                DOCINFOA di = new DOCINFOA();
                bool bSuccess = false; // Assume failure unless you specifically succeed.

                di.pDocName = "Ticket de venta";
                // Win7
                di.pDataType = "RAW";

                // Win8+
                // di.pDataType = "XPS_PASS";

                // Open the printer.
                if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
                {
                    // Start a document.
                    if (StartDocPrinter(hPrinter, 1, di))
                    {
                        // Start a page.
                        if (StartPagePrinter(hPrinter))
                        {
                            // Write your bytes.
                            bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                            EndPagePrinter(hPrinter);
                        }
                        EndDocPrinter(hPrinter);
                    }
                    ClosePrinter(hPrinter);
                }
                // If you did not succeed, GetLastError may give more information
                // about why not.
                if (bSuccess == false)
                {
                    dwError = Marshal.GetLastWin32Error();
                }
                return bSuccess;
            }

            public static bool SendStringToPrinter(string szPrinterName, string szString)
            {
                IntPtr pBytes;
                Int32 dwCount;
                // How many characters are in the string?
                dwCount = szString.Length;
                // Assume that the printer is expecting ANSI text, and then convert
                // the string to ANSI text.
                pBytes = Marshal.StringToCoTaskMemAnsi(szString);
                // Send the converted ANSI string to the printer.
                SendBytesToPrinter(szPrinterName, pBytes, dwCount);
                Marshal.FreeCoTaskMem(pBytes);
                return true;
            }
        }   


    }
}
