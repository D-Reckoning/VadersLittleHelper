namespace VadersLittleHelper.Interface
{
    partial class CardBrowser
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
            this.lstCards = new System.Windows.Forms.ListBox();
            this.ddCardType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstCards
            // 
            this.lstCards.FormattingEnabled = true;
            this.lstCards.Location = new System.Drawing.Point(12, 38);
            this.lstCards.Name = "lstCards";
            this.lstCards.Size = new System.Drawing.Size(188, 394);
            this.lstCards.Sorted = true;
            this.lstCards.TabIndex = 0;
            this.lstCards.SelectedIndexChanged += new System.EventHandler(this.lstCards_SelectedIndexChanged);
            // 
            // ddCardType
            // 
            this.ddCardType.FormattingEnabled = true;
            this.ddCardType.Location = new System.Drawing.Point(12, 13);
            this.ddCardType.Name = "ddCardType";
            this.ddCardType.Size = new System.Drawing.Size(188, 21);
            this.ddCardType.TabIndex = 1;
            this.ddCardType.Text = "Select Card Type";
            this.ddCardType.SelectedIndexChanged += new System.EventHandler(this.ddCardType_SelectedIndexChanged);
            // 
            // CardBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 452);
            this.Controls.Add(this.ddCardType);
            this.Controls.Add(this.lstCards);
            this.Name = "CardBrowser";
            this.Text = "CardBrowser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCards;
        private System.Windows.Forms.ComboBox ddCardType;
    }
}