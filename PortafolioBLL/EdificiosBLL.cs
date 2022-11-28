using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun.Cache;
using PortafolioDAL;
using PortafolioDLL;

namespace PortafolioBLL
{
    public class EdificiosBLL
    {
        private EdificiosDAL departamento = new EdificiosDAL();

        public DataTable MostrarDepartamentos()
        {
            DataTable tabla = new DataTable();
            tabla = departamento.MostrarDepartamentos();
            return tabla;
        }
        public DataTable MostrarExtra()
        {
            DataTable tabla = new DataTable();
            tabla = departamento.MostrarExtras();
            return tabla;
        }
        public void AgregarDepartamento(string direccion, string estacionamiento, int num_habitaciones, int extras_departamento_fk, string nombre)
        {
            departamento.Guardar(direccion, estacionamiento, Convert.ToInt32(num_habitaciones), Convert.ToInt32(extras_departamento_fk), nombre);
        }
        public void EliminarDepartamento(int id_departamento)
        {
            departamento.Eliminar(Convert.ToInt32(id_departamento));
        }
        public void CargarExtra(int extras_departamento_fk)
        {
            departamento.CargarExtra(extras_departamento_fk);


        }
        public void EditarDepa(string direccion, string estacionamiento, int num_habitaciones, int extras_departamento_fk, int id_departamento, string nombre)
        {
            departamento.Editar(direccion, estacionamiento, Convert.ToInt32(num_habitaciones), Convert.ToInt32(extras_departamento_fk), nombre, Convert.ToInt32(id_departamento));

        }
    }
}
