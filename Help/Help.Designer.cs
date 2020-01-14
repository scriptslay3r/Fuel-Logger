namespace Fuel_Logger
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkAdding = new System.Windows.Forms.LinkLabel();
            this.linkDispensing = new System.Windows.Forms.LinkLabel();
            this.linkDate = new System.Windows.Forms.LinkLabel();
            this.linkUsers = new System.Windows.Forms.LinkLabel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.logToolStripMenuItem});
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.goToToolStripMenuItem.Text = "Go To..";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logToolStripMenuItem.Text = "Log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // linkAdding
            // 
            this.linkAdding.AutoSize = true;
            this.linkAdding.Location = new System.Drawing.Point(187, 207);
            this.linkAdding.Name = "linkAdding";
            this.linkAdding.Size = new System.Drawing.Size(84, 18);
            this.linkAdding.TabIndex = 1;
            this.linkAdding.TabStop = true;
            this.linkAdding.Text = "Adding Fuel";
            this.linkAdding.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAdding_LinkClicked);
            // 
            // linkDispensing
            // 
            this.linkDispensing.AutoSize = true;
            this.linkDispensing.Location = new System.Drawing.Point(187, 250);
            this.linkDispensing.Name = "linkDispensing";
            this.linkDispensing.Size = new System.Drawing.Size(113, 18);
            this.linkDispensing.TabIndex = 2;
            this.linkDispensing.TabStop = true;
            this.linkDispensing.Text = "Dispensing Fuel";
            this.linkDispensing.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDispensing_LinkClicked);
            // 
            // linkDate
            // 
            this.linkDate.AutoSize = true;
            this.linkDate.Location = new System.Drawing.Point(187, 294);
            this.linkDate.Name = "linkDate";
            this.linkDate.Size = new System.Drawing.Size(117, 18);
            this.linkDate.TabIndex = 3;
            this.linkDate.TabStop = true;
            this.linkDate.Text = "Setting The Date";
            this.linkDate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDate_LinkClicked);
            // 
            // linkUsers
            // 
            this.linkUsers.AutoSize = true;
            this.linkUsers.Location = new System.Drawing.Point(187, 333);
            this.linkUsers.Name = "linkUsers";
            this.linkUsers.Size = new System.Drawing.Size(220, 18);
            this.linkUsers.TabIndex = 4;
            this.linkUsers.TabStop = true;
            this.linkUsers.Text = "Adding,Viewing, or Editing Users";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Fuel_Logger.Properties.Resources.Hudspeth_10_25_10;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(918, 164);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 390);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkUsers);
            this.Controls.Add(this.linkDate);
            this.Controls.Add(this.linkDispensing);
            this.Controls.Add(this.linkAdding);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHelp";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.frmHelp_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkAdding;
        private System.Windows.Forms.LinkLabel linkDispensing;
        private System.Windows.Forms.LinkLabel linkDate;
        private System.Windows.Forms.LinkLabel linkUsers;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}