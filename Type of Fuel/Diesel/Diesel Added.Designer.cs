namespace Fuel_Logger
{
    partial class frmDieselAdded
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDieselAdded));
            this.txtDieselSupplier = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHome = new System.Windows.Forms.ToolStripMenuItem();
            this.toolLog = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numDieselAdded = new System.Windows.Forms.NumericUpDown();
            this.btnChangeDate = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDieselAdded)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDieselSupplier
            // 
            this.txtDieselSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDieselSupplier.Location = new System.Drawing.Point(464, 170);
            this.txtDieselSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.txtDieselSupplier.Name = "txtDieselSupplier";
            this.txtDieselSupplier.Size = new System.Drawing.Size(151, 24);
            this.txtDieselSupplier.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Who Supplied the diesel?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "How many gallons of diesel were added?";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(503, 291);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 50);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(716, 25);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolHome,
            this.toolLog,
            this.helpToolStripMenuItem});
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(55, 19);
            this.goToToolStripMenuItem.Text = "Go To..";
            // 
            // toolHome
            // 
            this.toolHome.Name = "toolHome";
            this.toolHome.Size = new System.Drawing.Size(107, 22);
            this.toolHome.Text = "Home";
            this.toolHome.Click += new System.EventHandler(this.toolHome_Click);
            // 
            // toolLog
            // 
            this.toolLog.Name = "toolLog";
            this.toolLog.Size = new System.Drawing.Size(107, 22);
            this.toolLog.Text = "Log";
            this.toolLog.Click += new System.EventHandler(this.toolLog_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // numDieselAdded
            // 
            this.numDieselAdded.DecimalPlaces = 2;
            this.numDieselAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDieselAdded.Location = new System.Drawing.Point(462, 76);
            this.numDieselAdded.Margin = new System.Windows.Forms.Padding(4);
            this.numDieselAdded.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDieselAdded.Name = "numDieselAdded";
            this.numDieselAdded.Size = new System.Drawing.Size(153, 24);
            this.numDieselAdded.TabIndex = 0;
            // 
            // btnChangeDate
            // 
            this.btnChangeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeDate.Location = new System.Drawing.Point(0, 291);
            this.btnChangeDate.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeDate.Name = "btnChangeDate";
            this.btnChangeDate.Size = new System.Drawing.Size(174, 50);
            this.btnChangeDate.TabIndex = 3;
            this.btnChangeDate.Text = "Change Date";
            this.btnChangeDate.UseVisualStyleBackColor = true;
            this.btnChangeDate.Click += new System.EventHandler(this.btnChangeDate_Click);
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(251, 317);
            this.datePicker.Margin = new System.Windows.Forms.Padding(4);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(158, 24);
            this.datePicker.TabIndex = 37;
            this.datePicker.Visible = false;
            // 
            // frmDieselAdded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 432);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.numDieselAdded);
            this.Controls.Add(this.txtDieselSupplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnChangeDate);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDieselAdded";
            this.Text = "Diesel Added";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDieselAdded)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDieselSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolHome;
        private System.Windows.Forms.ToolStripMenuItem toolLog;
        private System.Windows.Forms.NumericUpDown numDieselAdded;
        private System.Windows.Forms.Button btnChangeDate;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}