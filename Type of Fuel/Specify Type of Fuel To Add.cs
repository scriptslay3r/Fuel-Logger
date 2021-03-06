﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Logger
{
    public partial class frmFuelTypeAdd : Form
    {
        public frmFuelTypeAdd()
        {
            InitializeComponent();
        }

        private void btnGas_Click(object sender, EventArgs e)
        {
            frmGasAdded m = new frmGasAdded();
            m.Show();
            this.Close();

        }

        private void btnDiesel_Click(object sender, EventArgs e)
        {
            frmDieselAdded m = new frmDieselAdded();
            m.Show();
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIndexPage m = new frmIndexPage();
            m.Show();
            this.Close();

        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransactionLog m = new frmTransactionLog();
            m.Show();
          
        }
    }
}
