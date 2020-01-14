using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fuel_Logger
{
    public partial class frmGasAdded : Form
    {
        public frmGasAdded()
        {
            InitializeComponent();
        }

        private void toolHome_Click(object sender, EventArgs e)
        {
            frmIndexPage m = new frmIndexPage();
            m.Show();
            this.Close();
        }

        private void toolLog_Click(object sender, EventArgs e)
        {
            frmTransactionLog m = new frmTransactionLog();
            m.Show();
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp m = new frmHelp();
            m.Show();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            datePicker.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string supplierName = txtGasSupplier.Text;
            decimal gasAdded = numGasAdded.Value;
            DateTime date;
            date = datePicker.Value;
            //Keeps users from inputting "useless" data
            if (supplierName == "" && gasAdded == 0)
            {
                MessageBox.Show("Please Make Sure You Entered A Value For Both!");
            }
            try
            {
                // inserts values from the text boxes into the SQL database

                string query = "INSERT INTO GasLog(date,vendorName, gallonsGasAdded) " + "Values'" + date + "', '" + supplierName + "', '" + gasAdded + "')";

                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Maintenance\Gas Logger\GasLog.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Submitted");
                    }
                }
            }
            catch
            {
                //If there is an error (it will likely be a network connection issue, since this program relies on a shared drived with the SQL database on it) this will alert the user
                string message = "Make sure you are connected to the netowrk. If you still have trouble, please contact the developer :(";
                string caption = "A submit error has occured";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }



    }
}
