namespace VadersLittleHelper.Interface
{
    partial class StartScreen
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSquad = new System.Windows.Forms.Button();
            this.btnMatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(24, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(131, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse Cards";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSquad
            // 
            this.btnSquad.Location = new System.Drawing.Point(24, 41);
            this.btnSquad.Name = "btnSquad";
            this.btnSquad.Size = new System.Drawing.Size(131, 23);
            this.btnSquad.TabIndex = 1;
            this.btnSquad.Text = "Manage Squadrons";
            this.btnSquad.UseVisualStyleBackColor = true;
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(24, 70);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(131, 23);
            this.btnMatch.TabIndex = 2;
            this.btnMatch.Text = "Prepare Game";
            this.btnMatch.UseVisualStyleBackColor = true;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 108);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.btnSquad);
            this.Controls.Add(this.btnBrowse);
            this.Name = "StartScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSquad;
        private System.Windows.Forms.Button btnMatch;
    }
}

