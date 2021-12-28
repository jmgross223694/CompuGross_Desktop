using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Negocio;

namespace CompuGross
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindData()
        {
            txtClave.Enabled = false;
            txtClave.Text = "";
            lblMail.Visible = false;
            txtMail.Text = "";
            txtMail.Visible = false;
            txtMail.MaxLength = 100;
            lblUsuario.Visible = true;
            txtUsuario.Visible = true;
            txtUsuario.Text = "";
            lblClave.Visible = true;
            txtClave.Visible = true;
            lblRecuperarClave.Visible = true;
            lblLargoClave2.Visible = false;
            btnIngresar.Visible = true;
            btnRegistro.Visible = true;
            btnEnviarCodigo.Visible = false;
            lblCodigoRecuperacion.Visible = false;
            lblClaveNueva.Visible = false;
            cbMostrarClave.Visible = false;
        }

        public void ClickBtnIngresar()
        {
            if (txtUsuario.Text == "" || txtClave.Text == "" || txtClave.Text.Length < 8)
            {
                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("Usuario vacío.");
                    txtUsuario.BackColor = Color.LightSalmon;
                    txtUsuario.Focus();
                }
                else
                {
                    txtUsuario.BackColor = Color.White;

                    if (txtClave.Text == "" || txtClave.Text.Length < 8)
                    {
                        MessageBox.Show("Clave inferior a 8 caracteres.");
                        txtClave.BackColor = Color.LightSalmon;
                        txtClave.Focus();
                    }
                    else
                    {
                        txtClave.BackColor = Color.White;
                    }
                }
            }
            else
            {
                AccesoDatos datos = new AccesoDatos();

                string usuario = txtUsuario.Text + ".cg";
                string clave = txtClave.Text;

                string buscarUsuario = "select (select TU.Tipo from TiposUsuario TU where ID = IdTipo) Tipo, " +
                    "Nombre, Apellido, Count(*) as Cantidad " +
                    "from Usuarios where Username = '" + usuario + "' " +
                    "and PWDCOMPARE('" + clave + "', Clave)=1 " +
                    "group by IdTipo, Nombre, Apellido";

                int existe = 0;
                string nombre = "";
                string tipoUsuario = "";
                string apellido = "";

                try
                {
                    datos.SetearConsulta(buscarUsuario);
                    datos.EjecutarLectura();

                    if (datos.Lector.Read() == true)
                    {
                        existe = Convert.ToInt32(datos.Lector["Cantidad"]);
                        nombre = datos.Lector["Nombre"].ToString();
                        apellido = datos.Lector["Apellido"].ToString();
                        tipoUsuario = datos.Lector["Tipo"].ToString();

                        MessageBox.Show("Bienvenido nuevamente "+nombre+" "+apellido, "Log-in exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtUsuario.Text = "";
                        txtClave.Text = "";
                        txtUsuario.BackColor = Color.White;
                        txtClave.BackColor = Color.White;
                        txtClave.Enabled = false;

                        MenuPrincipal frmInicio = new MenuPrincipal(nombre+" "+apellido, tipoUsuario);

                        this.Hide();
                        frmInicio.ShowDialog();
                        this.Show();
                    }
                    else 
                    {
                        MessageBox.Show("Credenciales inválidas.");
                    }
                }
                catch
                {
                    MessageBox.Show("Credenciales inválidas.");
                }
                finally
                {
                    datos.CerrarConexion();
                }
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ClickBtnIngresar();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "") 
            { txtUsuario.BackColor = Color.LightSalmon; txtClave.Enabled = false; }
            else if (txtUsuario.Text.Length < 5) { txtUsuario.BackColor = Color.White; txtClave.Enabled = false; }
            else { txtUsuario.BackColor = Color.White; }

            if (txtUsuario.Text.Length >= 5) { txtClave.Enabled = true; }
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            if (txtClave.Text == "") { txtClave.BackColor = Color.LightSalmon; }
            else { txtClave.BackColor = Color.White; }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtUsuario.Text == "") 
                {
                    MessageBox.Show("Usuario vacío.");
                    txtUsuario.BackColor = Color.LightSalmon;
                    txtUsuario.Focus();
                }
                else if (txtClave.Text == "")
                {
                    txtClave.Focus(); 
                }
                else { ClickBtnIngresar(); }
            }

            soloNumeros(sender, e);
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ClickBtnIngresar();
            }
        }

        private void lblRecuperarClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblMail.Visible = true;
            txtMail.Visible = true;
            lblUsuario.Visible = false;
            txtUsuario.Visible = false;
            lblClave.Visible = false;
            txtClave.Visible = false;
            lblRecuperarClave.Visible = false;
            btnIngresar.Visible = false;
            btnRegistro.Visible = false;
            btnEnviarCodigo.Visible = true;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            AgregarUsuario frmAgregarUsuario = new AgregarUsuario();
            this.Hide();
            frmAgregarUsuario.ShowDialog();
            this.Show();
        }

        private void btnEnviarCodigo_Click(object sender, EventArgs e)
        {
            if (btnEnviarCodigo.Text == "Cambiar Clave")
            {
                if (txtMail.Text == "")
                {
                    MessageBox.Show("Clave nueva vacía.");
                    txtMail.BackColor = Color.LightSalmon;
                    txtMail.Focus();
                }
                else if (txtMail.Text.Length < 8)
                {
                    MessageBox.Show("La clave no puede ser menor a 8 caracteres.");
                    txtMail.BackColor = Color.LightSalmon;
                    txtMail.Focus();
                }
                else if (txtMail.Text.Length > 8)
                {
                    MessageBox.Show("La clave no puede ser mayor a 8 caracteres.");
                    txtMail.BackColor = Color.LightSalmon;
                    txtMail.Focus();
                }
                else
                {
                    int IdUsuario = Convert.ToInt32(txtClave.Text);
                    string ClaveNueva = txtMail.Text;
                    string updateClaveUsuario = "update Usuarios set CodigoRecuperarClave = 0, Clave = PWDENCRYPT('" + ClaveNueva + "') where ID = " + IdUsuario;

                    AccesoDatos datos = new AccesoDatos();

                    try
                    {
                        datos.SetearConsulta(updateClaveUsuario);
                        datos.EjecutarLectura();

                        MessageBox.Show("Clave actualizada correctamente.");

                        BindData();
                    }
                    catch
                    {
                        MessageBox.Show("Error al intentar actualizar la clave.");
                    }
                    finally
                    {
                        datos.CerrarConexion();
                    }
                }
            }
            else if (btnEnviarCodigo.Text == "Validar")
            {
                if (txtMail.Text == "")
                {
                    MessageBox.Show("Código de recuperación vacío.");
                    txtMail.BackColor = Color.LightSalmon;
                    txtMail.Focus();
                }
                else
                {
                    int ID = 0, Cantidad = 0;
                    string mailUsuario = txtUsuario.Text;
                    string selectCodigoMail = "select count(*) as CANTIDAD, ID as ID from Usuarios where Mail = '" + mailUsuario +
                        "' AND CodigoRecuperarClave = " + txtMail.Text + "group by ID";

                    AccesoDatos datos2 = new AccesoDatos();
                    try
                    {
                        datos2.SetearConsulta(selectCodigoMail);
                        datos2.EjecutarLectura();

                        if (datos2.Lector.Read() == true)
                        {
                            ID = Convert.ToInt32(datos2.Lector["ID"]);
                            Cantidad = Convert.ToInt32(datos2.Lector["CANTIDAD"]);
                        }
                        if (ID != 0 && Cantidad != 0)
                        {
                            MessageBox.Show("Código correcto. En el próximo paso deberás ingresar tu nueva clave.");

                            txtClave.Text = ID.ToString();
                            lblCodigoRecuperacion.Visible = false;
                            lblClaveNueva.Visible = true;
                            btnEnviarCodigo.Text = "Cambiar Clave";
                            txtMail.Text = "";

                            txtMail.UseSystemPasswordChar = true;

                            cbMostrarClave.Visible = true;

                            lblLargoClave2.Visible = true;

                            txtMail.MaxLength = 8;
                        }
                        else
                        {
                            MessageBox.Show("Código de recuperación incorrecto.");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error en la Base de datos.");
                    }
                    finally
                    {
                        datos2.CerrarConexion();
                    }
                }
            }
            else
            {
                txtMail.UseSystemPasswordChar = false;
                if (txtMail.Text == "")
                {
                    MessageBox.Show("Mail vacío.");
                    txtMail.BackColor = Color.LightSalmon;
                    txtMail.Focus();
                }
                else
                {
                    int existe = 0, IdUsuario = 0;
                    string mailDestino = "";
                    string selectMail = "select Count(*) as CANTIDAD, Mail as MAIL, ID as ID from Usuarios where Mail = '" + txtMail.Text + "' group by Mail, ID";

                    AccesoDatos datos = new AccesoDatos();

                    try
                    {
                        datos.SetearConsulta(selectMail);
                        datos.EjecutarLectura();

                        if (datos.Lector.Read() == true)
                        {
                            existe = Convert.ToInt32(datos.Lector["CANTIDAD"]);
                            mailDestino = datos.Lector["MAIL"].ToString();
                            IdUsuario = Convert.ToInt32(datos.Lector["ID"]);
                            txtUsuario.Text = mailDestino;
                        }
                        if (existe != 0 && mailDestino != "")
                        {
                            Random numRandom = new Random();

                            int codigoMail = numRandom.Next(100000, 999999);

                            if (codigoMail < 0) { codigoMail = codigoMail * (-1); }

                            string asunto = "COMPUGROSS - RECUPERAR CONTRASEÑA (" + DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToShortTimeString() + " hs)";
                            string cuerpo = "Este mail ha sido enviado debido a que olvidaste tu clave.\n\n" +
                                "Si no has sido tú, ponte en contacto con nosotros de manera inmediata.\n\n" +
                                "Si has sido tú, debes ingresar este código para poder crear una nueva clave: '" + codigoMail + "'\n\n\n" +
                                "Saludos cordiales.\n\nCompuGross";

                            EmailService mail = new EmailService();

                            try
                            {
                                MessageBoxTemporal.Show("Se está enviando un código de recuperación al mail '" + mailDestino + "'\n\n" +
                                        "Por favor aguarde unos instantes...",
                                        "Envío de mail", 3, true);

                                mail.armarCorreo(mailDestino, asunto, cuerpo);
                                mail.enviarEmail();
                                MessageBox.Show("Revisa tu mail, se ha enviado un código para que puedas recuperar tu clave.");
                            }
                            catch
                            {
                                MessageBox.Show("Error al intentar enviar el mail.");
                            }

                            string updateCodigoRecuperacion = "update Usuarios set CodigoRecuperarClave = " + codigoMail + " where ID = " + IdUsuario;

                            AccesoDatos datos3 = new AccesoDatos();

                            try
                            {
                                datos3.SetearConsulta(updateCodigoRecuperacion);
                                datos3.EjecutarLectura();

                                txtMail.Text = "";
                                lblMail.Visible = false;
                                lblCodigoRecuperacion.Visible = true;
                                btnEnviarCodigo.Text = "Validar";
                            }
                            catch
                            {
                                MessageBox.Show("Error al agregar el código de recuperación a la Base de datos.");
                            }
                            finally
                            {
                                datos3.CerrarConexion();
                            }
                        }
                        else
                        {
                            MessageBox.Show("El mail " + txtMail.Text + " no existe en el sistema.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        datos.CerrarConexion();
                    }
                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (txtMail.Visible == true)
            {
                BindData();
            }
            else
            {
                Application.Exit();
            }
        }

        private void cbMostrarClave_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarClave.Checked == true)
            {
                txtMail.UseSystemPasswordChar = false;
            }
            else
            {
                txtMail.UseSystemPasswordChar = true;
            }
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public class MessageBoxTemporal
        {
            System.Threading.Timer IntervaloTiempo;
            string TituloMessageBox;
            string TextoMessageBox;
            int TiempoMaximo;
            IntPtr hndLabel = IntPtr.Zero;
            bool MostrarContador;

            MessageBoxTemporal(string texto, string titulo, int tiempo, bool contador)
            {
                TituloMessageBox = titulo;
                TiempoMaximo = tiempo;
                TextoMessageBox = texto;
                MostrarContador = contador;

                if (TiempoMaximo > 99) return; //Máximo 99 segundos
                IntervaloTiempo = new System.Threading.Timer(EjecutaCada1Segundo,
                    null, 1000, 1000);
                if (contador)
                {
                    DialogResult ResultadoMensaje = MessageBox.Show(texto, titulo);
                    if (ResultadoMensaje == DialogResult.None) IntervaloTiempo.Dispose();
                }
                else
                {
                    DialogResult ResultadoMensaje = MessageBox.Show(texto, titulo);
                    if (ResultadoMensaje == DialogResult.None) IntervaloTiempo.Dispose();
                }
            }
            public static void Show(string texto, string titulo, int tiempo, bool contador)
            {
                new MessageBoxTemporal(texto, titulo, tiempo, contador);
            }
            void EjecutaCada1Segundo(object state)
            {
                TiempoMaximo--;
                if (TiempoMaximo <= 0)
                {
                    IntPtr hndMBox = FindWindow(null, TituloMessageBox);
                    if (hndMBox != IntPtr.Zero)
                    {
                        SendMessage(hndMBox, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                        IntervaloTiempo.Dispose();
                    }
                }
                else if (MostrarContador)
                {
                    // Ha pasado un intervalo de 1 seg:
                    if (hndLabel != IntPtr.Zero)
                    {
                        SetWindowText(hndLabel, TextoMessageBox +
                            "\r\nEste mensaje se cerrará dentro de " +
                            TiempoMaximo.ToString("00") + " segundos");
                    }
                    else
                    {
                        IntPtr hndMBox = FindWindow(null, TituloMessageBox);
                        if (hndMBox != IntPtr.Zero)
                        {
                            // Ha encontrado el MessageBox, busca ahora el texto
                            hndLabel = FindWindowEx(hndMBox, IntPtr.Zero, "Static", null);
                            if (hndLabel != IntPtr.Zero)
                            {
                                // Ha encontrado el texto porque el MessageBox
                                // solo tiene un control "Static".
                                SetWindowText(hndLabel, TextoMessageBox +
                                    "\r\nEste mensaje se cerrará dentro de " +
                                    TiempoMaximo.ToString("00") + " segundos");
                            }
                        }
                    }
                }
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll",
                CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true,
                CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter,
                string lpszClass, string lpszWindow);
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true,
                CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern bool SetWindowText(IntPtr hwnd, string lpString);
        }
    }
}
