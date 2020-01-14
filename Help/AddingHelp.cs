using System;
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
    public partial class frmAddingHelp : Form
    {
        public frmAddingHelp()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIndexPage m = new frmIndexPage();
            m.Show();
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp m = new frmHelp();
            m.Show();
            this.Close();
        }



        private void fontToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void linkAddingFuel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmFuelTypeAdd m = new frmFuelTypeAdd();
            m.Show();
        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHelp m = new frmHelp();
            m.Show();
            this.Close();

        }
    }
}
