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
    public partial class frmUserRegistration : Form
    {
        public frmUserRegistration()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Please provide UserName and Password");
                    return;
                }
                if (txtPassword.Text != txtPasswordConfirm.Text)
                {
                    MessageBox.Show("Your passwords do not match :(");
                    lblPassword.ForeColor = System.Drawing.Color.Red;
                    lblConfirm.ForeColor = System.Drawing.Color.Red;
                    return;
                }

                SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Maintenance\Gas Logger\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
                //Create SqlConnection
                string query = "Select * from [Table] Where username= '" + txtUsername.Text + "'";
                //Creates an object which will send the query through the connection to the sql server
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                //Creates a dataTable in which we will input the login information that matches
                DataTable dtbl = new DataTable();
                //Fill the table with whatever entery in the DB fits the criteria of : having the username put in the txtUserName.txt and password from the txtPassword.txt
                sda.Fill(dtbl);
                //If there is a match, then we deny the registration

                if (dtbl.Rows.Count > 0)
                {
                    MessageBox.Show("Username is taken!");
                    lblUserName.ForeColor = System.Drawing.Color.Red;
                }
                //else, Add the user (add the username and password combo in the DB)
                try
                {
                    //the query 
                    string commString = "INSERT INTO [Table](username,password) VALUES (@val1, @val2)";
                    string conString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = G:\Maintenance\Gas Logger\LoginDB.mdf; Integrated Security = True; Connect Timeout = 30";
                    //Connect to DB
                    using (SqlConnection conn = new SqlConnection(conString))
                    {
                        //creat an sqlCommand
                        //This is done to santize the inputs and prevent injection into the string
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.Connection = conn;
                            comm.CommandText = commString;
                            //this is where the sanitizing happens
                            comm.Parameters.AddWithValue("@val1", txtUsername.Text);
                            comm.Parameters.AddWithValue("@val2", txtPassword.Text);
                            //open the connection
                            conn.Open();
                            //execute the query that was just written
                            comm.ExecuteNonQuery();

                        }


                    }
                    MessageBox.Show("Sucessfully Registered");
                }
                catch { MessageBox.Show("A registration error has occured. Please contact the developer :("); }
            }



        }

 
    }
}

