using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stellar_Parking
{
    public partial class PayPage : Form
    {
        string parkingNumberPattern = @"\b[A-Z][0-9]{3}\b";
        ConnectionString connect = new ConnectionString();

        public PayPage()
        {
            InitializeComponent();
        }

        private void PayPage_Load(object sender, EventArgs e)
        {
            timer.Start();

            SqlConnection con;
            con = connect.con;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM UserInfo WHERE username = '" + AuthenticationPage.username + "'");
            cmd.Connection = con;
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                paymentComboBox.Items.Add(rd[2].ToString());
            }
            con.Close();
        }

        private void PayPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void homePB_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomePage().Show();
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

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            bool validParkingNumber = true;
            bool validTime = true;
            bool validPaymentMethod = true;
            double minutes = (double)parkingTimeNumericUpDown.Value;

            Regex parkingNumberRG = new Regex(parkingNumberPattern);

            if (!parkingNumberRG.IsMatch(parkingNumberTB.Text.ToUpper()))
            {
                validParkingNumber = false;
            }

            if (paymentComboBox.SelectedItem == null)
            {
                validPaymentMethod = false;
            }

            if (parkingTimeNumericUpDown.Value == 0)
            {
                validTime = false;
            }

            if (validParkingNumber == false)
            {
                MessageBox.Show("Invalid parking number!");
                parkingNumberTB.Focus();
            }
            else if (validTime == false)
            {
                MessageBox.Show("Increase the parking time!");
            }
            else if (validPaymentMethod == false)
            {
                MessageBox.Show("Select a payment method!");
            }
            
            if (validParkingNumber == true && validTime == true && validPaymentMethod == true) {
                SqlConnection con;
                con = connect.con;
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[ParkingInfo] VALUES('" + 
                    AuthenticationPage.username + "','" + paymentComboBox.SelectedItem.ToString() + "','" + 
                    parkingNumberTB.Text.ToUpper() + "','" + DateTime.Now.ToShortDateString() + "','" + 
                    DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.AddMinutes(minutes) + "')");
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Payment Successful!");
                parkingNumberTB.Clear();
                parkingTimeNumericUpDown.Value = 0;
                totalTB.Clear();
                parkingNumberTB.Focus();
            }
        }

        private void parkingTimeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            totalTB.Text = $"${(double)parkingTimeNumericUpDown.Value * 0.08}";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Start();
            dateLabel.Text = DateTime.Now.ToLongTimeString();
            timeLabel.Text = DateTime.Now.ToLongDateString();
        }
    }
}
