namespace Fuel_Logger
{
    partial class frmTransactionLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactionLog));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToPrinterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gasLogDataSet = new Fuel_Logger.GasLogDataSet();
            this.fuelLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fuelLogTableAdapter = new Fuel_Logger.GasLogDataSetTableAdapters.FuelLogTableAdapter();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odometerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gallonsGasUsedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gallonsGasAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gallonsDieselUsedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gallonsDieselAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasLogDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelLogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1365, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(55, 19);
            this.goToToolStripMenuItem.Text = "Go To..";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendToPrinterToolStripMenuItem,
            this.printPreviewToolStripMenuItem});
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // sendToPrinterToolStripMenuItem
            // 
            this.sendToPrinterToolStripMenuItem.Name = "sendToPrinterToolStripMenuItem";
            this.sendToPrinterToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sendToPrinterToolStripMenuItem.Text = "Send To Printer";
            this.sendToPrinterToolStripMenuItem.Click += new System.EventHandler(this.sendToPrinterToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.vendorNameDataGridViewTextBoxColumn,
            this.vehicleDataGridViewTextBoxColumn,
            this.odometerDataGridViewTextBoxColumn,
            this.gallonsGasUsedDataGridViewTextBoxColumn,
            this.gallonsGasAddedDataGridViewTextBoxColumn,
            this.gallonsDieselUsedDataGridViewTextBoxColumn,
            this.gallonsDieselAddedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fuelLogBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1365, 759);
            this.dataGridView1.TabIndex = 1;
            // 
            // gasLogDataSet
            // 
            this.gasLogDataSet.DataSetName = "GasLogDataSet";
            this.gasLogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fuelLogBindingSource
            // 
            this.fuelLogBindingSource.DataMember = "FuelLog";
            this.fuelLogBindingSource.DataSource = this.gasLogDataSet;
            // 
            // fuelLogTableAdapter
            // 
            this.fuelLogTableAdapter.ClearBeforeFill = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "employeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "Employee\'s Name";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            this.employeeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vendorNameDataGridViewTextBoxColumn
            // 
            this.vendorNameDataGridViewTextBoxColumn.DataPropertyName = "vendorName";
            this.vendorNameDataGridViewTextBoxColumn.HeaderText = "Vendor\'s Name";
            this.vendorNameDataGridViewTextBoxColumn.Name = "vendorNameDataGridViewTextBoxColumn";
            this.vendorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleDataGridViewTextBoxColumn
            // 
            this.vehicleDataGridViewTextBoxColumn.DataPropertyName = "vehicle";
            this.vehicleDataGridViewTextBoxColumn.HeaderText = "Vehicle";
            this.vehicleDataGridViewTextBoxColumn.Name = "vehicleDataGridViewTextBoxColumn";
            this.vehicleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odometerDataGridViewTextBoxColumn
            // 
            this.odometerDataGridViewTextBoxColumn.DataPropertyName = "odometer";
            this.odometerDataGridViewTextBoxColumn.HeaderText = "Vehicle Odometer";
            this.odometerDataGridViewTextBoxColumn.Name = "odometerDataGridViewTextBoxColumn";
            // 
            // gallonsGasUsedDataGridViewTextBoxColumn
            // 
            this.gallonsGasUsedDataGridViewTextBoxColumn.DataPropertyName = "gallonsGasUsed";
            this.gallonsGasUsedDataGridViewTextBoxColumn.HeaderText = "Gas Used";
            this.gallonsGasUsedDataGridViewTextBoxColumn.Name = "gallonsGasUsedDataGridViewTextBoxColumn";
            // 
            // gallonsGasAddedDataGridViewTextBoxColumn
            // 
            this.gallonsGasAddedDataGridViewTextBoxColumn.DataPropertyName = "gallonsGasAdded";
            this.gallonsGasAddedDataGridViewTextBoxColumn.HeaderText = "Gas Added";
            this.gallonsGasAddedDataGridViewTextBoxColumn.Name = "gallonsGasAddedDataGridViewTextBoxColumn";
            // 
            // gallonsDieselUsedDataGridViewTextBoxColumn
            // 
            this.gallonsDieselUsedDataGridViewTextBoxColumn.DataPropertyName = "gallonsDieselUsed";
            this.gallonsDieselUsedDataGridViewTextBoxColumn.HeaderText = "Diesel Used";
            this.gallonsDieselUsedDataGridViewTextBoxColumn.Name = "gallonsDieselUsedDataGridViewTextBoxColumn";
            this.gallonsDieselUsedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gallonsDieselAddedDataGridViewTextBoxColumn
            // 
            this.gallonsDieselAddedDataGridViewTextBoxColumn.DataPropertyName = "gallonsDieselAdded";
            this.gallonsDieselAddedDataGridViewTextBoxColumn.HeaderText = "Diesel Added";
            this.gallonsDieselAddedDataGridViewTextBoxColumn.Name = "gallonsDieselAddedDataGridViewTextBoxColumn";
            this.gallonsDieselAddedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmTransactionLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 784);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTransactionLog";
            this.Text = "Transaction Log";
            this.Load += new System.EventHandler(this.frmTransactionLog_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasLogDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelLogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToPrinterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GasLogDataSet gasLogDataSet;
        private System.Windows.Forms.BindingSource fuelLogBindingSource;
        private GasLogDataSetTableAdapters.FuelLogTableAdapter fuelLogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odometerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gallonsGasUsedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gallonsGasAddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gallonsDieselUsedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gallonsDieselAddedDataGridViewTextBoxColumn;
    }
}