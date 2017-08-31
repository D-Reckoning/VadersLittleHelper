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
            this.cardBox = new System.Windows.Forms.GroupBox();
            this.ddCard = new System.Windows.Forms.ComboBox();
            this.lblCardPoints = new System.Windows.Forms.Label();
            this.lblCardName = new System.Windows.Forms.Label();
            this.lblPilotSkill = new System.Windows.Forms.Label();
            this.txtCardText = new System.Windows.Forms.TextBox();
            this.lblUpgradeType = new System.Windows.Forms.Label();
            this.lblShip = new System.Windows.Forms.Label();
            this.lblFirePower = new System.Windows.Forms.Label();
            this.lblAgility = new System.Windows.Forms.Label();
            this.lblHull = new System.Windows.Forms.Label();
            this.lblShields = new System.Windows.Forms.Label();
            this.cardBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCards
            // 
            this.lstCards.FormattingEnabled = true;
            this.lstCards.Location = new System.Drawing.Point(12, 77);
            this.lstCards.Name = "lstCards";
            this.lstCards.Size = new System.Drawing.Size(364, 160);
            this.lstCards.Sorted = true;
            this.lstCards.TabIndex = 0;
            this.lstCards.SelectedIndexChanged += new System.EventHandler(this.lstCards_SelectedIndexChanged);
            // 
            // ddCardType
            // 
            this.ddCardType.FormattingEnabled = true;
            this.ddCardType.Location = new System.Drawing.Point(12, 41);
            this.ddCardType.Name = "ddCardType";
            this.ddCardType.Size = new System.Drawing.Size(364, 21);
            this.ddCardType.TabIndex = 1;
            this.ddCardType.Text = "Select Card Type";
            this.ddCardType.SelectedIndexChanged += new System.EventHandler(this.ddCardType_SelectedIndexChanged);
            // 
            // cardBox
            // 
            this.cardBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cardBox.Controls.Add(this.lblShields);
            this.cardBox.Controls.Add(this.lblHull);
            this.cardBox.Controls.Add(this.lblAgility);
            this.cardBox.Controls.Add(this.lblFirePower);
            this.cardBox.Controls.Add(this.lblShip);
            this.cardBox.Controls.Add(this.lblUpgradeType);
            this.cardBox.Controls.Add(this.txtCardText);
            this.cardBox.Controls.Add(this.lblPilotSkill);
            this.cardBox.Controls.Add(this.lblCardName);
            this.cardBox.Controls.Add(this.lblCardPoints);
            this.cardBox.Location = new System.Drawing.Point(382, 14);
            this.cardBox.Name = "cardBox";
            this.cardBox.Size = new System.Drawing.Size(263, 224);
            this.cardBox.TabIndex = 2;
            this.cardBox.TabStop = false;
            // 
            // ddCard
            // 
            this.ddCard.FormattingEnabled = true;
            this.ddCard.Location = new System.Drawing.Point(12, 14);
            this.ddCard.Name = "ddCard";
            this.ddCard.Size = new System.Drawing.Size(364, 21);
            this.ddCard.TabIndex = 3;
            this.ddCard.SelectedIndexChanged += new System.EventHandler(this.ddCard_SelectedIndexChanged);
            // 
            // lblCardPoints
            // 
            this.lblCardPoints.AutoSize = true;
            this.lblCardPoints.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardPoints.Location = new System.Drawing.Point(206, 198);
            this.lblCardPoints.Name = "lblCardPoints";
            this.lblCardPoints.Size = new System.Drawing.Size(37, 17);
            this.lblCardPoints.TabIndex = 0;
            this.lblCardPoints.Text = "0 pts";
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardName.Location = new System.Drawing.Point(42, 16);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(80, 19);
            this.lblCardName.TabIndex = 1;
            this.lblCardName.Text = "CardName";
            // 
            // lblPilotSkill
            // 
            this.lblPilotSkill.AutoSize = true;
            this.lblPilotSkill.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPilotSkill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPilotSkill.Location = new System.Drawing.Point(10, 16);
            this.lblPilotSkill.Name = "lblPilotSkill";
            this.lblPilotSkill.Size = new System.Drawing.Size(30, 33);
            this.lblPilotSkill.TabIndex = 2;
            this.lblPilotSkill.Text = "X";
            // 
            // txtCardText
            // 
            this.txtCardText.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardText.Location = new System.Drawing.Point(46, 57);
            this.txtCardText.Multiline = true;
            this.txtCardText.Name = "txtCardText";
            this.txtCardText.ReadOnly = true;
            this.txtCardText.Size = new System.Drawing.Size(197, 138);
            this.txtCardText.TabIndex = 3;
            // 
            // lblUpgradeType
            // 
            this.lblUpgradeType.AutoSize = true;
            this.lblUpgradeType.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpgradeType.Location = new System.Drawing.Point(44, 201);
            this.lblUpgradeType.Name = "lblUpgradeType";
            this.lblUpgradeType.Size = new System.Drawing.Size(73, 14);
            this.lblUpgradeType.TabIndex = 4;
            this.lblUpgradeType.Text = "UpgradeType";
            // 
            // lblShip
            // 
            this.lblShip.AutoSize = true;
            this.lblShip.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShip.Location = new System.Drawing.Point(43, 35);
            this.lblShip.Name = "lblShip";
            this.lblShip.Size = new System.Drawing.Size(66, 19);
            this.lblShip.TabIndex = 5;
            this.lblShip.Text = "ShipType";
            // 
            // lblFirePower
            // 
            this.lblFirePower.AutoSize = true;
            this.lblFirePower.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirePower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFirePower.Location = new System.Drawing.Point(10, 57);
            this.lblFirePower.Name = "lblFirePower";
            this.lblFirePower.Size = new System.Drawing.Size(30, 33);
            this.lblFirePower.TabIndex = 6;
            this.lblFirePower.Text = "X";
            // 
            // lblAgility
            // 
            this.lblAgility.AutoSize = true;
            this.lblAgility.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgility.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAgility.Location = new System.Drawing.Point(10, 90);
            this.lblAgility.Name = "lblAgility";
            this.lblAgility.Size = new System.Drawing.Size(30, 33);
            this.lblAgility.TabIndex = 7;
            this.lblAgility.Text = "X";
            // 
            // lblHull
            // 
            this.lblHull.AutoSize = true;
            this.lblHull.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHull.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblHull.Location = new System.Drawing.Point(10, 123);
            this.lblHull.Name = "lblHull";
            this.lblHull.Size = new System.Drawing.Size(30, 33);
            this.lblHull.TabIndex = 8;
            this.lblHull.Text = "X";
            // 
            // lblShields
            // 
            this.lblShields.AutoSize = true;
            this.lblShields.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShields.ForeColor = System.Drawing.Color.Blue;
            this.lblShields.Location = new System.Drawing.Point(10, 156);
            this.lblShields.Name = "lblShields";
            this.lblShields.Size = new System.Drawing.Size(30, 33);
            this.lblShields.TabIndex = 9;
            this.lblShields.Text = "X";
            // 
            // PilotCardBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 261);
            this.Controls.Add(this.ddCard);
            this.Controls.Add(this.cardBox);
            this.Controls.Add(this.ddCardType);
            this.Controls.Add(this.lstCards);
            this.Name = "PilotCardBrowser";
            this.Text = "CardBrowser";
            this.Load += new System.EventHandler(this.PilotCardBrowser_Load);
            this.cardBox.ResumeLayout(false);
            this.cardBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCards;
        private System.Windows.Forms.ComboBox ddCardType;
        private System.Windows.Forms.GroupBox cardBox;
        private System.Windows.Forms.ComboBox ddCard;
        private System.Windows.Forms.Label lblShields;
        private System.Windows.Forms.Label lblHull;
        private System.Windows.Forms.Label lblAgility;
        private System.Windows.Forms.Label lblFirePower;
        private System.Windows.Forms.Label lblShip;
        private System.Windows.Forms.Label lblUpgradeType;
        private System.Windows.Forms.TextBox txtCardText;
        private System.Windows.Forms.Label lblPilotSkill;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.Label lblCardPoints;
    }
}