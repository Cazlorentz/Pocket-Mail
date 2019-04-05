namespace Pocket_mail
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.MailBox = new System.Windows.Forms.TextBox();
            this.GmailLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MailBox
            // 
            this.MailBox.AutoCompleteCustomSource.AddRange(new string[] {
            "caslodk@gmail.com",
            "bubbihaters@gmail.com"});
            this.MailBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.MailBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.MailBox.Font = new System.Drawing.Font("TYPOGRAPH PRO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailBox.Location = new System.Drawing.Point(55, 236);
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(424, 32);
            this.MailBox.TabIndex = 5;
            this.MailBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MailBox_KeyPress);
            this.MailBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MailBox_PreviewKeyDown);
            // 
            // GmailLabel
            // 
            this.GmailLabel.Font = new System.Drawing.Font("TYPOGRAPH PRO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GmailLabel.ForeColor = System.Drawing.Color.White;
            this.GmailLabel.Location = new System.Drawing.Point(51, 206);
            this.GmailLabel.Name = "GmailLabel";
            this.GmailLabel.Size = new System.Drawing.Size(76, 23);
            this.GmailLabel.TabIndex = 4;
            this.GmailLabel.Text = "Gmail";
            this.GmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginLabel
            // 
            this.LoginLabel.Font = new System.Drawing.Font("TYPOGRAPH PRO", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(82, 67);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(364, 117);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "Gmail Login";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginLabel_MouseDown);
            // 
            // PassBox
            // 
            this.PassBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassBox.Location = new System.Drawing.Point(54, 311);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(424, 32);
            this.PassBox.TabIndex = 7;
            this.PassBox.Enter += new System.EventHandler(this.PassBox_Enter);
            this.PassBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassBox_KeyPress);
            // 
            // PassLabel
            // 
            this.PassLabel.Font = new System.Drawing.Font("TYPOGRAPH PRO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.ForeColor = System.Drawing.Color.White;
            this.PassLabel.Location = new System.Drawing.Point(49, 281);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(119, 23);
            this.PassLabel.TabIndex = 6;
            this.PassLabel.Text = "Password";
            this.PassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PassLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.White;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("TYPOGRAPH PRO", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LoginButton.Location = new System.Drawing.Point(202, 406);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(124, 54);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(489, -1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 52);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "✖";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(529, 594);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.MailBox);
            this.Controls.Add(this.GmailLabel);
            this.Controls.Add(this.LoginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pocket Mail Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginPage_FormClosing);
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MailBox;
        private System.Windows.Forms.Label GmailLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button CloseButton;
    }
}