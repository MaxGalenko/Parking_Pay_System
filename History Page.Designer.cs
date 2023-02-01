namespace Stellar_Parking
{
    partial class HistoryPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryPage));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.payLabel = new System.Windows.Forms.Label();
            this.nearbyLabel = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.parkingHistoryTB = new System.Windows.Forms.TextBox();
            this.parkingHistoryLabel = new System.Windows.Forms.Label();
            this.payPB = new System.Windows.Forms.PictureBox();
            this.nearbyPB = new System.Windows.Forms.PictureBox();
            this.setttingsPB = new System.Windows.Forms.PictureBox();
            this.homePB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.payPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nearbyPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setttingsPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePB)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
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
            // timeLabel
            // 
            resources.ApplyResources(this.timeLabel, "timeLabel");
            this.timeLabel.Name = "timeLabel";
            // 
            // dateLabel
            // 
            resources.ApplyResources(this.dateLabel, "dateLabel");
            this.dateLabel.Name = "dateLabel";
            // 
            // settingsLabel
            // 
            resources.ApplyResources(this.settingsLabel, "settingsLabel");
            this.settingsLabel.Name = "settingsLabel";
            // 
            // parkingHistoryTB
            // 
            resources.ApplyResources(this.parkingHistoryTB, "parkingHistoryTB");
            this.parkingHistoryTB.BackColor = System.Drawing.SystemColors.Window;
            this.parkingHistoryTB.Name = "parkingHistoryTB";
            this.parkingHistoryTB.ReadOnly = true;
            // 
            // parkingHistoryLabel
            // 
            resources.ApplyResources(this.parkingHistoryLabel, "parkingHistoryLabel");
            this.parkingHistoryLabel.Name = "parkingHistoryLabel";
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
            // homePB
            // 
            resources.ApplyResources(this.homePB, "homePB");
            this.homePB.BackColor = System.Drawing.SystemColors.Window;
            this.homePB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.homePB.Image = global::Stellar_Parking.Properties.Resources.homeImg;
            this.homePB.Name = "homePB";
            this.homePB.TabStop = false;
            this.homePB.Click += new System.EventHandler(this.homePB_Click);
            // 
            // HistoryPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.parkingHistoryLabel);
            this.Controls.Add(this.parkingHistoryTB);
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.payLabel);
            this.Controls.Add(this.nearbyLabel);
            this.Controls.Add(this.homeLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.payPB);
            this.Controls.Add(this.nearbyPB);
            this.Controls.Add(this.setttingsPB);
            this.Controls.Add(this.homePB);
            this.Name = "HistoryPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HistoryPage_FormClosing);
            this.Load += new System.EventHandler(this.HistoryPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nearbyPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setttingsPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label payLabel;
        private System.Windows.Forms.Label nearbyLabel;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.PictureBox payPB;
        private System.Windows.Forms.PictureBox nearbyPB;
        private System.Windows.Forms.PictureBox setttingsPB;
        private System.Windows.Forms.PictureBox homePB;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.TextBox parkingHistoryTB;
        private System.Windows.Forms.Label parkingHistoryLabel;
    }
}