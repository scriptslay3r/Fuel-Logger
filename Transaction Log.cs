using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GridPrintPreviewLib;

namespace Fuel_Logger
{
    public partial class frmTransactionLog : Form
    {
        public frmTransactionLog()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIndexPage m = new frmIndexPage();
            m.Show();
            this.Close();
        }

        private void frmTransactionLog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gasLogDataSet.FuelLog' table. You can move, or remove it, as needed.
            this.fuelLogTableAdapter.Fill(this.gasLogDataSet.FuelLog);
            // TODO: This line of code loads data into the 'gasLogDataSet.FuelLog' table. You can move, or remove it, as needed.
            this.fuelLogTableAdapter.Fill(this.gasLogDataSet.FuelLog);

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



        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            printPreviewDialog1.ShowDialog();
        }
    

        private void sendToPrinterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // dataGridView1 is the DataGridView to print 
            GridPrintDocument doc = new GridPrintDocument(this.dataGridView1,
              this.dataGridView1.Font, true);
            doc.DocumentName = "Preview Test";
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Location = new Point(29, 29);
            printPreviewDialog.Name = "Print Preview Dialog";
            printPreviewDialog.UseAntiAlias = true;
            printPreviewDialog.Document = doc;
           

            // calc factor for fit grid in one page 
            float scale = doc.CalcScaleForFit();
            doc.ScaleFactor = scale;

            // show the grid again 
            printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Location = new Point(29, 29);
            printPreviewDialog.Name = "PrintPreviewDialog1";
            printPreviewDialog.UseAntiAlias = true;
            printPreviewDialog.Document = doc;
            printPreviewDialog.ShowDialog();
            doc.Dispose();
            doc = null;


        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
