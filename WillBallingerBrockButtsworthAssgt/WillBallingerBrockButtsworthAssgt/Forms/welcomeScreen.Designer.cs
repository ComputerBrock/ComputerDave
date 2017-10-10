namespace WillBallingerBrockButtsworthAssgt.Forms
{
    partial class welcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcomeScreen));
            this.btnGameRules = new System.Windows.Forms.Button();
            this.lblGameMode = new System.Windows.Forms.Label();
            this.lbl1v1 = new System.Windows.Forms.Label();
            this.lbl1vCPU = new System.Windows.Forms.Label();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.tbxPlayer1Name = new System.Windows.Forms.TextBox();
            this.tbxPlayer2Name = new System.Windows.Forms.TextBox();
            this.lblGoalScore = new System.Windows.Forms.Label();
            this.tbxGoalScore = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.cbx1v1 = new System.Windows.Forms.CheckBox();
            this.cbx1vCPU = new System.Windows.Forms.CheckBox();
            this.lblPlayer1tbxError = new System.Windows.Forms.Label();
            this.lblPlayer2tbxError = new System.Windows.Forms.Label();
            this.lblGoalScoretbxError = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.horizontalRule = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGameRules
            // 
            this.btnGameRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGameRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameRules.Location = new System.Drawing.Point(836, 217);
            this.btnGameRules.Name = "btnGameRules";
            this.btnGameRules.Size = new System.Drawing.Size(440, 80);
            this.btnGameRules.TabIndex = 3;
            this.btnGameRules.Text = "Game Rules";
            this.btnGameRules.UseVisualStyleBackColor = false;
            this.btnGameRules.Click += new System.EventHandler(this.btnGameRules_Click);
            // 
            // lblGameMode
            // 
            this.lblGameMode.AutoSize = true;
            this.lblGameMode.BackColor = System.Drawing.Color.Transparent;
            this.lblGameMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameMode.Location = new System.Drawing.Point(262, 151);
            this.lblGameMode.Name = "lblGameMode";
            this.lblGameMode.Size = new System.Drawing.Size(152, 29);
            this.lblGameMode.TabIndex = 4;
            this.lblGameMode.Text = "Game Mode:";
            // 
            // lbl1v1
            // 
            this.lbl1v1.AutoSize = true;
            this.lbl1v1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1v1.Location = new System.Drawing.Point(188, 203);
            this.lbl1v1.Name = "lbl1v1";
            this.lbl1v1.Size = new System.Drawing.Size(62, 29);
            this.lbl1v1.TabIndex = 5;
            this.lbl1v1.Text = "1 v 1";
            this.lbl1v1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl1vCPU
            // 
            this.lbl1vCPU.AutoSize = true;
            this.lbl1vCPU.BackColor = System.Drawing.Color.Transparent;
            this.lbl1vCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1vCPU.Location = new System.Drawing.Point(370, 203);
            this.lbl1vCPU.Name = "lbl1vCPU";
            this.lbl1vCPU.Size = new System.Drawing.Size(99, 29);
            this.lbl1vCPU.TabIndex = 6;
            this.lbl1vCPU.Text = "1 v CPU";
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Name.Location = new System.Drawing.Point(162, 309);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(106, 29);
            this.lblPlayer1Name.TabIndex = 7;
            this.lblPlayer1Name.Text = "Player 1:";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(363, 309);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(106, 29);
            this.lblPlayer2.TabIndex = 8;
            this.lblPlayer2.Text = "Player 2:";
            // 
            // tbxPlayer1Name
            // 
            this.tbxPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPlayer1Name.Location = new System.Drawing.Point(142, 402);
            this.tbxPlayer1Name.Name = "tbxPlayer1Name";
            this.tbxPlayer1Name.Size = new System.Drawing.Size(138, 28);
            this.tbxPlayer1Name.TabIndex = 9;
            this.tbxPlayer1Name.Text = "Player 1 Name";
            // 
            // tbxPlayer2Name
            // 
            this.tbxPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPlayer2Name.Location = new System.Drawing.Point(368, 402);
            this.tbxPlayer2Name.Name = "tbxPlayer2Name";
            this.tbxPlayer2Name.Size = new System.Drawing.Size(146, 28);
            this.tbxPlayer2Name.TabIndex = 10;
            this.tbxPlayer2Name.Text = "Player 2 Name";
            // 
            // lblGoalScore
            // 
            this.lblGoalScore.AutoSize = true;
            this.lblGoalScore.BackColor = System.Drawing.Color.Transparent;
            this.lblGoalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalScore.Location = new System.Drawing.Point(140, 518);
            this.lblGoalScore.Name = "lblGoalScore";
            this.lblGoalScore.Size = new System.Drawing.Size(274, 29);
            this.lblGoalScore.TabIndex = 11;
            this.lblGoalScore.Text = "What is your goal score?";
            // 
            // tbxGoalScore
            // 
            this.tbxGoalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGoalScore.Location = new System.Drawing.Point(381, 512);
            this.tbxGoalScore.Name = "tbxGoalScore";
            this.tbxGoalScore.Size = new System.Drawing.Size(150, 28);
            this.tbxGoalScore.TabIndex = 12;
            this.tbxGoalScore.Text = "Enter Goal Score";
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(836, 331);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(440, 80);
            this.btnStartGame.TabIndex = 13;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // cbx1v1
            // 
            this.cbx1v1.AutoSize = true;
            this.cbx1v1.BackColor = System.Drawing.Color.Transparent;
            this.cbx1v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx1v1.Location = new System.Drawing.Point(208, 255);
            this.cbx1v1.Name = "cbx1v1";
            this.cbx1v1.Size = new System.Drawing.Size(22, 21);
            this.cbx1v1.TabIndex = 14;
            this.cbx1v1.UseVisualStyleBackColor = false;
            // 
            // cbx1vCPU
            // 
            this.cbx1vCPU.AutoSize = true;
            this.cbx1vCPU.BackColor = System.Drawing.Color.Transparent;
            this.cbx1vCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx1vCPU.Location = new System.Drawing.Point(408, 255);
            this.cbx1vCPU.Name = "cbx1vCPU";
            this.cbx1vCPU.Size = new System.Drawing.Size(22, 21);
            this.cbx1vCPU.TabIndex = 15;
            this.cbx1vCPU.UseVisualStyleBackColor = false;
            // 
            // lblPlayer1tbxError
            // 
            this.lblPlayer1tbxError.AutoSize = true;
            this.lblPlayer1tbxError.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1tbxError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1tbxError.Location = new System.Drawing.Point(206, 363);
            this.lblPlayer1tbxError.Name = "lblPlayer1tbxError";
            this.lblPlayer1tbxError.Size = new System.Drawing.Size(23, 29);
            this.lblPlayer1tbxError.TabIndex = 17;
            this.lblPlayer1tbxError.Text = "*";
            // 
            // lblPlayer2tbxError
            // 
            this.lblPlayer2tbxError.AutoSize = true;
            this.lblPlayer2tbxError.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2tbxError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2tbxError.Location = new System.Drawing.Point(446, 363);
            this.lblPlayer2tbxError.Name = "lblPlayer2tbxError";
            this.lblPlayer2tbxError.Size = new System.Drawing.Size(23, 29);
            this.lblPlayer2tbxError.TabIndex = 18;
            this.lblPlayer2tbxError.Text = "*";
            // 
            // lblGoalScoretbxError
            // 
            this.lblGoalScoretbxError.AutoSize = true;
            this.lblGoalScoretbxError.BackColor = System.Drawing.Color.Transparent;
            this.lblGoalScoretbxError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalScoretbxError.Location = new System.Drawing.Point(420, 482);
            this.lblGoalScoretbxError.Name = "lblGoalScoretbxError";
            this.lblGoalScoretbxError.Size = new System.Drawing.Size(23, 29);
            this.lblGoalScoretbxError.TabIndex = 19;
            this.lblGoalScoretbxError.Text = "*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(575, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // horizontalRule
            // 
            this.horizontalRule.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horizontalRule.Location = new System.Drawing.Point(5, 100);
            this.horizontalRule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.horizontalRule.Name = "horizontalRule";
            this.horizontalRule.Size = new System.Drawing.Size(1365, 5);
            this.horizontalRule.TabIndex = 33;
            // 
            // welcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1378, 644);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblGoalScoretbxError);
            this.Controls.Add(this.lblPlayer2tbxError);
            this.Controls.Add(this.lblPlayer1tbxError);
            this.Controls.Add(this.cbx1vCPU);
            this.Controls.Add(this.cbx1v1);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.tbxGoalScore);
            this.Controls.Add(this.lblGoalScore);
            this.Controls.Add(this.tbxPlayer2Name);
            this.Controls.Add(this.tbxPlayer1Name);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1Name);
            this.Controls.Add(this.lbl1vCPU);
            this.Controls.Add(this.lbl1v1);
            this.Controls.Add(this.lblGameMode);
            this.Controls.Add(this.btnGameRules);
            this.Name = "welcomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plus Moins";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGameRules;
        private System.Windows.Forms.Label lblGameMode;
        private System.Windows.Forms.Label lbl1v1;
        private System.Windows.Forms.Label lbl1vCPU;
        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.TextBox tbxPlayer1Name;
        private System.Windows.Forms.TextBox tbxPlayer2Name;
        private System.Windows.Forms.Label lblGoalScore;
        private System.Windows.Forms.TextBox tbxGoalScore;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.CheckBox cbx1v1;
        private System.Windows.Forms.CheckBox cbx1vCPU;
        private System.Windows.Forms.Label lblPlayer1tbxError;
        private System.Windows.Forms.Label lblPlayer2tbxError;
        private System.Windows.Forms.Label lblGoalScoretbxError;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label horizontalRule;
    }
}