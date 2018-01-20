using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbertEinsteinCommunity
{
    public partial class InfoForm : Form
    {
        User user;
        public InfoForm(User user)
        {
            InitializeComponent();
            this.user = user;
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
            RefreshInfo();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditUserForm editUserForm = new EditUserForm(user,this);
            editUserForm.Show();
        }
    }
}
