using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
namespace CapaDeNegocio
{
    public class CN_Cliente

    {
        CD_Cliente oCliente = new CD_Cliente();
        public string DIRECCION_CLIENTE { get; set; }
        public string EMAIL_CLIENTE { get; set; }
        public string NIT_CLIENTE { get; set; }
        public string NOMBRE { get; set; }
        public string TELEFONO { get; set; }

        public Boolean Guardar ()
        {
            if (NOMBRE.Trim()=="")
            {
                return false;
            }
            if (DIRECCION_CLIENTE.Trim() == "")
            {
                return false;
            }
            if (TELEFONO.Trim() == "")
            {
                return false;
            }
            if (NIT_CLIENTE.Trim() == "")
            {
                return false;
            }
            if (EMAIL_CLIENTE.Trim() == "")
            {
                return false;
            }
            try
            {
               
                //oCliente.Guardar(NOMBRE, DIRECCION_CLIENTE, TELEFONO, NIT_CLIENTE, EMAIL_CLIENTE);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
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
        public bool VerificarCliente(string codigo, ref DataTable TablaCliente)
        {
            int idcliente;
            if (!int.TryParse(codigo, out idcliente))
            {
                
                return false;
            }
            try
            {

             TablaCliente =  oCliente.BuscarCliente(idcliente);
                if (TablaCliente.Rows.Count==0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
