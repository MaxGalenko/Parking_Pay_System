using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stellar_Parking
{
    public partial class HistoryPage : Form
    {
        ConnectionString connect = new ConnectionString();

        public HistoryPage()
        {
            InitializeComponent();
        }

        private void HistoryPage_Load(object sender, EventArgs e)
        {
            timer.Start();

            SqlConnection con;
            con = connect.con;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ParkingInfo where username = '" + AuthenticationPage.username + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                parkingHistoryTB.AppendText($"{dr[2]} | {dr[3]} | {dr[4]} | {dr[5]} | {dr[6]}\r\n");
            }
        }

        private void HistoryPage_FormClosing(object sender, FormClosingEventArgs e)
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

        private void setttingsPB_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SettingsPage().Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Start();
            dateLabel.Text = DateTime.Now.ToLongTimeString();
            timeLabel.Text = DateTime.Now.ToLongDateString();
        }
    }
}
