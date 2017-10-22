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
            this.tbxRules = new System.Windows.Forms.TextBox();
            this.lblGameRulesHeading = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxRules
            // 
            this.tbxRules.BackColor = System.Drawing.Color.White;
            this.tbxRules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxRules.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbxRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRules.ForeColor = System.Drawing.Color.Black;
            this.tbxRules.Location = new System.Drawing.Point(140, 167);
            this.tbxRules.Multiline = true;
            this.tbxRules.Name = "tbxRules";
            this.tbxRules.ReadOnly = true;
            this.tbxRules.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxRules.Size = new System.Drawing.Size(1226, 331);
            this.tbxRules.TabIndex = 35;
            this.tbxRules.Text = resources.GetString("tbxRules.Text");
            this.tbxRules.TextChanged += new System.EventHandler(this.tbxRules_TextChanged);
            // 
            // lblGameRulesHeading
            // 
            this.lblGameRulesHeading.AutoSize = true;
            this.lblGameRulesHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblGameRulesHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameRulesHeading.ForeColor = System.Drawing.Color.Black;
            this.lblGameRulesHeading.Location = new System.Drawing.Point(625, 132);
            this.lblGameRulesHeading.Name = "lblGameRulesHeading";
            this.lblGameRulesHeading.Size = new System.Drawing.Size(173, 32);
            this.lblGameRulesHeading.TabIndex = 37;
            this.lblGameRulesHeading.Text = "How to play";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gold;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 10;
            this.btnExit.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1052, 23);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 55);
            this.btnExit.TabIndex = 62;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Game_Rules
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::WillBallingerBrockButtsworthAssgt.Properties.Resources.GameScreenBackground2;
            this.ClientSize = new System.Drawing.Size(1378, 644);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblGameRulesHeading);
            this.Controls.Add(this.tbxRules);
            this.Name = "Game_Rules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Rules";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxRules;
        private System.Windows.Forms.Label lblGameRulesHeading;
        private System.Windows.Forms.Button btnExit;
    }
}