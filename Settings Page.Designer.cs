namespace Stellar_Parking
{
    partial class SettingsPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsPage));
            this.historyLabel = new System.Windows.Forms.Label();
            this.payLabel = new System.Windows.Forms.Label();
            this.nearbyLabel = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.languagesBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.paymentMethodsBtn = new System.Windows.Forms.Button();
            this.profileInfoBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.profileNameLabel = new System.Windows.Forms.Label();
            this.profileImagePB = new System.Windows.Forms.PictureBox();
            this.payPB = new System.Windows.Forms.PictureBox();
            this.nearbyPB = new System.Windows.Forms.PictureBox();
            this.historyPB = new System.Windows.Forms.PictureBox();
            this.homePB = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileImagePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nearbyPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePB)).BeginInit();
            this.SuspendLayout();
            // 
            // historyLabel
            // 
            resources.ApplyResources(this.historyLabel, "historyLabel");
            this.historyLabel.Name = "historyLabel";
            // 
            // payLabel
            // 
            resources.ApplyResources(this.payLabel, "payLabel");
            this.payLabel.Name = "payLabel";
            // 
            // nearbyLabel
            // 
            resources.ApplyResources(this.nearbyLabel, "nearbyLabel");
            this.nearbyLabel.Name = "nearbyLabel";
            // 
            // homeLabel
            // 
            resources.ApplyResources(this.homeLabel, "homeLabel");
            this.homeLabel.Name = "homeLabel";
            // 
            // dateLabel
            // 
            resources.ApplyResources(this.dateLabel, "dateLabel");
            this.dateLabel.Name = "dateLabel";
            // 
            // timeLabel
            // 
            resources.ApplyResources(this.timeLabel, "timeLabel");
            this.timeLabel.Name = "timeLabel";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.languagesBtn);
            this.panel1.Controls.Add(this.logOutBtn);
            this.panel1.Controls.Add(this.paymentMethodsBtn);
            this.panel1.Controls.Add(this.profileInfoBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Name = "panel1";
            // 
            // languagesBtn
            // 
            resources.ApplyResources(this.languagesBtn, "languagesBtn");
            this.languagesBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.languagesBtn.Name = "languagesBtn";
            this.languagesBtn.UseVisualStyleBackColor = false;
            this.languagesBtn.Click += new System.EventHandler(this.languagesBtn_Click);
            // 
            // logOutBtn
            // 
            resources.ApplyResources(this.logOutBtn, "logOutBtn");
            this.logOutBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // paymentMethodsBtn
            // 
            resources.ApplyResources(this.paymentMethodsBtn, "paymentMethodsBtn");
            this.paymentMethodsBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.paymentMethodsBtn.Name = "paymentMethodsBtn";
            this.paymentMethodsBtn.UseVisualStyleBackColor = false;
            this.paymentMethodsBtn.Click += new System.EventHandler(this.payementMethodsBtn_Click);
            // 
            // profileInfoBtn
            // 
            resources.ApplyResources(this.profileInfoBtn, "profileInfoBtn");
            this.profileInfoBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.profileInfoBtn.Name = "profileInfoBtn";
            this.profileInfoBtn.UseVisualStyleBackColor = false;
            this.profileInfoBtn.Click += new System.EventHandler(this.profileInfoBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.profileNameLabel);
            this.panel2.Controls.Add(this.profileImagePB);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // profileNameLabel
            // 
            resources.ApplyResources(this.profileNameLabel, "profileNameLabel");
            this.profileNameLabel.Name = "profileNameLabel";
            // 
            // profileImagePB
            // 
            resources.ApplyResources(this.profileImagePB, "profileImagePB");
            this.profileImagePB.Image = global::Stellar_Parking.Properties.Resources.profile;
            this.profileImagePB.Name = "profileImagePB";
            this.profileImagePB.TabStop = false;
            // 
            // payPB
            // 
            this.payPB.BackColor = System.Drawing.SystemColors.Window;
            this.payPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.payPB.Image = global::Stellar_Parking.Properties.Resources.payImg;
            resources.ApplyResources(this.payPB, "payPB");
            this.payPB.Name = "payPB";
            this.payPB.TabStop = false;
            this.payPB.Click += new System.EventHandler(this.payPB_Click);
            // 
            // nearbyPB
            // 
            this.nearbyPB.BackColor = System.Drawing.SystemColors.Window;
            this.nearbyPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nearbyPB.Image = global::Stellar_Parking.Properties.Resources.nearbyImg;
            resources.ApplyResources(this.nearbyPB, "nearbyPB");
            this.nearbyPB.Name = "nearbyPB";
            this.nearbyPB.TabStop = false;
            this.nearbyPB.Click += new System.EventHandler(this.nearbyPB_Click);
            // 
            // historyPB
            // 
            this.historyPB.BackColor = System.Drawing.SystemColors.Window;
            this.historyPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historyPB.Image = global::Stellar_Parking.Properties.Resources.historyImg;
            resources.ApplyResources(this.historyPB, "historyPB");
            this.historyPB.Name = "historyPB";
            this.historyPB.TabStop = false;
            this.historyPB.Click += new System.EventHandler(this.historyPB_Click);
            // 
            // homePB
            // 
            this.homePB.BackColor = System.Drawing.SystemColors.Window;
            this.homePB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.homePB.Image = global::Stellar_Parking.Properties.Resources.homeImg;
            resources.ApplyResources(this.homePB, "homePB");
            this.homePB.Name = "homePB";
            this.homePB.TabStop = false;
            this.homePB.Click += new System.EventHandler(this.homePB_Click);
            // 
            // SettingsPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.historyLabel);
            this.Controls.Add(this.payLabel);
            this.Controls.Add(this.nearbyLabel);
            this.Controls.Add(this.homeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.payPB);
            this.Controls.Add(this.nearbyPB);
            this.Controls.Add(this.historyPB);
            this.Controls.Add(this.homePB);
            this.Name = "SettingsPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsPage_FormClosing);
            this.Load += new System.EventHandler(this.SettingsPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profileImagePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nearbyPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.Label payLabel;
        private System.Windows.Forms.Label nearbyLabel;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.PictureBox payPB;
        private System.Windows.Forms.PictureBox nearbyPB;
        private System.Windows.Forms.PictureBox historyPB;
        private System.Windows.Forms.PictureBox homePB;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox profileImagePB;
        private System.Windows.Forms.Label profileNameLabel;
        private System.Windows.Forms.Button profileInfoBtn;
        private System.Windows.Forms.Button paymentMethodsBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button languagesBtn;
    }
}