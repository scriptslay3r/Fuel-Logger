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
    public partial class frmViewUsers : Form
    {
        public frmViewUsers()
        {
            InitializeComponent();
        }



        private void frmViewUsers_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDBDataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter1.Fill(this.loginDBDataSet1.Table);

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



        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is coming soon");
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteUser m = new frmDeleteUser();
            m.Show();
        }
    }
}
