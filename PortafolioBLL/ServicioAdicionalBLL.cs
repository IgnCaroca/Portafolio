using PortafolioDLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortafolioBLL
{
    public class ServicioAdicionalBLL
    {
        private ServicioAdicionalDAL servicio = new ServicioAdicionalDAL();

        public DataTable MostrarServicio()
        {
            DataTable tabla = new DataTable();
            tabla = servicio.MostrarServicios();
            return tabla;
        }

        public void AgregarServicio(string descripcion)
        {
            servicio.Guardar(descripcion);
        }
        public void EditarUsuario(string descripcion, int id_servicio_adicional)
        {
            servicio.Editar(descripcion, Convert.ToInt32(id_servicio_adicional));

        }
        public void EliminarServicio(int id_servicio_adicional)
        {
            servicio.Eliminar(Convert.ToInt32(id_servicio_adicional));
        }

    }
}
