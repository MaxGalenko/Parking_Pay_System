namespace Stellar_Parking
{
    partial class PrivacyPolicyPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrivacyPolicyPage));
            this.privacyPolicyTB = new System.Windows.Forms.TextBox();
            this.privacyPolicyLabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // privacyPolicyTB
            // 
            resources.ApplyResources(this.privacyPolicyTB, "privacyPolicyTB");
            this.privacyPolicyTB.BackColor = System.Drawing.SystemColors.Window;
            this.privacyPolicyTB.Name = "privacyPolicyTB";
            this.privacyPolicyTB.ReadOnly = true;
            // 
            // privacyPolicyLabel
            // 
            resources.ApplyResources(this.privacyPolicyLabel, "privacyPolicyLabel");
            this.privacyPolicyLabel.Name = "privacyPolicyLabel";
            // 
            // backBtn
            // 
            resources.ApplyResources(this.backBtn, "backBtn");
            this.backBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.backBtn.Name = "backBtn";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // PrivacyPolicyPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.privacyPolicyLabel);
            this.Controls.Add(this.privacyPolicyTB);
            this.Name = "PrivacyPolicyPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrivacyPolicyPage_FormClosing);
            this.Load += new System.EventHandler(this.PrivacyPolicyPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox privacyPolicyTB;
        private System.Windows.Forms.Label privacyPolicyLabel;
        private System.Windows.Forms.Button backBtn;
    }
}