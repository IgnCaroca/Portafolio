using PortafolioBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Portafolio
{
    public partial class ServicioAdicional : Form
    {
        private string id_servicio_adicional = null;
        public ServicioAdicional()
        {
            InitializeComponent();
        }

        private void ServicioAdicional_Load(object sender, EventArgs e)
        {
            MostrarServicio();
        }
        private void MostrarServicio()
        {
            ServicioAdicionalBLL servicio = new ServicioAdicionalBLL();
            dtgServicio.DataSource = servicio.MostrarServicio();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ServicioAdicionalBLL servicio = new ServicioAdicionalBLL();
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else
            {

                try
                {
                    servicio.AgregarServicio(txtDescripcion.Text);
                    MessageBox.Show("Se registro correctamente");
                    MostrarServicio();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo ingersar los datos por: " + ex);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ServicioAdicionalBLL servicio = new ServicioAdicionalBLL();
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else
            {

                try
                {
                    servicio.EditarUsuario(txtDescripcion.Text, Convert.ToInt32(id_servicio_adicional));
                    MessageBox.Show("Se editó correctamente");
                    MostrarServicio();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo ingersar los datos por: " + ex);
                }
            }
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            if (dtgServicio.SelectedRows.Count > 0)
            {
                id_servicio_adicional = dtgServicio.CurrentRow.Cells["id_servicio_adicional"].Value.ToString();
                txtDescripcion.Text = dtgServicio.CurrentRow.Cells["descripcion"].Value.ToString();


            }
            else
                MessageBox.Show("Seleccione una fila por favor.");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ServicioAdicionalBLL servicio = new ServicioAdicionalBLL();
            if (dtgServicio.SelectedRows.Count > 0)
            {
                id_servicio_adicional = dtgServicio.CurrentRow.Cells["id_servicio_adicional"].Value.ToString();
                servicio.EliminarServicio(Convert.ToInt32(id_servicio_adicional));
                MessageBox.Show("Usuario Eliminado Correctamente.");
                MostrarServicio();
            }
            else
                MessageBox.Show("Seleccione una fila por favor.");
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {

            ErrorProvider errorP = new ErrorProvider();
            if (txtDescripcion.Text == "")
            {
                errorP.SetError(txtDescripcion, "No puede dejar este campo vacio.");

            }
            else
                errorP.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
        }

    }
}
