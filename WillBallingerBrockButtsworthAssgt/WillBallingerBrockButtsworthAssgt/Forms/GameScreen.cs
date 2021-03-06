﻿using System;
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
    PlusMoins is a rather unforgiving and frustrating iArrayDice game. 
    It involves five iArrayDice, and permits the player a certain amount of judgement, 
    but luck also plays a very big part. There are two players, 
    each of whom is trying to reach an agreed total.
 */
namespace WillBallingerBrockButtsworthAssgt.Forms

{
    public partial class GameScreen : Form
    {
        Game player1Game = new Game(1, "Human", true);
        Game player2Game = new Game(2, "Human", false);
        Player player1;
        Player player2;
        Int32 iGoalScore;
        Graphics graPaper;
        public GameScreen(Player tempPlayer1, Player tempPlayer2, Int32 tempGoalScore)
        {
            InitializeComponent();
            player1= tempPlayer1;
            Int32 iTempPlayerID = player1.getPlayerID();
            player2 = tempPlayer2;
            Int32 iTempPlayerID2 = player2.getPlayerID();
            iGoalScore = tempGoalScore;
            refresh();
        }
        public void refresh()
        {
            if(player1Game.getTotalScore()==iGoalScore)
            {
                //Player 1 Won
                Form form3 = new WinScreen(player1);
                form3.StartPosition = FormStartPosition.CenterParent;
                this.Hide();
                form3.ShowDialog();
            }
            if (player2Game.getTotalScore() == iGoalScore)
            {
                //Player 2 Won
                Form form3 = new WinScreen(player2);
                form3.StartPosition = FormStartPosition.CenterParent;
                this.Hide();
                form3.ShowDialog();
            }
            //Player1
            lblPlayer1Name.Text = player1.getPlayerName();
            lblPlayer1TotalScore.Text = player1Game.getTotalScore().ToString();
            lblTargetScore.Text = iGoalScore.ToString();
            //Add Label Updates for Player1's Current Roll Labels
            lblResult5OfAKind.Text = player1Game.fiveOfAKind().ToString() + " Points";
            lblResult4OfAKind.Text = player1Game.fourOfAKind().ToString() + " Points";
            lblResult3OfAKind.Text = player1Game.threeOfAKind().ToString() + " Points";
            lblResult5InARow.Text = player1Game.fiveInARow().ToString() + " Points";
            lblResult4InARow.Text = player1Game.fourInARow().ToString() + " Points";
            lblResult3InARow.Text = player1Game.threeInARow().ToString() + " Points";
            if (player1Game.isEvenNotOdd())
            {
                lblResultOddorEven.Text = "Even and is Added";
            }
            if (player1Game.getCurrentTurn())
            {
                pbxPlayer1Background.BackColor = Color.LightSeaGreen;
                //Current Player
                lblTurnResult.Text = player1Game.getTurn().ToString();
                lblRollsRemaingResult.Text = player1Game.getRoll().ToString();
                if (player1Game.getRoll() == 3)
                {
                    btnRoll.Visible = true;
                    btnSaveScore.Visible = false;
                    lblResult5OfAKind.Visible = false;
                    lblResult4OfAKind.Visible = false;
                    lblResult3OfAKind.Visible = false;
                    lblResult5InARow.Visible = false;
                    lblResult4InARow.Visible = false;
                    lblResult3InARow.Visible = false;
                    lblResultOddorEven.Visible = false;
                    lbl5OfAKind.Visible = false;
                    lbl4OfAKind.Visible = false;
                    lbl3OfAKind.Visible = false;
                    lbl5InARow.Visible = false;
                    lbl4InARow.Visible = false;
                    lbl3InARow.Visible = false;
                    lblOddorEven.Visible = false;
                }
                else if (player1Game.getRoll() == 0)
                {
                    btnRoll.Visible = false;
                    btnSaveScore.Visible = true;
                    lblResult5OfAKind.Visible = true;
                    lblResult4OfAKind.Visible = true;
                    lblResult3OfAKind.Visible = true;
                    lblResult5InARow.Visible = true;
                    lblResult4InARow.Visible = true;
                    lblResult3InARow.Visible = true;
                    lblResultOddorEven.Visible = true;
                    lbl5OfAKind.Visible = true;
                    lbl4OfAKind.Visible = true;
                    lbl3OfAKind.Visible = true;
                    lbl5InARow.Visible = true;
                    lbl4InARow.Visible = true;
                    lbl3InARow.Visible = true;
                    lblOddorEven.Visible = true;
                }
                else
                {
                    btnRoll.Visible = true;
                    btnSaveScore.Visible = true;
                    lblResult5OfAKind.Visible = true;
                    lblResult4OfAKind.Visible = true;
                    lblResult3OfAKind.Visible = true;
                    lblResult5InARow.Visible = true;
                    lblResult4InARow.Visible = true;
                    lblResult3InARow.Visible = true;
                    lblResultOddorEven.Visible = true;
                    lbl5OfAKind.Visible = true;
                    lbl4OfAKind.Visible = true;
                    lbl3OfAKind.Visible = true;
                    lbl5InARow.Visible = true;
                    lbl4InARow.Visible = true;
                    lbl3InARow.Visible = true;
                    lblOddorEven.Visible = true;
                }
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
                //Add Label Updates for Player2's Current Roll Labels
                lblResult5OfAKind.Text = player2Game.fiveOfAKind().ToString() + " Points";
                lblResult4OfAKind.Text = player2Game.fourOfAKind().ToString() + " Points";
                lblResult3OfAKind.Text = player2Game.threeOfAKind().ToString() + " Points";
                lblResult5InARow.Text = player2Game.fiveInARow().ToString() + " Points";
                lblResult4InARow.Text = player2Game.fourInARow().ToString() + " Points";
                lblResult3InARow.Text = player2Game.threeInARow().ToString() + " Points";
                if (player2Game.isEvenNotOdd())
                {
                    lblResultOddorEven.Text = "Even and is Added";
                }
                else
                {
                    lblResultOddorEven.Text = "Odd and is Subtracted";
                }
                if (player2Game.getRoll() == 3)
                {
                    btnRoll.Visible = true;
                    btnSaveScore.Visible = false;
                    lblResult5OfAKind.Visible = false;
                    lblResult4OfAKind.Visible = false;
                    lblResult3OfAKind.Visible = false;
                    lblResult5InARow.Visible = false;
                    lblResult4InARow.Visible = false;
                    lblResult3InARow.Visible = false;
                    lblResultOddorEven.Visible = false;
                    lbl5OfAKind.Visible = false;
                    lbl4OfAKind.Visible = false;
                    lbl3OfAKind.Visible = false;
                    lbl5InARow.Visible = false;
                    lbl4InARow.Visible = false;
                    lbl3InARow.Visible = false;
                    lblOddorEven.Visible = false;
                }
                else if (player2Game.getRoll() == 0)
                {
                    btnRoll.Visible = false;
                    btnSaveScore.Visible = true;
                    lblResult5OfAKind.Visible = true;
                    lblResult4OfAKind.Visible = true;
                    lblResult3OfAKind.Visible = true;
                    lblResult5InARow.Visible = true;
                    lblResult4InARow.Visible = true;
                    lblResult3InARow.Visible = true;
                    lblResultOddorEven.Visible = true;
                    lbl5OfAKind.Visible = true;
                    lbl4OfAKind.Visible = true;
                    lbl3OfAKind.Visible = true;
                    lbl5InARow.Visible = true;
                    lbl4InARow.Visible = true;
                    lbl3InARow.Visible = true;
                    lblOddorEven.Visible = true;
                }
                else
                {
                    btnRoll.Visible = true;
                    btnSaveScore.Visible = true;
                    lblResult5OfAKind.Visible = true;
                    lblResult4OfAKind.Visible = true;
                    lblResult3OfAKind.Visible = true;
                    lblResult5InARow.Visible = true;
                    lblResult4InARow.Visible = true;
                    lblResult3InARow.Visible = true;
                    lblResultOddorEven.Visible = true;
                    lbl5OfAKind.Visible = true;
                    lbl4OfAKind.Visible = true;
                    lbl3OfAKind.Visible = true;
                    lbl5InARow.Visible = true;
                    lbl4InARow.Visible = true;
                    lbl3InARow.Visible = true;
                    lblOddorEven.Visible = true;
                }
            }
            else
            {
                pbxPlayer2Background.BackColor = Color.OrangeRed;
            }
        }

        private void rollDice(Graphics graTempCanvas, int iDiceIndex, int ixValue, int iyValue)
        {
            int iTempX = ixValue;
            int iTtempY = iyValue;
            Random ranNumber = new Random();
            int iRollValue = ranNumber.Next(1, 7);
            //iArrayDice % Convert.ToInt32(ranNumber);
            //txbCurrentRoll.Text = Convert.ToString(iRollValue);
            //totalRolls = totalRolls + iRollValue;
            //String appendValue = Convert.ToString(totalRolls) + "\n\r";
            //txbTotalRoll.AppendText(String.Format("{0:d} {1:d}\n\r"), loopValue, appendValue);
            //txbTotalRoll.Text = (appendValue);
            //Adds the iRoll to the array.
            if (player1Game.getCurrentTurn())
            {
                player1Game.setDice(iDiceIndex, iRollValue);
            }
            else
            {
                player2Game.setDice(iDiceIndex, iRollValue);
            }
            
            //Used to Draw the Dice that was Rolled.
            switch (iRollValue)
            {
                case 1:
                    roll1(graTempCanvas, iTempX, iTtempY);
                    break;
                case 2:
                    roll2(graTempCanvas, iTempX, iTtempY);
                    break;
                case 3:
                    roll3(graTempCanvas, iTempX, iTtempY);
                    break;
                case 4:
                    roll4(graTempCanvas, iTempX, iTtempY);
                    break;
                case 5:
                    roll5(graTempCanvas, iTempX, iTtempY);
                    break;
                case 6:
                    roll6(graTempCanvas, iTempX, iTtempY);
                    break;
            }
        }

        //Used to Create a Dice Displaying a square with 1 dot
        private void roll1(Graphics graTempCanvas, int iTempX, int iTempY)
        {
            centreDot(graTempCanvas, iTempX, iTempY);
        }

        //Used to Create a Dice Displaying a square with 2 dots
        private void roll2(Graphics graTempCanvas, int iTempX, int iTempY)
        {
            thirdDot(graTempCanvas, iTempX, iTempY);
            sixthDot(graTempCanvas, iTempX, iTempY);
        }

        //Used to Create a Dice Displaying a square with 3 dots
        private void roll3(Graphics graTempCanvas, int iTempX, int iTempY)
        {
            thirdDot(graTempCanvas, iTempX, iTempY);
            centreDot(graTempCanvas, iTempX, iTempY);
            sixthDot(graTempCanvas, iTempX, iTempY);
        }

        //Used to Create a Dice Displaying a square with 4 dots
        private void roll4(Graphics graTempCanvas, int iTempX, int iTempY)
        {
            firstDot(graTempCanvas, iTempX, iTempY);
            thirdDot(graTempCanvas, iTempX, iTempY);
            fourthDot(graTempCanvas, iTempX, iTempY);
            sixthDot(graTempCanvas, iTempX, iTempY);
        }

        //Used to Create a Dice Displaying a square with 5 dots
        private void roll5(Graphics graTempCanvas, int iTempX, int iTempY)
        {
            firstDot(graTempCanvas, iTempX, iTempY);
            thirdDot(graTempCanvas, iTempX, iTempY);
            centreDot(graTempCanvas, iTempX, iTempY);
            fourthDot(graTempCanvas, iTempX, iTempY);
            sixthDot(graTempCanvas, iTempX, iTempY);
        }

        //Used to Create a Dice Displaying a square with 6 dots
        private void roll6(Graphics graTempCanvas, int iTempX, int iTempY)
        {
            firstDot(graTempCanvas, iTempX, iTempY);
            secondDot(graTempCanvas, iTempX, iTempY);
            thirdDot(graTempCanvas, iTempX, iTempY);
            fourthDot(graTempCanvas, iTempX, iTempY);
            fifthDot(graTempCanvas, iTempX, iTempY);
            sixthDot(graTempCanvas, iTempX, iTempY);
        }

        //Uses the target (X,Y) to draws a rectangle from that spot.
        private void drawBox(Graphics graTempCanvas, int iTargetX, int iTargetY)
        {
            graTempCanvas.FillRectangle(Brushes.Black, iTargetX, iTargetY, 75, 75);
        }

        //Uses the target (X,Y) to draws a dot from that spot.
        private void centreDot(Graphics graTempCanvas, int iTargetX, int iTargetY)
        {
            int iTempTargetX = iTargetX + 32;
            int iTempTargetY = iTargetY + 32;
            graTempCanvas.FillEllipse(Brushes.White, iTempTargetX, iTempTargetY, 10, 10);
        }

        //Uses the target (X,Y) to draws a dot from that spot.
        private void firstDot(Graphics graTempCanvas, int iTargetX, int iTargetY)
        {
            int iTempTargetX = iTargetX + 17;
            int iTempTargetY = iTargetY + 17;
            graTempCanvas.FillEllipse(Brushes.White, iTempTargetX, iTempTargetY, 10, 10);
        }

        //Uses the target (X,Y) to draws a dot from that spot.
        private void secondDot(Graphics graTempCanvas, int iTargetX, int iTargetY)
        {
            int iTempTargetX = iTargetX + 17;
            int iTempTargetY = iTargetY + 32;
            graTempCanvas.FillEllipse(Brushes.White, iTempTargetX, iTempTargetY, 10, 10);
        }

        //Uses the target (X,Y) to draws a dot from that spot.
        private void thirdDot(Graphics graTempCanvas, int iTargetX, int iTargetY)
        {
            int iTempTargetX = iTargetX + 17;
            int iTempTargetY = iTargetY + 50;
            graTempCanvas.FillEllipse(Brushes.White, iTempTargetX, iTempTargetY, 10, 10);
        }

        //Uses the target (X,Y) to draws a dot from that spot.
        private void fourthDot(Graphics graTempCanvas, int iTargetX, int iTargetY)
        {
            int iTempTargetX = iTargetX + 50;
            int iTempTargetY = iTargetY + 50;
            graTempCanvas.FillEllipse(Brushes.White, iTempTargetX, iTempTargetY, 10, 10);
        }

        //Uses the target (X,Y) to draws a dot from that spot.
        private void fifthDot(Graphics graTempCanvas, int iTargetX, int iTargetY)
        {
            int iTempTargetX = iTargetX + 50;
            int iTempTargetY = iTargetY + 32;
            graTempCanvas.FillEllipse(Brushes.White, iTempTargetX, iTempTargetY, 10, 10);
        }

        //Uses the target (X,Y) to draws a dot from that spot.
        private void sixthDot(Graphics graTempCanvas, int iTargetX, int iTargetY)
        {
            int iTempTargetX = iTargetX + 50;
            int iTempTargetY = iTargetY + 17;
            graTempCanvas.FillEllipse(Brushes.White, iTempTargetX, iTempTargetY, 10, 10);
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            graPaper = graPicbxDrawing.CreateGraphics();
            //totalRolls = 0;
            int iNumberOfRolls = 3;
            int iTempX = 10;
            int iTempY = 10;
            int iJ = 1;
            if ((player1Game.getRoll() != 0) && (player2Game.getRoll() != 0))
            {
                if (ckbHoldDice1.Checked != true)
                {
                    //Draws First Dice
                    for (int i = 0; i < iNumberOfRolls; i++)
                    {
                        drawBox(graPaper, iTempX, iTempY);
                        rollDice(graPaper, iJ, iTempX, iTempY);
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(500);
                    }
                }
                iJ++;
                if (ckbHoldDice2.Checked != true)
                {
                    //Draws Second Dice
                    iTempX = 110;
                    iTempY = 10;
                    for (int i = 0; i < iNumberOfRolls; i++)
                    {
                        drawBox(graPaper, iTempX, iTempY);
                        rollDice(graPaper, iJ, iTempX, iTempY);
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(500);
                    }
                }
                iJ++;
                if (ckbHoldDice3.Checked != true)
                {
                    //Draws Third Dice
                    iTempX = 210;
                    iTempY = 10;
                    for (int i = 0; i < iNumberOfRolls; i++)
                    {
                        drawBox(graPaper, iTempX, iTempY);
                        rollDice(graPaper, iJ, iTempX, iTempY);
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(500);
                    }
                }
                iJ++;
                if (ckbHoldDice4.Checked != true)
                {
                    //Draws Fourth Dice
                    iTempX = 310;
                    iTempY = 10;
                    for (int i = 0; i < iNumberOfRolls; i++)
                    {
                        drawBox(graPaper, iTempX, iTempY);
                        rollDice(graPaper, iJ, iTempX, iTempY);
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(500);
                    }
                }
                iJ++;
                if (ckbHoldDice5.Checked != true)
                {
                    //Draws Fifth Dice
                    if (ckbHoldDice5.Checked != true)
                    {
                        iTempX = 410;
                        iTempY = 10;
                        for (int i = 0; i < iNumberOfRolls; i++)
                        {
                            drawBox(graPaper, iTempX, iTempY);
                            rollDice(graPaper, iJ, iTempX, iTempY);
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
                    player1Game.setTotalScore();
                }
                else
                {
                    player2Game.setTotalScore();
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
                    graPaper.Clear(Color.Gainsboro);
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
                    graPaper.Clear(Color.Gainsboro);
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
            graPaper = graPicbxDrawing.CreateGraphics();
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
            graPaper = graPicbxDrawing.CreateGraphics();
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
            graPaper = graPicbxDrawing.CreateGraphics();
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
            graPaper = graPicbxDrawing.CreateGraphics();
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
            graPaper = graPicbxDrawing.CreateGraphics();
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

        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            if (player1Game.getCurrentTurn())
            {
                player1Game.setTotalScore();
                player1Game.setRoll(3);
                player1Game.nextTurn();
                player1Game.setCurrentTurn(false);
                player2Game.setCurrentTurn(true);
                graPaper.Clear(Color.Gainsboro);
                ckbHoldDice1.Checked = false;
                ckbHoldDice2.Checked = false;
                ckbHoldDice3.Checked = false;
                ckbHoldDice4.Checked = false;
                ckbHoldDice5.Checked = false;
            }
            else //player2 
            {
                player2Game.setTotalScore();
                player2Game.setRoll(3);
                player2Game.nextTurn();
                player2Game.setCurrentTurn(false);
                player1Game.setCurrentTurn(true);
                graPaper.Clear(Color.Gainsboro);
                ckbHoldDice1.Checked = false;
                ckbHoldDice2.Checked = false;
                ckbHoldDice3.Checked = false;
                ckbHoldDice4.Checked = false;
                ckbHoldDice5.Checked = false;
            }
            refresh();
        }

        private void btnGameRules_Click(object sender, EventArgs e)
        {
            Form form = new Game_Rules();
            form.StartPosition = FormStartPosition.CenterParent;
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
