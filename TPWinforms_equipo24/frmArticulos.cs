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
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Marca");
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


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            Articulo seleccionado; 
            try
            {
                DialogResult rta = MessageBox.Show("¿Esta seguro que desea eliminarlo? Dicho articulo no podra ser recuperado.", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(rta == DialogResult.Yes)
                {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                negocio.eliminarArticulo(seleccionado.IdArticulo);
                Cargar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnFiltroRapido_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception)
            {

                throw;
            }
        }

        

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltroRapido.Text;

            if (filtro.Length >= 3)
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

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if(opcion == "Categoria")
            {   
                CategoriaNegocio categorias = new CategoriaNegocio();   
                cboCriterio.Items.Clear();
                foreach(var categoria in categorias.listar()){cboCriterio.Items.Add(categoria);}  
            }
            else if (opcion == "Marca")
            {
                MarcaNegocio marcas = new MarcaNegocio();
                cboCriterio.Items.Clear();
                foreach (var marc in marcas.listar()) { cboCriterio.Items.Add(marc);}
            }
            else if(opcion == "Nombre")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            } 

        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
