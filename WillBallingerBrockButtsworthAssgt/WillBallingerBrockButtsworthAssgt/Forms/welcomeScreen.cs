using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WillBallingerBrockButtsworthAssgt;
/*
-INFT2012 - Assignment 1 - Plus Mois
-Authors Brock Buttsworth and Will Ballinger.
-Created 5/10/2017
-Brief Description :
    PlusMoins is a rather unforgiving and frustrating dice game. 
    It involves five dice, and permits the player a certain amount of judgement, 
    but luck also plays a very big part. There are two players, 
    each of whom is trying to reach an agreed total.
 */

namespace WillBallingerBrockButtsworthAssgt.Forms
{
    public partial class welcomeScreen : Form
    {
        Player player1;
        Player player2;
        public welcomeScreen()
        {
            InitializeComponent();
            
        }

        private void btnGameRules_Click(object sender, EventArgs e)
        {
            Form form = new Game_Rules();
            form.StartPosition = FormStartPosition.CenterParent;
            form.Show();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            string playerName = tbxPlayer1Name.Text;
            string playerName2 = tbxPlayer2Name.Text;
            player1 = new Player(playerName);
            player2 = new Player(playerName2);
            Form form2 = new GameScreen(player1, player2);
            form2.StartPosition = FormStartPosition.CenterParent;
            this.Hide();
            form2.ShowDialog();
        }
    }
}
