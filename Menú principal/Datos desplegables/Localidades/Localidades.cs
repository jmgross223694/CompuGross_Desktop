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
        }

        private void Localidades_Load(object sender, EventArgs e)
        {
            this.Height = 477;
            cargarDdlLocalidades();
            btnCancelar.Visible = false;
            btnConfirmar.Visible = false;
            lblLocalidad.Visible = false;
            txtLocalidad.Visible = false;
            listLocalidades.Visible = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Height = 225;
            btnCancelar.Visible = true;
            btnConfirmar.Visible = true;
            lblLocalidad.Visible = true;
            txtLocalidad.Visible = true;
            listLocalidades.Visible = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Height = 477;
            btnCancelar.Visible = false;
            btnConfirmar.Visible = false;
            lblLocalidad.Visible = false;
            txtLocalidad.Visible = false;
            listLocalidades.Visible = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string localidad = txtLocalidad.Text;
            
            if (localidad == "" || localidad == "-")
            {
                MessageBox.Show("Por favor ingresa una localidad.", "Atención!!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (btnConfirmar.Text == "Guardar") //Modificar Localidad
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

                        this.Height = 477;
                        cargarDdlLocalidades();
                        btnCancelar.Visible = false;
                        btnConfirmar.Visible = false;
                        lblLocalidad.Visible = false;
                        txtLocalidad.Visible = false;
                        listLocalidades.Visible = true;
                        btnEliminar.Enabled = true;
                        btnAgregar.Enabled = true;
                        btnEditar.Enabled = true;

                        txtLocalidad.Text = "";

                        btnConfirmar.Text = "Confirmar";
                        lblLocalidad.Text = "Ingrese la nueva localidad";
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
                else //Agregar nueva Localidad
                {

                    string insert = "insert into Localidades(Descripcion) values('" + localidad + "')";

                    AccesoDatos datos = new AccesoDatos();

                    try
                    {
                        datos.SetearConsulta(insert);
                        datos.EjecutarLectura();

                        MessageBox.Show("Localidad agregada correctamente.", "Atención!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Height = 477;
                        cargarDdlLocalidades();
                        btnCancelar.Visible = false;
                        btnConfirmar.Visible = false;
                        lblLocalidad.Visible = false;
                        txtLocalidad.Visible = false;
                        listLocalidades.Visible = true;
                        btnEliminar.Enabled = true;
                        btnAgregar.Enabled = true;
                        btnEditar.Enabled = true;

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("La localidad ya existe en el sistema.", "Atención!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion.ToString() != "No")
            {
                string localidad = listLocalidades.SelectedItem.ToString();
                string delete = "delete from Localidades where Descripcion = '" + localidad + "'";

                AccesoDatos datos = new AccesoDatos();

                try
                {
                    datos.SetearConsulta(delete);
                    datos.EjecutarLectura();

                    MessageBox.Show("Localidad eliminada correctamente.", "Atención!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    this.Height = 477;
                    cargarDdlLocalidades();
                    btnCancelar.Visible = false;
                    btnConfirmar.Visible = false;
                    lblLocalidad.Visible = false;
                    txtLocalidad.Visible = false;
                    listLocalidades.Visible = true;
                    btnEliminar.Enabled = true;
                    btnAgregar.Enabled = true;
                    btnEditar.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("La localidad no se puede eliminar, " +
                        "ya que esta asociada a uno o más clientes.", "Atención!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    datos.CerrarConexion();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Height = 225;
            btnCancelar.Visible = true;
            btnConfirmar.Visible = true;
            btnConfirmar.Text = "Guardar";
            lblLocalidad.Visible = true;
            lblLocalidad.Text = "Modifique la localidad";
            txtLocalidad.Visible = true;
            listLocalidades.Visible = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;

            string localidad = listLocalidades.SelectedItem.ToString();

            this.LocalidadSeleccionada = localidad;

            txtLocalidad.Text = localidad;
        }
    }
}
