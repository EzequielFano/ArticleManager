﻿using System;
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
    public partial class frmPantallaPrincipala : Form
    {
        public frmPantallaPrincipala()
        {
            InitializeComponent();
        }

        private void btnStart_Enter(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmArticulos alta = new frmArticulos();
            alta.ShowDialog();
        }

        private void francoDanelonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPresentacionFranco go = new frmPresentacionFranco();
            go.ShowDialog();
        }
    }
}
