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
    public partial class frmDeleteUser : Form
    {
        public frmDeleteUser()
        {
            InitializeComponent();
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {


            try
            {
                using (SqlConnection connection = new SqlConnection((@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Maintenance\Gas Logger\LoginDB.mdf;Integrated Security=True;Connect Timeout=30")))
                {
                    SqlCommand command = new SqlCommand("Select username FROM [Table]", connection);


                    connection.Open();
                    {
                        SqlDataReader drd = command.ExecuteReader();

                        while (drd.Read())
                        {
                            this.cmbUsers.Items.Add(drd.GetString(0).ToString());
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());

            }


        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            string user = cmbUsers.Text;
            string message = "Are you sure you want to delete " + user + "?";
            string caption = "Caution";
            DialogResult dialogResult = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE From [Table] WHERE username= " + "'" + user + "'";

                    using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Maintenance\Gas Logger\LoginDB.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            //this should comfirm that it worked
                            MessageBox.Show(user + " Has Been Successfully Deleted... Goodbye friend");
                        }
                    }
                }

                catch
                {
                    //If there is an error (it will likely be a network connection issue, since this program relies on a shared drived with the SQL database on it) this will alert the user
                    string errorMessage = "Make sure you are connected to the netowrk. If you still have trouble, please contact the developer :(";
                    string errorCaption = "A submit error has occured";
                    MessageBox.Show(errorMessage, errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }
    }
}