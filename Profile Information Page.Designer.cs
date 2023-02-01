namespace Stellar_Parking
{
    partial class ProfileInformationPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileInformationPage));
            this.profileInformationLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.cardNumberTB = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.licensePlateLabel = new System.Windows.Forms.Label();
            this.licensePlateTB = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // profileInformationLabel
            // 
            resources.ApplyResources(this.profileInformationLabel, "profileInformationLabel");
            this.profileInformationLabel.Name = "profileInformationLabel";
            // 
            // usernameLabel
            // 
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.Name = "usernameLabel";
            // 
            // usernameTB
            // 
            resources.ApplyResources(this.usernameTB, "usernameTB");
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.ReadOnly = true;
            // 
            // cardNumberLabel
            // 
            resources.ApplyResources(this.cardNumberLabel, "cardNumberLabel");
            this.cardNumberLabel.Name = "cardNumberLabel";
            // 
            // cardNumberTB
            // 
            resources.ApplyResources(this.cardNumberTB, "cardNumberTB");
            this.cardNumberTB.Name = "cardNumberTB";
            this.cardNumberTB.ReadOnly = true;
            // 
            // emailLabel
            // 
            resources.ApplyResources(this.emailLabel, "emailLabel");
            this.emailLabel.Name = "emailLabel";
            // 
            // emailTB
            // 
            resources.ApplyResources(this.emailTB, "emailTB");
            this.emailTB.Name = "emailTB";
            this.emailTB.ReadOnly = true;
            // 
            // licensePlateLabel
            // 
            resources.ApplyResources(this.licensePlateLabel, "licensePlateLabel");
            this.licensePlateLabel.Name = "licensePlateLabel";
            // 
            // licensePlateTB
            // 
            resources.ApplyResources(this.licensePlateTB, "licensePlateTB");
            this.licensePlateTB.Name = "licensePlateTB";
            this.licensePlateTB.ReadOnly = true;
            // 
            // firstNameLabel
            // 
            resources.ApplyResources(this.firstNameLabel, "firstNameLabel");
            this.firstNameLabel.Name = "firstNameLabel";
            // 
            // firstNameTB
            // 
            resources.ApplyResources(this.firstNameTB, "firstNameTB");
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.ReadOnly = true;
            // 
            // lastNameLabel
            // 
            resources.ApplyResources(this.lastNameLabel, "lastNameLabel");
            this.lastNameLabel.Name = "lastNameLabel";
            // 
            // lastNameTB
            // 
            resources.ApplyResources(this.lastNameTB, "lastNameTB");
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.ReadOnly = true;
            // 
            // ProfileInformationPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.licensePlateTB);
            this.Controls.Add(this.licensePlateLabel);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.cardNumberTB);
            this.Controls.Add(this.cardNumberLabel);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.profileInformationLabel);
            this.Name = "ProfileInformationPage";
            this.Load += new System.EventHandler(this.ProfileInformationPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label profileInformationLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.TextBox cardNumberTB;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label licensePlateLabel;
        private System.Windows.Forms.TextBox licensePlateTB;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTB;
    }
}