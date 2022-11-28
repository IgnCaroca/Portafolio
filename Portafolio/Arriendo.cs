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
    public partial class Arriendo : Form
    {
        private string id_arriendo = null;
        public Arriendo()
        {
            InitializeComponent();
        }
        private void Arriendo_Load(object sender, EventArgs e)
        {
            dtpInicioArriendo.Format = DateTimePickerFormat.Custom;
            dtpInicioArriendo.CustomFormat = "yyyy-MM-dd";

            dtpTerminoArriendo.Format = DateTimePickerFormat.Custom;
            dtpTerminoArriendo.CustomFormat = "yyyy-MM-dd";
            MostrarArriendos();
            MostrarRut();
            MostrarDepartamento();

        }
        private void MostrarDepartamento()
        {
            ArriendosBLL arriendos = new ArriendosBLL();
            cbxDepa.DataSource = arriendos.MostrarDepartamento();
            cbxDepa.ValueMember = "id_departamento";
            cbxDepa.DisplayMember = "id_departamento";

        }
        private void MostrarRut()
        {
            ArriendosBLL arriendos = new ArriendosBLL();
            cbxRut.DataSource = arriendos.CargarRut();
            cbxRut.ValueMember = "rut";
            cbxRut.DisplayMember = "rut";

        }

        private void MostrarArriendos()
        {
            ArriendosBLL arriendos = new ArriendosBLL();
            dtgArriendos.DataSource = arriendos.MostrarArriendo();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            id_arriendo = dtgArriendos.CurrentRow.Cells["id_arriendo"].Value.ToString();
            txtMonto_total.Text = dtgArriendos.CurrentRow.Cells["monto_total"].Value.ToString();
            txtEstado.Text = dtgArriendos.CurrentRow.Cells["estado_arriendo"].Value.ToString();
            dtpInicioArriendo.Text = dtgArriendos.CurrentRow.Cells["fecha_inicio"].Value.ToString();
            dtpTerminoArriendo.Text = dtgArriendos.CurrentRow.Cells["fecha_termino"].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ArriendosBLL arriendos = new ArriendosBLL();
            if (txtEstado.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (dtpInicioArriendo.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (dtpTerminoArriendo.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (dtpTerminoArriendo.Value < dtpInicioArriendo.Value)
            {
                MessageBox.Show("Campos inválidos", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (dtpInicioArriendo.Text.Trim() == "")
            {
                MessageBox.Show("Campos inválidos", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (dtpTerminoArriendo.Text.Trim() == "")
            {
                MessageBox.Show("Campos inválidos", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else
            {
                try
                {
                    arriendos.AgregarArriendo(Convert.ToInt32(txtMonto_total.Text),txtEstado.Text, dtpInicioArriendo.Value, dtpTerminoArriendo.Value, Convert.ToString(cbxRut.SelectedValue), Convert.ToInt32(cbxDepa.SelectedValue));
                    MessageBox.Show("Se registro correctamente");
                    MostrarArriendos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar los datos por: " + ex);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ArriendosBLL arriendos = new ArriendosBLL();
            if (txtEstado.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (dtpInicioArriendo.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (dtpTerminoArriendo.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (dtpTerminoArriendo.Value < dtpInicioArriendo.Value)
            {
                MessageBox.Show("Campos inválidos", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (dtpInicioArriendo.Text.Trim() == "")
            {
                MessageBox.Show("Campos inválidos", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (dtpTerminoArriendo.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (cbxRut.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (cbxDepa.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else
            {
                try
                {
                    arriendos.EditarArriendo(Convert.ToInt32(txtMonto_total.Text), txtEstado.Text, dtpInicioArriendo.Value, dtpTerminoArriendo.Value, Convert.ToString(cbxRut.SelectedValue), Convert.ToInt32(id_arriendo), Convert.ToInt32(cbxDepa.SelectedValue));
                    MessageBox.Show("Se registro correctamente");
                    MostrarArriendos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo ingersar los datos por: " + ex);
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ArriendosBLL arriendos = new ArriendosBLL();
            if (dtgArriendos.SelectedRows.Count > 0)
            {
                id_arriendo = dtgArriendos.CurrentRow.Cells["id_arriendo"].Value.ToString();
                arriendos.EliminarArriendo(id_arriendo);
                MessageBox.Show("Usuario Eliminado Correctamente.");
                MostrarArriendos();
            }
            else
                MessageBox.Show("Seleccione una fila por favor.");
        }

        private void txtEstado_Leave(object sender, EventArgs e)
        {
            ErrorProvider errorP = new ErrorProvider();
            if (txtEstado.Text == "")
            {
                errorP.SetError(txtEstado, "No puede dejar este campo vacio.");

            }
            else
                errorP.Clear();
        }

        private void cbxRut_Leave(object sender, EventArgs e)
        {
            ErrorProvider errorP = new ErrorProvider();
            if (cbxRut.Text == "")
            {
                errorP.SetError(cbxRut, "No puede dejar este campo vacio.");

            }
            else
                errorP.Clear();
        }

        private void txtMonto_total_Leave(object sender, EventArgs e)
        {
            ErrorProvider errorP = new ErrorProvider();
            if (txtMonto_total.Text == "")
            {
                errorP.SetError(txtMonto_total, "No puede dejar este campo vacio.");

            }
            else
                errorP.Clear();
        }

        private void txtMonto_total_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                //MessageBox.Show("Inserte solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEstado.Text = "";
            txtMonto_total.Text = "";
        }
    }
}
