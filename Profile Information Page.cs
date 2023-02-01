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
    public partial class ProfileInformationPage : Form
    {
        ConnectionString connect = new ConnectionString();

        public ProfileInformationPage()
        {
            InitializeComponent();
        }

        private void ProfileInformationPage_Load(object sender, EventArgs e)
        {
            SqlConnection con;
            con = connect.con;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from UserInfo where username = '" + AuthenticationPage.username + "'";
            cmd.Connection = con;
            SqlDataReader rd = cmd.ExecuteReader();


            while (rd.Read())
            {
                usernameTB.Text = rd[0].ToString();
                cardNumberTB.Text = rd[2].ToString();
                emailTB.Text = rd[3].ToString();
                licensePlateTB.Text = rd[4].ToString();
                firstNameTB.Text = rd[5].ToString();
                lastNameTB.Text = rd[6].ToString();
            }
            con.Close();
        }
    }
}
