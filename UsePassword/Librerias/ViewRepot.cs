using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using UsePassword.Properties;
using System.Diagnostics;

namespace UsePassword.Librerias
{
    public class ViewRepot
    {
        public void addParagraph(Document doc, string text)
        {
            try
            {
                Paragraph parrafo = new Paragraph();
                parrafo.Alignment = Element.ALIGN_CENTER;
                parrafo.Font = FontFactory.GetFont("Arial", 24);
                parrafo.Font.SetStyle(iTextSharp.text.Font.BOLD);
                //parrafo.Font.SetStyle(iTextSharp.text.Font.UNDERLINE);

                parrafo.Add(text);
                doc.Add(parrafo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo ocurrio :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void addParagraph(Document doc, string text, int align, iTextSharp.text.Font font, int[] Styles)
        {
            try
            {
                Paragraph parrafo = new Paragraph();
                parrafo.Alignment = align;
                parrafo.Font = font;
                foreach (var style in Styles)
                {
                    parrafo.Font.SetStyle(style);
                }              

                parrafo.Add(text);
                doc.Add(parrafo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo ocurrio :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void addTable(Document doc, SqlDataReader sqlReader, int TableColumns,string TableHeader, string[] Titles, int orientation)
        {
            try
            {
                PdfPTable table = new PdfPTable(TableColumns);
                PdfPCell cell = new PdfPCell(new Phrase(TableHeader));
                cell.Colspan = TableColumns;
                cell.HorizontalAlignment = orientation; //0=Left, 1=Centre, 2=Right
                table.AddCell(cell);

                foreach (var title in Titles)
                {
                    table.AddCell(title);
                }

                while (sqlReader.Read())
                {
                    for (int i = 0; i < TableColumns; i++)
                    {
                        table.AddCell(sqlReader[i].ToString());
                    }
                }
                doc.Add(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo ocurrio :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void addTable(Document doc, DataTable dataTable, int TableColumns, string TableHeader, string[] Titles, int orientation)
        {
            try
            {
                PdfPTable table = new PdfPTable(TableColumns);
                PdfPCell cell = new PdfPCell(new Phrase(TableHeader));
                cell.Colspan = TableColumns;
                cell.HorizontalAlignment = orientation; //0=Left, 1=Centre, 2=Right
                table.AddCell(cell);

                foreach (var title in Titles)
                {
                    table.AddCell(title);
                }

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    foreach (var item in dataRow.ItemArray)
                    {
                        table.AddCell(item.ToString());
                    }
                }
                doc.Add(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo ocurrio :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void addImage(Document doc, Bitmap bitmap)
        {
            try
            {
                // Creamos la imagen y le ajustamos el tamaño Properties.Resources.logobmy1
                byte[] bytesImagen = new System.Drawing.ImageConverter().ConvertTo(bitmap, typeof(byte[])) as byte[];
                iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(bytesImagen);
                imagen.BorderWidth = 0;
                imagen.Alignment = Element.ALIGN_CENTER;
                float percentage = 0.0f;
                percentage = 150 / imagen.Width;
                imagen.ScalePercent(percentage * 100);
                
                doc.Add(imagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo ocurrio :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void addImage(Document doc, Bitmap bitmap, float border, int align, int percent)
        {
            try
            {
                // Creamos la imagen y le ajustamos el tamaño Properties.Resources.logobmy1
                byte[] bytesImagen = new System.Drawing.ImageConverter().ConvertTo(bitmap, typeof(byte[])) as byte[];
                iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(bytesImagen);
                imagen.BorderWidth = border;
                imagen.Alignment = align;
                float percentage = 0.0f;
                percentage = percent / imagen.Width;
                imagen.ScalePercent(percentage * 100);
                
                doc.Add(imagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo ocurrio :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region ejemplos de Apoyo
        public void CreateBasicReport(SqlDataReader SqlReader, string Name, string[] arrTitle)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                folder.RootFolder = Environment.SpecialFolder.Desktop;
                folder.Description = "** Selecciona una carpeta **";

                if (folder.ShowDialog() == System.Windows.Forms.DialogResult.OK)  
                {
                    Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                    string FileName = folder.SelectedPath + "\\Report" + Name + ".pdf";
                    FileStream fs = new FileStream(FileName, FileMode.Create);
                    PdfWriter wri = PdfWriter.GetInstance(doc, fs);

                    doc.Open();

                    int[] arrStyles = { iTextSharp.text.Font.BOLD };
                    addParagraph(doc, "Reportes Bimyou Meraky", Element.ALIGN_CENTER, FontFactory.GetFont("Arial", 24), arrStyles);

                    addImage(doc, Resources.logobmy1, 0, Element.ALIGN_CENTER, 100);
                    
                    addTable(doc, SqlReader, arrTitle.Length, Name, arrTitle, 1);

                    doc.Close();
                    wri.Close();
                    SqlReader.Close();

                    Process prc = new Process();
                    prc.StartInfo.FileName = FileName;
                    prc.Start();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CreateBasicReport(DataTable dataTable, string Name, string[] arrTitle)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();    //01afAplicamos el filtro para los tipos de archivo
                folder.RootFolder = Environment.SpecialFolder.Desktop;
                folder.Description = "** Selecciona una carpeta **";

                if (folder.ShowDialog() == System.Windows.Forms.DialogResult.OK)    //Si han seleccionado el archivo y han pulsado OK
                {
                    Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                    string FileName = folder.SelectedPath + "\\Report" + Name + ".pdf";
                    FileStream fs = new FileStream(FileName, FileMode.Create);
                    PdfWriter wri = PdfWriter.GetInstance(doc, fs);

                    doc.Open();

                    int[] arrStyles = { iTextSharp.text.Font.BOLD };
                    addParagraph(doc, "Reportes Bimyou Meraky", Element.ALIGN_CENTER, FontFactory.GetFont("Arial", 24), arrStyles);

                    addImage(doc, Resources.logobmy1, 0, Element.ALIGN_CENTER, 100);
                    
                    addTable(doc, dataTable, arrTitle.Length, Name, arrTitle, 1);

                    doc.Close();
                    wri.Close();

                    Process prc = new Process();
                    prc.StartInfo.FileName = FileName;
                    prc.Start();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
