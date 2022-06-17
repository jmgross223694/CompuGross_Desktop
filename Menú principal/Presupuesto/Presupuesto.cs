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
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using Dominio;
using Negocio;
using System.Net;

namespace CompuGross
{
    public partial class Presupuesto : Form
    {
        private List<Cliente> listaClientes;
        private Cliente cliente = null;

        public Presupuesto()
        {
            InitializeComponent();
        }

        private void Presupuesto_Load(object sender, EventArgs e)
        {
            lblFecha.Text = selectFecha.Text;

            txtCantidad.Focus();
            dgvClientes.Visible = false;

            cargarListadoClientes();
            AlinearColumnasGrillaClientes();
            ordenarColumnasGrillaClientes();
            cambiarTitulosGrillaClientes();
            ocultarColumnasClientes();
        }

        private void ExportToPdf(DataGridView dgv, string nombresCliente)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Presupuesto (" + lblFecha.Text + ") " + nombresCliente + ".pdf";
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

                    BaseFont _cliente = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, true);
                    iTextSharp.text.Font cliente = new iTextSharp.text.Font(_subtitulo, 12f, iTextSharp.text.Font.BOLD, new BaseColor(0, 0, 0));

                    BaseFont _parrafo = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, true);
                    iTextSharp.text.Font parrafo = new iTextSharp.text.Font(_parrafo, 10f, iTextSharp.text.Font.NORMAL, new BaseColor(0, 0, 0));

                    BaseFont _tituloGrilla = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, true);
                    iTextSharp.text.Font tituloGrilla = new iTextSharp.text.Font(_tituloGrilla, 10f, iTextSharp.text.Font.NORMAL, new BaseColor(255, 255, 255));

                    BaseFont _contenidoGrilla = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, true);
                    iTextSharp.text.Font contenidoGrilla = new iTextSharp.text.Font(_contenidoGrilla, 10f, iTextSharp.text.Font.NORMAL, new BaseColor(0, 0, 0));

                    BaseFont _footer = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, true);
                    iTextSharp.text.Font footer = new iTextSharp.text.Font(_footer, 6f, iTextSharp.text.Font.BOLD, new BaseColor(0, 0, 0));

                    string NombreEmpresa = "COMPUGROSS";
                    string Cliente = "Cliente:\n" + nombresCliente;
                    //string Direccion = "Profesor Simon 2005, Villa Ballester";
                    string Contacto = "WhatsApp: 11-5607-3553";
                    string Mail = "compugross02.05.13@gmail.com";
                    string FechaHoraPresupuesto = "Fecha: " + lblFecha.Text;
                    string Footer = "* Los precios no incluyen IVA.\n\n" +
                                    "* Los precios serán válidos por 24 Hs.";

                    //LETRA CABECERA
                    //var tblLetraRemito = new PdfPTable(new float[] { 100f }) { WidthPercentage = 100 };

                    string imageURL = "img/Presupuesto/letra2.jpg";
                    iTextSharp.text.Image imagenTipoDocumento = iTextSharp.text.Image.GetInstance(imageURL);
                    //Resize image depend upon your need
                    imagenTipoDocumento.ScaleToFit(40f, 40f);
                    //Give space before image
                    //imagenTipoDocumento.SpacingBefore = 10f;
                    //Give some space after the image
                    //imagenTipoDocumento.SpacingAfter = 1f;
                    imagenTipoDocumento.Alignment = Element.ALIGN_CENTER;

                    //tblLetraRemito.AddCell(new PdfPCell(new Phrase("X", letraRemito))
                    //{
                    //    Border = 0,
                    //    VerticalAlignment = Element.ALIGN_MIDDLE,
                    //    HorizontalAlignment = Element.ALIGN_CENTER
                    //});

                    //DATOS CABECERA
                    string imageURL2 = "img/Presupuesto/CG.png";
                    iTextSharp.text.Image imgLogo = iTextSharp.text.Image.GetInstance(imageURL2);
                    //Resize image depend upon your need
                    imgLogo.ScaleToFit(100f, 100f);
                    //Give space before image
                    //imgLogo.SpacingBefore = 10f;
                    //Give some space after the image
                    //imgLogo.SpacingAfter = 5f;
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

                    tblCabecera.AddCell(new PdfPCell(new Phrase(Cliente, cliente))
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
                    tblCabecera.AddCell(new PdfPCell(new Phrase(FechaHoraPresupuesto, parrafo))
                    {
                        Border = 0,
                        HorizontalAlignment = Element.ALIGN_RIGHT
                    });

                    //DATOS CONTENIDO
                    try
                    {
                        PdfPTable tblContenido = new PdfPTable(new float[] { 7f, 15f, 58f, 10f, 10f })
                        {
                            WidthPercentage = 100,
                            HorizontalAlignment = Element.ALIGN_CENTER
                        };

                        //TITULOS GRILLA
                        foreach (DataGridViewColumn column in dgv.Columns)
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
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.ColumnIndex == 2) //Descripción
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
                                else if (cell.ColumnIndex == 0) //Cantidad
                                {
                                    tblContenido.AddCell(new PdfPCell(new Phrase(cell.Value.ToString(), contenidoGrilla))
                                    {
                                        BorderWidthRight = 1,
                                        BorderWidthLeft = 1,
                                        BorderWidthBottom = 1,
                                        BorderWidthTop = 1,
                                        BorderColor = iTextSharp.text.BaseColor.BLACK,
                                        HorizontalAlignment = Element.ALIGN_CENTER,
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

                        //TABLA_TOTAL
                        PdfPTable tblTotal = new PdfPTable(new float[] { 100f })
                        {
                            WidthPercentage = 20,
                            HorizontalAlignment = Element.ALIGN_RIGHT,
                        };
                        tblTotal.AddCell(new PdfPCell(new Phrase(lblTotal.Text, tituloGrilla))
                        {
                            BackgroundColor = iTextSharp.text.BaseColor.BLACK,
                            HorizontalAlignment = Element.ALIGN_CENTER,
                            VerticalAlignment = Element.ALIGN_MIDDLE,
                            Border = 1,
                            BorderColor = iTextSharp.text.BaseColor.BLACK
                        });

                        //TABLA_FOOTER
                        var tblFooter = new PdfPTable(new float[] { 100f }) { WidthPercentage = 100 };
                        tblFooter.AddCell(new PdfPCell(new Phrase(Footer, footer))
                        {
                            Border = 0,
                            HorizontalAlignment = Element.ALIGN_LEFT,
                            VerticalAlignment = Element.ALIGN_BOTTOM
                        });

                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.LETTER, 40f, 40f, 40f, 40f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            //pdfDoc.AddAuthor("CompuGross");
                            pdfDoc.AddTitle("Presupuesto");
                            pdfDoc.Open();
                            //pdfDoc.Add(tblLetraRemito);
                            pdfDoc.Add(imagenTipoDocumento);
                            //pdfDoc.Add(saltoDeLinea);
                            pdfDoc.Add(imgLogo);
                            //pdfDoc.Add(tblLogoCG);
                            //pdfDoc.Add(saltoDeLinea);
                            pdfDoc.Add(tblCabecera);
                            pdfDoc.Add(saltoDeLinea);
                            pdfDoc.Add(tblContenido);
                            pdfDoc.Add(saltoDeLinea);
                            pdfDoc.Add(tblTotal);
                            pdfDoc.Add(saltoDeLinea);
                            pdfDoc.Add(saltoDeLinea);
                            pdfDoc.Add(tblFooter);
                            pdfDoc.Close();
                            stream.Close();
                        }

                        //MessageBox.Show("Se completó la exportación a PDF");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }
                }
            }
        }

        private void agregarItem()
        {
            if (txtCantidad.Text == "" || txtCodigo.Text == ""
                || txtDescripcion.Text == "" || txtPrecioUnitario.Text == "")
            {
                MessageBox.Show("Faltan datos.", "Atención!");
            }
            else
            {
                decimal subtotal = Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtPrecioUnitario.Text);

                dgvPresupuesto.Rows.Add(txtCantidad.Text, txtCodigo.Text,
                    txtDescripcion.Text, txtPrecioUnitario.Text, subtotal.ToString());

                borrarCamposItem();

                txtCantidad.Focus();
            }
        }

        private void borrarPresupuestoActual()
        {
            dgvPresupuesto.DataSource = null;
            dgvPresupuesto.Rows.Clear();
            lblTotal.Text = "Total: $";
            lblItems.Text = "Items:";
            txtCliente.Text = "";
        }

        private void borrarCamposItem()
        {
            txtCantidad.Text = "";
            txtCodigo.Text = "";
            txtPrecioUnitario.Text = "";
            txtDescripcion.Text = "";
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                agregarItem();
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }
        }

        private void soloNumerosConDecimales(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPrecioUnitario.Focus();
            }
            else
            {
                soloNumeros(sender, e);
            }
        }

        private void txtPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCodigo.Focus();
            }
            else
            {
                soloNumerosConDecimales(sender, e);
            }
        }

        private void dgvPresupuesto_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int items = dgvPresupuesto.Rows.Count;
            lblItems.Text = "Items: " + items.ToString();

            decimal total = sumarSubtotalesPresupuesto();
            lblTotal.Text = "Total: $" + total;
        }

        private decimal sumarSubtotalesPresupuesto()
        {
            int filas = dgvPresupuesto.Rows.Count;
            decimal total = 0;

            for (int fila = 0; fila < filas; fila++)
            {
                total += Convert.ToDecimal(dgvPresupuesto.Rows[fila].Cells["Subtotal"].Value);
            }

            return total;
        }

        private void dgvPresupuesto_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int items = dgvPresupuesto.Rows.Count;
            lblItems.Text = "Items: " + items.ToString();

            decimal total = sumarSubtotalesPresupuesto();
            lblTotal.Text = "Total: $" + total;
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDescripcion.Focus();
            }
        }

        private void cargarListadoClientes()
        {
            ClienteDB clienteDB = new ClienteDB();

            try
            {
                listaClientes = clienteDB.Listar();
                dgvClientes.DataSource = listaClientes;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
        }

        private void ocultarColumnasClientes()
        {
            dgvClientes.Columns["Direccion"].Visible = false;
            dgvClientes.Columns["Localidad"].Visible = false;
            dgvClientes.Columns["IdLocalidad"].Visible = false;
            dgvClientes.Columns["Mail"].Visible = false;
        }

        private void cambiarTitulosGrillaClientes()
        {
            dgvClientes.Columns["Id"].HeaderText = "N° cliente";
            dgvClientes.Columns["Nombres"].HeaderText = "Cliente";
            dgvClientes.Columns["Telefono"].HeaderText = "Teléfono";
        }

        private void ordenarColumnasGrillaClientes()
        {
            dgvClientes.AllowUserToOrderColumns = true;

            dgvClientes.Columns["Id"].DisplayIndex = 0;
            dgvClientes.Columns["Nombres"].DisplayIndex = 1;
            dgvClientes.Columns["Telefono"].DisplayIndex = 2;
            dgvClientes.Columns["DNI"].DisplayIndex = 3;
        }

        private void AlinearColumnasGrillaClientes()
        {
            dgvClientes.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["DNI"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvClientes.Columns["Id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["Nombres"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["Telefono"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["DNI"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.Visible == false)
            {
                visibilidadCamposPresupuesto("hide");
                dgvClientes.Visible = true;
            }
            else
            {
                this.cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

                visibilidadCamposPresupuesto("show");

                txtCliente.Text = this.cliente.Nombres;

                dgvClientes.Visible = false;
            }
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

            visibilidadCamposPresupuesto("show");

            txtCliente.Text = this.cliente.Nombres;

            dgvClientes.Visible = false;
        }

        private void buscarCliente()
        {
            List<Cliente> filtro;
            if (txtCliente.Text != "")
            {
                filtro = listaClientes.FindAll(Art => Art.DNI.ToUpper().Contains(txtCliente.Text.ToUpper()) ||
                                               Art.Nombres.ToUpper().Contains(txtCliente.Text.ToUpper()) ||
                                               Art.Id.ToString().Contains(txtCliente.Text.ToUpper()) ||
                                               Art.Telefono.ToUpper().Contains(txtCliente.Text.ToUpper()));
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = filtro;
            }
            else
            {
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = listaClientes;
            }
            AlinearColumnasGrillaClientes();
            ordenarColumnasGrillaClientes();
            cambiarTitulosGrillaClientes();
            ocultarColumnasClientes();
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvClientes.Visible == true)
            {
                if (e.KeyCode.Equals(Keys.Enter))
                {
                    if (dgvClientes.DataSource == null)
                    {
                        cargarListadoClientes();
                        AlinearColumnasGrillaClientes();
                        ordenarColumnasGrillaClientes();
                        cambiarTitulosGrillaClientes();
                        ocultarColumnasClientes();
                    }

                    buscarCliente();
                }
            }
        }

        private void txtCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (dgvClientes.Visible == true)
            {
                if (e.KeyCode.Equals(Keys.Enter))
                {
                    if (dgvClientes.DataSource == null)
                    {
                        cargarListadoClientes();
                        AlinearColumnasGrillaClientes();
                        ordenarColumnasGrillaClientes();
                        cambiarTitulosGrillaClientes();
                        ocultarColumnasClientes();
                    }

                    buscarCliente();
                }
            }
        }

        private void visibilidadCamposPresupuesto(string aux)
        {
            if (aux == "show")
            {
                menuStrip1.Visible = true;
                lblCantidad.Visible = true;
                txtCantidad.Visible = true;
                lblPrecioUnitario.Visible = true;
                txtPrecioUnitario.Visible = true;
                lblCodigo.Visible = true;
                txtCodigo.Visible = true;
                lblDescripcion.Visible = true;
                txtDescripcion.Visible = true;
                dgvPresupuesto.Visible = true;
            }
            if (aux == "hide")
            {
                menuStrip1.Visible = false;
                lblCantidad.Visible = false;
                txtCantidad.Visible = false;
                lblPrecioUnitario.Visible = false;
                txtPrecioUnitario.Visible = false;
                lblCodigo.Visible = false;
                txtCodigo.Visible = false;
                lblDescripcion.Visible = false;
                txtDescripcion.Visible = false;
                dgvPresupuesto.Visible = false;
            }
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            agregarItem();
        }

        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminar ítem 'Código: " + dgvPresupuesto.CurrentRow.Cells["Codigo"].Value.ToString()
                + "'?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvPresupuesto.Rows.Remove(dgvPresupuesto.CurrentRow);
            }
        }

        private void btnExportarPresupuesto_Click(object sender, EventArgs e)
        {
            if (dgvPresupuesto.Rows.Count > 0 && txtCliente.Text != "")
            {
                string cliente = txtCliente.Text;
                ExportToPdf(dgvPresupuesto, cliente);

                if (MessageBox.Show("¿Borrar Presupuesto actual?", "Atención!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    borrarCamposItem();
                    borrarPresupuestoActual();
                }
            }
            else
            {
                MessageBox.Show("Presupuesto sin Ítems o Cliente no seleccionado.", "Atención!");
            }
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {
            selectFecha.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void selectFecha_ValueChanged(object sender, EventArgs e)
        {
            lblFecha.Text = selectFecha.Text;
        }
    }
}
