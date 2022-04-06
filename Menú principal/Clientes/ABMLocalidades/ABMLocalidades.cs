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
    public partial class Localidades : Form
    {
        private string LocalidadSeleccionada = "";

        public Localidades()
        {
            InitializeComponent();
        }

        private void btnGuardarClick()
        {
            string localidad = txtLocalidad.Text;

            if (localidad == "" || localidad == "-")
            {
                MessageBox.Show("Localidad vacía.", "Atención!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLocalidad.Focus();
            }
            else
            {   //Modificar Localidad
                if (lblLocalidad.Text != "Nueva Localidad" &&
                    MessageBox.Show("¿Confirma la modificación?", "Atención!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string update = "update Localidades set Descripcion = '" + localidad + "' " +
                    "where Descripcion = '" + this.LocalidadSeleccionada + "'";

                    AccesoDatos datos = new AccesoDatos();

                    try
                    {
                        datos.SetearConsulta(update);
                        datos.EjecutarLectura();

                        MessageBox.Show("Localidad modificada correctamente.", "Atención!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                        cargarDdlLocalidades();
                        btnCancelar.Visible = false;
                        btnConfirmar.Visible = false;
                        lblLocalidad.Visible = false;
                        txtLocalidad.Visible = false;
                        listLocalidades.Visible = true;
                        btnEliminar.Visible = true;
                        btnAgregar.Visible = true;
                        btnModificar.Visible = true;

                        txtLocalidad.Text = "";
                    }
                    catch
                    {
                        MessageBox.Show("No se pudo modificar la localidad, reintente más tarde.", "Atención!!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        datos.CerrarConexion();
                    }
                }
                else //Agregar Nueva Localidad
                {
                    if (MessageBox.Show("¿Confirma la nueva Localidad?", "Atención!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string insert = "insert into Localidades(Descripcion) values('" + localidad + "')";

                        AccesoDatos datos = new AccesoDatos();

                        try
                        {
                            datos.SetearConsulta(insert);
                            datos.EjecutarLectura();

                            MessageBox.Show("Localidad agregada correctamente.", "Atención!!",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);

                            cargarDdlLocalidades();
                            btnCancelar.Visible = false;
                            btnConfirmar.Visible = false;
                            lblLocalidad.Visible = false;
                            txtLocalidad.Visible = false;
                            listLocalidades.Visible = true;
                            btnEliminar.Visible = true;
                            btnAgregar.Visible = true;
                            btnModificar.Visible = true;

                            txtLocalidad.Text = "";
                        }
                        catch
                        {
                            MessageBox.Show("La localidad ya existe en el sistema.", "Atención!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        finally
                        {
                            datos.CerrarConexion();
                        }
                    }
                }
            }
        }

        private void cargarDdlLocalidades()
        {
            listLocalidades.Items.Clear();

            string selectLocalidades = "select * from Localidades where Estado = 1 order by Descripcion asc";
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta(selectLocalidades);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    if (datos.Lector["Descripcion"].ToString() != "-")
                    {
                        listLocalidades.Items.Add(datos.Lector["Descripcion"].ToString());
                    }
                }
                listLocalidades.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al leer la tabla Localidades en la base de datos.");
                this.Close();
            }
            finally
            {
                datos.CerrarConexion();
            }
            listLocalidades.Focus();
        }

        private void Localidades_Load(object sender, EventArgs e)
        {
            cargarDdlLocalidades();
            btnCancelar.Visible = false;
            btnConfirmar.Visible = false;
            lblLocalidad.Visible = false;
            txtLocalidad.Visible = false;
            listLocalidades.Visible = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            btnGuardarClick();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnAgregarClick();
        }

        private void btnAgregarClick()
        {
            btnCancelar.Visible = true;
            btnConfirmar.Visible = true;
            lblLocalidad.Visible = true;
            lblLocalidad.Text = "Nueva Localidad";
            txtLocalidad.Visible = true;
            txtLocalidad.Text = "";
            listLocalidades.Visible = false;
            btnEliminar.Visible = false;
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnModificarClick();
        }

        private void btnModificarClick()
        {
            string localidad = listLocalidades.SelectedItem.ToString();

            btnCancelar.Visible = true;
            btnConfirmar.Visible = true;
            btnConfirmar.Text = "Guardar";
            lblLocalidad.Visible = true;
            lblLocalidad.Text = "Modificando la Localidad   '" + localidad.ToUpper() + "'";
            txtLocalidad.Visible = true;
            listLocalidades.Visible = false;
            btnEliminar.Visible = true;
            btnAgregar.Visible = false;
            btnModificar.Visible = false;

            this.LocalidadSeleccionada = localidad;

            txtLocalidad.Text = localidad;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            btnEliminarClick();
        }

        private void btnEliminarClick()
        {
            string localidad = listLocalidades.SelectedItem.ToString();

            if (MessageBox.Show("¿Seguro que desea eliminar la Localidad " + localidad.ToUpper() + "?", "Atención!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string delete = "delete from Localidades where Descripcion = '" + localidad + "'";

                AccesoDatos datos = new AccesoDatos();

                try
                {
                    datos.SetearConsulta(delete);
                    datos.EjecutarLectura();

                    MessageBox.Show("Se ha eliminado la Localidad " + localidad.ToUpper(), "Atención!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    cargarDdlLocalidades();
                    btnCancelar.Visible = false;
                    btnConfirmar.Visible = false;
                    lblLocalidad.Visible = false;
                    txtLocalidad.Visible = false;
                    txtLocalidad.Text = "";
                    listLocalidades.Visible = true;
                    btnEliminar.Visible = true;
                    btnAgregar.Visible = true;
                    btnModificar.Visible = true;
                }
                catch
                {
                    MessageBox.Show("La localidad se encuentra asignada a uno o más clientes.", "Atención!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    datos.CerrarConexion();
                }
            }
        }

        private void btnCancelarClick()
        {
            MessageBox.Show("Se canceló la operación.", "Atención!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            btnCancelar.Visible = false;
            btnConfirmar.Visible = false;
            lblLocalidad.Visible = false;
            txtLocalidad.Visible = false;
            txtLocalidad.Text = "";
            listLocalidades.Visible = true;
            btnEliminar.Visible = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelarClick();
        }

        private void txtLocalidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                btnGuardarClick();
            }
            if (e.KeyCode.Equals(Keys.Escape))
            {
                btnCancelarClick();
            }
            if (e.KeyCode.Equals(Keys.Delete))
            {
                btnEliminarClick();
            }
        }

        private void listLocalidades_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                btnModificarClick();
            }
            if (e.KeyCode.Equals(Keys.Oemplus) || e.KeyCode.Equals(Keys.Add))
            {
                btnAgregarClick();
            }
            if (e.KeyCode.Equals(Keys.Delete))
            {
                btnEliminarClick();
            }
        }
    }
}
