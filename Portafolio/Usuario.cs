using Comun.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portafolio
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(125, Color.Black);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ArriendosViñacs arriendos = new ArriendosViñacs();
            arriendos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_Load_1(object sender, EventArgs e)
        {
            /*
            if (UserLoginCache.Id_rol == Cargos.Cliente)
            {
                BtnAdmin.Enabled = false;
                BtnAdmin.Hide();
            }
            if(UserLoginCache.Id_rol == Cargos.Administrador)
            {
                //code
            }*/
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
