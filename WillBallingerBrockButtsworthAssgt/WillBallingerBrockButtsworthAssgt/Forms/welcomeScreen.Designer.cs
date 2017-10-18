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
            this.btnGameRules = new System.Windows.Forms.Button();
            this.lblGameMode = new System.Windows.Forms.Label();
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
            this.horizontalRule = new System.Windows.Forms.Label();
            this.btn1Vs1 = new System.Windows.Forms.Button();
            this.btn1vsCPU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGameRules
            // 
            this.btnGameRules.BackColor = System.Drawing.Color.Gold;
            this.btnGameRules.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblGameMode.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameMode.Location = new System.Drawing.Point(262, 151);
            this.lblGameMode.Name = "lblGameMode";
            this.lblGameMode.Size = new System.Drawing.Size(159, 30);
            this.lblGameMode.TabIndex = 4;
            this.lblGameMode.Text = "Game Mode:";
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1Name.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Name.Location = new System.Drawing.Point(154, 330);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(126, 30);
            this.lblPlayer1Name.TabIndex = 7;
            this.lblPlayer1Name.Text = "Player 1:";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(372, 330);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(127, 30);
            this.lblPlayer2.TabIndex = 8;
            this.lblPlayer2.Text = "Player 2:";
            // 
            // tbxPlayer1Name
            // 
            this.tbxPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPlayer1Name.Location = new System.Drawing.Point(148, 365);
            this.tbxPlayer1Name.Name = "tbxPlayer1Name";
            this.tbxPlayer1Name.Size = new System.Drawing.Size(138, 28);
            this.tbxPlayer1Name.TabIndex = 9;
            this.tbxPlayer1Name.Text = "Player 1 Name";
            this.tbxPlayer1Name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxPlayer1Name_MouseClick);
            // 
            // tbxPlayer2Name
            // 
            this.tbxPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPlayer2Name.Location = new System.Drawing.Point(362, 365);
            this.tbxPlayer2Name.Name = "tbxPlayer2Name";
            this.tbxPlayer2Name.Size = new System.Drawing.Size(146, 28);
            this.tbxPlayer2Name.TabIndex = 10;
            this.tbxPlayer2Name.Text = "Player 2 Name";
            this.tbxPlayer2Name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxPlayer2Name_MouseClick);
            // 
            // lblGoalScore
            // 
            this.lblGoalScore.AutoSize = true;
            this.lblGoalScore.BackColor = System.Drawing.Color.Transparent;
            this.lblGoalScore.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalScore.Location = new System.Drawing.Point(190, 440);
            this.lblGoalScore.Name = "lblGoalScore";
            this.lblGoalScore.Size = new System.Drawing.Size(340, 30);
            this.lblGoalScore.TabIndex = 11;
            this.lblGoalScore.Text = "What is your goal score?";
            // 
            // tbxGoalScore
            // 
            this.tbxGoalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGoalScore.Location = new System.Drawing.Point(190, 475);
            this.tbxGoalScore.Name = "tbxGoalScore";
            this.tbxGoalScore.Size = new System.Drawing.Size(220, 28);
            this.tbxGoalScore.TabIndex = 12;
            this.tbxGoalScore.Text = "Enter Goal Score";
            this.tbxGoalScore.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxGoalScore_MouseClick);
            this.tbxGoalScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxGoalScore_KeyPress);
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Gold;
            this.btnStartGame.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbx1v1.Location = new System.Drawing.Point(211, 220);
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
            this.cbx1vCPU.Location = new System.Drawing.Point(420, 220);
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
            this.lblPlayer1tbxError.ForeColor = System.Drawing.Color.Red;
            this.lblPlayer1tbxError.Location = new System.Drawing.Point(292, 365);
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
            this.lblPlayer2tbxError.ForeColor = System.Drawing.Color.Red;
            this.lblPlayer2tbxError.Location = new System.Drawing.Point(514, 365);
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
            this.lblGoalScoretbxError.ForeColor = System.Drawing.Color.Red;
            this.lblGoalScoretbxError.Location = new System.Drawing.Point(497, 422);
            this.lblGoalScoretbxError.Name = "lblGoalScoretbxError";
            this.lblGoalScoretbxError.Size = new System.Drawing.Size(23, 29);
            this.lblGoalScoretbxError.TabIndex = 19;
            this.lblGoalScoretbxError.Text = "*";
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
            // btn1Vs1
            // 
            this.btn1Vs1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1Vs1.BackColor = System.Drawing.Color.Gold;
            this.btn1Vs1.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Vs1.Location = new System.Drawing.Point(132, 255);
            this.btn1Vs1.Name = "btn1Vs1";
            this.btn1Vs1.Size = new System.Drawing.Size(170, 45);
            this.btn1Vs1.TabIndex = 20;
            this.btn1Vs1.Text = "1 Vs 1";
            this.btn1Vs1.UseVisualStyleBackColor = false;
            this.btn1Vs1.Click += new System.EventHandler(this.btn1Vs1_Click);
            // 
            // btn1vsCPU
            // 
            this.btn1vsCPU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1vsCPU.BackColor = System.Drawing.Color.Gold;
            this.btn1vsCPU.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1vsCPU.Location = new System.Drawing.Point(350, 255);
            this.btn1vsCPU.Name = "btn1vsCPU";
            this.btn1vsCPU.Size = new System.Drawing.Size(170, 45);
            this.btn1vsCPU.TabIndex = 21;
            this.btn1vsCPU.Text = "1 Vs CPU";
            this.btn1vsCPU.UseVisualStyleBackColor = false;
            this.btn1vsCPU.Click += new System.EventHandler(this.btn1vsCPU_Click);
            // 
            // welcomeScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::WillBallingerBrockButtsworthAssgt.Properties.Resources.GameScreenBackground2;
            this.ClientSize = new System.Drawing.Size(1378, 644);
            this.ControlBox = false;
            this.Controls.Add(this.btn1vsCPU);
            this.Controls.Add(this.btn1Vs1);
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
            this.Controls.Add(this.lblGameMode);
            this.Controls.Add(this.btnGameRules);
            this.Name = "welcomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plus Moins";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGameRules;
        private System.Windows.Forms.Label lblGameMode;
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
        private System.Windows.Forms.Label horizontalRule;
        private System.Windows.Forms.Button btn1Vs1;
        private System.Windows.Forms.Button btn1vsCPU;
    }
}