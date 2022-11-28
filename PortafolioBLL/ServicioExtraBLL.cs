using PortafolioDLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortafolioBLL
{
    public class ServicioExtraBLL
    {
        private ServicioExtraDAL servicio = new ServicioExtraDAL();

        public DataTable MostrarExtras()
        {
            DataTable tabla = new DataTable();
            tabla = servicio.Mostrar();
            return tabla;
        }
        public void AgregarExtra(string descripcion)
        {
            servicio.Guardar(descripcion);
        }
        public void EditarExtra(string descripcion, int id_extras_departamento)
        {
            servicio.Editar(descripcion, Convert.ToInt32(id_extras_departamento));

        }
        public void EliminarExtra(string id_extras_departamento)
        {
            servicio.Eliminar(Convert.ToInt32(id_extras_departamento));
        }
    }
}
