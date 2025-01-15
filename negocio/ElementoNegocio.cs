using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ElementoNegocio
    {
        public List<Elemento> listar()
        {
            List<Elemento> listaElementos = new List<Elemento>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id,Descripcion from ELEMENTOS");
                datos.ejecutarLectura();

                while (datos.obtenerDatos().Read())
                {
                    Elemento elemento = new Elemento();
                    elemento.Id = (int)datos.obtenerDatos()["Id"];
                    elemento.Descripcion = (string)datos.obtenerDatos()["Descripcion"];
                    listaElementos.Add(elemento);
                }
                return listaElementos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
