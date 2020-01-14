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
    public partial class frmDieselAdded : Form
    {
        public frmDieselAdded()
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

        private void btnChangeDate_Click(object sender, EventArgs e)
        {
            datePicker.Show();
        }
    
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string supplierName = txtDieselSupplier.Text;
            decimal dieselAdded = numDieselAdded.Value;
            DateTime date;
            date = datePicker.Value;
            
            //Keeps users from inputting "useless" data. Forces both fields to be filled out before you can submit
            if (supplierName == "" && dieselAdded == 0)
            {
                MessageBox.Show("Please Make Sure You Entered A Value For Both!");
            }
            try
            {
                // inserts values from the text boxes into the SQL database
                string query = "INSERT INTO FuelLog(date,vendorName, gallonsDieselAdded) " + "Values('" + date +"', '" + supplierName + "', '" + dieselAdded + "')";
                //Judge Me... I couldn't get it to work in the "query" string 
               // string addDate = "INSERT INTO FuelLog(date) " + "Values(GetDate())"; 

                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Maintenance\Gas Logger\GasLog.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        //this should comfirm that it worked
                        MessageBox.Show("Submitted");
                    }
                 /*   using (SqlCommand getDate = new SqlCommand(addDate, connection))
                    {
                        getDate.ExecuteNonQuery();
                        //This is just to test that it worked
                        MessageBox.Show("Date Submitted");
                    }*/
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

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp m = new frmHelp();
            m.Show();
        }
    }
}
