using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stellar_Parking
{
    public partial class SettingsPage : Form
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void SettingsPage_Load(object sender, EventArgs e)
        {
            timer.Start();
            profileNameLabel.Text = AuthenticationPage.username;
        }

        private void SettingsPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void homePB_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomePage().Show();
        }

        private void payPB_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PayPage().Show();
        }

        private void nearbyPB_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NearbyPage().Show();
        }

        private void historyPB_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HistoryPage().Show();
        }

        private void profileInfoBtn_Click(object sender, EventArgs e)
        {
            new ProfileInformationPage().Show();
        }

        private void payementMethodsBtn_Click(object sender, EventArgs e)
        {
            new PayementMethodPage().Show();
        }

        private void languagesBtn_Click(object sender, EventArgs e)
        {
            new LanguagesSelectionPage().Show();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AuthenticationPage().Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            dateLabel.Text = DateTime.Now.ToLongDateString();
        }
    }
}
