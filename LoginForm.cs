using System;
using System.Windows.Forms;
using Rework;

namespace AlbertEinsteinCommunity
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLoginAccept_Click(object sender, EventArgs e)
        {
            User user = new User();
            Controller controller = new Controller();
            user.Username = txtboxUsername.Text;
            user.Password = Rework.Crypto.ToSHA(txtboxPassword.Text,Crypto.SHA_Type.SHA256).ToLower();
            string passwordCheck = controller.PasswordCheck(user.Username);
            if (user.Password == passwordCheck)
            {
                if (ckbRememberMe.Checked)
                {
                    Properties.Settings.Default.Username = user.Username;
                    Properties.Settings.Default.Password = user.Password;
                    Properties.Settings.Default.RememberMe = true;
                    Properties.Settings.Default.Save();
                }
                Login(user);
            }
            else
                MessageBox.Show(null,"There was an error, wrong username or password","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void btnLoginRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void txtboxPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtboxPassword.UseSystemPasswordChar = false;
        }

        private void txtboxPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtboxPassword.UseSystemPasswordChar = true;
        }

        private void ckbRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckbRememberMe.Checked)
            {
                Properties.Settings.Default.RememberMe = false;
                Properties.Settings.Default.Save();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RememberMe == true)
            {
                User user = new User();
                Controller controller = new Controller();
                user.Username = Properties.Settings.Default.Username;
                user.Password = Properties.Settings.Default.Password;
                string passwordCheck = controller.PasswordCheck(user.Username);
                if (user.Password == passwordCheck)
                {
                    Login(user);
                }
            }
        }

        private void Login(User user)
        {
            Controller controller = new Controller();
            this.Hide();
            WelcomeForm welcomeForm = new WelcomeForm(controller.IdentifyUser(user.Username));
            welcomeForm.ShowDialog();
            this.Close();
        }
    }
}
