using PortafolioDLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortafolioBLL
{
    public class PagosBLL
    {
        private PagosDAL pagos = new PagosDAL();
        public DataTable MostrarPagos()
        {
            DataTable tabla = new DataTable();
            tabla = pagos.MostrarPagos();
            return tabla;
        }
    }
}
