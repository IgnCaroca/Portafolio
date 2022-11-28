using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PortafolioBLL;
using System.Windows;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Portafolio
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(125, Color.Black);
            panel2.BackColor = Color.FromArgb(125, Color.Black);
            
            
        }

        private void Registrar_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtrut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                //MessageBox.Show("Inserte solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtdire_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {
            
        }
        

        private void txtrut_Leave(object sender, EventArgs e)
        {
            ErrorProvider errorP = new ErrorProvider();
            if (txtrut.Text == "")
            {
                errorP.SetError(txtrut, "No puede dejar este campo vacio.");

            }
            else
                errorP.Clear();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            ErrorProvider errorP = new ErrorProvider();
            if (txtnombre.Text == "")
            {
                errorP.SetError(txtnombre, "No puede dejar este campo vacio.");

            }
            else
                errorP.Clear();
        }

        private void txtapellido_Leave(object sender, EventArgs e)
        {
            ErrorProvider errorP = new ErrorProvider();
            if (txtapellido.Text == "")
            {
                errorP.SetError(txtapellido, "No puede dejar este campo vacio.");

            }
            else
                errorP.Clear();
        }
        ErrorProvider errorP = new ErrorProvider();
        private void txtdire_Leave(object sender, EventArgs e)
        {
            
            if (txtdire.Text == "")
            {
                errorP.SetError(txtdire, "No puede dejar este campo vacio.");

            }
            else
                errorP.Clear();
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            ErrorProvider errorP = new ErrorProvider();
            if (txtpass.Text == "")
            {
                errorP.SetError(txtpass, "No puede dejar este campo vacio.");

            }
            else
                errorP.Clear();
        }
        
        private void txtcorreo_Leave(object sender, EventArgs e)
        {
            
            ErrorProvider errorP = new ErrorProvider();
            if (txtcorreo.Text == "")
            {
                errorP.SetError(txtcorreo, "No puede dejar este campo vacio.");

            }
            else
                errorP.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            if (txtrut.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (txtnombre.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (txtapellido.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (txtdire.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (txtpass.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (txtcorreo.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (dtpfech.Value.Date >= DateTime.Today)
            {
               MessageBox.Show("Introduzca una fecha válida.", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (dtpfech.Value.AddYears(18) >= DateTime.Today)
            {
                MessageBox.Show("Debe ser mayor de 18 años.", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else
            {
                //usuarioBLL.AgregarUsuario(txtnombre.Text, txtcorreo.Text, txtUsuario.Text, txtpass.Text, dtpfech.Value , txtdire.Text, txtrut.Text, txtapellido.Text);
                MessageBox.Show("Se registro correctamente");
                this.Close();
            }                             
            /*
            string Rut = txtrut.Text;
            string Nombre = txtnombre.Text;
            string Apellido = txtapellido.Text;
            string Direccion = txtdire.Text;
            DateTimePicker FechaNacimiento = dtpfech;
            string Contraseña = txtpass.Text;
            string Correo = txtcorreo.Text;
            Usuario usuario = new Usuario();
            usuario.Show();*/
        }

        private void dtpfech_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtrut_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
