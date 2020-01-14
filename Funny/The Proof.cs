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
    public partial class frmProof : Form
    {
        public frmProof()
        {
            InitializeComponent();
        }

        private void btnMercy_Click(object sender, EventArgs e)
        {
            frmIndexPage m = new frmIndexPage();
            m.Show();
            this.Close();

              
        }

        private void btnProof_Click(object sender, EventArgs e)
        {
            string message = "YOU DID THIS TO YOUR SELF!!! I TOLD YOU NOT TO CLICK!!";
            string caption = "NICE TRY... HACKER";
            int counter = 10; 
            frmViewUsers m = new frmViewUsers();
            if (txtProof.Text == "PuddingPass")
            {
                m.Show();
                this.Close();
            }
            else 
                {
                
                while (counter > 0)
                {
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    counter = counter - 1;
                }

                }
            }
            
        }
    }

