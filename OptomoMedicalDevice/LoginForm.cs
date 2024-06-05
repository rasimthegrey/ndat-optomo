using OptomoMedicalDevice;
using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CenterLoginControls();
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            // Re-center the controls when the form is resized
            CenterLoginControls();
        }

        private void CenterLoginControls()
        {
            // Calculate the center of the panel
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            // Position the controls centered

            pictureBox1.Left = centerX - pictureBox1.Width / 2;
            pictureBox1.Top = centerY - 170;

            username.Left = centerX - username.Width / 2;
            username.Top = centerY - 70;

            txtUsername.Left = centerX - txtUsername.Width / 2;
            txtUsername.Top = centerY - 30;

            password.Left = centerX - password.Width / 2;
            password.Top = centerY ;

            txtPassword.Left = centerX - txtPassword.Width / 2;
            txtPassword.Top = centerY + 40;

            btnLogin.Left = centerX - btnLogin.Width / 2;
            btnLogin.Top = centerY + 110;
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "1";

            string inputUsername = txtUsername.Text;
            string inputPassword = txtPassword.Text;

            if (inputUsername == username && inputPassword == password)
            {
                // Open MainForm and close LoginForm
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Gecersiz kullanici adi veya parola.", "Giris Basarisiz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
