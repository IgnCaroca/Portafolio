using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PortafolioBLL;
using System.Windows;
using MessageBox = System.Windows.Forms.MessageBox;
using System.Text.RegularExpressions;

namespace Portafolio
{
    public partial class UsuarioAdmin : Form
    {
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        private string idusuario = null;

        public UsuarioAdmin()
        {
            InitializeComponent();
        }

        private void UsuarioAdmin_Load(object sender, EventArgs e)
        {
            dtpfech.Format = DateTimePickerFormat.Custom;
            dtpfech.CustomFormat = "yyyy-MM-dd";
            MostrarUsuarios();
            MostrarRol();   
        }
        private void MostrarUsuarios()
        {
            UsuarioBLL usuario = new UsuarioBLL();
            dtgUsuario.DataSource = usuario.MostrarUsuario();
        }
        private void MostrarRol()
        {
            UsuarioBLL usuario = new UsuarioBLL();
            cbxRol.DataSource = usuario.MostrarRol();
            cbxRol.ValueMember = "id_rol";
            cbxRol.DisplayMember = "rol";
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();

            if (txtrut.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            /*
            else if (txtrut.Text == usuarioBLL.ExisteRut().ToString())
            {
                MessageBox.Show("El rut ya existe.", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }*/

            else if (txtpass.TextLength <=5 )
            {
                MessageBox.Show("Contraseña poco segura.", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (txtnombre.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (Convert.ToInt32(txtrut.Text) <= 100000)
            {
                MessageBox.Show("Rut inválido", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (Convert.ToInt32(txtrut.Text) >= 999999999)
            {
                MessageBox.Show("Rut inválido", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (txtrut.Text ==  dtgUsuario.CurrentRow.Cells["rut"].Value.ToString())
            {
                MessageBox.Show("Rut duplicado", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (txtUsuario.Text == dtgUsuario.CurrentRow.Cells["usuario"].Value.ToString())
            {
                MessageBox.Show("Usuario ya existe, por favor, ingrese uno nuevo.", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (txtUsuario.Text.Trim() == "")
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
            else if (cbxRol.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un rol.", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }

            else
            {
               
                    try
                    {
                        usuarioBLL.AgregarUsuario(txtnombre.Text, txtcorreo.Text, txtUsuario.Text, txtpass.Text, dtpfech.Value, txtdire.Text, txtrut.Text, txtapellido.Text, Convert.ToInt32(cbxRol.SelectedValue));
                        MessageBox.Show("Se registro correctamente");
                        MostrarUsuarios();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo ingersar los datos por: " + ex);
                    }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtrut.Text = "";
            txtapellido.Text = "";
            txtcorreo.Text = "";
            txtdire.Text = "";
            txtnombre.Text = "";
            txtUsuario.Text = "";
            txtpass.Text = "";
            cbxRol.Text = "";
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dtgUsuario.SelectedRows.Count > 0)
            {
                idusuario = dtgUsuario.CurrentRow.Cells["idusuario"].Value.ToString();
                txtnombre.Text = dtgUsuario.CurrentRow.Cells["nombre"].Value.ToString();
                txtcorreo.Text = dtgUsuario.CurrentRow.Cells["correo"].Value.ToString();
                txtUsuario.Text = dtgUsuario.CurrentRow.Cells["usuario"].Value.ToString();
                txtpass.Text = dtgUsuario.CurrentRow.Cells["clave"].Value.ToString();
                txtdire.Text = dtgUsuario.CurrentRow.Cells["direccion"].Value.ToString();
                txtapellido.Text = dtgUsuario.CurrentRow.Cells["apellido"].Value.ToString();
                dtpfech.Text = dtgUsuario.CurrentRow.Cells["fecha_nac"].Value.ToString();

            }
            else
                MessageBox.Show("Seleccione una fila por favor.");
        }

        private void dtpfech_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dtgUsuario.SelectedRows.Count > 0)
            {
                idusuario = dtgUsuario.CurrentRow.Cells["idusuario"].Value.ToString();
                usuarioBLL.EliminarUsuario(idusuario);
                MessageBox.Show("Usuario Eliminado Correctamente.");
                MostrarUsuarios();
            }
            else
                MessageBox.Show("Seleccione una fila por favor.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxRol.ValueMember = "id_rol";
            cbxRol.DisplayMember = "rol";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();


            if (txtnombre.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (txtrut.Text == dtgUsuario.CurrentRow.Cells["rut"].Value.ToString())
            {
                MessageBox.Show("Rut duplicado", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (txtUsuario.Text.Trim() == "")
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
            else if (cbxRol.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un rol.", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }

            try
            {
                usuarioBLL.EditarUsuario(txtnombre.Text, txtcorreo.Text, txtUsuario.Text, txtpass.Text, dtpfech.Value, txtdire.Text, txtapellido.Text, Convert.ToInt32(cbxRol.SelectedValue), Convert.ToInt32(idusuario));
                MessageBox.Show("Se editó correctamente.");
                MostrarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo editar los datos por: " + ex);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
        ErrorProvider errorP = new ErrorProvider();
        private void txtrut_Leave(object sender, EventArgs e)
        {
           
            if (txtrut.Text == "")
            {
                errorP.SetError(txtrut, "No puede dejar este campo vacio.");

            }
            else
                errorP.Clear();
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        
        private void txtnombre_Leave(object sender, EventArgs e)
        {
            
            if (txtnombre.Text == "")
            {
                errorP.SetError(txtnombre, "No puede dejar este campo vacio.");

            }
            else
                errorP.Clear();
        }

        private void txtapellido_Leave(object sender, EventArgs e)
        {
           
            if (txtapellido.Text == "")
            {
                errorP.SetError(txtapellido, "No puede dejar este campo vacio.");

            }
            else
                errorP.Clear();
        }

        private void txtdire_Leave(object sender, EventArgs e)
        {
            
            if (txtdire.Text == "")
            {
                errorP.SetError(txtdire, "No puede dejar este campo vacio.");

            }
            else
                errorP.Clear();
        }
        public static bool textVacios(TextBox pTxt)
        {
            if (pTxt.Text == String.Empty)
            {
                pTxt.Focus();
                return true;
            }
            else
                return false;
        }
        public static bool validarEmail(string pCorreo)
        {
            return pCorreo != null && Regex.IsMatch(pCorreo,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        
        private void txtcorreo_Leave(object sender, EventArgs e)
        {
            
            if (txtcorreo.Text == "")
            {
                errorP.SetError(txtcorreo, "No puede dejar este campo vacio.");

            }
            else if (!validarEmail(txtcorreo.Text))
            {
                errorP.SetError(txtcorreo, "Correo no válido.");
            }
            else
                errorP.Clear();
        }

        private void cbxRol_Leave(object sender, EventArgs e)
        {
            
            if (cbxRol.Text == "")
            {
                errorP.SetError(cbxRol, "No puede dejar este campo vacio.");

            }
            else
                errorP.Clear();
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            
            if (txtUsuario.Text == "")
            {
                errorP.SetError(txtUsuario, "No puede dejar este campo vacio.");

            }
            else
                errorP.Clear();
        }
        private void txtpass_Leave(object sender, EventArgs e)
        {
            
            if (txtpass.Text == "")
            {
                errorP.SetError(txtpass, "No puede dejar este campo vacio.");
                errorP.Clear();

            }
            else
                errorP.Clear();
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }


        /*
private void btnGuardar_Click(object sender, EventArgs e)
{
   usuarioBLL.AgregarUsuario
}
/*private void CargarUsuarios()
{
lblName.Text = UserLoginCache.Nombre;
}*/
    }
}
