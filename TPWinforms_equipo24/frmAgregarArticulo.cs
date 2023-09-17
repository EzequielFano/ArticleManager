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
        private Articulo articulo = null;
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }
        public frmAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }
        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if (articulo!=null)
                {
                    txtCodigo.Text = articulo.CodigoArticulo;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtNombre.Text = articulo.NombreArticulo;
                    txtPrecio.Text = articulo.Precio.ToString();
                    txtURL.Text = articulo.URLImagen.URL;
                    cargarImagen(articulo.URLImagen.URL);
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    if (!(articulo.Categoria == null))
                    {
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    }



                }

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
            try
            { 
                if (articulo == null)
                {
                    articulo = new Articulo();
                }
                
                articulo.CodigoArticulo = txtCodigo.Text;
                articulo.NombreArticulo = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.URLImagen = new Imagen();
                articulo.URLImagen.URL = txtURL.Text;
                articulo.Precio = float.Parse(txtPrecio.Text);

                if (articulo.IdArticulo != 0)
                {
                    negocio.modificarArticulo(articulo);
                    MessageBox.Show("Modificado correctamente");
                    

                }
                else
                {
                    negocio.agregarArticulo(articulo);
                    MessageBox.Show("Agregado correctamente");
                }

               
                Close();
                
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor cargue los campos OBLIGATORIOS");
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
            catch (Exception)
            {
                pbxArticuloCarga.Load("https://redthread.uoregon.edu/files/original/affd16fd5264cab9197da4cd1a996f820e601ee4.png");
            }
        }
    }
}
