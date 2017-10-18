namespace WillBallingerBrockButtsworthAssgt.Forms
{
    partial class WinScreen
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
            this.lblWinnerIs = new System.Windows.Forms.Label();
            this.lblResultWinnerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWinnerIs
            // 
            this.lblWinnerIs.AutoSize = true;
            this.lblWinnerIs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWinnerIs.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerIs.Location = new System.Drawing.Point(249, 95);
            this.lblWinnerIs.Name = "lblWinnerIs";
            this.lblWinnerIs.Size = new System.Drawing.Size(389, 62);
            this.lblWinnerIs.TabIndex = 0;
            this.lblWinnerIs.Text = "The Winner Is:";
            // 
            // lblResultWinnerName
            // 
            this.lblResultWinnerName.AutoSize = true;
            this.lblResultWinnerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultWinnerName.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultWinnerName.Location = new System.Drawing.Point(672, 203);
            this.lblResultWinnerName.Name = "lblResultWinnerName";
            this.lblResultWinnerName.Size = new System.Drawing.Size(214, 62);
            this.lblResultWinnerName.TabIndex = 1;
            this.lblResultWinnerName.Text = "Sydney";
            // 
            // WinScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = global::WillBallingerBrockButtsworthAssgt.Properties.Resources.winscreen;
            this.ClientSize = new System.Drawing.Size(1378, 644);
            this.Controls.Add(this.lblResultWinnerName);
            this.Controls.Add(this.lblWinnerIs);
            this.Name = "WinScreen";
            this.Text = "WinScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWinnerIs;
        private System.Windows.Forms.Label lblResultWinnerName;
    }
}