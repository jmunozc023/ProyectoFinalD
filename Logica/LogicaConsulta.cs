using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionSQL;
using System.Data;

namespace Logica
{
    public class LogicaConsulta
    {
        private Consulta_BD consulta = new Consulta_BD();
        public DataTable FiltrarPorIdYEstado(int idProducto, string estado)
        {
            DataTable dt = new DataTable();
            dt = consulta.FiltrarPorIdYEstado(idProducto, estado);
            return dt;
        }

    }
}
