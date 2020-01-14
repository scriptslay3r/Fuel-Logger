namespace Fuel_Logger
{
    partial class frmWhoAreYou
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnProveIt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Okay, You Must Be Important If You Are Still Clicking";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(68, 166);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(117, 52);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "I\'m Really Not, Sorry, Take Me Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnProveIt
            // 
            this.btnProveIt.Location = new System.Drawing.Point(390, 166);
            this.btnProveIt.Name = "btnProveIt";
            this.btnProveIt.Size = new System.Drawing.Size(117, 52);
            this.btnProveIt.TabIndex = 2;
            this.btnProveIt.Text = "I AM! Here, I\'ll Prove It!";
            this.btnProveIt.UseVisualStyleBackColor = true;
            this.btnProveIt.Click += new System.EventHandler(this.btnProveIt_Click);
            // 
            // frmWhoAreYou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 357);
            this.Controls.Add(this.btnProveIt);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label1);
            this.Name = "frmWhoAreYou";
            this.Text = "Who Are You?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnProveIt;
    }
}