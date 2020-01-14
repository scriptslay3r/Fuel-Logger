namespace Fuel_Logger
{
    partial class frmProof
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
            this.txtProof = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMercy = new System.Windows.Forms.Button();
            this.btnProof = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProof
            // 
            this.txtProof.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProof.Location = new System.Drawing.Point(236, 242);
            this.txtProof.Name = "txtProof";
            this.txtProof.PasswordChar = '♥';
            this.txtProof.Size = new System.Drawing.Size(296, 38);
            this.txtProof.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "PROVE IT!!!";
            // 
            // btnMercy
            // 
            this.btnMercy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMercy.Location = new System.Drawing.Point(236, 320);
            this.btnMercy.Name = "btnMercy";
            this.btnMercy.Size = new System.Drawing.Size(145, 42);
            this.btnMercy.TabIndex = 2;
            this.btnMercy.Text = "Have Mercy!!";
            this.btnMercy.UseVisualStyleBackColor = true;
            this.btnMercy.Click += new System.EventHandler(this.btnMercy_Click);
            // 
            // btnProof
            // 
            this.btnProof.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProof.Location = new System.Drawing.Point(387, 320);
            this.btnProof.Name = "btnProof";
            this.btnProof.Size = new System.Drawing.Size(145, 42);
            this.btnProof.TabIndex = 3;
            this.btnProof.Text = "Gladly!";
            this.btnProof.UseVisualStyleBackColor = true;
            this.btnProof.Click += new System.EventHandler(this.btnProof_Click);
            // 
            // frmProof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProof);
            this.Controls.Add(this.btnMercy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProof);
            this.Name = "frmProof";
            this.Text = "The Proof is in the Pudding, or in this case, the Password XD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProof;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMercy;
        private System.Windows.Forms.Button btnProof;
    }
}