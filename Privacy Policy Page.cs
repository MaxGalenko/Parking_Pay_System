using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stellar_Parking
{
    public partial class PrivacyPolicyPage : Form
    {
        public PrivacyPolicyPage()
        {
            InitializeComponent();
        }

        private void PrivacyPolicyPage_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "PrivacyPolicy.txt");

            if (File.Exists(path))
            {
                privacyPolicyTB.Text = File.ReadAllText(path);
            }
        }

        private void PrivacyPolicyPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUpPage().Show();
        }
    }
}
