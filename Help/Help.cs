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
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
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
            this.Close();

        }

        private void linkAdding_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddingHelp m = new frmAddingHelp();
            m.Show();
            this.Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            fontDialog1.ShowDialog();
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                linkAdding.Font = fontDialog1.Font;
                linkDate.Font = fontDialog1.Font;
                linkUsers.Font = fontDialog1.Font;
                linkDispensing.Font = fontDialog1.Font;
                goToToolStripMenuItem.Font = fontDialog1.Font;
                homeToolStripMenuItem.Font = fontDialog1.Font;
                logToolStripMenuItem.Font = fontDialog1.Font;
                editToolStripMenuItem.Font = fontDialog1.Font;
                fontToolStripMenuItem.Font = fontDialog1.Font;

            }
        }


        private void frmHelp_Load(object sender, EventArgs e)
        {
       
        }

        private void linkDispensing_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDispensingHelp m = new frmDispensingHelp();
            m.Show();
        }

        private void linkDate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDateHelp m = new frmDateHelp();
            m.Show();
        }
    }
}
