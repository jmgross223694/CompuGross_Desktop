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

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public MenuPrincipal(string usuario, string tipoUsuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.tipoUsuario = tipoUsuario;
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
                }
            }
            catch
            {
                MessageBox.Show("No se logueó ningún Usuario.", "Atención !!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            //cargarUsuarioLogueado();

            lblUserTipo.Text = this.usuario + " (" + this.tipoUsuario + ")";

            if (this.tipoUsuario != "admin")
            {
                btnBackup.Visible = false;
                btnUsuarios.Visible = false;
                btnIngresos.Visible = false;
                pnBtnBackup.Visible = false;
                pnBtnUsuarios.Visible = false;
                pnBtnIngresos.Visible = false;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void visibilidadPanelSubMenuClientes(string aux)
        {
            if (aux == "show")
            {
                pnSubMenuClientes.Visible = true;
                imgAgregarCliente.Visible = true;
                imgModificarCliente.Visible = true;
            }
            else if (aux == "hide")
            {
                pnSubMenuClientes.Visible = false;
                imgAgregarCliente.Visible = false;
                imgModificarCliente.Visible = false;
            }
        }

        private void visibilidadPanelSubMenuServicios(string aux)
        {
            if (aux == "show")
            {
                pnSubMenuServicios.Visible = true;
                imgAgregarServicio.Visible = true;
                imgModificarServicio.Visible = true;
            }
            else if (aux == "hide")
            {
                pnSubMenuServicios.Visible = false;
                imgAgregarServicio.Visible = false;
                imgModificarServicio.Visible = false;
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //abrirFormHijo(new Clientes());
            if (pnSubMenuClientes.Visible == false)
            {
                visibilidadPanelSubMenuClientes("show");
                visibilidadPanelSubMenuServicios("hide");
            }
            else
            {
                visibilidadPanelSubMenuClientes("hide");
            }
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.borrarUsuarioLogueado();

            Application.Exit();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AgregarUsuario frmAgregarUsuario = new AgregarUsuario(this.usuario, this.tipoUsuario);
            this.Hide();
            frmAgregarUsuario.ShowDialog();
        }

        private void btnPrecios_Click(object sender, EventArgs e)
        {
            ListadoPrecios frmListadoPrecios = new ListadoPrecios();
            this.Hide();
            frmListadoPrecios.ShowDialog();
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            visibilidadPanelSubMenuClientes("hide");
            visibilidadPanelSubMenuServicios("hide");
            abrirFormHijo(new Ingresos());
        }

        private void btnOrdenesTrabajo_Click(object sender, EventArgs e)
        {
            //abrirFormHijo(new OrdenesTrabajo());
            if (pnSubMenuServicios.Visible == false)
            {
                visibilidadPanelSubMenuServicios("show");
                visibilidadPanelSubMenuClientes("hide");
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
            abrirFormHijo(new Backup());
        }

        private void btnDatosDesplegables_Click(object sender, EventArgs e)
        {
            DatosDesplegables frmDd = new DatosDesplegables();
            this.Hide();
            frmDd.ShowDialog();
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
            string urlCompuGross = "https://www.instagram.com/compugrossok";

            System.Diagnostics.Process.Start(urlCompuGross);
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
                Application.Restart();
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
            abrirFormHijo(new OrdenesTrabajo());
        }

        private void contentPanel_Click(object sender, EventArgs e)
        {
            visibilidadPanelSubMenuClientes("hide");
            visibilidadPanelSubMenuServicios("hide");
        }

        public void abrirFormHijo(object formHijo)
        {
            if (this.contentPanel.Controls.Count > 3)
            {
                this.contentPanel.Controls.RemoveAt(3);
            }
            Form fH = formHijo as Form;
            fH.TopLevel = false;
            fH.Dock = DockStyle.Fill;
            this.contentPanel.Controls.Add(fH);
            this.contentPanel.Tag = fH;
            fH.Show();
        }
    }
}
