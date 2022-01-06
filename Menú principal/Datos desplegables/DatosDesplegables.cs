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
    public partial class DatosDesplegables : Form
    {
        public DatosDesplegables()
        {
            InitializeComponent();
        }

        private void btnLocalidades_Click(object sender, EventArgs e)
        {
            Localidades frmLocalidades = new Localidades();
            this.Hide();
            frmLocalidades.ShowDialog();
            this.Show();
        }
        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal frmMenu = new MenuPrincipal();
            this.Hide();
            frmMenu.ShowDialog();
        }

        private void DatosDesplegables_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.borrarUsuarioLogueado();

            Application.Exit();
        }
    }
}
