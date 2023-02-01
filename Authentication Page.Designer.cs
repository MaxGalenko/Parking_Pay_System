namespace Stellar_Parking
{
    partial class AuthenticationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthenticationPage));
            this.loginLabel = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.signUpLabel = new System.Windows.Forms.LinkLabel();
            this.revealBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            resources.ApplyResources(this.loginLabel, "loginLabel");
            this.loginLabel.Name = "loginLabel";
            // 
            // usernameTB
            // 
            resources.ApplyResources(this.usernameTB, "usernameTB");
            this.usernameTB.Name = "usernameTB";
            // 
            // passwordTB
            // 
            resources.ApplyResources(this.passwordTB, "passwordTB");
            this.passwordTB.Name = "passwordTB";
            // 
            // usernameLabel
            // 
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.Name = "usernameLabel";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.Name = "passwordLabel";
            // 
            // loginBtn
            // 
            resources.ApplyResources(this.loginBtn, "loginBtn");
            this.loginBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // signUpLabel
            // 
            resources.ApplyResources(this.signUpLabel, "signUpLabel");
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.TabStop = true;
            this.signUpLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpLabel_LinkClicked);
            // 
            // revealBtn
            // 
            resources.ApplyResources(this.revealBtn, "revealBtn");
            this.revealBtn.BackgroundImage = global::Stellar_Parking.Properties.Resources.showHidePassImg0;
            this.revealBtn.Name = "revealBtn";
            this.revealBtn.UseVisualStyleBackColor = true;
            this.revealBtn.Click += new System.EventHandler(this.revealBtn_Click);
            // 
            // AuthenticationPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.revealBtn);
            this.Controls.Add(this.signUpLabel);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.loginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AuthenticationPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthenticationForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.LinkLabel signUpLabel;
        private System.Windows.Forms.Button revealBtn;
        protected System.Windows.Forms.TextBox usernameTB;
    }
}

