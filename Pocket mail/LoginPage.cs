using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pocket_mail;

namespace Pocket_mail
{
    public partial class LoginPage : Form
    {
        public static bool login = true;
        public static string bubbi_password = "cazoersej123";
        public static string user_mail;
        public static string user_password;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            PassBox.PasswordChar = (char)183;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (PassBox.Text == "" || MailBox.Text == "" || !MailBox.Text.Contains("@"))
            {
                return;
            }
            else
            {
                user_mail = MailBox.Text;
                user_password = PassBox.Text;
                this.Hide();
                Form1 main = new Form1();
                login = false;
                main.Show();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
        
        // The following makes the form move when moving gmaillogin label
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void LoginLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MailBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (MailBox.Text == "c" && e.KeyData == Keys.Tab)
            { 
                MailBox.Text = "caslodk@gmail.com";
            }else if (MailBox.Text == "b" && e.KeyData == Keys.Tab)
            {
                MailBox.Text = "bubbihaters@gmail.com";
            }
            else if (e.KeyData == Keys.Enter)
            {
                LoginButton.PerformClick();
            }
        }

        private void PassBox_Enter(object sender, EventArgs e)
        {
            if (MailBox.Text == "bubbihaters@gmail.com")
            {
                PassBox.Text = bubbi_password;
            }
        }

        private void PassBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                LoginButton.PerformClick();
            }
        }

        private void MailBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                LoginButton.PerformClick();
            }
        }
    }
}
