using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winform_app
{
    public partial class frmPokemonesActivos : Form
    {
        public frmPokemonesActivos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                HelperPoke.actualizarLista(dgwPokemons, pbxImagenPokemon);
                cboCampo.Items.Add("Numero");
                cboCampo.Items.Add("Nombre");
                cboCampo.Items.Add("Descripcion");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgwPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgwPokemons.CurrentRow.DataBoundItem;
            HelperPoke.cargarImagen(seleccionado.urlImagen, pbxImagenPokemon);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                frmAltaPokemon alta = new frmAltaPokemon();
                alta.ShowDialog();
                HelperPoke.actualizarLista(dgwPokemons, pbxImagenPokemon);
                //MessageBox.Show("Pokemon agregado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (HelperPoke.validarVacio(dgwPokemons))
            {
                try
                {
                    Pokemon aModificar = (Pokemon)dgwPokemons.CurrentRow.DataBoundItem;
                    frmAltaPokemon modificacion = new frmAltaPokemon();
                    modificacion.setearPokemon(aModificar);
                    modificacion.ShowDialog();
                    HelperPoke.actualizarLista(dgwPokemons, pbxImagenPokemon);
                    // MessageBox.Show("Pokemon modificado exitosamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
                MessageBox.Show("Ningun Pokemon seleccionado");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (HelperPoke.validarVacio(dgwPokemons))
                HelperPoke.EliminacionPokemones((Pokemon)dgwPokemons.CurrentRow.DataBoundItem, dgwPokemons, pbxImagenPokemon, false, false);
            else
                MessageBox.Show("Ningun Pokemon Seleccionado");
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            if (HelperPoke.validarVacio(dgwPokemons))
                HelperPoke.EliminacionPokemones((Pokemon)dgwPokemons.CurrentRow.DataBoundItem, dgwPokemons, pbxImagenPokemon, true, false);
            else
                MessageBox.Show("Ningun Pokemon Seleccionado");

        }

        private void btnInactivos_Click(object sender, EventArgs e)
        {
            frmPokemonesInactivos inactivos = new frmPokemonesInactivos();
            inactivos.ShowDialog();

            try
            {
                HelperPoke.actualizarLista(dgwPokemons, pbxImagenPokemon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                HelperPoke.filtrar(dgwPokemons, txtFiltro, pbxImagenPokemon, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            HelperPoke.ajustarCboCampo(lblCampo, lblCriterio, cboCampo, cboCriterio, lblNumerico, txtFiltroAvanzado);
        }

        private void btnBuscarAvanzado_Click(object sender, EventArgs e)
        {
            try
            {
                HelperPoke.buscarAvanzado(cboCampo, cboCriterio, txtFiltroAvanzado, lblNumerico, dgwPokemons, pbxImagenPokemon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cboCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCriterio.SelectedItem == null)
                lblCriterio.Text = "Seleccione un criterio";

            else
                lblCriterio.Text = "";
        }

        private void txtFiltroAvanzado_TextChanged(object sender, EventArgs e)
        {
            if (cboCampo.SelectedItem != null)
            {
                if (cboCampo.SelectedItem.ToString() == "Numero")
                    HelperPoke.validarCampoNumerico(txtFiltroAvanzado, lblNumerico);
            }

        }
    }
}
