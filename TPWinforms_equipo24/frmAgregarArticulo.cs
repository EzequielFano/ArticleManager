using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinforms_equipo24
{
    public partial class frmAgregarArticulo : Form
    {
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }
        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboCategoria.DataSource = categoriaNegocio.listar();    

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                    ArticulosNegocio negocio = new ArticulosNegocio();
                    Articulo art = new Articulo();
            try
            { 
                art.CodigoArticulo = txtCodigo.Text;
                art.NombreArticulo = txtNombre.Text;
                art.Descripcion = txtDescripcion.Text;
                art.Marca = (Marca)cboMarca.SelectedItem;
                art.Categoria = (Categoria)cboCategoria.SelectedItem;
                art.URLImagen = new Imagen();
                art.URLImagen.URL = txtURL.Text;
                art.Precio = float.Parse(txtPrecio.Text);
                negocio.agregarArticulo(art);
                MessageBox.Show("Agregado correctamente");
                Close();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void txtURL_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtURL.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticuloCarga.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticuloCarga.Load("https://redthread.uoregon.edu/files/original/affd16fd5264cab9197da4cd1a996f820e601ee4.png");
            }
        }
    }
}
