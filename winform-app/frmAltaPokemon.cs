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
    public partial class frmAltaPokemon : Form
    {

        private Pokemon poke;
        private OpenFileDialog archivo;

        public frmAltaPokemon()
        {
            InitializeComponent();

        }

        public void setearPokemon(Pokemon poke)
        {
            this.poke = poke;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumero.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("Por favor, complete el campo numero");
                    return;
                }

                foreach (char item in txtNumero.Text)
                {
                    if (!char.IsNumber(item))
                    {
                        MessageBox.Show("el campo solo debe contener numeros");
                        return;
                    }
                }

                if (txtNombre.Text.Replace(" ", "") == "")
                {
                    MessageBox.Show("Por favor, complete el campo nombre");
                    return;
                }

                PokemonNegocio negocio = new PokemonNegocio();
                if (poke == null)
                    poke = new Pokemon();
                else
                {
                    if (File.Exists(@"C:\poke-app\" + Path.GetFileName(poke.urlImagen)) && poke.urlImagen != txtUrlImagen.Text)
                        File.Delete(@"C:\poke-app\" + Path.GetFileName(poke.urlImagen));
                }

                poke.Numero = int.Parse(txtNumero.Text);
                poke.Nombre = txtNombre.Text;
                poke.Descripcion = txtDescripcion.Text;
                poke.Tipo = (Elemento)cboTipo.SelectedItem;
                poke.Debilidad = (Elemento)cboDebilidad.SelectedItem;
                poke.urlImagen = txtUrlImagen.Text;


                if (poke.Id == 0)
                {
                    negocio.insertarPokemon(poke);
                    MessageBox.Show("Pokemon agregado exitosamente");
                }

                else
                {
                    negocio.modificarPokemon(poke);
                    MessageBox.Show("Pokemon modificado exitosamente");
                }

                if (!(txtUrlImagen.Text.ToLower().Contains("http")) && archivo != null && txtUrlImagen.Text.Replace(" ", "") != "")
                {
                    //@ para que tome la cadena literal sin caracteres de escape especiales
                    if (!File.Exists(@"C:\poke-app\" + archivo.SafeFileName))
                    {
                        File.Copy(archivo.FileName, ConfigurationManager.AppSettings["imagenes-pokemones"] + archivo.SafeFileName);
                    }

                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {
            try
            {
                ElementoNegocio negocio = new ElementoNegocio();
                cboTipo.DataSource = negocio.listar();
                cboDebilidad.DataSource = negocio.listar();
                if (poke != null)
                {
                    this.Text = "Modificar Pokemon";
                    txtNumero.Text = poke.Numero.ToString();
                    txtNombre.Text = poke.Nombre;
                    txtDescripcion.Text = poke.Descripcion;
                    txtUrlImagen.Text = poke.urlImagen;
                    HelperPoke.cargarImagen(txtUrlImagen.Text, pbxPokemon);
                    //o uso value member y display member
                    foreach (Elemento item in cboTipo.Items)
                    {
                        if (item.Id == poke.Tipo.Id)
                            cboTipo.SelectedIndex = item.Id - 1;
                    }
                    foreach (Elemento item in cboDebilidad.Items)
                    {
                        if (item.Id == poke.Debilidad.Id)
                            cboDebilidad.SelectedIndex = item.Id - 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            HelperPoke.cargarImagen(txtUrlImagen.Text, pbxPokemon);
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tiff;*.ico";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                HelperPoke.cargarImagen(archivo.FileName, pbxPokemon);
                txtUrlImagen.Text = archivo.FileName;
            }
        }
    }
}
