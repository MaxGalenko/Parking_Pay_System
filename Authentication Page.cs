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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Stellar_Parking
{
    public partial class AuthenticationPage : Form
    {
        public int imageNumber { get; set; } = 0;

        public static string username = "";

        ConnectionString connect = new ConnectionString();

        public AuthenticationPage()
        {
            InitializeComponent();
        }

        private void signUpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new SignUpPage().Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            con = connect.con;
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select count(*) from [UserInfo] where username='" + usernameTB.Text + "' and password='" + passwordTB.Text + "'", con);

            // in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user.
            DataTable dataTable = new DataTable(); //this is creating a virtual table 
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows[0][0].ToString() == "1")
            {
                username = usernameTB.Text;
                this.Hide();
                new HomePage().Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.");
                usernameTB.Clear();
                passwordTB.Clear();
                usernameTB.Focus();
            }
        }

        private void AuthenticationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void revealBtn_Click(object sender, EventArgs e)
        {
            imageNumber = (imageNumber + 1) % 2;

            revealBtn.BackgroundImage =
                (Image)Properties.Resources.ResourceManager.GetObject("showHidePassImg" + imageNumber);

            if (imageNumber == 0)
            {
                passwordTB.PasswordChar = '●';
            } else if (imageNumber == 1)
            {
                passwordTB.PasswordChar = '\0';
            }
        }
    }
}
