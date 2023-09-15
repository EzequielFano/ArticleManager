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
        public frmArticulos()
        {
            InitializeComponent();
        }


        private void frmArticulos_Load(object sender, EventArgs e)
        {
           DBConexion dBConexion = new DBConexion();
           dgvArticulos.DataSource = dBConexion.TraerListado();
        }
    }
}
