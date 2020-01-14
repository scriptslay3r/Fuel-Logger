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
    public partial class frmDieselUsed : Form
    {
        public frmDieselUsed()
        {
            InitializeComponent();
        }
        private void frmDieselUsed_Load(object sender, EventArgs e)
        {
            //Used to autofill the "Who got diesel" field by "grabbing" the name of whoever is currently logged in
            //The text box will also be "read only" to prevent users from changing the name to provide accountability
            //NO COOKIN THE BOOKS HERE AND BLAMING IT ON SOMEONE ELSE :) 
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["frmAuthorization"];
            txtDieselUser.Text = ((frmAuthorization)f).txtUserName.Text;

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
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }


        private void btnChangeDate_Click(object sender, EventArgs e)
        {
            datePicker.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string userName = txtDieselUser.Text;
            decimal dieselUsed = numDieselUsed.Value;
            DateTime date;
            date = datePicker.Value;
            string vehicle = txtVehicle.Text;
            string odometer = txtOdometer.Text;
            //Keeps users from inputting "useless" data. Forces both fields to be filled out before you can submit
            if (userName == "" && dieselUsed == 0)
            {
                MessageBox.Show("Please Make Sure You Entered A Value For Your Name And The Amount of Diesel Used!");
            }
            try
            {
                // inserts values from the text boxes into the SQL database
                string query = "INSERT INTO FuelLog(date,employeeName,vehicle,odometer,gallonsDieselUsed) " + "Values('" + date + "', '" + userName + "', '" + vehicle + "', '" + odometer + "', '" + dieselUsed + "')";

                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Maintenance\Gas Logger\GasLog.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        //this should comfirm that it worked
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
