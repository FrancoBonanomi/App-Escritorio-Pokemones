using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using dominio;

namespace negocio
{
    public class PokemonNegocio
    {

        private List<Pokemon> listaDePokemones;

        public PokemonNegocio()
        {
            listaDePokemones = new List<Pokemon>();
        }
        public List<Pokemon> listar(bool soloInactivos = false)
        {
            AccesoDatos datos = new AccesoDatos();
            int estado = soloInactivos ? 0 : 1;


            try
            {
                cargarLector("select P.Id,Numero,Nombre,P.Descripcion,UrlImagen,E.Descripcion as Tipo, D.Descripcion as Debilidad, P.IdTipo,P.IdDebilidad from POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE P.IdTipo=E.Id AND P.IdDebilidad=D.Id AND P.Activo=" + estado);
                return this.listaDePokemones;
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


        public void insertarPokemon(Pokemon nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into POKEMONS (Numero,Nombre,Descripcion,IdTipo,IdDebilidad,UrlImagen,Activo) values(" + "'" + nuevo.Numero + "'" + "," + "'" + nuevo.Nombre + "'" + "," + "'" + nuevo.Descripcion + "'" + "," + nuevo.Tipo.Id + "," + nuevo.Debilidad.Id + "," + "@urlImagen," + 1 + ")");
                datos.setearParametros("@urlImagen", nuevo.urlImagen);
                datos.ejecutarAccion();
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

        public void modificarPokemon(Pokemon aModificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update POKEMONS SET Numero=@num,Nombre=@nom,Descripcion=@desc,UrlImagen=@url,IdTipo=@idTipo,IdDebilidad=@idDebilidad,Activo=1 where Id=" + aModificar.Id);
                datos.setearParametros("@num", aModificar.Numero);
                datos.setearParametros("@nom", aModificar.Nombre);
                datos.setearParametros("@desc", aModificar.Descripcion);
                datos.setearParametros("@url", aModificar.urlImagen);
                datos.setearParametros("@idTipo", aModificar.Tipo.Id);
                datos.setearParametros("@idDebilidad", aModificar.Debilidad.Id);
                datos.ejecutarAccion();
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


        public void eliminarPokemon(int id, bool esElimLogica = false)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                if (!esElimLogica)
                    datos.setearConsulta("DELETE FROM POKEMONS WHERE Id=" + id);

                else
                    datos.setearConsulta("UPDATE POKEMONS SET Activo=0 where Id=" + id);

                datos.ejecutarAccion();
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

        public void reactivarPokemon(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE POKEMONS SET Activo=1 where Id=" + id);
                datos.ejecutarAccion();
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


        public List<Pokemon> filtrar(string campo, string criterio, string filtro, bool soloInactivos = false)
        {
            AccesoDatos datos = new AccesoDatos();
            int estado = soloInactivos ? 0 : 1;
            string consulta = "select P.Id,Numero,Nombre,P.Descripcion,UrlImagen,E.Descripcion as Tipo, D.Descripcion as Debilidad, P.IdTipo,P.IdDebilidad from POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE P.IdTipo=E.Id AND P.IdDebilidad=D.Id AND P.Activo=" + estado + " AND ";
            if (campo == "Numero")
            {
                switch (criterio)
                {
                    case "Igual a":
                        consulta += "Numero = " + filtro;
                        break;

                    case "Menor a":
                        consulta += "Numero < " + filtro;
                        break;

                    default:
                        consulta += "Numero > " + filtro;
                        break;
                }
            }

            else if (campo == "Descripcion")
            {
                switch (criterio)
                {
                    case "Empieza con":
                        consulta += "P.Descripcion like '" + filtro + "%'";
                        break;

                    case "Termina con":
                        consulta += "P.Descripcion like '%" + filtro + "'";
                        break;

                    default:
                        consulta += "P.Descripcion like '%" + filtro + "%'";
                        break;
                }
            }

            else
            {
                switch (criterio)
                {
                    case "Empieza con":
                        consulta += campo + " like '" + filtro + "%'";
                        break;

                    case "Termina con":
                        consulta += campo + " like '%" + filtro + "'";
                        break;

                    default:
                        consulta += campo + " like '%" + filtro + "%'";
                        break;
                }
            }
            try
            {
                cargarLector(consulta);
                return this.listaDePokemones;
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
        public void cargarLector(string consulta)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.setearConsulta(consulta);
            try
            {
                datos.ejecutarLectura();
                while (datos.obtenerDatos().Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)datos.obtenerDatos()["Id"];
                    aux.Numero = (int)datos.obtenerDatos()["Numero"];
                    aux.Nombre = (string)datos.obtenerDatos()["Nombre"];
                    aux.Descripcion = (string)datos.obtenerDatos()["Descripcion"];
                    //if (!(datos.obtenerDatos().IsDBNull(datos.obtenerDatos().GetOrdinal("UrlImagen"))))
                    if (!(datos.obtenerDatos()["UrlImagen"] is DBNull))
                        aux.urlImagen = (string)datos.obtenerDatos()["UrlImagen"];
                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)datos.obtenerDatos()["IdTipo"];
                    aux.Tipo.Descripcion = (string)datos.obtenerDatos()["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)datos.obtenerDatos()["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)datos.obtenerDatos()["Debilidad"];
                    this.listaDePokemones.Add(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
