namespace Stellar_Parking
{
    partial class PayementMethodPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayementMethodPage));
            this.addCreditCardLabel = new System.Windows.Forms.Label();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.cardNumberTB = new System.Windows.Forms.TextBox();
            this.nameOnCardLabel = new System.Windows.Forms.Label();
            this.nameOnCardTB = new System.Windows.Forms.TextBox();
            this.expirationDateLabel = new System.Windows.Forms.Label();
            this.expirationDateTB = new System.Windows.Forms.TextBox();
            this.addCardBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addCreditCardLabel
            // 
            resources.ApplyResources(this.addCreditCardLabel, "addCreditCardLabel");
            this.addCreditCardLabel.Name = "addCreditCardLabel";
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
            // 
            // nameOnCardLabel
            // 
            resources.ApplyResources(this.nameOnCardLabel, "nameOnCardLabel");
            this.nameOnCardLabel.Name = "nameOnCardLabel";
            // 
            // nameOnCardTB
            // 
            resources.ApplyResources(this.nameOnCardTB, "nameOnCardTB");
            this.nameOnCardTB.Name = "nameOnCardTB";
            // 
            // expirationDateLabel
            // 
            resources.ApplyResources(this.expirationDateLabel, "expirationDateLabel");
            this.expirationDateLabel.Name = "expirationDateLabel";
            // 
            // expirationDateTB
            // 
            resources.ApplyResources(this.expirationDateTB, "expirationDateTB");
            this.expirationDateTB.Name = "expirationDateTB";
            // 
            // addCardBtn
            // 
            resources.ApplyResources(this.addCardBtn, "addCardBtn");
            this.addCardBtn.Name = "addCardBtn";
            this.addCardBtn.UseVisualStyleBackColor = true;
            this.addCardBtn.Click += new System.EventHandler(this.addCardBtn_Click);
            // 
            // PayementMethodPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.addCardBtn);
            this.Controls.Add(this.expirationDateTB);
            this.Controls.Add(this.expirationDateLabel);
            this.Controls.Add(this.nameOnCardTB);
            this.Controls.Add(this.nameOnCardLabel);
            this.Controls.Add(this.cardNumberTB);
            this.Controls.Add(this.cardNumberLabel);
            this.Controls.Add(this.addCreditCardLabel);
            this.Name = "PayementMethodPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addCreditCardLabel;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.TextBox cardNumberTB;
        private System.Windows.Forms.Label nameOnCardLabel;
        private System.Windows.Forms.TextBox nameOnCardTB;
        private System.Windows.Forms.Label expirationDateLabel;
        private System.Windows.Forms.TextBox expirationDateTB;
        private System.Windows.Forms.Button addCardBtn;
    }
}