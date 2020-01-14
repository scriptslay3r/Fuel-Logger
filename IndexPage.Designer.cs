namespace Fuel_Logger
{
    partial class frmIndexPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndexPage));
            this.btnFuelUsed = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dontClickMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtGasLeft = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDieselLeft = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFuelUsed
            // 
            this.btnFuelUsed.Location = new System.Drawing.Point(121, 534);
            this.btnFuelUsed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFuelUsed.Name = "btnFuelUsed";
            this.btnFuelUsed.Size = new System.Drawing.Size(211, 71);
            this.btnFuelUsed.TabIndex = 0;
            this.btnFuelUsed.Text = "Dispense Fuel";
            this.btnFuelUsed.UseVisualStyleBackColor = true;
            this.btnFuelUsed.Click += new System.EventHandler(this.btnFuelUsed_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(806, 534);
            this.btnLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(211, 71);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "View Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(467, 534);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(211, 71);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Fuel";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(467, 649);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(211, 71);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToToolStripMenuItem,
            this.dontToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1148, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dontClickMeToolStripMenuItem,
            this.viewUsersToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(55, 19);
            this.goToToolStripMenuItem.Text = "Go To..";
            // 
            // dontClickMeToolStripMenuItem
            // 
            this.dontClickMeToolStripMenuItem.Name = "dontClickMeToolStripMenuItem";
            this.dontClickMeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dontClickMeToolStripMenuItem.Text = "Don\'t Click Me";
            this.dontClickMeToolStripMenuItem.Click += new System.EventHandler(this.dontClickMeToolStripMenuItem_Click);
            // 
            // viewUsersToolStripMenuItem
            // 
            this.viewUsersToolStripMenuItem.Name = "viewUsersToolStripMenuItem";
            this.viewUsersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewUsersToolStripMenuItem.Text = "View Users";
            this.viewUsersToolStripMenuItem.Click += new System.EventHandler(this.viewUsersToolStripMenuItem_Click);
            // 
            // dontToolStripMenuItem
            // 
            this.dontToolStripMenuItem.Name = "dontToolStripMenuItem";
            this.dontToolStripMenuItem.Size = new System.Drawing.Size(12, 19);
            // 
            // txtGasLeft
            // 
            this.txtGasLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGasLeft.Location = new System.Drawing.Point(467, 265);
            this.txtGasLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGasLeft.Name = "txtGasLeft";
            this.txtGasLeft.ReadOnly = true;
            this.txtGasLeft.Size = new System.Drawing.Size(211, 24);
            this.txtGasLeft.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 265);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total Gasoline Left:";
            // 
            // txtDieselLeft
            // 
            this.txtDieselLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDieselLeft.Location = new System.Drawing.Point(467, 379);
            this.txtDieselLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDieselLeft.Name = "txtDieselLeft";
            this.txtDieselLeft.ReadOnly = true;
            this.txtDieselLeft.Size = new System.Drawing.Size(211, 24);
            this.txtDieselLeft.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 379);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total Diesel Left:";
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
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Fuel_Logger.Properties.Resources.Hudspeth_10_25_10;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1148, 215);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmIndexPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 757);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDieselLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGasLeft);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnFuelUsed);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmIndexPage";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmIndexPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFuelUsed;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dontClickMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dontToolStripMenuItem;
        private System.Windows.Forms.TextBox txtGasLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDieselLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem viewUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}