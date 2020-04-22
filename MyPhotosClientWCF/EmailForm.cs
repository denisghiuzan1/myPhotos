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
    public partial class EmailForm : Form
    {
        private readonly string fileToSend;

        public EmailForm()
        {
            InitializeComponent();
            sendButton.Enabled = false;
            passwordTextBox.UseSystemPasswordChar = true;
        }

        public EmailForm(string file)
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
            try
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
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Could not send email. Please enter valid data!");
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void subjectTextBox_TextChanged(object sender, EventArgs e)
        {
            if (subjectTextBox.Text!=""
            && toTextBox.Text!=""
            &&bodyTextBox.Text!=""
            &&fromgmailTextBox.Text!=""
            &&passwordTextBox.Text!=""
            && validationLabel.Visible == false)
            {
                sendButton.Enabled = true;
            }
            else
            {
                sendButton.Enabled = false;
            }
        }

        private void toTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidEmail(toTextBox.Text))
            {
                validationLabel.Visible = true;
                sendButton.Enabled = false;
            }
            else
            {
                validationLabel.Visible = false;
                if (subjectTextBox.Text != ""
                    && toTextBox.Text != ""
                    && bodyTextBox.Text != ""
                    && fromgmailTextBox.Text != ""
                    && passwordTextBox.Text != "")
                {
                    sendButton.Enabled = true;
                }
            }
        }
    }
}
