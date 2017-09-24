namespace WillBallingerBrockButtsworthAssgt
{
    partial class FormGameScreen
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
            this.lblHeaderPlusMois = new System.Windows.Forms.Label();
            this.lblGoalScore = new System.Windows.Forms.Label();
            this.lblTargetScore = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.picbxDrawing = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDrawing)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeaderPlusMois
            // 
            this.lblHeaderPlusMois.AutoSize = true;
            this.lblHeaderPlusMois.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderPlusMois.Location = new System.Drawing.Point(538, 9);
            this.lblHeaderPlusMois.Name = "lblHeaderPlusMois";
            this.lblHeaderPlusMois.Size = new System.Drawing.Size(231, 55);
            this.lblHeaderPlusMois.TabIndex = 1;
            this.lblHeaderPlusMois.Text = "Plus Mois";
            this.lblHeaderPlusMois.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGoalScore
            // 
            this.lblGoalScore.AutoSize = true;
            this.lblGoalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalScore.Location = new System.Drawing.Point(1004, 16);
            this.lblGoalScore.Name = "lblGoalScore";
            this.lblGoalScore.Size = new System.Drawing.Size(233, 46);
            this.lblGoalScore.TabIndex = 2;
            this.lblGoalScore.Text = "Goal Score:";
            this.lblGoalScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTargetScore
            // 
            this.lblTargetScore.AutoSize = true;
            this.lblTargetScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetScore.Location = new System.Drawing.Point(1243, 16);
            this.lblTargetScore.Name = "lblTargetScore";
            this.lblTargetScore.Size = new System.Drawing.Size(86, 46);
            this.lblTargetScore.TabIndex = 3;
            this.lblTargetScore.Text = "200";
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(1176, 454);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(143, 43);
            this.btnRoll.TabIndex = 4;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // picbxDrawing
            // 
            this.picbxDrawing.Location = new System.Drawing.Point(45, 106);
            this.picbxDrawing.Name = "picbxDrawing";
            this.picbxDrawing.Size = new System.Drawing.Size(1300, 120);
            this.picbxDrawing.TabIndex = 5;
            this.picbxDrawing.TabStop = false;
            // 
            // FormGameScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1378, 644);
            this.Controls.Add(this.picbxDrawing);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.lblTargetScore);
            this.Controls.Add(this.lblGoalScore);
            this.Controls.Add(this.lblHeaderPlusMois);
            this.Name = "FormGameScreen";
            this.Text = "Plus Mois";
            ((System.ComponentModel.ISupportInitialize)(this.picbxDrawing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeaderPlusMois;
        private System.Windows.Forms.Label lblGoalScore;
        private System.Windows.Forms.Label lblTargetScore;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.PictureBox picbxDrawing;
    }
}

