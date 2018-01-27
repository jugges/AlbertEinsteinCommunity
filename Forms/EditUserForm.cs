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
    public partial class EditUserForm : Form
    {
        User user;
        InfoForm infoFormParent;
        public EditUserForm(User user, InfoForm infoFormParent)
        {
            InitializeComponent();
            this.user = user;
            this.infoFormParent = infoFormParent;
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            txtboxEmail.Text = user.Email;
            try
            {
                datetimepickerBirthDate.Value = user.BirthDate;
            }
            catch
            {
                // ignored
            }

            txtboxFirstName.Text = user.FirstName;
            txtboxBiography.Text = user.Biography;
            txtboxJob.Text = user.Job;
            comboboxSex.Text = user.Sex;
            comboboxLivingArea.Text = user.LivingArea;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            user.Email = txtboxEmail.Text;
            user.BirthDate = datetimepickerBirthDate.Value;
            user.FirstName = txtboxFirstName.Text;
            user.Biography = txtboxBiography.Text;
            user.Job = txtboxJob.Text;
            user.Sex = comboboxSex.Text;
            user.LivingArea = comboboxLivingArea.Text;

            Controller controller = new Controller();
            controller.EditUser(user);

            infoFormParent.RefreshInfo();
            this.Close();
        }
    }
}
