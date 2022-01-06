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

namespace CompuGross
{
    public partial class MenuPrincipal : Form
    {
        private string usuario = "", tipoUsuario = "";

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
            cargarUsuarioLogueado();

            lblUser.Text = this.usuario + " (" + this.tipoUsuario + ")";

            if (this.tipoUsuario != "admin")
            {
                btnBackup.Visible = false;
                btnUsuarios.Visible = false;
                btnIngresos.Visible = false;
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes frmClientes = new Clientes();
            this.Hide();
            frmClientes.ShowDialog();
            this.Show();
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
            this.Show();
        }

        private void btnPrecios_Click(object sender, EventArgs e)
        {
            ListaPrecios frmListadoPrecios = new ListaPrecios();
            this.Hide();
            frmListadoPrecios.ShowDialog();
            this.Show();
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            Ingresos frmIngresos = new Ingresos();
            this.Hide();
            frmIngresos.ShowDialog();
            this.Show();
        }

        private void btnOrdenesTrabajo_Click(object sender, EventArgs e)
        {
            OrdenesTrabajo frmOrdenesTrabajo = new OrdenesTrabajo();
            this.Hide();
            frmOrdenesTrabajo.ShowDialog();
            this.Show();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            Backup frmBackup = new Backup();
            this.Hide();
            frmBackup.ShowDialog();
            this.Show();
        }

        private void btnDatosDesplegables_Click(object sender, EventArgs e)
        {
            DatosDesplegables frmDd = new DatosDesplegables();
            this.Hide();
            frmDd.ShowDialog();
            this.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Cerrar la sesión en curso?", "Atención !!",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (confirmResult.ToString() != "No")
            {
                Login frmLogin = new Login();
                this.Hide();
                frmLogin.ShowDialog();
            }
        }
    }
}
