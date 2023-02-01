using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Stellar_Parking
{
    public partial class SignUpPage : Form
    {   
        string namePattern = @"\b[a-zA-Z\-]{1,20}\b";
        string licesnsePlatePattern = @"\b[a-zA-Z0-9]{6,7}\b";
        string emailPattern = @"\b[a-zA-Z0-9][\w\.\-]{0,35}[@][a-zA-Z][a-zA-Z]{0,22}[a-zA-Z]\.(com|ca|qc\.ca)\b";
        string usernamePattern = @"\b[\w\.]{1,18}\b";
        string passwordPattern = @"\b[.]{6,50}\b";

        ConnectionString connect = new ConnectionString();

        public int imageNumber { get; set; } = 0;

        public SignUpPage()
        {
            InitializeComponent();
        }

        private void SignUpPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            bool validFirstName = true;
            bool validLastName = true;
            bool validUsername = true;
            bool validLicensePlate = true;
            bool validEmail = true;
            bool validPassword = true;

            SqlConnection con;
            con = connect.con;
            con.Open();
            SqlCommand selectAll = new SqlCommand("SELECT * FROM [dbo].[UserInfo]");
            selectAll.Connection = con;
            SqlDataReader rd = selectAll.ExecuteReader();

            while (rd.Read())
            {
                if (rd[0].ToString() == usernameTB.Text)
                {
                    validUsername = false;
                }
                if (rd[3].ToString() == emailTB.Text)
                {
                    validEmail = false;
                }
                if (rd[4].ToString() == licensePlateTB.Text)
                {
                    validLicensePlate = false;
                }
            }
            con.Close();

            Regex firstNameRG = new Regex(namePattern);
            Regex lastNameRG = new Regex(namePattern);
            Regex licensePlateRG = new Regex(licesnsePlatePattern);
            Regex emailRG = new Regex(emailPattern);
            Regex usernameRG = new Regex(usernamePattern);
            Regex passwordRG = new Regex(passwordPattern);

            if (!firstNameRG.IsMatch(firstNameTB.Text))
            {
                validFirstName = false;
            }

            if (!lastNameRG.IsMatch(lastNameTB.Text))
            {
                validLastName = false;
            }

            if (!licensePlateRG.IsMatch(licensePlateTB.Text))
            {
                validLicensePlate = false;
            }

            if (!emailRG.IsMatch(emailTB.Text))
            {
                validEmail = false;
            }

            if (!usernameRG.IsMatch(usernameTB.Text))
            {
                validUsername = false;
            }

            if (!passwordRG.IsMatch(passwordTB.Text))
            {
                validPassword = false;
            }

            if (validFirstName == false)
            {
                MessageBox.Show("First name is invalid!");
                firstNameTB.Focus();
            }
            else if (validLastName == false)
            {
                MessageBox.Show("Last name is invalid!");
                lastNameTB.Focus();
            }
            else if (validLicensePlate == false)
            {
                MessageBox.Show("License plate is invalid!");
                licensePlateTB.Focus();
            }
            else if (validEmail == false)
            {
                MessageBox.Show("Email is invalid or is already used by another user!");
                emailTB.Focus();
            }
            else if (validUsername == false)
            {
                MessageBox.Show("Username is invalid or already taken!");
                usernameTB.Focus();
            }
            else if (!passwordTB.Text.Equals(repeatPasswordTB.Text))
            {
                MessageBox.Show("Passwords do not match or password is too long!");
                passwordTB.Clear();
                repeatPasswordTB.Clear();
                passwordTB.Focus();
            } else if (validPassword == false)
            {
                MessageBox.Show("Password is invalid!");
                passwordTB.Clear();
                repeatPasswordTB.Clear();
                passwordTB.Focus();
            }

            if (validFirstName == true && validLastName == true && validLicensePlate == true && validEmail == true && validUsername == true && validPassword == true && passwordTB.Text.Equals(repeatPasswordTB.Text))
            {
                string fisrtName = firstNameTB.Text.Substring(0,1).ToUpper() + firstNameTB.Text.Substring(1).ToLower();
                string lastName = lastNameTB.Text.Substring(0, 1).ToUpper() + lastNameTB.Text.Substring(1).ToLower();
                con.Open();
                SqlCommand insert = new SqlCommand("INSERT INTO [dbo].[UserInfo] (username,password," +
                    "email,licensePlate,firstName,lastName) VALUES('" + 
                    usernameTB.Text + "','" + repeatPasswordTB.Text + "','" + 
                    emailTB.Text.ToLower() + "','" + licensePlateTB.Text.ToUpper() + "','" + 
                    fisrtName + "','" + lastName + "')", con);
                insert.ExecuteNonQuery();
                con.Close();
                this.Hide();
                new AuthenticationPage().Show();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AuthenticationPage().Show();
        }

        private void revealPassBtn_Click(object sender, EventArgs e)
        {
            imageNumber = (imageNumber + 1) % 2;

            revealPassBtn.BackgroundImage =
                (Image)Properties.Resources.ResourceManager.GetObject("showHidePassImg" + imageNumber);

            if (imageNumber == 0)
            {
                passwordTB.PasswordChar = '●';
            }
            else if (imageNumber == 1)
            {
                passwordTB.PasswordChar = '\0';
            }
        }

        private void revealRepeatPassBtn_Click(object sender, EventArgs e)
        {
            imageNumber = (imageNumber + 1) % 2;

            revealRepeatPassBtn.BackgroundImage =
                (Image)Properties.Resources.ResourceManager.GetObject("showHidePassImg" + imageNumber);

            if (imageNumber == 0)
            {
                repeatPasswordTB.PasswordChar = '●';
            }
            else if (imageNumber == 1)
            {
                repeatPasswordTB.PasswordChar = '\0';
            }
        }

        private void privacyPolicyLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new PrivacyPolicyPage().Show();
        }
    }
}
