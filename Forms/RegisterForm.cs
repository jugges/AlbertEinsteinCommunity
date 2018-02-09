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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            if (txtboxUsername.Text != "" && txtboxPassword.Text != "" && txtboxEmail.Text != "")
            {
                if (IsValidEmail(txtboxEmail.Text))
                {
                    if (controller.UsernameCheck(txtboxUsername.Text))
                    {
                        if (controller.EmailCheck(txtboxEmail.Text))
                        {
                            if (System.DateTime.Today.Subtract(datetimepickerBirthDate.Value).Days > 3650)
                            {
                                User user = new User();
                                user.Username = txtboxUsername.Text;
                                user.Password = txtboxPassword.Text.ToSHA(Crypto.SHA_Type.SHA256).ToLower();
                                user.Email = txtboxEmail.Text;
                                user.BirthDate = datetimepickerBirthDate.Value;
                                user.FirstName = txtboxFirstName.Text;
                                user.Biography = txtboxBiography.Text;
                                user.Job = txtboxJob.Text;
                                user.Sex = comboboxSex.Text;
                                user.LivingArea = comboboxLivingArea.Text;
                                controller.RegisterUser(user);
                                this.Close();
                            }
                            else
                                MessageBox.Show(null,
                                    "There was an error, sorry but you have to be above the age of 10 years to register.",
                                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show(null,
                                "There was an error, the email you entered is in use.",
                                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show(null,
                            "There was an error, the username you entered is in use.",
                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(null,
                        "There was an error, you have to enter a valid email address to register.",
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(null, "There was an error, please don't leave one the required fields blank.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
