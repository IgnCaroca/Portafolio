using PortafolioDLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PortafolioBLL
{
    public class ArriendosBLL
    {
        private ArriendosDAL arriendosDAL = new ArriendosDAL();

        public DataTable MostrarArriendo()
        {
            DataTable tabla = new DataTable();
            tabla = arriendosDAL.Mostrar();
            return tabla;
        }
        public DataTable CargarRut()
        {
            DataTable tabla = new DataTable();
            tabla = arriendosDAL.MostrarRut();
            return tabla;
        }
        public DataTable MostrarDepartamento()
        {
            DataTable tabla = new DataTable();
            tabla = arriendosDAL.MostrarDepartamento();
            return tabla;
        }


        public void AgregarArriendo(int monto_total, string estado_arriendo, DateTime fecha_inicio, DateTime fecha_termino, string usuario_id_cliente_fk, int id_departamento_fk)
        {
            arriendosDAL.Guardar(Convert.ToInt32(monto_total), estado_arriendo, fecha_inicio, fecha_termino, usuario_id_cliente_fk, Convert.ToInt32(id_departamento_fk));
        }
        public void EditarArriendo(int monto_total, string estado_arriendo, DateTime fecha_inicio, DateTime fecha_termino, string usuario_id_cliente_fk, int id_departamento_fk, int id_arriendo)
        {
            arriendosDAL.Editar(monto_total, estado_arriendo, fecha_inicio, fecha_termino, usuario_id_cliente_fk, Convert.ToInt32(id_departamento_fk), Convert.ToInt32(id_arriendo));

        }
        public void EliminarArriendo(string id_arriendo)
        {
            arriendosDAL.Eliminar(Convert.ToInt32(id_arriendo));
        }

        
    }
}