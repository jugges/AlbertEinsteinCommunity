using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbertEinsteinCommunity
{
    public partial class AddTile : UserControl
    {
        WelcomeForm welcomeForm;
        public AddTile(WelcomeForm welcomeForm)
        {
            InitializeComponent();
            this.welcomeForm = welcomeForm;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            welcomeForm.Wysiwyg();
        }
    }
}
