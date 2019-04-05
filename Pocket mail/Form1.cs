using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;
using System.Net;
using System.Threading;
using Pocket_mail;

namespace Pocket_mail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                SendMail(ToTxtbox.Text,
                    LoginPage.user_mail,
                    MessageTxtbox.Text,
                    SubjectTxtbox.Text,
                    LoginPage.user_password);

                MessageBox.Show("Your mail has been sent.");
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error.");
            }
        }

        private void SendMail(string _to, string _from, string _message, string _subject, string _password)
        {
            var message = new MailMessage(_from, _to);
            message.Subject = _subject;
            message.Body = _message;

            SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587);
            mailer.Credentials = new NetworkCredential(_from, _password);
            mailer.EnableSsl = true;
            mailer.Send(message);

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (LoginPage.login)
            {
                Hide();
                LoginPage loginmenu = new LoginPage();
                loginmenu.Show();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage log = new LoginPage();
            log.BringToFront();
            log.Show();
        }
    }
}