using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rework;

namespace AlbertEinsteinCommunity
{
    public partial class InfoForm : Form
    {
        User user;
        private bool isPermission;

        public InfoForm(User user, bool isPermission)
        {
            InitializeComponent();
            this.user = user;
            this.isPermission = isPermission;
        }

        public void RefreshInfo()
        {
            lblUsername.Text = user.Username;
            lblEmail.Text = user.Email;
            lblKarma.Text = user.Karma.ToString();
            lblRegisteringDate.Text = user.RegisteringDate.ToShortDateString();
            try
            {
                lblBirthDate.Text = user.BirthDate.ToShortDateString();
            }
            catch
            {
                lblBirthDate.Text = "Not mentioned";
            }
            lblFirstName.Text = user.FirstName;
            lblBiography.Text = user.Biography;
            lblJob.Text = user.Job;
            lblSex.Text = user.Sex;
            lblLivingArea.Text = user.LivingArea;
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            if (isPermission)
                btnEdit.Show();
            else
            {
                Height -= 101;
            }
            RefreshInfo();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            //string passwordEnter;
            //if (Properties.Settings.Default.RememberMe == true)
            //{
            //    passwordEnter = Properties.Settings.Default.Password;
            //}
            //else
            //{
            //    passwordEnter = Microsoft.VisualBasic.Interaction.InputBox("Enter password to verify yourself to edit you'r profile", "Authentication Required", "").ToSHA(Crypto.SHA_Type.SHA256).ToLower();
            //}
            //string passwordCheck = controller.PasswordCheck(user.Username);
            //if (passwordEnter == passwordCheck)
            //{
                new EditUserForm(user, this).ShowDialog();
            //}
            //else
            //    MessageBox.Show(null, "There was an error, wrong password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
