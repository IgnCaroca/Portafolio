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
using PortafolioBLL;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Portafolio
{
    public partial class InventarioEdificios : Form
    {
        private string id_departamento = null;
        EdificiosBLL edificio = new EdificiosBLL();
        public InventarioEdificios()
        {
            InitializeComponent();
        }
        private void MostrarDepartamentos()
        {
            EdificiosBLL edificios = new EdificiosBLL();
            dtgDepartamento.DataSource = edificios.MostrarDepartamentos();
        }
        private void MostrarExtras()
        {
            EdificiosBLL edificios = new EdificiosBLL();
            cbxServicio.DataSource = edificios.MostrarExtra();
            cbxServicio.ValueMember = "id_extras_departamento";
            cbxServicio.DisplayMember = "descripcion";

        }

        private void InventarioEdificios_Load(object sender, EventArgs e)
        {
            MostrarDepartamentos();
            MostrarExtras();
        }

        private void dtgMotrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EdificiosBLL edificios = new EdificiosBLL();
            if (txtDire.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (txtEstacionamiento.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (txtHabitaciones.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (cbxServicio.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else
                try
                {
                    edificios.AgregarDepartamento(txtDire.Text, txtEstacionamiento.Text, Convert.ToInt32(txtHabitaciones.Text), Convert.ToInt32(cbxServicio.SelectedValue), txtNombre.Text);
                    MessageBox.Show("Se registro correctamente");
                    MostrarDepartamentos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo ingersar los datos por: " + ex);
                }
        }

        private void dtgDepartamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnllenar_Click(object sender, EventArgs e)
        {
            if (dtgDepartamento.SelectedRows.Count > 0)
            {
                id_departamento = dtgDepartamento.CurrentRow.Cells["id_departamento"].Value.ToString();
                txtDire.Text = dtgDepartamento.CurrentRow.Cells["direccion"].Value.ToString();
                txtEstacionamiento.Text = dtgDepartamento.CurrentRow.Cells["estacionamiento"].Value.ToString();
                txtHabitaciones.Text = dtgDepartamento.CurrentRow.Cells["num_habitaciones"].Value.ToString();
                cbxServicio.Text = dtgDepartamento.CurrentRow.Cells["extras_departamento_fk"].Value.ToString();
                txtNombre.Text = dtgDepartamento.CurrentRow.Cells["nombres"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor.");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDire.Text = "";
            txtEstacionamiento.Text = "";
            txtHabitaciones.Text = "";
            cbxServicio.Text = "";
            txtNombre.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (dtgDepartamento.SelectedRows.Count > 0)
            {
                id_departamento = dtgDepartamento.CurrentRow.Cells["id_departamento"].Value.ToString();
                edificio.EliminarDepartamento(Convert.ToInt32(id_departamento));
                MessageBox.Show("Usuario Eliminado Correctamente.");
                MostrarDepartamentos();
            }
            else
                MessageBox.Show("Seleccione una fila por favor.");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EdificiosBLL edificios = new EdificiosBLL();
            if (txtDire.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (txtEstacionamiento.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (txtHabitaciones.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (cbxServicio.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else
                try
                {
                    edificios.EditarDepa(txtDire.Text, txtEstacionamiento.Text, Convert.ToInt32(txtHabitaciones.Text), Convert.ToInt32(cbxServicio.SelectedValue), Convert.ToInt32(id_departamento), txtNombre.Text);
                    MessageBox.Show("Se registro correctamente");
                    MostrarDepartamentos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo ingersar los datos por: " + ex);
                }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {

        }
    }
}
