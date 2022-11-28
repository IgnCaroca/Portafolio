using PortafolioDAL;
using PortafolioDLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortafolioBLL
{
    public class DashboardBLL
    {
        private DashboardDAL dashboard = new DashboardDAL();
        
        public DataTable ContadorUsuarios(int idusuario)
        {
            //idusuario = Convert.ToInt32(rows[0]);
            DataTable tabla = new DataTable();
            tabla = dashboard.ContadorUsuarios(Convert.ToInt32(idusuario));
            return tabla;
        }
        public DataTable Dashdatos()
        {
            DashboardDAL dashboard = new DashboardDAL();
            DataTable tabla = new DataTable();
            tabla = dashboard.DashDatos();
            return tabla;
        }
        public class Fechas
        {
            public DateTime DiasArrendados { get; set; }
        }
        public class DepartamentosTotales
        {
            public int TotalDepartamentos { get; set; }
        }
        public class DepartamentoDisponible
        {
            public int DepartamentosDisponibles { get; set; }
        }
        public class DepartamentoArrendado
        {
            public int DepartamentosArrendados { get; set; }
        }
        public class Ganancias
        {
            public int GananciasTotales { get; set; }
        }

    }
}
