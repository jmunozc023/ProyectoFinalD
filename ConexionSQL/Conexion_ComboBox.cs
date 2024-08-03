using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ConexionSQL
{
    public class Conexion_ComboBox
    {
        private Conexion_BD conexion = new Conexion_BD();
        SqlCommand comando = new SqlCommand();

        public string RellenarComboBox()
        {

        }
        public DataTable RellenarComboBox1()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RellenarComboBox1";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable RellenarComboBox2()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RellenarComboBox2";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
