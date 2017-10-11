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
-Created 20/9/2017
-Brief Description :
    PlusMoins is a rather unforgiving and frustrating dice game. 
    It involves five dice, and permits the player a certain amount of judgement, 
    but luck also plays a very big part. There are two players, 
    each of whom is trying to reach an agreed total.
 */
namespace WillBallingerBrockButtsworthAssgt.Forms

{
    public partial class GameScreen : Form
    {
        int totalRolls = 0;
        Game player1Game = new Game(1, "Human", true);
        Game player2Game = new Game(2, "Human", false);
        Player player1;
        Player player2;
        Graphics graPaper;
        public GameScreen(Player tempPlayer1, Player tempPlayer2)
        {
            InitializeComponent();
            player1= tempPlayer1;
            Int32 tempPlayerID = player1.getPlayerID();
            player2 = tempPlayer2;
            Int32 tempPlayerID2 = player2.getPlayerID();
            refresh();
        }
        public void refresh()
        {
            //Player1
            lblPlayer1Name.Text = player1.getPlayerName();
            lblPlayer1TotalScore.Text = player1Game.getTotalScore().ToString();
            if(player1Game.getCurrentTurn())
            {
                pbxPlayer1Background.BackColor = Color.LightSeaGreen;
                //Current Player
                lblTurnResult.Text = player1Game.getTurn().ToString();
                lblRollsRemaingResult.Text = player1Game.getRoll().ToString();
            }
            else
            {
                pbxPlayer1Background.BackColor = Color.OrangeRed;
            }
            //Player 2
            lblPlayer2Name.Text = player2.getPlayerName();
            lblPlayer2TotalScore.Text = player2Game.getTotalScore().ToString();
            if (player2Game.getCurrentTurn())
            {
                pbxPlayer2Background.BackColor = Color.LightSeaGreen;
                //Current Player
                lblTurnResult.Text = player2Game.getTurn().ToString();
                lblRollsRemaingResult.Text = player2Game.getRoll().ToString();
            }
            else
            {
                pbxPlayer2Background.BackColor = Color.OrangeRed;
            }
        }

        private void rollDice(Graphics tempCanvas, int diceIndex, int xValue, int yValue)
        {
            int tempX = xValue;
            int tempY = yValue;
            Random number = new Random();
            int rollValue = number.Next(1, 7);
            //dice % Convert.ToInt32(number);
            //txbCurrentRoll.Text = Convert.ToString(rollValue);
            //totalRolls = totalRolls + rollValue;
            //String appendValue = Convert.ToString(totalRolls) + "\n\r";
            //txbTotalRoll.AppendText(String.Format("{0:d} {1:d}\n\r"), loopValue, appendValue);
            //txbTotalRoll.Text = (appendValue);
            //Adds the roll to the array.
            if (player1Game.getCurrentTurn())
            {
                player1Game.setDice(diceIndex, rollValue);
            }
            else
            {
                player2Game.setDice(diceIndex, rollValue);
            }
            
            //Used to Draw the Dice that was Rolled.
            switch (rollValue)
            {
                case 1:
                    roll1(tempCanvas, tempX, tempY);
                    break;
                case 2:
                    roll2(tempCanvas, tempX, tempY);
                    break;
                case 3:
                    roll3(tempCanvas, tempX, tempY);
                    break;
                case 4:
                    roll4(tempCanvas, tempX, tempY);
                    break;
                case 5:
                    roll5(tempCanvas, tempX, tempY);
                    break;
                case 6:
                    roll6(tempCanvas, tempX, tempY);
                    break;
            }
        }

        //Used to Create a Dice Displaying a square with 1 dot
        private void roll1(Graphics tempCanvas, int tempX, int tempY)
        {
            centreDot(tempCanvas, tempX, tempY);
        }

        //Used to Create a Dice Displaying a square with 2 dots
        private void roll2(Graphics tempCanvas, int tempX, int tempY)
        {
            thirdDot(tempCanvas, tempX, tempY);
            sixthDot(tempCanvas, tempX, tempY);
        }

        //Used to Create a Dice Displaying a square with 3 dots
        private void roll3(Graphics tempCanvas, int tempX, int tempY)
        {
            thirdDot(tempCanvas, tempX, tempY);
            centreDot(tempCanvas, tempX, tempY);
            sixthDot(tempCanvas, tempX, tempY);
        }

        //Used to Create a Dice Displaying a square with 4 dots
        private void roll4(Graphics tempCanvas, int tempX, int tempY)
        {
            firstDot(tempCanvas, tempX, tempY);
            thirdDot(tempCanvas, tempX, tempY);
            fourthDot(tempCanvas, tempX, tempY);
            sixthDot(tempCanvas, tempX, tempY);
        }

        //Used to Create a Dice Displaying a square with 5 dots
        private void roll5(Graphics tempCanvas, int tempX, int tempY)
        {
            firstDot(tempCanvas, tempX, tempY);
            thirdDot(tempCanvas, tempX, tempY);
            centreDot(tempCanvas, tempX, tempY);
            fourthDot(tempCanvas, tempX, tempY);
            sixthDot(tempCanvas, tempX, tempY);
        }

        //Used to Create a Dice Displaying a square with 6 dots
        private void roll6(Graphics tempCanvas, int tempX, int tempY)
        {
            firstDot(tempCanvas, tempX, tempY);
            secondDot(tempCanvas, tempX, tempY);
            thirdDot(tempCanvas, tempX, tempY);
            fourthDot(tempCanvas, tempX, tempY);
            fifthDot(tempCanvas, tempX, tempY);
            sixthDot(tempCanvas, tempX, tempY);
        }

        //Uses the target (X,Y) to draws a rectangle from that spot.
        private void drawBox(Graphics tempCanvas, int targetX, int targetY)
        {
            tempCanvas.FillRectangle(Brushes.Black, targetX, targetY, 75, 75);
        }

        //Uses the target (X,Y) to draws a dot from that spot.
        private void centreDot(Graphics tempCanvas, int targetX, int targetY)
        {
            int tempTargetX = targetX + 32;
            int tempTargetY = targetY + 32;
            tempCanvas.FillEllipse(Brushes.White, tempTargetX, tempTargetY, 10, 10);
        }

        //Uses the target (X,Y) to draws a dot from that spot.
        private void firstDot(Graphics tempCanvas, int targetX, int targetY)
        {
            int tempTargetX = targetX + 17;
            int tempTargetY = targetY + 17;
            tempCanvas.FillEllipse(Brushes.White, tempTargetX, tempTargetY, 10, 10);
        }

        //Uses the target (X,Y) to draws a dot from that spot.
        private void secondDot(Graphics tempCanvas, int targetX, int targetY)
        {
            int tempTargetX = targetX + 17;
            int tempTargetY = targetY + 32;
            tempCanvas.FillEllipse(Brushes.White, tempTargetX, tempTargetY, 10, 10);
        }

        //Uses the target (X,Y) to draws a dot from that spot.
        private void thirdDot(Graphics tempCanvas, int targetX, int targetY)
        {
            int tempTargetX = targetX + 17;
            int tempTargetY = targetY + 50;
            tempCanvas.FillEllipse(Brushes.White, tempTargetX, tempTargetY, 10, 10);
        }

        //Uses the target (X,Y) to draws a dot from that spot.
        private void fourthDot(Graphics tempCanvas, int targetX, int targetY)
        {
            int tempTargetX = targetX + 50;
            int tempTargetY = targetY + 50;
            tempCanvas.FillEllipse(Brushes.White, tempTargetX, tempTargetY, 10, 10);
        }

        //Uses the target (X,Y) to draws a dot from that spot.
        private void fifthDot(Graphics tempCanvas, int targetX, int targetY)
        {
            int tempTargetX = targetX + 50;
            int tempTargetY = targetY + 32;
            tempCanvas.FillEllipse(Brushes.White, tempTargetX, tempTargetY, 10, 10);
        }

        //Uses the target (X,Y) to draws a dot from that spot.
        private void sixthDot(Graphics tempCanvas, int targetX, int targetY)
        {
            int tempTargetX = targetX + 50;
            int tempTargetY = targetY + 17;
            tempCanvas.FillEllipse(Brushes.White, tempTargetX, tempTargetY, 10, 10);
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            graPaper = picbxDrawing.CreateGraphics();

            totalRolls = 0;
            int numberOfRolls = 3;
            int tempX = 10;
            int tempY = 10;
            int j = 1;
            if ((player1Game.getRoll() != 0) && (player2Game.getRoll() != 0))
            {
                if (ckbHoldDice1.Checked != true)
                {
                    //Draws First Dice
                    for (int i = 0; i < numberOfRolls; i++)
                    {
                        drawBox(graPaper, tempX, tempY);
                        rollDice(graPaper, j, tempX, tempY);
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(500);
                    }
                }
                j++;
                if (ckbHoldDice2.Checked != true)
                {
                    //Draws Second Dice
                    tempX = 110;
                    tempY = 10;
                    for (int i = 0; i < numberOfRolls; i++)
                    {
                        drawBox(graPaper, tempX, tempY);
                        rollDice(graPaper, j, tempX, tempY);
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(500);
                    }
                }
                j++;
                if (ckbHoldDice3.Checked != true)
                {

                    //Draws Third Dice
                    tempX = 210;
                    tempY = 10;
                    for (int i = 0; i < numberOfRolls; i++)
                    {
                        drawBox(graPaper, tempX, tempY);
                        rollDice(graPaper, j, tempX, tempY);
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(500);
                    }
                }
                j++;
                if (ckbHoldDice4.Checked != true)
                {
                    //Draws Fourth Dice
                    tempX = 310;
                    tempY = 10;
                    for (int i = 0; i < numberOfRolls; i++)
                    {
                        drawBox(graPaper, tempX, tempY);
                        rollDice(graPaper, j, tempX, tempY);
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(500);
                    }
                }
                j++;
                if (ckbHoldDice5.Checked != true)
                {
                    //Draws Fifth Dice
                    if (ckbHoldDice5.Checked != true)
                    {
                        tempX = 410;
                        tempY = 10;
                        for (int i = 0; i < numberOfRolls; i++)
                        {
                            drawBox(graPaper, tempX, tempY);
                            rollDice(graPaper, j, tempX, tempY);
                            Application.DoEvents();
                            System.Threading.Thread.Sleep(500);
                        }
                    }
                }
            }
            else
            {
                //SaveCurrentScore
                if (player1Game.getCurrentTurn())
                {
                    Int32 totalScore = player1Game.getTotalScore();
                    Int32 currentScore = player1Game.getCurrentScore();
                    totalScore = totalScore + currentScore;
                    player1Game.setTotalScore(totalScore);
                }
                else
                {
                    Int32 totalScore = player2Game.getTotalScore();
                    Int32 currentScore = player2Game.getCurrentScore();
                    totalScore = totalScore + currentScore;
                    player2Game.setTotalScore(totalScore);
                }
                    
            }
            if (player1Game.getCurrentTurn())
            {
                if (player1Game.getRoll() > 0)
                {
                    player1Game.nextRoll();
                }
                else
                {
                    player1Game.setRoll(3);
                    player1Game.nextTurn();
                    player1Game.setCurrentTurn(false);
                    player2Game.setCurrentTurn(true);
                    graPaper.Clear(Color.LightYellow);
                    ckbHoldDice1.Checked = false;
                    ckbHoldDice2.Checked = false;
                    ckbHoldDice3.Checked = false;
                    ckbHoldDice4.Checked = false;
                    ckbHoldDice5.Checked = false;
                }
            }
            else
            {
                if (player2Game.getRoll() > 0)
                {
                    player2Game.nextRoll();
                }
                else
                {
                    player2Game.setRoll(3);
                    player2Game.nextTurn();
                    player2Game.setCurrentTurn(false);
                    player1Game.setCurrentTurn(true);
                    graPaper.Clear(Color.LightYellow);
                    ckbHoldDice1.Checked = false;
                    ckbHoldDice2.Checked = false;
                    ckbHoldDice3.Checked = false;
                    ckbHoldDice4.Checked = false;
                    ckbHoldDice5.Checked = false;
                }
            }
            refresh();
        }

        //When Clicked if checkbox is checked=
        //  True: draws 4 rectangles forming a border the color of the background and unchecks checkbox.
        //  False: draws 4 Yellow rectangles forming a border and checks checkbox.
        private void btnHold1_Click(object sender, EventArgs e)
        {
            graPaper = picbxDrawing.CreateGraphics();
            if (ckbHoldDice1.Checked != true)
            {
                graPaper.FillRectangle(Brushes.Yellow, 5, 5, 85, 5);
                graPaper.FillRectangle(Brushes.Yellow, 5, 10, 5, 80);
                graPaper.FillRectangle(Brushes.Yellow, 10, 85, 80, 5);
                graPaper.FillRectangle(Brushes.Yellow, 85, 10, 5, 75);
                ckbHoldDice1.Checked = true;
            }
            else
            {
                graPaper.FillRectangle(Brushes.Gainsboro, 5, 5, 85, 5);
                graPaper.FillRectangle(Brushes.Gainsboro, 5, 10, 5, 80);
                graPaper.FillRectangle(Brushes.Gainsboro, 10, 85, 80, 5);
                graPaper.FillRectangle(Brushes.Gainsboro, 85, 10, 5, 75);
                ckbHoldDice1.Checked = false;
            }
        }

        //When Clicked if checkbox is checked=
        //  True: draws 4 rectangles forming a border the color of the background and unchecks checkbox.
        //  False: draws 4 Yellow rectangles forming a border and checks checkbox.
        private void btnHold2_Click(object sender, EventArgs e)
        {
            graPaper = picbxDrawing.CreateGraphics();
            if (ckbHoldDice2.Checked != true)
            {
                graPaper.FillRectangle(Brushes.Yellow, 105, 5, 85, 5);
                graPaper.FillRectangle(Brushes.Yellow, 105, 10, 5, 80);
                graPaper.FillRectangle(Brushes.Yellow, 110, 85, 80, 5);
                graPaper.FillRectangle(Brushes.Yellow, 185, 10, 5, 75);
                ckbHoldDice2.Checked = true;
            }
            else
            {
                graPaper.FillRectangle(Brushes.Gainsboro, 105, 5, 85, 5);
                graPaper.FillRectangle(Brushes.Gainsboro, 105, 10, 5, 80);
                graPaper.FillRectangle(Brushes.Gainsboro, 110, 85, 80, 5);
                graPaper.FillRectangle(Brushes.Gainsboro, 185, 10, 5, 75);
                ckbHoldDice2.Checked = false;
            }
        }

        //When Clicked if checkbox is checked=
        //  True: draws 4 rectangles forming a border the color of the background and unchecks checkbox.
        //  False: draws 4 Yellow rectangles forming a border and checks checkbox.
        private void btnHold3_Click(object sender, EventArgs e)
        {
            graPaper = picbxDrawing.CreateGraphics();
            if (ckbHoldDice3.Checked != true)
            {
                graPaper.FillRectangle(Brushes.Yellow, 205, 5, 85, 5);
                graPaper.FillRectangle(Brushes.Yellow, 205, 10, 5, 80);
                graPaper.FillRectangle(Brushes.Yellow, 210, 85, 80, 5);
                graPaper.FillRectangle(Brushes.Yellow, 285, 10, 5, 75);
                ckbHoldDice3.Checked = true;
            }
            else
            {
                graPaper.FillRectangle(Brushes.Gainsboro, 205, 5, 85, 5);
                graPaper.FillRectangle(Brushes.Gainsboro, 205, 10, 5, 80);
                graPaper.FillRectangle(Brushes.Gainsboro, 210, 85, 80, 5);
                graPaper.FillRectangle(Brushes.Gainsboro, 285, 10, 5, 75);
                ckbHoldDice3.Checked = false;
            }
        }

        //When Clicked if checkbox is checked=
        //  True: draws 4 rectangles forming a border the color of the background and unchecks checkbox.
        //  False: draws 4 Yellow rectangles forming a border and checks checkbox.
        private void btnHold4_Click(object sender, EventArgs e)
        {
            graPaper = picbxDrawing.CreateGraphics();
            if (ckbHoldDice4.Checked != true)
            {
                graPaper.FillRectangle(Brushes.Yellow, 305, 5, 85, 5);
                graPaper.FillRectangle(Brushes.Yellow, 305, 10, 5, 80);
                graPaper.FillRectangle(Brushes.Yellow, 310, 85, 80, 5);
                graPaper.FillRectangle(Brushes.Yellow, 385, 10, 5, 75);
                ckbHoldDice4.Checked = true;
            }
            else
            {
                graPaper.FillRectangle(Brushes.Gainsboro, 305, 5, 85, 5);
                graPaper.FillRectangle(Brushes.Gainsboro, 305, 10, 5, 80);
                graPaper.FillRectangle(Brushes.Gainsboro, 310, 85, 80, 5);
                graPaper.FillRectangle(Brushes.Gainsboro, 385, 10, 5, 75);
                ckbHoldDice4.Checked = false;
            }
        }
        
        //When Clicked if checkbox is checked=
        //  True: draws 4 rectangles forming a border the color of the background and unchecks checkbox.
        //  False: draws 4 Yellow rectangles forming a border and checks checkbox.
        private void btnHold5_Click(object sender, EventArgs e)
        {
            graPaper = picbxDrawing.CreateGraphics();
            if (ckbHoldDice5.Checked != true)
            {
                graPaper.FillRectangle(Brushes.Yellow, 405, 5, 85, 5);
                graPaper.FillRectangle(Brushes.Yellow, 405, 10, 5, 80);
                graPaper.FillRectangle(Brushes.Yellow, 410, 85, 80, 5);
                graPaper.FillRectangle(Brushes.Yellow, 485, 10, 5, 75);
                ckbHoldDice5.Checked = true;
            }
            else
            {
                graPaper.FillRectangle(Brushes.Gainsboro, 405, 5, 85, 5);
                graPaper.FillRectangle(Brushes.Gainsboro, 405, 10, 5, 80);
                graPaper.FillRectangle(Brushes.Gainsboro, 410, 85, 80, 5);
                graPaper.FillRectangle(Brushes.Gainsboro, 485, 10, 5, 75);
                ckbHoldDice5.Checked = false;
            }
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            lblTurnResult.Text = player1Game.getTurn().ToString();
            lblRollsRemaingResult.Text = player1Game.getRoll().ToString(); 
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Form form = new TestForm(player1Game, player1);
            form.StartPosition = FormStartPosition.CenterParent;
            form.Show();
        }

    }

}
