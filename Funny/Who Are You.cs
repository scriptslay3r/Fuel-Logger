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
    public partial class frmWhoAreYou : Form
    {
        public frmWhoAreYou()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmIndexPage m = new frmIndexPage();
            m.Show();
            this.Close();

        }

        private void btnProveIt_Click(object sender, EventArgs e)
        {
            frmProof m = new frmProof();
            m.Show();
            this.Close();
        }
    }
}
