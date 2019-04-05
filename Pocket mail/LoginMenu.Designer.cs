namespace Pocket_mail
{
    partial class LoginMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginLabel = new System.Windows.Forms.Label();
            this.GmailLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.Font = new System.Drawing.Font("TYPOGRAPH PRO", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(91, 45);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(364, 117);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Gmail Login";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GmailLabel
            // 
            this.GmailLabel.Font = new System.Drawing.Font("TYPOGRAPH PRO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GmailLabel.ForeColor = System.Drawing.Color.White;
            this.GmailLabel.Location = new System.Drawing.Point(56, 198);
            this.GmailLabel.Name = "GmailLabel";
            this.GmailLabel.Size = new System.Drawing.Size(71, 23);
            this.GmailLabel.TabIndex = 1;
            this.GmailLabel.Text = "Gmail";
            this.GmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("TYPOGRAPH PRO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(61, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(424, 32);
            this.textBox1.TabIndex = 2;
            // 
            // LoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GmailLabel);
            this.Controls.Add(this.LoginLabel);
            this.Name = "LoginMenu";
            this.Size = new System.Drawing.Size(547, 641);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label GmailLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}
