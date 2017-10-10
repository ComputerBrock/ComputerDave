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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.horizontalRule = new System.Windows.Forms.Label();
            this.tbxRules = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WillBallingerBrockButtsworthAssgt.Properties.Resources.plusmoinslogo1;
            this.pictureBox1.Location = new System.Drawing.Point(575, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.tbxRules.Location = new System.Drawing.Point(234, 149);
            this.tbxRules.Multiline = true;
            this.tbxRules.Name = "tbxRules";
            this.tbxRules.Size = new System.Drawing.Size(921, 371);
            this.tbxRules.TabIndex = 35;
            this.tbxRules.Text = resources.GetString("tbxRules.Text");
            // 
            // Game_Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1378, 644);
            this.Controls.Add(this.tbxRules);
            this.Controls.Add(this.horizontalRule);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Game_Rules";
            this.Text = "Game Rules";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label horizontalRule;
        private System.Windows.Forms.TextBox tbxRules;
    }
}