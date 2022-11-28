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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Show();
            this.Close();
        }

        private void BtnAdmArriendos_Click(object sender, EventArgs e)
        {
            ArriendosViñacs arriendos = new ArriendosViñacs();
            arriendos.Show();
            this.Close();
        }

        private void BtnModiArri_Click(object sender, EventArgs e)
        {
            InventarioEdificios inventario = new InventarioEdificios();
            inventario.Show();
            this.Close();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            UsuarioAdmin usuarioadmin = new UsuarioAdmin();
            usuarioadmin.Show();
            this.Close();
        }

        private void btnPagArriendos_Click(object sender, EventArgs e)
        {
            ArriendosViñacs arriendos = new ArriendosViñacs();
            arriendos.Show();
            this.Close();
        }
    }
}
