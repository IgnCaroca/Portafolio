using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows;
using MessageBox = System.Windows.Forms.MessageBox;
using Application = System.Windows.Forms.Application;
using PortafolioBLL;
using Comun.Cache;

namespace Portafolio
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(125, Color.Black);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_Load(object sender, EventArgs e)
        {
            Permisos();
        }
        private void Permisos()
        {
            if (UserLoginCache.Rol_fk == Rol_fky.Cliente)
            {
                MessageBox.Show("Usted no es administrador.", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "USUARIO")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.LightGray;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "USUARIO";
                txtNombre.ForeColor = Color.LightGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrar register = new Registrar();
            register.Show();
            register.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (UserLoginCache.Rol_fk == Rol_fky.Cliente )
            {
                MessageBox.Show("Usted no es administrador.", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (txtpass.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (txtNombre.Text.Trim() == "USUARIO")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else if (txtpass.Text.Trim() == "CONTRASEÑA")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                return;
            }
            else
            {
                LoginBLL login = new LoginBLL();
                var validLogin = login.LoginUser(txtNombre.Text, txtpass.Text);
                if (validLogin == true)
                {
                    Formbase formbase = new Formbase();
                    formbase.Show();
                    formbase.BringToFront();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos, por favor, intenta de nuevo", "Aviso", (MessageBoxButtons)MessageBoxButton.OK, (MessageBoxIcon)MessageBoxImage.Warning);
                    txtpass.Clear();
                    txtNombre.Focus();
                    
                }

            }
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
