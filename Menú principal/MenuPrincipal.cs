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
using System.Runtime.InteropServices;

namespace CompuGross
{
    public partial class MenuPrincipal : Form
    {
        private string usuario = "", tipoUsuario = "";
        private Form formActual = null;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void cargarUsuarioLogueado()
        {
            AccesoDatos datos = new AccesoDatos();

            string selectUser = "select * from UsuarioLogueado where ID = 1";

            try
            {
                datos.SetearConsulta(selectUser);
                datos.EjecutarLectura();

                if (datos.Lector.Read())
                {
                    this.usuario = datos.Lector["Username"].ToString();
                    this.tipoUsuario = datos.Lector["Tipo"].ToString();
                    lblUserTipo.Text = this.usuario+" ("+this.tipoUsuario+")";
                }

                if (this.tipoUsuario != "admin")
                {
                    btnBackup.Visible = false;
                    btnUsuarios.Visible = false;
                    btnReportes.Visible = false;
                    pnBtnBackup.Visible = false;
                    pnBtnUsuarios.Visible = false;
                    pnBtnInformes.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("No se logueó ningún Usuario.", "Atención !!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void actualizarUsuarioLogueado(string nombre, string apellido, string tipoUsuario)
        {
            AccesoDatos datos = new AccesoDatos();
            string updateUsuarioLogueado = "update UsuarioLogueado set Username = '" + nombre + " " + apellido + "', " +
                    "Tipo = '" + tipoUsuario + "' where ID = 1";

            try
            {
                datos.SetearConsulta(updateUsuarioLogueado);
                datos.EjecutarLectura();
            }
            catch
            {
                MessageBox.Show("No se pudo actualizar el usuario logueado.", "Atención !!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void ClickBtnIngresar()
        {
            bool ingreso = false;

            if (txtDni.Text == "" || txtDni.Text.Length < 7)
            {
                MessageBox.Show("DNI inválido.");
                txtDni.Focus();
            }
            else if (txtClave.Text == "")
            {
                MessageBox.Show("Contraseña vacía.");
                txtClave.Focus();
            }
            else if (txtClave.Text.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener entre 8-15 caracteres.");
                txtClave.Focus();
            }
            else
            {
                AccesoDatos datos = new AccesoDatos();

                string usuario = txtDni.Text;
                string clave = txtClave.Text;

                string buscarUsuario = "select (select TU.Tipo from TiposUsuario TU where ID = IdTipo) Tipo, " +
                    "Nombre, Apellido, Count(*) as Cantidad " +
                    "from Usuarios where Username = '" + usuario + "' " +
                    "and PWDCOMPARE('" + clave + "', Clave)=1 " +
                    "group by IdTipo, Nombre, Apellido";

                string nombre = "";
                string tipoUsuario = "";
                string apellido = "";

                try
                {
                    datos.SetearConsulta(buscarUsuario);
                    datos.EjecutarLectura();

                    if (datos.Lector.Read() == true)
                    {
                        nombre = datos.Lector["Nombre"].ToString();
                        apellido = datos.Lector["Apellido"].ToString();
                        tipoUsuario = datos.Lector["Tipo"].ToString();

                        ingreso = true;
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

                actualizarUsuarioLogueado(nombre, apellido, tipoUsuario);

                if (ingreso)
                {
                    //mostrar Controles MenuPrincipal
                    btnClientes.Visible = true;
                    pnBtnClientes.Visible = true;
                    btnServicios.Visible = true;
                    pnBtnServicios.Visible = true;
                    btnPresupuesto.Visible = true;
                    pnBtnPresupuesto.Visible = true;
                    btnPrecios.Visible = true;
                    pnBtnPrecios.Visible = true;
                    btnLocalidades.Visible = true;
                    btnReportes.Visible = true;
                    pnBtnInformes.Visible = true;
                    btnBackup.Visible = true;
                    pnBtnBackup.Visible = true;
                    btnUsuarios.Visible = true;
                    pnBtnUsuarios.Visible = true;
                    btnCerrarSesion.Visible = true;
                    lblUsuario.Visible = true;
                    lblUserTipo.Visible = true;

                    cargarUsuarioLogueado();

                    //ocultar Controles Login
                    lblDni.Visible = false;
                    lblClave.Visible = false;
                    txtDni.Visible = false;
                    txtClave.Visible = false;
                    lblRecuperarClave.Visible = false;
                    btnIngresar.Visible = false;
                    lblTitulo.Visible = false;
                    cbMostrarClave1.Visible = false;
                }
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            //mostrar Campos Login
            txtDni.Text = "";
            txtClave.Text = "";
            txtRecuperarClave.Text = "";
            lblDni.Visible = true;
            lblClave.Visible = true;
            txtDni.Visible = true;
            txtClave.Visible = true;
            txtClave.Enabled = false;
            lblRecuperarClave.Visible = true;
            btnIngresar.Visible = true;
            btnIngresar.Enabled = false;
            lblTitulo.Visible = true;

            //ocultar Controles menuPrincipal
            btnClientes.Visible = false;
            pnBtnClientes.Visible = false;
            btnServicios.Visible = false;
            pnBtnServicios.Visible = false;
            btnPresupuesto.Visible = false;
            pnBtnPresupuesto.Visible = false;
            btnPrecios.Visible = false;
            pnBtnPrecios.Visible = false;
            btnLocalidades.Visible = false;
            btnReportes.Visible = false;
            pnBtnInformes.Visible = false;
            btnBackup.Visible = false;
            pnBtnBackup.Visible = false;
            btnUsuarios.Visible = false;
            pnBtnUsuarios.Visible = false;
            btnCerrarSesion.Visible = false;
            lblUsuario.Visible = false;
            lblUserTipo.Visible = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void borrarUsuarioLogueado()
        {
            string updateUsuarioLogueado = "update UsuarioLogueado set Username = 'test', Tipo = 'test' " +
                "where ID = 1";

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta(updateUsuarioLogueado);
                datos.EjecutarLectura();
            }
            catch
            {
                MessageBox.Show("No se pudo quitar el usuario logueado de la DB.");
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        private void visibilidadPanelSubMenuInformes(string aux)
        {
            if (aux == "show")
            {
                pnSubMenuInformes.Visible = true;
            }
            else if (aux == "hide")
            {
                pnSubMenuInformes.Visible = false;
            }
        }

        private void visibilidadPanelSubMenuClientes(string aux)
        {
            if (aux == "show")
            {
                pnSubMenuClientes.Visible = true;
            }
            else if (aux == "hide")
            {
                pnSubMenuClientes.Visible = false;
            }
        }

        private void visibilidadPanelSubMenuServicios(string aux)
        {
            if (aux == "show")
            {
                pnSubMenuServicios.Visible = true;
            }
            else if (aux == "hide")
            {
                pnSubMenuServicios.Visible = false;
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (pnSubMenuClientes.Visible == false)
            {
                visibilidadPanelSubMenuClientes("show");
                visibilidadPanelSubMenuServicios("hide");
                visibilidadPanelSubMenuInformes("hide");
            }
            else
            {
                visibilidadPanelSubMenuClientes("hide");
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            visibilidadPanelSubMenuClientes("hide");
            visibilidadPanelSubMenuServicios("hide");
            visibilidadPanelSubMenuInformes("hide");
            abrirFormHijo(new ABMUsuarios(this.usuario, this.tipoUsuario));
        }

        private void btnPrecios_Click(object sender, EventArgs e)
        {
            visibilidadPanelSubMenuClientes("hide");
            visibilidadPanelSubMenuServicios("hide");
            visibilidadPanelSubMenuInformes("hide");
            abrirFormHijo(new ListadoPrecios());
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            visibilidadPanelSubMenuClientes("hide");
            visibilidadPanelSubMenuServicios("hide");
            visibilidadPanelSubMenuInformes("hide");
            abrirFormHijo(new Ingresos());
        }

        private void btnOrdenesTrabajo_Click(object sender, EventArgs e)
        {
            if (pnSubMenuServicios.Visible == false)
            {
                visibilidadPanelSubMenuServicios("show");
                visibilidadPanelSubMenuClientes("hide");
                visibilidadPanelSubMenuInformes("hide");
            }
            else
            {
                visibilidadPanelSubMenuServicios("hide");
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            visibilidadPanelSubMenuClientes("hide");
            visibilidadPanelSubMenuServicios("hide");
            visibilidadPanelSubMenuInformes("hide");
            abrirFormHijo(new Backup());
        }

        private void btnLocalidades_Click(object sender, EventArgs e)
        {
            visibilidadPanelSubMenuClientes("hide");
            abrirFormHijo(new Localidades());
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir del programa?", "Atención!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximize.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconoCG_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Abrir Instagram de CompuGross?", "Atención!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string urlCompuGross = "https://www.instagram.com/compugrossok";

                System.Diagnostics.Process.Start(urlCompuGross);
            }
        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Cerrar la sesión en curso?", "Atención !!",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (confirmResult.ToString() != "No")
            {
                if (formActual != null)
                {
                    this.contentPanel.Controls.Remove(formActual);
                }

                borrarUsuarioLogueado();

                //ocultar Campos Menu
                btnClientes.Visible = false;
                pnBtnClientes.Visible = false;
                btnServicios.Visible = false;
                pnBtnServicios.Visible = false;
                btnPresupuesto.Visible = false;
                pnBtnPresupuesto.Visible = false;
                btnPrecios.Visible = false;
                pnBtnPrecios.Visible = false;
                btnLocalidades.Visible = false;
                btnReportes.Visible = false;
                pnBtnInformes.Visible = false;
                btnBackup.Visible = false;
                pnBtnBackup.Visible = false;
                btnUsuarios.Visible = false;
                pnBtnUsuarios.Visible = false;
                btnCerrarSesion.Visible = false;
                lblUsuario.Visible = false;
                lblUserTipo.Visible = false;

                //mostrar Campos Login
                txtDni.Text = "";
                txtClave.Text = "";
                txtRecuperarClave.Text = "";
                lblDni.Visible = true;
                lblClave.Visible = true;
                txtDni.Visible = true;
                txtClave.Visible = true;
                txtClave.Enabled = false;
                lblRecuperarClave.Visible = true;
                btnIngresar.Visible = true;
                btnIngresar.Enabled = false;
                lblTitulo.Visible = true;
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            visibilidadPanelSubMenuClientes("hide");
            abrirFormHijo(new Clientes());
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            visibilidadPanelSubMenuClientes("hide");
            abrirFormHijo(new AgregarCliente());
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            visibilidadPanelSubMenuClientes("hide");
            visibilidadPanelSubMenuServicios("hide");
            abrirFormHijo(new AgregarOrden());
        }

        private void btnModificarServicio_Click(object sender, EventArgs e)
        {
            visibilidadPanelSubMenuClientes("hide");
            visibilidadPanelSubMenuServicios("hide");
            abrirFormHijo(new Servicios());
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ClickBtnIngresar();
        }

        private bool validarMinusculaClave(string clave)
        {
            bool resultado = false;
            string claveMinuscula = clave.ToLower();
            int minuscula = 0;

            for (int i = 0; i < clave.Length; i++)
            {
                if (!char.IsDigit(clave[i]) && clave[i] == claveMinuscula[i])
                {
                    minuscula++;
                }
            }

            if (minuscula > 0) { resultado = true; }

            return resultado;
        }

        private bool validarMayusculaClave(string clave)
        {
            bool resultado = false;
            string claveMayuscula = clave.ToUpper();
            int mayuscula = 0;

            for (int i = 0; i < clave.Length; i++)
            {
                if (!char.IsDigit(clave[i]) && clave[i] == claveMayuscula[i])
                {
                    mayuscula++;
                }
            }

            if (mayuscula > 0) { resultado = true; }

            return resultado;
        }

        private bool validarNumeroClave(string clave)
        {
            bool resultado = false;
            int numero = 0;

            for (int i = 0; i < clave.Length; i++)
            {
                if (char.IsNumber(clave, i))
                {
                    numero++;
                }
            }

            if (numero > 0) { resultado = true; }

            return resultado;
        }

        private void btnEnviarCodigo_Click(object sender, EventArgs e)
        {
            if (btnEnviarCodigo.Text == "Cambiar Clave")
            {
                bool claveValida = false;
                string claveNueva = txtRecuperarClave.Text;
                int len = claveNueva.Length;

                if (claveNueva == "")
                {
                    MessageBox.Show("Clave nueva vacía.");
                    txtRecuperarClave.Focus();
                }
                else
                {
                    bool mayuscula = validarMayusculaClave(claveNueva),
                     minuscula = validarMinusculaClave(claveNueva),
                     numero = validarNumeroClave(claveNueva);

                    if (mayuscula && minuscula && numero && len == 8) { claveValida = true; }
                }
                if (claveValida)
                {
                    int IdUsuario = Convert.ToInt32(txtClave.Text);
                    string updateClaveUsuario = "update Usuarios set CodigoRecuperarClave = 0, " +
                        "Clave = PWDENCRYPT('" + claveNueva + "') where ID = " + IdUsuario;

                    AccesoDatos datos = new AccesoDatos();

                    try
                    {
                        datos.SetearConsulta(updateClaveUsuario);
                        datos.EjecutarLectura();

                        MessageBox.Show("Clave actualizada correctamente.");

                        lblTitulo.Text = "Log-in";
                        lblTitulo.Location = new System.Drawing.Point(348, 47);

                        //mostrar Campos Login
                        txtDni.Text = "";
                        txtClave.Text = "";
                        txtRecuperarClave.Text = "";
                        lblDni.Visible = true;
                        lblClave.Visible = true;
                        txtDni.Visible = true;
                        txtClave.Visible = true;
                        txtClave.Enabled = false;
                        lblRecuperarClave.Visible = true;
                        btnIngresar.Visible = true;
                        btnIngresar.Enabled = false;
                        lblTitulo.Visible = true;

                        //ocultar Campos Recuperar Clave
                        lblIngreseCodigo.Visible = false;
                        lblClaveNueva.Visible = false;
                        txtRecuperarClave.Text = "";
                        txtRecuperarClave.Visible = false;
                        cbMostrarClave2.Visible = false;
                        lblCaracteres.Visible = false;
                        lblMayuscula.Visible = false;
                        lblMinuscula.Visible = false;
                        lblNumero.Visible = false;
                        btnEnviarCodigo.Text = "Enviar código";
                        btnEnviarCodigo.Visible = false;

                        //ocultar Controles menuPrincipal
                        btnClientes.Visible = false;
                        pnBtnClientes.Visible = false;
                        btnServicios.Visible = false;
                        pnBtnServicios.Visible = false;
                        btnPresupuesto.Visible = false;
                        pnBtnPresupuesto.Visible = false;
                        btnPrecios.Visible = false;
                        pnBtnPrecios.Visible = false;
                        btnLocalidades.Visible = false;
                        btnReportes.Visible = false;
                        pnBtnInformes.Visible = false;
                        btnBackup.Visible = false;
                        pnBtnBackup.Visible = false;
                        btnUsuarios.Visible = false;
                        pnBtnUsuarios.Visible = false;
                        btnCerrarSesion.Visible = false;
                        lblUsuario.Visible = false;
                        lblUserTipo.Visible = false;
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
                if (txtRecuperarClave.Text == "")
                {
                    MessageBox.Show("Código inválido.");
                    txtRecuperarClave.Focus();
                }
                else
                {
                    int ID = 0, Cantidad = 0;
                    string mailUsuario = txtClave.Text;
                    string selectCodigoMail = "select count(*) as CANTIDAD, ID as ID from Usuarios where Mail = '" + mailUsuario +
                        "' AND CodigoRecuperarClave = " + txtRecuperarClave.Text + "group by ID";

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
                            MessageBox.Show("Código correcto. Por favor ingresá tu nueva clave.");

                            txtClave.Text = ID.ToString();
                            lblClaveNueva.Visible = true;
                            lblIngreseCodigo.Visible = false;
                            btnEnviarCodigo.Text = "Cambiar Clave";
                            txtRecuperarClave.Text = "";
                            txtRecuperarClave.UseSystemPasswordChar = true;
                            cbMostrarClave2.Visible = true;
                            txtRecuperarClave.MaxLength = 8;
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
                txtRecuperarClave.UseSystemPasswordChar = false;
                if (txtRecuperarClave.Text == "")
                {
                    MessageBox.Show("DNI vacío.");
                    txtRecuperarClave.Focus();
                }
                else
                {
                    string dni = txtRecuperarClave.Text;
                    int existe = 0, IdUsuario = 0;
                    string mailDestino = "";
                    string selectMail = "select Count(*) Cantidad, Mail, ID from Usuarios " +
                        "where Username = '" + dni + "' group by Mail, ID";

                    AccesoDatos datos = new AccesoDatos();

                    try
                    {
                        datos.SetearConsulta(selectMail);
                        datos.EjecutarLectura();

                        if (datos.Lector.Read() == true)
                        {
                            existe = Convert.ToInt32(datos.Lector["Cantidad"]);
                            mailDestino = datos.Lector["Mail"].ToString();
                            IdUsuario = Convert.ToInt32(datos.Lector["ID"]);
                            txtClave.Text = mailDestino;
                        }
                        if (existe != 0 && mailDestino != "")
                        {
                            Random numRandom = new Random();

                            int codigoMail = numRandom.Next(100000, 999999);

                            if (codigoMail < 0) { codigoMail = codigoMail * (-1); }

                            string asunto = "COMPUGROSS - RECUPERAR CONTRASEÑA (" + DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToShortTimeString() + " hs)";
                            string cuerpo = "Este mail ha sido enviado debido a que solicitaste un cambio de clave.\n\n" +
                                "Si no has sido tú, ponte en contacto con nosotros de manera inmediata.\n\n" +
                                "Debes ingresar este código para poder crear una nueva clave: '" + codigoMail + "'\n\n\n" +
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

                                string updateCodigoRecuperacion = "update Usuarios set CodigoRecuperarClave = " + codigoMail + " where ID = " + IdUsuario;

                                AccesoDatos datos3 = new AccesoDatos();

                                try
                                {
                                    datos3.SetearConsulta(updateCodigoRecuperacion);
                                    datos3.EjecutarLectura();

                                    txtRecuperarClave.Text = "";
                                    lblDni.Visible = false; ;
                                    lblIngreseCodigo.Visible = true;
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
                            catch
                            {
                                MessageBox.Show("Error al intentar enviar el mail.");
                                txtRecuperarClave.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("El DNI " + dni + " no existe en el sistema.", "Atención!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cbMostrarClave2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarClave2.Checked == true)
            {
                txtRecuperarClave.UseSystemPasswordChar = false;
            }
            else
            {
                txtRecuperarClave.UseSystemPasswordChar = true;
            }
        }

        private void cbMostrarClave1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarClave1.Checked)
            {
                txtClave.UseSystemPasswordChar = false;
            }
            else
            {
                txtClave.UseSystemPasswordChar = true;
            }
        }

        private void lblRecuperarClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblDni.Visible = true;
            txtRecuperarClave.Visible = true;
            lblUsuario.Visible = false;
            txtDni.Visible = false;
            lblClave.Visible = false;
            txtClave.Visible = false;
            lblRecuperarClave.Visible = false;
            btnIngresar.Visible = false;
            btnEnviarCodigo.Visible = true;
            cbMostrarClave1.Visible = false;

            lblTitulo.Text = "Recuperar contraseña";
            lblTitulo.Location = new System.Drawing.Point(218, 47);
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (txtDni.Text == "" || txtDni.Text.Length < 7)
            {
                if (txtDni.Text.Length < 7)
                {
                    txtClave.Text = "";
                }
                txtClave.Enabled = false;
            }
            else
            {
                txtClave.Enabled = true;
            }
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            if (txtClave.Text == "" || txtClave.Text.Length < 8)
            {
                btnIngresar.Enabled = false;
            }
            else
            {
                btnIngresar.Enabled = true;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtDni.Text == "")
                {
                    MessageBox.Show("DNI inválido.");
                    txtDni.Focus();
                }
                else if (txtClave.Text == "")
                {
                    txtClave.Focus();
                }
                else { ClickBtnIngresar(); }
            }

            soloNumeros(sender, e);
        }

        public void abrirFormHijo(object formHijo)
        {
            if (formActual != null)
            {
                this.contentPanel.Controls.Remove(formActual);
            }

            Form fH = formHijo as Form;
            fH.TopLevel = false;
            fH.Dock = DockStyle.Fill;
            this.contentPanel.Controls.Add(fH);
            this.contentPanel.Tag = fH;
            fH.Show();
            formActual = fH as Form;
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && btnIngresar.Enabled)
            {
                ClickBtnIngresar();
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

        private void txtClave_Enter(object sender, EventArgs e)
        {
            cbMostrarClave1.Visible = true;
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {

        }

        private void txtRecuperarClave_TextChanged(object sender, EventArgs e)
        {
            if (btnEnviarCodigo.Text == "Cambiar Clave")
            {
                string claveNueva = txtRecuperarClave.Text;

                if (claveNueva == "")
                {
                    lblCaracteres.Visible = true;
                    lblMayuscula.Visible = true;
                    lblMinuscula.Visible = true;
                    lblNumero.Visible = true;
                }
                else
                {
                    int len = claveNueva.Length;

                    bool mayuscula = validarMayusculaClave(claveNueva),
                         minuscula = validarMinusculaClave(claveNueva),
                         numero = validarNumeroClave(claveNueva);

                    if (len >= 8) { lblCaracteres.Visible = false; }
                    else { lblCaracteres.Visible = true; }

                    if (mayuscula) { lblMayuscula.Visible = false; }
                    else { lblMayuscula.Visible = true; }

                    if (minuscula) { lblMinuscula.Visible = false; }
                    else { lblMinuscula.Visible = true; }

                    if (numero) { lblNumero.Visible = false; }
                    else { lblNumero.Visible = true; }
                }
            }
        }

        private void txtRecuperarClave_Enter(object sender, EventArgs e)
        {
            if (btnEnviarCodigo.Text == "Cambiar Clave")
            {
                cbMostrarClave2.Visible = true;

                string claveNueva = txtRecuperarClave.Text;

                if (claveNueva == "")
                {
                    lblCaracteres.Visible = true;
                    lblMayuscula.Visible = true;
                    lblMinuscula.Visible = true;
                    lblNumero.Visible = true;
                }
                else
                {
                    int len = claveNueva.Length;

                    bool mayuscula = validarMayusculaClave(claveNueva),
                         minuscula = validarMinusculaClave(claveNueva),
                         numero = validarNumeroClave(claveNueva);

                    if (len >= 8) { lblCaracteres.Visible = false; }
                    else { lblCaracteres.Visible = true; }

                    if (mayuscula) { lblMayuscula.Visible = false; }
                    else { lblMayuscula.Visible = true; }

                    if (minuscula) { lblMinuscula.Visible = false; }
                    else { lblMinuscula.Visible = true; }

                    if (numero) { lblNumero.Visible = false; }
                    else { lblNumero.Visible = true; }
                }
            }
        }

        private void txtRecuperarClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (btnEnviarCodigo.Text == "Validar")
            {
                txtRecuperarClave.MaxLength = 8;
                soloNumeros(sender, e);
            }
            else if (btnEnviarCodigo.Text == "Cambiar Clave")
            {
                txtRecuperarClave.MaxLength = 15;
            }
        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            visibilidadPanelSubMenuClientes("hide");
            visibilidadPanelSubMenuServicios("hide");
            abrirFormHijo(new Presupuesto());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (pnSubMenuInformes.Visible == false)
            {
                visibilidadPanelSubMenuInformes("show");
                visibilidadPanelSubMenuClientes("hide");
                visibilidadPanelSubMenuServicios("hide");
            }
            else
            {
                visibilidadPanelSubMenuInformes("hide");
            }
        }

        private void btnServiciosPorCliente_Click(object sender, EventArgs e)
        {
            visibilidadPanelSubMenuClientes("hide");
            visibilidadPanelSubMenuServicios("hide");
            visibilidadPanelSubMenuInformes("hide");
            abrirFormHijo(new ReportePorCliente());
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
