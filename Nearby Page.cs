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
    public partial class NearbyPage : Form
    {
        public NearbyPage()
        {
            InitializeComponent();
            webBrowser.ScriptErrorsSuppressed = true;
        }

        private void NearbyPage_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void NearbyPage_FormClosing(object sender, FormClosingEventArgs e)
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string street = streetTB.Text;
            string city = cityTB.Text;
            string state = stateTB.Text;
            string zip = zipTB.Text;

            StringBuilder queryAddress = new StringBuilder();
            queryAddress.Append("http://google.com/maps?q=");

            if (street != string.Empty)
            {
                queryAddress.Append(street + "," + "+");
            }
            if (city != string.Empty)
            {
                queryAddress.Append(city + "," + "+");
            }
            if (state != string.Empty)
            {
                queryAddress.Append(state + "," + "+");
            }
            if (zip != string.Empty)
            {
                queryAddress.Append(zip + "," + "+");
            }

            webBrowser.Navigate(queryAddress.ToString());
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongTimeString();
            timeLabel.Text = DateTime.Now.ToLongDateString();
        }
    }
}
