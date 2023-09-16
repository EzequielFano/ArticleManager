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


        private void frmArticulos_Load(object sender, EventArgs e)
        {
           ArticulosNegocio articulosNegocio = new ArticulosNegocio();
            listaArticulos = articulosNegocio.TraerListado();
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns["URLImagen"].Visible = false;
            pbxArticulo.Load(listaArticulos[0].URLImagen.URL);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo alta=new frmAgregarArticulo();
            alta.ShowDialog();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.URLImagen.URL);
           
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Imagen_no_disponible.svg/1200px-Imagen_no_disponible.svg.png");
            }
        }
    }
}
