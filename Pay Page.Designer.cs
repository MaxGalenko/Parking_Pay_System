namespace Stellar_Parking
{
    partial class PayPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayPage));
            this.nearbyLabel = new System.Windows.Forms.Label();
            this.historyLabel = new System.Windows.Forms.Label();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.payPanel = new System.Windows.Forms.Panel();
            this.totalTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.parkingTimeLabel = new System.Windows.Forms.Label();
            this.parkingTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.paymentComboBox = new System.Windows.Forms.ComboBox();
            this.paymentMethodLabel = new System.Windows.Forms.Label();
            this.parkingNumberTB = new System.Windows.Forms.TextBox();
            this.parkingNumberLabel = new System.Windows.Forms.Label();
            this.parkingPaymentLabel = new System.Windows.Forms.Label();
            this.nearbyPB = new System.Windows.Forms.PictureBox();
            this.historyPB = new System.Windows.Forms.PictureBox();
            this.setttingsPB = new System.Windows.Forms.PictureBox();
            this.homePB = new System.Windows.Forms.PictureBox();
            this.payPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkingTimeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nearbyPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setttingsPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePB)).BeginInit();
            this.SuspendLayout();
            // 
            // nearbyLabel
            // 
            resources.ApplyResources(this.nearbyLabel, "nearbyLabel");
            this.nearbyLabel.Name = "nearbyLabel";
            // 
            // historyLabel
            // 
            resources.ApplyResources(this.historyLabel, "historyLabel");
            this.historyLabel.Name = "historyLabel";
            // 
            // settingsLabel
            // 
            resources.ApplyResources(this.settingsLabel, "settingsLabel");
            this.settingsLabel.Name = "settingsLabel";
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
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // payPanel
            // 
            resources.ApplyResources(this.payPanel, "payPanel");
            this.payPanel.BackColor = System.Drawing.SystemColors.Window;
            this.payPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.payPanel.Controls.Add(this.totalTB);
            this.payPanel.Controls.Add(this.label2);
            this.payPanel.Controls.Add(this.label1);
            this.payPanel.Controls.Add(this.parkingTimeLabel);
            this.payPanel.Controls.Add(this.parkingTimeNumericUpDown);
            this.payPanel.Controls.Add(this.confirmBtn);
            this.payPanel.Controls.Add(this.paymentComboBox);
            this.payPanel.Controls.Add(this.paymentMethodLabel);
            this.payPanel.Controls.Add(this.parkingNumberTB);
            this.payPanel.Controls.Add(this.parkingNumberLabel);
            this.payPanel.Controls.Add(this.parkingPaymentLabel);
            this.payPanel.Name = "payPanel";
            // 
            // totalTB
            // 
            resources.ApplyResources(this.totalTB, "totalTB");
            this.totalTB.Name = "totalTB";
            this.totalTB.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // parkingTimeLabel
            // 
            resources.ApplyResources(this.parkingTimeLabel, "parkingTimeLabel");
            this.parkingTimeLabel.Name = "parkingTimeLabel";
            // 
            // parkingTimeNumericUpDown
            // 
            resources.ApplyResources(this.parkingTimeNumericUpDown, "parkingTimeNumericUpDown");
            this.parkingTimeNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.parkingTimeNumericUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.parkingTimeNumericUpDown.Name = "parkingTimeNumericUpDown";
            this.parkingTimeNumericUpDown.ReadOnly = true;
            this.parkingTimeNumericUpDown.ValueChanged += new System.EventHandler(this.parkingTimeNumericUpDown_ValueChanged);
            // 
            // confirmBtn
            // 
            resources.ApplyResources(this.confirmBtn, "confirmBtn");
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // paymentComboBox
            // 
            this.paymentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.paymentComboBox, "paymentComboBox");
            this.paymentComboBox.FormattingEnabled = true;
            this.paymentComboBox.Name = "paymentComboBox";
            // 
            // paymentMethodLabel
            // 
            resources.ApplyResources(this.paymentMethodLabel, "paymentMethodLabel");
            this.paymentMethodLabel.Name = "paymentMethodLabel";
            // 
            // parkingNumberTB
            // 
            resources.ApplyResources(this.parkingNumberTB, "parkingNumberTB");
            this.parkingNumberTB.Name = "parkingNumberTB";
            // 
            // parkingNumberLabel
            // 
            resources.ApplyResources(this.parkingNumberLabel, "parkingNumberLabel");
            this.parkingNumberLabel.Name = "parkingNumberLabel";
            // 
            // parkingPaymentLabel
            // 
            resources.ApplyResources(this.parkingPaymentLabel, "parkingPaymentLabel");
            this.parkingPaymentLabel.Name = "parkingPaymentLabel";
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
            // setttingsPB
            // 
            this.setttingsPB.BackColor = System.Drawing.SystemColors.Window;
            this.setttingsPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setttingsPB.Image = global::Stellar_Parking.Properties.Resources.settingsImg;
            resources.ApplyResources(this.setttingsPB, "setttingsPB");
            this.setttingsPB.Name = "setttingsPB";
            this.setttingsPB.TabStop = false;
            this.setttingsPB.Click += new System.EventHandler(this.setttingsPB_Click);
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
            // PayPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.payPanel);
            this.Controls.Add(this.nearbyLabel);
            this.Controls.Add(this.historyLabel);
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.homeLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.nearbyPB);
            this.Controls.Add(this.historyPB);
            this.Controls.Add(this.setttingsPB);
            this.Controls.Add(this.homePB);
            this.Name = "PayPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PayPage_FormClosing);
            this.Load += new System.EventHandler(this.PayPage_Load);
            this.payPanel.ResumeLayout(false);
            this.payPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkingTimeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nearbyPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setttingsPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label nearbyLabel;
        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.PictureBox nearbyPB;
        private System.Windows.Forms.PictureBox historyPB;
        private System.Windows.Forms.PictureBox setttingsPB;
        private System.Windows.Forms.PictureBox homePB;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel payPanel;
        private System.Windows.Forms.Label parkingPaymentLabel;
        private System.Windows.Forms.Label parkingNumberLabel;
        private System.Windows.Forms.TextBox parkingNumberTB;
        private System.Windows.Forms.Label paymentMethodLabel;
        private System.Windows.Forms.ComboBox paymentComboBox;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label parkingTimeLabel;
        private System.Windows.Forms.NumericUpDown parkingTimeNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalTB;
        private System.Windows.Forms.Label label2;
    }
}