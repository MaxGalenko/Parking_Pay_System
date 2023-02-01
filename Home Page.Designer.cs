namespace Stellar_Parking
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.dateLabel = new System.Windows.Forms.Label();
            this.payLabel = new System.Windows.Forms.Label();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.historyLabel = new System.Windows.Forms.Label();
            this.nearbyLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logoPB = new System.Windows.Forms.PictureBox();
            this.nearbyPB = new System.Windows.Forms.PictureBox();
            this.historyPB = new System.Windows.Forms.PictureBox();
            this.setttingsPB = new System.Windows.Forms.PictureBox();
            this.payPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nearbyPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setttingsPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payPB)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            resources.ApplyResources(this.welcomeLabel, "welcomeLabel");
            this.welcomeLabel.Name = "welcomeLabel";
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
            // dateLabel
            // 
            resources.ApplyResources(this.dateLabel, "dateLabel");
            this.dateLabel.Name = "dateLabel";
            // 
            // payLabel
            // 
            resources.ApplyResources(this.payLabel, "payLabel");
            this.payLabel.Name = "payLabel";
            // 
            // settingsLabel
            // 
            resources.ApplyResources(this.settingsLabel, "settingsLabel");
            this.settingsLabel.Name = "settingsLabel";
            // 
            // historyLabel
            // 
            resources.ApplyResources(this.historyLabel, "historyLabel");
            this.historyLabel.Name = "historyLabel";
            // 
            // nearbyLabel
            // 
            resources.ApplyResources(this.nearbyLabel, "nearbyLabel");
            this.nearbyLabel.Name = "nearbyLabel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // logoPB
            // 
            resources.ApplyResources(this.logoPB, "logoPB");
            this.logoPB.Image = global::Stellar_Parking.Properties.Resources.logo;
            this.logoPB.Name = "logoPB";
            this.logoPB.TabStop = false;
            // 
            // nearbyPB
            // 
            resources.ApplyResources(this.nearbyPB, "nearbyPB");
            this.nearbyPB.BackColor = System.Drawing.SystemColors.Window;
            this.nearbyPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nearbyPB.Image = global::Stellar_Parking.Properties.Resources.nearbyImg;
            this.nearbyPB.Name = "nearbyPB";
            this.nearbyPB.TabStop = false;
            this.nearbyPB.Click += new System.EventHandler(this.nearbyPB_Click);
            // 
            // historyPB
            // 
            resources.ApplyResources(this.historyPB, "historyPB");
            this.historyPB.BackColor = System.Drawing.SystemColors.Window;
            this.historyPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historyPB.Image = global::Stellar_Parking.Properties.Resources.historyImg;
            this.historyPB.Name = "historyPB";
            this.historyPB.TabStop = false;
            this.historyPB.Click += new System.EventHandler(this.historyPB_Click);
            // 
            // setttingsPB
            // 
            resources.ApplyResources(this.setttingsPB, "setttingsPB");
            this.setttingsPB.BackColor = System.Drawing.SystemColors.Window;
            this.setttingsPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setttingsPB.Image = global::Stellar_Parking.Properties.Resources.settingsImg;
            this.setttingsPB.Name = "setttingsPB";
            this.setttingsPB.TabStop = false;
            this.setttingsPB.Click += new System.EventHandler(this.setttingsPB_Click);
            // 
            // payPB
            // 
            resources.ApplyResources(this.payPB, "payPB");
            this.payPB.BackColor = System.Drawing.SystemColors.Window;
            this.payPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.payPB.Image = global::Stellar_Parking.Properties.Resources.payImg;
            this.payPB.Name = "payPB";
            this.payPB.TabStop = false;
            this.payPB.Click += new System.EventHandler(this.payPB_Click);
            // 
            // HomePage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.logoPB);
            this.Controls.Add(this.nearbyLabel);
            this.Controls.Add(this.historyLabel);
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.payLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.nearbyPB);
            this.Controls.Add(this.historyPB);
            this.Controls.Add(this.setttingsPB);
            this.Controls.Add(this.payPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HomePage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nearbyPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setttingsPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox payPB;
        private System.Windows.Forms.PictureBox setttingsPB;
        private System.Windows.Forms.PictureBox historyPB;
        private System.Windows.Forms.PictureBox nearbyPB;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label payLabel;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.Label nearbyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox logoPB;
    }
}