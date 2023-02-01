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
    public partial class PayementMethodPage : Form
    {
        string cardNumberPattern = @"\b[0-9]{16}\b";
        string namePattern = @"\b[a-zA-Z\-]{1,40}\b";
        string expirationDatePattern = @"\b[0-9]{2}[/][0-9]{2}\b";

        ConnectionString connect = new ConnectionString();

        public PayementMethodPage()
        {
            InitializeComponent();
        }

        private void addCardBtn_Click(object sender, EventArgs e)
        {
            bool validCardNumber = true;
            bool validName = true;
            bool validExpirationDate = true;

            SqlConnection con;
            con = connect.con;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM [PaymentInfo]";
            cmd.Connection = con;
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                if (rd[0].ToString() == cardNumberTB.Text)
                {
                    validCardNumber = false;
                }
            }
            con.Close();

            Regex cardNumberRG = new Regex(cardNumberPattern);
            Regex nameRG = new Regex(namePattern);
            Regex expirationDateRG = new Regex(expirationDatePattern);

            if (!cardNumberRG.IsMatch(cardNumberTB.Text))
            {
                validCardNumber = false;
            }

            if (!nameRG.IsMatch(nameOnCardTB.Text))
            {
                validName = false;
            }

            if (!expirationDateRG.IsMatch(expirationDateTB.Text))
            {
                validExpirationDate = false;
            }

            if (validCardNumber == false)
            {
                MessageBox.Show("Card Number is invalid!");
                cardNumberTB.Focus();
            }
            else if (validName == false)
            {
                MessageBox.Show("Name on card in invalid!");
                nameOnCardTB.Focus();
            }
            else if (validExpirationDate == false)
            {
                MessageBox.Show("Expiration Date is invalid!");
                expirationDateTB.Focus();
            }

            if (validCardNumber == true && validName == true && validExpirationDate == true)
            {
                string nameOnCard = nameOnCardTB.Text.Substring(0, 1).ToUpper() + nameOnCardTB.Text.Substring(1).ToLower();
                con.Open();
                SqlCommand cmd1 = new SqlCommand("INSERT INTO [dbo].[PaymentInfo] VALUES('" +
                    cardNumberTB.Text + "','" + nameOnCard + "','" +
                    expirationDateTB.Text + "','" + AuthenticationPage.username + "')", con);
                cmd1.ExecuteNonQuery();
                con.Close();

                con.Open();
                SqlCommand cmd2 = new SqlCommand("UPDATE [dbo].[UserInfo] SET cardNumber = '" + 
                    cardNumberTB.Text + "' WHERE username = '" + AuthenticationPage.username + 
                    "'", con);
                cmd2.ExecuteNonQuery();
                con.Close();
                this.Hide();
                MessageBox.Show("Card Added Successfully!");
            }

        }
    }
}
