using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinforms_equipo24
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulos;
        public frmArticulos()
        {
            InitializeComponent();
        }
        private void ocultarColumnas()
        {
            dgvArticulos.Columns["IdArticulo"].Visible = false;
            dgvArticulos.Columns["URLImagen"].Visible = false;
        }
        private void Cargar()
        {
            ArticulosNegocio articulosNegocio = new ArticulosNegocio();
            try
            {
            listaArticulos = articulosNegocio.TraerListado();
            dgvArticulos.DataSource = listaArticulos;
            ocultarColumnas();
            pbxArticulo.Load(listaArticulos[0].URLImagen.URL);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void frmArticulos_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo alta=new frmAgregarArticulo();
            alta.ShowDialog();
            Cargar();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.URLImagen.URL);
            }
           
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://redthread.uoregon.edu/files/original/affd16fd5264cab9197da4cd1a996f820e601ee4.png");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo Seleccionado;
            Seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAgregarArticulo modificar = new frmAgregarArticulo(Seleccionado);
            modificar.ShowDialog();
            Cargar();

        }

<<<<<<< HEAD
      
=======
        private void btnFiltroRapido_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltroRapido.Text;

            if (filtro != "")
            {
                listaFiltrada = listaArticulos.FindAll(x => x.NombreArticulo.ToUpper().Contains(filtro.ToUpper())
                || x.CodigoArticulo.ToUpper().Contains(filtro.ToUpper())
                || x.Descripcion.ToUpper().Contains(filtro.ToUpper())
                || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper())
                || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }
>>>>>>> cc00f0f22986b1b96f10b087639f2f4a707f0616
    }
}
