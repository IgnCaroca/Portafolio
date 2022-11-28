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
using System.Windows.Forms.DataVisualization;

namespace Portafolio
{
    public partial class Dash : Form
    {
        
        public Dash()
        {
            InitializeComponent();
            Ganancias();

        }
        private void dashdatos(object sender, EventArgs e)
        {
        }
        private void Dash_Load(object sender, EventArgs e)
        {
            Clientes();
        }

        private void Clientes()
        {
            
            DashboardBLL dashboard = new DashboardBLL();
            
            
        }
        private void Ganancias()
        {
            DashboardBLL dash = new DashboardBLL();
            //chart2.Series[0].Points.DataBindXY((System.Collections.IEnumerable)dash.Ganancias());
        }

        private void lblClientes_Click(object sender, EventArgs e)
        {

        }
    }
}
