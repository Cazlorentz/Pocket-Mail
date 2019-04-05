namespace Pocket_mail
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SendButton = new System.Windows.Forms.Button();
            this.ToLabel = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.ToTxtbox = new System.Windows.Forms.TextBox();
            this.SubjectTxtbox = new System.Windows.Forms.TextBox();
            this.MessageTxtbox = new System.Windows.Forms.TextBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.AutoSize = true;
            this.SendButton.BackColor = System.Drawing.Color.Transparent;
            this.SendButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SendButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Font = new System.Drawing.Font("Gill Sans MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.SendButton.Image = ((System.Drawing.Image)(resources.GetObject("SendButton.Image")));
            this.SendButton.Location = new System.Drawing.Point(835, 456);
            this.SendButton.Margin = new System.Windows.Forms.Padding(0);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(136, 136);
            this.SendButton.TabIndex = 0;
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ToLabel
            // 
            this.ToLabel.Font = new System.Drawing.Font("Gravity Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.Location = new System.Drawing.Point(9, 26);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(64, 36);
            this.ToLabel.TabIndex = 1;
            this.ToLabel.Text = "To:";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.Font = new System.Drawing.Font("Gravity Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectLabel.Location = new System.Drawing.Point(12, 69);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(151, 36);
            this.SubjectLabel.TabIndex = 2;
            this.SubjectLabel.Text = "Subject:";
            // 
            // ToTxtbox
            // 
            this.ToTxtbox.Font = new System.Drawing.Font("TYPOGRAPH PRO", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToTxtbox.Location = new System.Drawing.Point(59, 29);
            this.ToTxtbox.Name = "ToTxtbox";
            this.ToTxtbox.Size = new System.Drawing.Size(701, 36);
            this.ToTxtbox.TabIndex = 3;
            // 
            // SubjectTxtbox
            // 
            this.SubjectTxtbox.Font = new System.Drawing.Font("TYPOGRAPH PRO", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectTxtbox.Location = new System.Drawing.Point(117, 70);
            this.SubjectTxtbox.Name = "SubjectTxtbox";
            this.SubjectTxtbox.Size = new System.Drawing.Size(643, 36);
            this.SubjectTxtbox.TabIndex = 4;
            // 
            // MessageTxtbox
            // 
            this.MessageTxtbox.Font = new System.Drawing.Font("TYPOGRAPH PRO", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageTxtbox.Location = new System.Drawing.Point(15, 157);
            this.MessageTxtbox.Multiline = true;
            this.MessageTxtbox.Name = "MessageTxtbox";
            this.MessageTxtbox.Size = new System.Drawing.Size(752, 454);
            this.MessageTxtbox.TabIndex = 5;
            // 
            // MessageLabel
            // 
            this.MessageLabel.Font = new System.Drawing.Font("Gravity Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.Location = new System.Drawing.Point(12, 118);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(151, 36);
            this.MessageLabel.TabIndex = 6;
            this.MessageLabel.Text = "Message:";
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(1047, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 52);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "✖";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(854, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 82);
            this.button1.TabIndex = 11;
            this.button1.Text = "CHANGE\r\nLOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1086, 636);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.MessageTxtbox);
            this.Controls.Add(this.SubjectTxtbox);
            this.Controls.Add(this.ToTxtbox);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.SendButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pocket Mail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.TextBox ToTxtbox;
        private System.Windows.Forms.TextBox SubjectTxtbox;
        private System.Windows.Forms.TextBox MessageTxtbox;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button button1;
    }
}

