using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using System.Net;

namespace CompuGross
{
    public partial class Activación : Form
    {
        public Activación()
        {
            InitializeComponent();
        }

        private void Activación_Load(object sender, EventArgs e)
        {
            AccesoDatos datos3 = new AccesoDatos();
            DateTime Validez = DateTime.Now;
            string selectActivacion = "select Validez from Activado where Estado = 1 and " +
                "(select Estado from Licencias where ID = IdLicencia) = 1";
            datos3.SetearConsulta(selectActivacion);

            try
            {
                datos3.EjecutarLectura();
                if (datos3.Lector.Read() == true)
                {
                    Validez = Convert.ToDateTime(datos3.Lector["Validez"]);
                }
            }
            catch
            {
                MessageBox.Show("Se ha producido un error al validar la licencia.\n\n" +
                    "Reintente más tarde o contacte al administrador del software", "Atención",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                datos3.CerrarConexion();
            }

            string diaSemanaValidez = "";

            if (Validez.DayOfWeek.ToString() == "Sunday") { diaSemanaValidez = "Domingo"; }
            if (Validez.DayOfWeek.ToString() == "Monday") { diaSemanaValidez = "Lunes"; }
            if (Validez.DayOfWeek.ToString() == "Thursday") { diaSemanaValidez = "Martes"; }
            if (Validez.DayOfWeek.ToString() == "Wednesday") { diaSemanaValidez = "Miércoles"; }
            if (Validez.DayOfWeek.ToString() == "Tuesday") { diaSemanaValidez = "Jueves"; }
            if (Validez.DayOfWeek.ToString() == "Friday") { diaSemanaValidez = "Viernes"; }
            if (Validez.DayOfWeek.ToString() == "Saturday") { diaSemanaValidez = "Sábado"; }

            if (Validez < DateTime.Now)
            {
                MessageBox.Show("Licencia expirada el día " + diaSemanaValidez + " " + 
                    Validez.ToShortDateString() + ".\n\nContacte al administrador del " +
                    "software para obtener una nueva licencia.", "Atención",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);

                ocultarMostrarElementos();
                habilitarInhabilitarElementos();
            }
            else
            {
                MenuPrincipal frmMenuPrincipal = new MenuPrincipal();
                this.Hide();
                frmMenuPrincipal.ShowDialog();
            }
        }

        private void habilitarInhabilitarElementos()
        {
            linkLblActivación.Enabled = false;
            cbTerminos.Enabled = false;
        }

        private void ocultarMostrarElementos()
        {
            lblTitulo.Visible = true;
            lblTerminosLicencia.Visible = true;
            lblSerial.Visible = false;
            cbTerminos.Visible = true;
            linkLblActivación.Visible = true;
            btnValidar.Visible = false;
            txtSerial1.Visible = false;
            txtSerial2.Visible = false;
            txtSerial3.Visible = false;
            txtSerial4.Visible = false;
            txtSerial5.Visible = false;
            txtSerial6.Visible = false;
            lblGuion1.Visible = false;
            lblGuion2.Visible = false;
            lblGuion3.Visible = false;
            lblGuion4.Visible = false;
            lblGuion5.Visible = false;
        }

        private void txtSerial1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSerial1.Text.Length == 3 && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                txtSerial2.Focus();
            }
        }

        private void txtSerial2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Back) && txtSerial2.Text.Length == 1)
            {
                txtSerial1.Focus();
            }
            if (txtSerial2.Text.Length == 3 && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                txtSerial3.Focus();
            }
        }

        private void txtSerial3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Back) && txtSerial3.Text.Length == 1)
            {
                txtSerial2.Focus();
            }
            if (txtSerial3.Text.Length == 3 && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                txtSerial4.Focus();
            }
        }

        private void txtSerial4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Back) && txtSerial4.Text.Length == 1)
            {
                txtSerial3.Focus();
            }
            if (txtSerial4.Text.Length == 3 && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                txtSerial5.Focus();
            }
        }

        private void txtSerial5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Back) && txtSerial5.Text.Length == 1)
            {
                txtSerial4.Focus();
            }
            if (txtSerial5.Text.Length == 3 && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                txtSerial6.Focus();
            }
        }

        private void txtSerial6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Back) && txtSerial6.Text.Length == 1)
            {
                txtSerial5.Focus();
            }
            if (txtSerial6.Text.Length == 3 && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                btnValidar.Enabled = true;
                btnValidar.Focus();
            }
        }

        private void linkLblActivación_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblTerminosLicencia.Visible = false;
            cbTerminos.Visible = false;
            linkLblActivación.Visible = false;
            lblSerial.Visible = true;
            lblGuion1.Visible = true;
            lblGuion2.Visible = true;
            lblGuion3.Visible = true;
            lblGuion4.Visible = true;
            lblGuion5.Visible = true;
            txtSerial1.Visible = true;
            txtSerial2.Visible = true;
            txtSerial3.Visible = true;
            txtSerial4.Visible = true;
            txtSerial5.Visible = true;
            txtSerial6.Visible = true;
            btnValidar.Visible = true;
            btnValidar.Enabled = false;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtSerial1.Text == "" || txtSerial2.Text == ""
                || txtSerial3.Text == "" || txtSerial4.Text == ""
                || txtSerial5.Text == "" || txtSerial6.Text == "")
            {
                MessageBox.Show("Serial Key incompleto", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AccesoDatos datos = new AccesoDatos();
                AccesoDatos datos2 = new AccesoDatos();
                EmailService mailService = new EmailService();

                string NombreEquipo = Dns.GetHostName(); //OBTENER NOMBRE DE EQUIPO
                //string IP = Dns.GetHostByName(IPHost).AddressList[0].ToString(); 'OBTENER DIRECCION IP LOCAL'

                int Coincidencias = 0, IdLicencia = 0;
                string serial = txtSerial1.Text + "-" + txtSerial2.Text + "-" + txtSerial3.Text
                        + "-" + txtSerial4.Text + "-" + txtSerial5.Text + "-" + txtSerial6.Text;

                string selectLicencias = "select ID, count(*) Cantidad from Licencias where " +
                                         "Estado = 1 and PWDCOMPARE('" + serial + "', Serial)=1" +
                                         " group by ID";

                try
                {
                    datos.SetearConsulta(selectLicencias);
                    datos.EjecutarLectura();

                    if (datos.Lector.Read() == true)
                    {
                        Coincidencias = Convert.ToInt32(datos.Lector["Cantidad"]);
                        if (Coincidencias != 0)
                        {
                            IdLicencia = Convert.ToInt32(datos.Lector["ID"]);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Se ha producido un error al leer la Base de datos","Error en Base de datos",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                finally
                {
                    datos.CerrarConexion();
                }

                if (Coincidencias > 0 && IdLicencia > 0)
                {
                    string mailDestino = "compugross02.05.13@gmail.com";
                    string asunto = "NUEVO REGISTRO DE LICENCIA DE SOFTWARE - " + DateTime.Now.ToShortDateString();
                    string softwareRegistrado = "CompuGross - ST";
                    string cuerpo = "Sr. Juan Manuel Gross\n\n\n" + 
                        "Le informamos que se ha realizado " +
                        "una activación de licencia de software, correspondiente " +
                        "al programa " + softwareRegistrado + ", en el equipo " + NombreEquipo + "\n\n" +
                        "El ID de la licencia utilizada es el N°" + IdLicencia + "\n\n" +
                        "Saludos cordiales\n\n" +
                        "CompuGross.";

                    string insertActivacion = "insert into Activado(IdLicencia, Estado) " +
                                              "values(" + IdLicencia + ", 1)";

                    try
                    {
                        datos2.SetearConsulta(insertActivacion);
                        datos2.EjecutarLectura();

                        mailService.armarCorreo(mailDestino, asunto, cuerpo);
                        mailService.enviarEmail();

                        MessageBox.Show("Gracias por activar el software de CompuGross\n\n" +
                            "Recuerde que la licencia tiene una validez de un año a partir de este día.\n\n", 
                            "Activación de software exitosa",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        datos2.CerrarConexion();

                        MenuPrincipal frmMenuPrincipal = new MenuPrincipal();
                        this.Hide();
                        frmMenuPrincipal.ShowDialog();
                    }
                    catch
                    {
                        datos2.CerrarConexion();
                        MessageBox.Show("Se produjo un error al intentar enviar el correo.", "Atención",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Licencia inválida.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbTerminos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTerminos.Checked == true)
            {
                linkLblActivación.Enabled = true;
            }
            else
            {
                linkLblActivación.Enabled = false;
            }
        }

        private void lblTerminosLicencia_Click(object sender, EventArgs e)
        {
            string urlLicencia = "https://www.microsoft.com/es-es/store/standard-application-license-terms-eea";

            System.Diagnostics.Process.Start(urlLicencia);

            cbTerminos.Enabled = true;
        }

        private void btnValidar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSerial1.Text.Length < 4 || txtSerial2.Text.Length < 4
                || txtSerial3.Text.Length < 4 || txtSerial4.Text.Length < 4
                || txtSerial5.Text.Length < 4 || txtSerial6.Text.Length < 4)
            {
                btnValidar.Enabled = false;
            }
            else
            {
                btnValidar.Enabled = true;
            }
        }

        private void txtSerial1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSerial1.Text.Length < 4)
            {
                btnValidar.Enabled = false;
            }
            else
            {
                btnValidar.Enabled = true;
            }
        }

        private void txtSerial2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSerial2.Text.Length < 4)
            {
                btnValidar.Enabled = false;
            }
            else
            {
                btnValidar.Enabled = true;
            }
        }

        private void txtSerial3_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSerial3.Text.Length < 4)
            {
                btnValidar.Enabled = false;
            }
            else
            {
                btnValidar.Enabled = true;
            }
        }

        private void txtSerial4_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSerial4.Text.Length < 4)
            {
                btnValidar.Enabled = false;
            }
            else
            {
                btnValidar.Enabled = true;
            }
        }

        private void txtSerial5_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSerial5.Text.Length < 4)
            {
                btnValidar.Enabled = false;
            }
            else
            {
                btnValidar.Enabled = true;
            }
        }

        private void txtSerial6_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSerial6.Text.Length < 4)
            {
                btnValidar.Enabled = false;
            }
            else
            {
                btnValidar.Enabled = true;
            }
        }
    }
}
