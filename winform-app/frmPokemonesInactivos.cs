using dominio;
using negocio;
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

namespace winform_app
{
    public partial class frmPokemonesInactivos : Form
    {
        public frmPokemonesInactivos()
        {
            InitializeComponent();
        }

        private void frmPokemonesInactivos_Load(object sender, EventArgs e)
        {
            try
            {
                HelperPoke.actualizarLista(dgwInactivos, pbxInactivos, true);
                cboCampo.Items.Add("Numero");
                cboCampo.Items.Add("Nombre");
                cboCampo.Items.Add("Descripcion");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgwInactivos_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgwInactivos.CurrentRow.DataBoundItem;
            HelperPoke.cargarImagen(seleccionado.urlImagen, pbxInactivos);
        }

        private void btnReactivar_Click(object sender, EventArgs e)
        {
            if (HelperPoke.validarVacio(dgwInactivos))
            {
                Pokemon aReactivar = (Pokemon)dgwInactivos.CurrentRow.DataBoundItem;
                DialogResult respuesta = MessageBox.Show("¿Desea reactivar el pokemon " + aReactivar.Nombre + " con el id: " + aReactivar.Id + "?", " Confirmar reactivacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.OK)
                {

                    try
                    {
                        string rutaCarpeta = @"C:\poke-app-eliminadas\";
                        string[] archivos = Directory.GetFiles(rutaCarpeta);
                        foreach (string item in archivos)
                        {
                            if (aReactivar.urlImagen.ToLower().Contains(Path.GetFileName(item.ToLower())))
                                if (!aReactivar.urlImagen.ToLower().Contains("http"))
                                {
                                    File.Copy(item, ConfigurationManager.AppSettings["imagenes-pokemones"] + Path.GetFileName(item));
                                    File.Delete(item);
                                }
                        }
                        PokemonNegocio negocio = new PokemonNegocio();
                        negocio.reactivarPokemon(aReactivar.Id);
                        HelperPoke.actualizarLista(dgwInactivos, pbxInactivos, true);
                        MessageBox.Show("Pokemon rectivado exitosamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }

            else
                MessageBox.Show("Ningun Pokemon seleccionado");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                HelperPoke.filtrar(dgwInactivos, txtFiltro, pbxInactivos, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            HelperPoke.ajustarCboCampo(lblCampo, labelCriterio, cboCampo, cboCriterio, labelFiltro, txtFiltroAvanzado);
        }

        private void btnBuscarAvanzado_Click(object sender, EventArgs e)
        {
            try
            {
                HelperPoke.buscarAvanzado(cboCampo, cboCriterio, txtFiltroAvanzado, labelFiltro, dgwInactivos, pbxInactivos, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtFiltroAvanzado_TextChanged_1(object sender, EventArgs e)
        {
            if (cboCampo.SelectedItem != null)
            {
                if (cboCampo.SelectedItem.ToString() == "Numero")
                    HelperPoke.validarCampoNumerico(txtFiltroAvanzado, labelFiltro);
            }
        }

        private void cboCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCriterio.SelectedItem == null)
                labelCriterio.Text = "Seleccione un criterio";

            else
                labelCriterio.Text = "";
        }

        private void btnEliminarDefinitivamente_Click(object sender, EventArgs e)
        {
            if (HelperPoke.validarVacio(dgwInactivos))
                HelperPoke.EliminacionPokemones((Pokemon)dgwInactivos.CurrentRow.DataBoundItem, dgwInactivos, pbxInactivos, false, true);

            else
                MessageBox.Show("Ningun Pokemon Seleccionado");
        }
    }
}
