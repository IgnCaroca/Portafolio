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
using MessageBox = System.Windows.Forms.MessageBox;

namespace Portafolio
{
    public partial class ExtrasDepa : Form
    {
        ServicioExtraBLL servicio = new ServicioExtraBLL();
        private string id_extras_departamento = null;
        public ExtrasDepa()
        {
            InitializeComponent();
        }

        private void ExtrasDepa_Load(object sender, EventArgs e)
        {
            MostrarExtras();
        }
        private void MostrarExtras()
        {
            ServicioExtraBLL servicio = new ServicioExtraBLL();
            dtgExtrasDepa.DataSource = servicio.MostrarExtras();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ServicioExtraBLL servicio = new ServicioExtraBLL();
            if(txtServicioExtra.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else
            {

                try
                {
                    servicio.AgregarExtra(txtServicioExtra.Text);
                    MessageBox.Show("Se registro correctamente");
                    MostrarExtras();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo ingersar los datos por: " + ex);
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dtgExtrasDepa.SelectedRows.Count > 0)
            {
                id_extras_departamento = dtgExtrasDepa.CurrentRow.Cells["id_extras_departamento"].Value.ToString();
                servicio.EliminarExtra(id_extras_departamento);
                MessageBox.Show("Usuario Eliminado Correctamente.");
                MostrarExtras();
            }
            else
                MessageBox.Show("Seleccione una fila por favor.");
        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            if (dtgExtrasDepa.SelectedRows.Count > 0)
            {
                id_extras_departamento = dtgExtrasDepa.CurrentRow.Cells["id_extras_departamento"].Value.ToString();
                txtServicioExtra.Text = dtgExtrasDepa.CurrentRow.Cells["descripcion"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor.");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtServicioExtra.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ServicioExtraBLL servicio = new ServicioExtraBLL();
            if (txtServicioExtra.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else
            {

                try
                {
                    servicio.EditarExtra(txtServicioExtra.Text, Convert.ToInt32(id_extras_departamento));
                    MessageBox.Show("Se editó correctamente");
                    MostrarExtras();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editó los datos por: " + ex);
                }
            }
        }
    }
}
