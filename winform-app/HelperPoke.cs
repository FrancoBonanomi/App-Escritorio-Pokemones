using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_app
{
    internal static class HelperPoke
    {
        public static void cargarImagen(string url, PictureBox pbx)
        {
            try
            {
                pbx.Load(url);
            }
            catch (Exception ex)
            {
                pbx.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }
        public static void actualizarLista(DataGridView dgwPokemons, PictureBox pbxImagenPokemon, bool soloInactivos = false)
        {

            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                List<Pokemon> listaPokemons = negocio.listar(soloInactivos);
                dgwPokemons.DataSource = listaPokemons;
                dgwPokemons.Columns["urlImagen"].Visible = false;
                dgwPokemons.Columns["Id"].Visible = false;
                if (listaPokemons.Count > 0)
                    cargarImagen(listaPokemons[0].urlImagen, pbxImagenPokemon);
                else
                    pbxImagenPokemon.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool validarVacio(DataGridView dgwPokemons)
        {
            return dgwPokemons.CurrentRow != null;
        }

        public static void filtrar(DataGridView dgwPokemons, TextBox txtFiltro, PictureBox pbx, bool soloInactivos = false)
        {
            try
            {
                List<Pokemon> listaPokemons = new PokemonNegocio().listar(soloInactivos);
                dgwPokemons.DataSource = listaPokemons.FindAll(x => x.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(txtFiltro.Text.ToUpper()));
                if (dgwPokemons.CurrentRow == null)
                    pbx.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static void cargarCriterios(ComboBox cboCampo, ComboBox cboCriterio)
        {
            string seleccionado = (string)cboCampo.SelectedItem;
            cboCriterio.Items.Clear();

            if (seleccionado == "Numero")
            {
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Add("Empieza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        public static void filtrarAvanzado(DataGridView dgw, ComboBox cboCampo, ComboBox cboCriterio, string filtro, PictureBox pbx, bool soloInactivos = false)
        {

        }

        public static void validarCampoNumerico(TextBox txtFiltroAvanzado, Label lblNumerico)
        {
            if (txtFiltroAvanzado.Text == "")
            {
                lblNumerico.Text = "El filtro no debe estar vacio";
            }

            else
            {
                string filtroNumerico = txtFiltroAvanzado.Text;

                foreach (char item in filtroNumerico)
                {
                    if (!char.IsNumber(item))
                    {
                        lblNumerico.Text = "Por favor, ingrese Solo numeros";
                    }
                    else
                        lblNumerico.Text = "";
                }
            }
        }

        public static void ajustarCboCampo(Label lblCampo, Label lblCriterio, ComboBox cboCampo, ComboBox cboCriterio, Label lblNumerico, TextBox txtFiltroAvanzado)
        {
            lblCampo.Text = "";
            lblCriterio.Text = "Seleccione un criterio";
            if (cboCampo.SelectedItem.ToString() != "Numero")
                lblNumerico.Text = "";
            else
                validarCampoNumerico(txtFiltroAvanzado, lblNumerico);

            cargarCriterios(cboCampo, cboCriterio);
        }

        public static void buscarAvanzado(ComboBox cboCampo, ComboBox cboCriterio, TextBox txtFiltroAvanzado, Label lblNumerico, DataGridView dgw, PictureBox pbx, bool soloInactivos = false)
        {

            if (cboCampo.SelectedItem == null || cboCriterio.SelectedItem == null)
                return;

            if (cboCampo.SelectedItem.ToString() == "Numero")
            {
                if (txtFiltroAvanzado.Text == "")
                {
                    lblNumerico.Text = "El filtro no debe estar vacio";
                    return;
                }

                string filtroNumerico = txtFiltroAvanzado.Text;

                foreach (char item in filtroNumerico)
                {
                    if (!char.IsNumber(item))
                        return;
                }
            }

            try
            {
                dgw.DataSource = new PokemonNegocio().filtrar(cboCampo.SelectedItem.ToString(), cboCriterio.SelectedItem.ToString(), txtFiltroAvanzado.Text, soloInactivos);
                if (dgw.CurrentRow == null)
                    pbx.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void EliminacionPokemones(Pokemon aEliminar, DataGridView dgwPokemons, PictureBox pbxImagenPokemon, bool esLogica, bool estaInactivo)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea" + (!esLogica ? " eliminar " : " desactivar ") + " el pokemon " + aEliminar.Nombre + " con el id: " + aEliminar.Id + "?", " Confirmar eliminacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.OK)
            {

                try
                {
                    string rutaCarpeta = !estaInactivo ? @"C:\poke-app\" : @"C:\poke-app-eliminadas\";
                    string[] archivos = Directory.GetFiles(rutaCarpeta);
                    foreach (string item in archivos)
                    {
                        if (aEliminar.urlImagen.ToLower().Contains(Path.GetFileName(item.ToLower())))
                            if (!aEliminar.urlImagen.ToLower().Contains("http"))
                            {
                                if (esLogica)
                                    File.Copy(item, ConfigurationManager.AppSettings["imagenes-eliminadas"] + Path.GetFileName(item));
                                File.Delete(item);
                            }
                    }
                    PokemonNegocio negocio = new PokemonNegocio();
                    if (!esLogica)
                        negocio.eliminarPokemon(aEliminar.Id);
                    else
                        negocio.eliminarPokemon(aEliminar.Id, true);
                    HelperPoke.actualizarLista(dgwPokemons, pbxImagenPokemon);
                    MessageBox.Show(!esLogica ? "Pokemon eliminado exitosamente" : "Pokemon desactivado exitosamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }
    }




}
