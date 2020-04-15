using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace MyPhotosClientWCF
{
    public partial class EmailForm1 : Form
    {
        private readonly string fileToSend;

        public EmailForm1()
        {
            InitializeComponent();
            sendButton.Enabled = false;
            passwordTextBox.UseSystemPasswordChar = true;
        }

        public EmailForm1(string file)
        {
            InitializeComponent();
            sendButton.Enabled = false;
            passwordTextBox.UseSystemPasswordChar = true;
            fileToSend = file;
        }

        private void EmailForm_Load(object sender, EventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress("myphotos@gmail.com");
            message.To.Add(toTextBox.Text);
            message.Subject = subjectTextBox.Text;
            message.Body = bodyTextBox.Text;
            message.Attachments.Add(new Attachment(fileToSend));

            using (SmtpClient client = new SmtpClient())
            {
                client.UseDefaultCredentials = false;
                client.Host = "smtp.gmail.com";
                client.Credentials = new NetworkCredential
                {
                    UserName = fromgmailTextBox.Text,
                    Password = passwordTextBox.Text,
                }; 
                client.EnableSsl = true;
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(message);

                MessageBox.Show(@"The email was successfully sent!");
            }

            this.Close();
        }

        private void subjectTextBox_TextChanged(object sender, EventArgs e)
        {
            if (subjectTextBox.Text!=""
            && toTextBox.Text!=""
            &&bodyTextBox.Text!=""
            &&fromgmailTextBox.Text!=""
            &&passwordTextBox.Text!="")
            {
                sendButton.Enabled = true;
            }
        }
    }
}
