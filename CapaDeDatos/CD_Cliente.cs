using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CD_Cliente
    {
        ConexionBD oConexionBD = new ConexionBD();


        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comandoQuery = new SqlCommand();

        public void Guardar(string NOMBRE, string DIRECCION_CLIENTE, string TELEFONO, string NIT_CLIENTE, string EMAIL_CLIENTE)
        {

            comandoQuery.Connection = oConexionBD.abrirBd();

            comandoQuery.CommandText = "insert into CLIENTE" +
                 " values('" + NOMBRE + "','" +
                 TELEFONO + "','" + NIT_CLIENTE + "','" +
                 EMAIL_CLIENTE + "','" + DIRECCION_CLIENTE + "')";
            comandoQuery.CommandType = CommandType.Text;
            comandoQuery.ExecuteNonQuery();

            comandoQuery.Connection = oConexionBD.cerrarBD();
            
        }
        public void Modificar()
        {

        }
        public void Eliminar()
        {

        }
        public void Imprimir()
        {

        }
        public DataTable BuscarCliente(int idCliente)
        {
            comandoQuery.Connection = oConexionBD.abrirBd();
            comandoQuery.CommandText = "select NOMBRE, DIRECCION_CLIENTE, TELEFONO, NIT_CLIENTE, EMAIL_CLIENTE" +
            "from CLIENTE" +
            "where ID_CLIENTE = " + idCliente;

            leer = comandoQuery.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            //comandoQuery.CommandType = CommandType.Text;
            return tabla;
        }
    }
}
