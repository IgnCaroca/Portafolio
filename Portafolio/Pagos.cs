using PortafolioBLL;
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
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void MostrarPagos()
        {
            PagosBLL pagos = new PagosBLL();
            dtgPagos.DataSource = pagos.MostrarPagos();
        }
        private void Pagos_Load(object sender, EventArgs e)
        {
            MostrarPagos(); 
        }
    }
}
