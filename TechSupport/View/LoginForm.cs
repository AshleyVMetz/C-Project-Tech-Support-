using System;
using System.Drawing;
using System.Windows.Forms;

namespace TechSupport.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "Jane" && passwordTextBox.Text == "test1234")
            {
                this.Visible = false;
                MainForm mainForm = new MainForm(userNameTextBox.Text, this);
                mainForm.Show();
               
            }
            else 
            {
                messageLabel.Text = "invalid username/password";
                messageLabel.ForeColor = Color.Red;
            }
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }
    }
}
