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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            timer.Start();
            welcomeLabel.Text = $"{welcomeLabel.Text} {AuthenticationPage.username}!";
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void setttingsPB_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SettingsPage().Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            dateLabel.Text = DateTime.Now.ToLongDateString();
        }
    }
}
