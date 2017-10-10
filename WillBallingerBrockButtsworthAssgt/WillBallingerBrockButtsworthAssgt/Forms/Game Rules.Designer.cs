namespace WillBallingerBrockButtsworthAssgt.Forms
{
    partial class Game_Rules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Rules));
            this.pctbxLogo = new System.Windows.Forms.PictureBox();
            this.horizontalRule = new System.Windows.Forms.Label();
            this.tbxRules = new System.Windows.Forms.TextBox();
            this.lblGameRulesHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pctbxLogo
            // 
            this.pctbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctbxLogo.Image = global::WillBallingerBrockButtsworthAssgt.Properties.Resources.plusmoinslogo1;
            this.pctbxLogo.Location = new System.Drawing.Point(575, 0);
            this.pctbxLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctbxLogo.Name = "pctbxLogo";
            this.pctbxLogo.Size = new System.Drawing.Size(250, 100);
            this.pctbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbxLogo.TabIndex = 1;
            this.pctbxLogo.TabStop = false;
            // 
            // horizontalRule
            // 
            this.horizontalRule.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horizontalRule.Location = new System.Drawing.Point(5, 100);
            this.horizontalRule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.horizontalRule.Name = "horizontalRule";
            this.horizontalRule.Size = new System.Drawing.Size(1365, 5);
            this.horizontalRule.TabIndex = 34;
            // 
            // tbxRules
            // 
            this.tbxRules.BackColor = System.Drawing.Color.White;
            this.tbxRules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxRules.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbxRules.Enabled = false;
            this.tbxRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRules.ForeColor = System.Drawing.Color.Black;
            this.tbxRules.Location = new System.Drawing.Point(16, 167);
            this.tbxRules.Multiline = true;
            this.tbxRules.Name = "tbxRules";
            this.tbxRules.ReadOnly = true;
            this.tbxRules.Size = new System.Drawing.Size(1349, 466);
            this.tbxRules.TabIndex = 35;
            this.tbxRules.Text = resources.GetString("tbxRules.Text");
            // 
            // lblGameRulesHeading
            // 
            this.lblGameRulesHeading.AutoSize = true;
            this.lblGameRulesHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblGameRulesHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameRulesHeading.ForeColor = System.Drawing.Color.Black;
            this.lblGameRulesHeading.Location = new System.Drawing.Point(615, 120);
            this.lblGameRulesHeading.Name = "lblGameRulesHeading";
            this.lblGameRulesHeading.Size = new System.Drawing.Size(173, 32);
            this.lblGameRulesHeading.TabIndex = 37;
            this.lblGameRulesHeading.Text = "How to play";
            // 
            // Game_Rules
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1378, 644);
            this.Controls.Add(this.lblGameRulesHeading);
            this.Controls.Add(this.tbxRules);
            this.Controls.Add(this.horizontalRule);
            this.Controls.Add(this.pctbxLogo);
            this.Enabled = false;
            this.Name = "Game_Rules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Rules";
            ((System.ComponentModel.ISupportInitialize)(this.pctbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pctbxLogo;
        private System.Windows.Forms.Label horizontalRule;
        private System.Windows.Forms.TextBox tbxRules;
        private System.Windows.Forms.Label lblGameRulesHeading;
    }
}