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
    public partial class frmYouClickedIt : Form
    {
        public frmYouClickedIt()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmIndexPage m = new frmIndexPage();
            m.Show();
            this.Close();

        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            frmWhoAreYou m = new frmWhoAreYou();
            m.Show();
            this.Close();

        }
    }
}
