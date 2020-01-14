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
    public partial class frmIndexPage : Form
    {
        public frmIndexPage()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmFuelTypeAdd m = new frmFuelTypeAdd();
            m.Show();
            this.Close();
        }

        private void btnFuelUsed_Click(object sender, EventArgs e)
        {
            frmFuelTypeDispense m = new frmFuelTypeDispense();
            m.Show();
            this.Close();
            //MessageBox.Show("Delete Me Later");
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmUserRegistration m = new frmUserRegistration();
            m.Show();

        }

        private void dontClickMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYouClickedIt m = new frmYouClickedIt();
            m.Show();
            this.Close();

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            frmTransactionLog m = new frmTransactionLog();
            m.Show();

        }


        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewUsers m = new frmViewUsers();
            m.Show();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                txtGasLeft.Font = fontDialog1.Font;
                txtDieselLeft.Font = fontDialog1.Font;
                btnAdd.Font = fontDialog1.Font;
                btnAddUser.Font = fontDialog1.Font;
                btnFuelUsed.Font = fontDialog1.Font;
                btnLog.Font = fontDialog1.Font;
                label1.Font = fontDialog1.Font;
                label2.Font = fontDialog1.Font;
                goToToolStripMenuItem.Font = fontDialog1.Font;
                editToolStripMenuItem.Font = fontDialog1.Font;
                viewUsersToolStripMenuItem.Font = fontDialog1.Font;
                helpToolStripMenuItem.Font = fontDialog1.Font;
                dontClickMeToolStripMenuItem.Font = fontDialog1.Font;
                fontToolStripMenuItem.Font = fontDialog1.Font;
                
                

            }

        }

 


        private void frmIndexPage_Load(object sender, EventArgs e)
        {
         
        
            //My Query to get the current fuel that is supposed to be in the tank. Based off previous additions(by vendors) and subtractions (by employees using the gas)
            string getGas = "SELECT  SUM(gallonsGasAdded) - SUM(gallonsGasUsed) from FuelLog";
            string getDiesel = "SELECT SUM(gallonsDieselAdded) - SUM(gallonsDieselUsed) from FuelLog";

            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Maintenance\Gas Logger\GasLog.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                using (SqlCommand gasCommand = new SqlCommand(getGas, connection))
                {
                    connection.Open();
                    var result = Convert.ToDecimal(gasCommand.ExecuteScalar()); //the data type for the fuel is in decimal format, however, I need it to print a string into a textbox
                    txtGasLeft.Text = Convert.ToString(result) + " Gallons";


                }
                using (SqlCommand dieselCommand = new SqlCommand(getDiesel, connection))
                {
                    //connection.Open();
                    var result = Convert.ToDecimal(dieselCommand.ExecuteScalar());
                    txtDieselLeft.Text = Convert.ToString(result) + " Gallons"; // same thing here except this is for diesel.
                    connection.Close();
                }
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp m = new frmHelp();
            m.Show();
        }
    }
}
