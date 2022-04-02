using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Excel;
using Negocio;
using Dominio;

namespace CompuGross
{
    public partial class ReportePorCliente : Form
    {
        List<Dominio.ReportePorCliente> lista = new List<Dominio.ReportePorCliente>();

        public ReportePorCliente()
        {
            InitializeComponent();
        }

        private void ServiciosPorCliente_Load(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void CargarListado()
        {
            ReportePorCliente reporte = new ReportePorCliente();
            ReportePorClienteDB reporteDB = new ReportePorClienteDB();

            lista = reporteDB.Listar();

            dgvReporte.DataSource = lista;
            CambiosTitulosGrilla();
            ActualizarCoincidencias();
        }

        private void CambiosTitulosGrilla()
        {
            dgvReporte.Columns["ID"].HeaderText = "N° Cliente";
            dgvReporte.Columns["Nombres"].HeaderText = "Cliente";
            dgvReporte.Columns["TotalServicios"].HeaderText = "Servicios";
            dgvReporte.Columns["ServicioTecnico"].HeaderText = "S.T.";
            dgvReporte.Columns["Camaras"].HeaderText = "Cámaras";
            dgvReporte.Columns["ArmadoGabinete"].HeaderText = "A.G.";
        }

        private void FiltrarTabla()
        {
            CargarListado();
            CambiosTitulosGrilla();
            List<Dominio.ReportePorCliente> filtro;
            if (txtFiltro.Text != "")
            {
                filtro = lista.FindAll(Art => Art.ID.ToString().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.Nombres.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.TotalServicios.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.ServicioTecnico.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.Camaras.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.ArmadoGabinete.ToUpper().Contains(txtFiltro.Text.ToUpper()));
                dgvReporte.DataSource = null;
                dgvReporte.DataSource = filtro;
                CambiosTitulosGrilla();

                int resultado = filtro.Count();
                lblCoincidencias.Visible = true;
                lblCoincidencias.Text = "Cantidad: " + resultado.ToString();
                if (resultado == 0)
                {
                    lblCoincidencias.Text = "Cantidad: 0";
                }
            }
            else
            {
                dgvReporte.DataSource = null;
                dgvReporte.DataSource = lista;
                CambiosTitulosGrilla();
            }
        }

        private void ActualizarCoincidencias()
        {
            int aux = dgvReporte.Rows.Count;
            lblCoincidencias.Text = "Coincidencias: " + aux;
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            //FiltrarTabla();
            ActualizarCoincidencias();
            if (e.KeyCode.Equals(Keys.Enter))
            {
                FiltrarTabla();
            }
        }

        private void ExportExcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application(); //creamos nuevo archivo excel
            excel.Application.Workbooks.Add(true); //agregamos una hoja nueva al archivo

            int indiceColumna = 0;
            foreach (DataGridViewColumn col in tabla.Columns) //agregamos encabezados a la nueva hoja
            {
                indiceColumna++;
                excel.Cells[1, indiceColumna] = col.Name;
            }

            int indiceFila = 0;
            foreach (DataGridViewRow row in tabla.Rows) //agregamos contenido a la nueva hoja
            {
                indiceFila++;
                indiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    indiceColumna++;
                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;
                }
            }

            excel.Visible = true;
        }

        private void ExportPdf(DataGridView tabla)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            string fechaHora = DateTime.Now.ToString("dd-MM-yy");
            sfd.FileName = "Reporte de ingresos por cliente (" + fechaHora + ").pdf";
            bool fileError = false;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);
                    }
                    catch (IOException ex)
                    {
                        fileError = true;
                        MessageBox.Show("No es posible guardar el documento." + ex.Message);
                    }
                }
                if (!fileError)
                {
                    Paragraph saltoDeLinea = new Paragraph("                                                                                                                                                                                                                                                                                                                                                                                   ");

                    BaseFont _letraRemito = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1250, true);
                    iTextSharp.text.Font letraRemito = new iTextSharp.text.Font(_letraRemito, 40f, iTextSharp.text.Font.BOLD, new BaseColor(0, 0, 0));

                    BaseFont _titulo = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1250, true);
                    iTextSharp.text.Font titulo = new iTextSharp.text.Font(_titulo, 24f, iTextSharp.text.Font.BOLD, new BaseColor(0, 0, 0));

                    BaseFont _subtitulo = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, true);
                    iTextSharp.text.Font subtitulo = new iTextSharp.text.Font(_subtitulo, 10f, iTextSharp.text.Font.BOLD, new BaseColor(0, 0, 0));

                    BaseFont _parrafo = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, true);
                    iTextSharp.text.Font parrafo = new iTextSharp.text.Font(_parrafo, 10f, iTextSharp.text.Font.NORMAL, new BaseColor(0, 0, 0));

                    BaseFont _tituloGrilla = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, true);
                    iTextSharp.text.Font tituloGrilla = new iTextSharp.text.Font(_tituloGrilla, 10f, iTextSharp.text.Font.NORMAL, new BaseColor(255, 255, 255));

                    BaseFont _contenidoGrilla = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, true);
                    iTextSharp.text.Font contenidoGrilla = new iTextSharp.text.Font(_contenidoGrilla, 10f, iTextSharp.text.Font.NORMAL, new BaseColor(0, 0, 0));

                    string NombreEmpresa = "COMPUGROSS";
                    string Titulo = "Reporte de ingresos por cliente";
                    string Contacto = "WhatsApp: 11-5607-3553";
                    string Mail = "compugross02.05.13@gmail.com";
                    string fechaHoraActual = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                    //DATOS CABECERA
                    string imageURL2 = "img/Presupuesto/CG.png";
                    iTextSharp.text.Image imgLogo = iTextSharp.text.Image.GetInstance(imageURL2);
                    imgLogo.ScaleToFit(100f, 100f);
                    imgLogo.Border = 0;
                    imgLogo.Alignment = Element.ALIGN_RIGHT;

                    PdfPTable tblLogoCG = new PdfPTable(new float[] { 100f })
                    {
                        WidthPercentage = 100,
                        HorizontalAlignment = Element.ALIGN_CENTER,
                    };
                    tblLogoCG.AddCell(new PdfPCell(new Phrase(NombreEmpresa, titulo))
                    {
                        Border = 0,
                        VerticalAlignment = Element.ALIGN_MIDDLE,
                        HorizontalAlignment = Element.ALIGN_CENTER
                    });

                    var tblCabecera = new PdfPTable(new float[] { 50f, 50f }) { WidthPercentage = 100 };

                    tblCabecera.AddCell(new PdfPCell(new Phrase(Titulo, subtitulo))
                    {
                        Border = 0,
                        Rowspan = 3,
                        VerticalAlignment = Element.ALIGN_MIDDLE,
                        HorizontalAlignment = Element.ALIGN_LEFT
                    });
                    tblCabecera.AddCell(new PdfPCell(new Phrase(Contacto, parrafo))
                    {
                        Border = 0,
                        HorizontalAlignment = Element.ALIGN_RIGHT
                    });
                    tblCabecera.AddCell(new PdfPCell(new Phrase(Mail, parrafo))
                    {
                        Border = 0,
                        HorizontalAlignment = Element.ALIGN_RIGHT
                    });
                    tblCabecera.AddCell(new PdfPCell(new Phrase(fechaHoraActual, parrafo))
                    {
                        Border = 0,
                        HorizontalAlignment = Element.ALIGN_RIGHT
                    });

                    //DATOS CONTENIDO
                    try
                    {
                        PdfPTable tblContenido = new PdfPTable(new float[] { 7f, 53f, 10f, 10f, 10f, 10f })
                        {
                            WidthPercentage = 100,
                            HorizontalAlignment = Element.ALIGN_CENTER
                        };

                        //TITULOS GRILLA
                        foreach (DataGridViewColumn column in tabla.Columns)
                        {
                            tblContenido.AddCell(new PdfPCell(new Phrase(new Phrase(column.HeaderText, tituloGrilla)))
                            {
                                BackgroundColor = iTextSharp.text.BaseColor.BLACK,
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                VerticalAlignment = Element.ALIGN_MIDDLE,
                                Border = 1,
                                BorderColor = iTextSharp.text.BaseColor.WHITE
                            });
                        }

                        //CONTENIDO GRILLA
                        foreach (DataGridViewRow row in tabla.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.ColumnIndex == 1) //Cliente
                                {
                                    tblContenido.AddCell(new PdfPCell(new Phrase(cell.Value.ToString(), contenidoGrilla))
                                    {
                                        BorderWidthRight = 1,
                                        BorderWidthBottom = 1,
                                        BorderWidthTop = 1,
                                        BorderColor = iTextSharp.text.BaseColor.BLACK,
                                        HorizontalAlignment = Element.ALIGN_LEFT,
                                        VerticalAlignment = Element.ALIGN_MIDDLE
                                    });
                                }
                                else
                                {
                                    tblContenido.AddCell(new PdfPCell(new Phrase(cell.Value.ToString(), contenidoGrilla))
                                    {
                                        BorderWidthRight = 1,
                                        BorderWidthBottom = 1,
                                        BorderWidthTop = 1,
                                        BorderColor = iTextSharp.text.BaseColor.BLACK,
                                        HorizontalAlignment = Element.ALIGN_CENTER,
                                        VerticalAlignment = Element.ALIGN_MIDDLE
                                    });
                                }
                            }
                        }

                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.LETTER, 40f, 40f, 40f, 40f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.AddTitle("Reporte de ingresos por cliente");
                            pdfDoc.Open();
                            pdfDoc.Add(imgLogo);
                            pdfDoc.Add(tblCabecera);
                            pdfDoc.Add(saltoDeLinea);
                            pdfDoc.Add(tblContenido);
                            pdfDoc.Add(saltoDeLinea);
                            pdfDoc.Close();
                            stream.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportExcel(dgvReporte);
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            ExportPdf(dgvReporte);
        }
    }
}
