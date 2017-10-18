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
    PlusMoins is a rather unforgiving and frustrating iArrayDice game. 
    It involves five iArrayDice, and permits the player a certain amount of judgement, 
    but luck also plays a very big part. There are two players, 
    each of whom is trying to reach an agreed total.
 */

namespace WillBallingerBrockButtsworthAssgt.Forms
{
    public partial class welcomeScreen : Form
    {
        private Player player1;
        private Player player2;
        private Int32 iGameScore;
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
            string sPlayerName = tbxPlayer1Name.Text;
            string sPlayerName2 = tbxPlayer2Name.Text;
            if (!int.TryParse(tbxGoalScore.Text, out Int32 parsedValue))
            {
                MessageBox.Show("Enter The Goal Score");
                return;
            }
            iGameScore = Convert.ToInt32(tbxGoalScore.Text);
            //add validation that text box's are not blank
            player1 = new Player(sPlayerName);
            player2 = new Player(sPlayerName2);
            Form form2 = new GameScreen(player1, player2,iGameScore);
            form2.StartPosition = FormStartPosition.CenterParent;
            this.Hide();
            form2.ShowDialog();
        }

        private void refresh()
        {
            // Refresh if 1VCPU selected make player 2 options invisible.
            // Else make visible
        }

        //
        private void tbxGoalScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar)&& e.KeyChar != '\b';
        }

        private void tbxGoalScore_MouseClick(object sender, MouseEventArgs e)
        {
            tbxGoalScore.Text = "";
        }

        private void tbxPlayer2Name_MouseClick(object sender, MouseEventArgs e)
        {
            tbxPlayer2Name.Text = "";
        }

        private void tbxPlayer1Name_MouseClick(object sender, MouseEventArgs e)
        {
            tbxPlayer1Name.Text = "";
        }

        private void btn1Vs1_Click(object sender, EventArgs e)
        {
            if (cbx1v1.Checked == true)
            {
                cbx1v1.Checked = false;
            }
            else
            {
                cbx1v1.Checked = true;
            }
        }

        private void btn1vsCPU_Click(object sender, EventArgs e)
        {
            if (cbx1vCPU.Checked == true)
            {
                cbx1vCPU.Checked = false;
            }
            else
            {
                cbx1vCPU.Checked = true;
            }
        }
    }
}
