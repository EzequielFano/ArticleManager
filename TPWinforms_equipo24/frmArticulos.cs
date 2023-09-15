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
            dgvArticulos.Columns["Imagen"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo alta=new frmAgregarArticulo();
            alta.ShowDialog();
        }
    }
}
