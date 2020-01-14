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
    public partial class frmAuthorization : Form
    {
        public frmAuthorization()
        {
            InitializeComponent();
        }
        private void frmAuthorization_Load(object sender, EventArgs e)
        {
            //This is supposed to auto highlight the fields
            txtUserName.SelectionStart = 0;
            txtUserName.SelectionLength = txtUserName.Text.Length;
            txtPassword.SelectionStart = 0;
            txtPassword.SelectionLength = txtPassword.Text.Length;
            //System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["frmAuthorization"];
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            {
                if (txtUserName.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Please provide UserName and Password");
                    return;
                }
                try
                {
                    SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Maintenance\Gas Logger\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
                    //Create SqlConnection
                    string query = "Select * from [Table] Where username= '" + txtUserName.Text + "' and password = '" + txtPassword.Text + "'";
                    //Creates an object which will send the query through the connection to the sql server
                    SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                    //Creates a dataTable in which we will input the login information that matches
                    DataTable dtbl = new DataTable();
                    //Fill the table with whatever entery in the DB fits the criteria of : having the username put in the txtUserName.txt and password from the txtPassword.txt
                    sda.Fill(dtbl);
                    //if there is a match found, allow access


                    if (dtbl.Rows.Count == 1)
                    {
                        MessageBox.Show("Login Successful! Welcome, " + txtUserName.Text);
                        this.Hide();
                        frmIndexPage fm = new frmIndexPage();
                        fm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


    }
}
