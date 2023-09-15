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
            Articulo art = new Articulo();
            try
            {
                art.CodigoArticulo = txtCodigo.Text;
                art.NombreArticulo = txtNombre.Text;
                art.Descripcion = txtDescripcion.Text;
                art.Marca = (Marca)cboMarca.SelectedItem;
                art.Categoria = (Categoria)cboCategoria.SelectedItem;
                art.Imagen = txtURL.Text;
                art.Precio = float.Parse(txtPrecio.Text);
                ArticulosNegocio negocio = new ArticulosNegocio();
                negocio.agregarArticulo(art);
                MessageBox.Show("Agregado correctamente");
                Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
