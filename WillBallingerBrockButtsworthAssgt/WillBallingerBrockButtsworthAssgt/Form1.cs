﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
namespace WillBallingerBrockButtsworthAssgt
{
    public partial class FormGameScreen : Form
    {
        //int totalRolls = 0;
        
        public FormGameScreen()
        {
            InitializeComponent();
            
        }

        //BTnRoll Click Event
        private void btnRoll_Click(object sender, EventArgs e)
        {
            Graphics graPaper = picbxDrawing.CreateGraphics();
            int numberOfRolls = 3;
            int iTempX = 50;
            int iTempY = 50;
            if (ckbHoldDice1.Checked != true)
            {
                //Draws First Dice
                for (int i = 0; i < numberOfRolls; i++)
                {
                    drawBox(graPaper, iTempX, iTempY);
                    rollDice(graPaper, i, iTempX, iTempY);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(1500);
                }
            }

            if (ckbHoldDice2.Checked != true)
            {
                //Draws Second Dice
                iTempX = 150;
                iTempY = 50;
                for (int i = 0; i < numberOfRolls; i++)
                {
                    drawBox(graPaper, iTempX, iTempY);
                    rollDice(graPaper, i, iTempX, iTempY);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(1500);
                }
            }

            if (ckbHoldDice3.Checked != true)
            {
                //Draws Third Dice
                iTempX = 250;
                iTempY = 50;
                for (int i = 0; i < numberOfRolls; i++)
                {
                    drawBox(graPaper, iTempX, iTempY);
                    rollDice(graPaper, i, iTempX, iTempY);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(1500);
                }
            }

            if (ckbHoldDice4.Checked != true)
            {
                //Draws Fourth Dice
                iTempX = 350;
                iTempY = 50;
                for (int i = 0; i < numberOfRolls; i++)
                {
                    drawBox(graPaper, iTempX, iTempY);
                    rollDice(graPaper, i, iTempX, iTempY);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(1500);
                }
            }

            if (ckbHoldDice5.Checked != true)
            {
                //Draws Fifth Dice
                if (ckbHoldDice5.Checked != true)
                {
                    iTempX = 450;
                    iTempY = 50;
                    for (int i = 0; i < numberOfRolls; i++)
                    {
                        drawBox(graPaper, iTempX, iTempY);
                        rollDice(graPaper, i, iTempX, iTempY);
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(1500);
                    }
                }
            }
            
        }

        private void rollDice(Graphics tempCanvas, int loopValue, int xValue, int yValue)
        {
            int tempX = xValue;
            int tempY = yValue;
            Random number = new Random();
            int rollValue = number.Next(1, 7);  
            //iArrayDice % Convert.ToInt32(number);
            //txbCurrentRoll.Text = Convert.ToString(rollValue);
            //totalRolls = totalRolls + rollValue;
            //String appendValue = Convert.ToString(totalRolls) + "\n\r";
            //txbTotalRoll.AppendText(String.Format("{0:d} {1:d}\n\r"), loopValue, appendValue);
            //txbTotalRoll.Text = (appendValue);
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

        //When Clicked if checkbox is checked=
        //  True: draws 4 rectangles forming a border the color of the background and unchecks checkbox.
        //  False: draws 4 Yellow rectangles forming a border and checks checkbox.
        private void btnHold1_Click(object sender, EventArgs e)
        {
            Graphics graPaper = picbxDrawing.CreateGraphics();
            if (ckbHoldDice1.Checked != true)
            {
                graPaper.FillRectangle(Brushes.Yellow, 40, 40, 95, 10);
                graPaper.FillRectangle(Brushes.Yellow, 40, 50, 10, 85);
                graPaper.FillRectangle(Brushes.Yellow, 50, 125, 85, 10);
                graPaper.FillRectangle(Brushes.Yellow, 125, 50, 10, 75);
                ckbHoldDice1.Checked = true;
            }
            else
            {
                graPaper.FillRectangle(Brushes.Gainsboro, 40, 40, 95, 10);
                graPaper.FillRectangle(Brushes.Gainsboro, 40, 50, 10, 85);
                graPaper.FillRectangle(Brushes.Gainsboro, 50, 125, 85, 10);
                graPaper.FillRectangle(Brushes.Gainsboro, 125, 50, 10, 75);
                ckbHoldDice1.Checked = false;
            }  
        }

        //When Clicked if checkbox is checked=
        //  True: draws 4 rectangles forming a border the color of the background and unchecks checkbox.
        //  False: draws 4 Yellow rectangles forming a border and checks checkbox.
        private void btnHold2_Click(object sender, EventArgs e)
        {
            Graphics graPaper = picbxDrawing.CreateGraphics();
            if (ckbHoldDice2.Checked != true)
            {
                graPaper.FillRectangle(Brushes.Yellow, 140, 40, 95, 10);
                graPaper.FillRectangle(Brushes.Yellow, 140, 50, 10, 85);
                graPaper.FillRectangle(Brushes.Yellow, 150, 125, 85, 10);
                graPaper.FillRectangle(Brushes.Yellow, 225, 50, 10, 75);
                ckbHoldDice2.Checked = true;
            }
            else
            {
                graPaper.FillRectangle(Brushes.Gainsboro, 140, 40, 95, 10);
                graPaper.FillRectangle(Brushes.Gainsboro, 140, 50, 10, 85);
                graPaper.FillRectangle(Brushes.Gainsboro, 150, 125, 85, 10);
                graPaper.FillRectangle(Brushes.Gainsboro, 225, 50, 10, 75);
                ckbHoldDice2.Checked = false;
            }
        }

        //When Clicked if checkbox is checked=
        //  True: draws 4 rectangles forming a border the color of the background and unchecks checkbox.
        //  False: draws 4 Yellow rectangles forming a border and checks checkbox.
        private void btnHold3_Click(object sender, EventArgs e)
        {
            Graphics graPaper = picbxDrawing.CreateGraphics();
            if (ckbHoldDice3.Checked != true)
            {
                graPaper.FillRectangle(Brushes.Yellow, 240, 40, 95, 10);
                graPaper.FillRectangle(Brushes.Yellow, 240, 50, 10, 85);
                graPaper.FillRectangle(Brushes.Yellow, 250, 125, 85, 10);
                graPaper.FillRectangle(Brushes.Yellow, 325, 50, 10, 75);
                ckbHoldDice3.Checked = true;
            }
            else
            {
                graPaper.FillRectangle(Brushes.Gainsboro, 240, 40, 95, 10);
                graPaper.FillRectangle(Brushes.Gainsboro, 240, 50, 10, 85);
                graPaper.FillRectangle(Brushes.Gainsboro, 250, 125, 85, 10);
                graPaper.FillRectangle(Brushes.Gainsboro, 325, 50, 10, 75);
                ckbHoldDice3.Checked = false;
            }
        }

        //When Clicked if checkbox is checked=
        //  True: draws 4 rectangles forming a border the color of the background and unchecks checkbox.
        //  False: draws 4 Yellow rectangles forming a border and checks checkbox.
        private void btnHold4_Click(object sender, EventArgs e)
        {
            Graphics graPaper = picbxDrawing.CreateGraphics();
            if (ckbHoldDice4.Checked != true)
            {
                graPaper.FillRectangle(Brushes.Yellow, 340, 40, 95, 10);
                graPaper.FillRectangle(Brushes.Yellow, 340, 50, 10, 85);
                graPaper.FillRectangle(Brushes.Yellow, 350, 125, 85, 10);
                graPaper.FillRectangle(Brushes.Yellow, 425, 50, 10, 75);
                ckbHoldDice4.Checked = true;
            }
            else
            {
                graPaper.FillRectangle(Brushes.Gainsboro, 340, 40, 95, 10);
                graPaper.FillRectangle(Brushes.Gainsboro, 340, 50, 10, 85);
                graPaper.FillRectangle(Brushes.Gainsboro, 350, 125, 85, 10);
                graPaper.FillRectangle(Brushes.Gainsboro, 425, 50, 10, 75);
                ckbHoldDice4.Checked = false;
            }
        }

        //When Clicked if checkbox is checked=
        //  True: draws 4 rectangles forming a border the color of the background and unchecks checkbox.
        //  False: draws 4 Yellow rectangles forming a border and checks checkbox.
        private void btnHold5_Click(object sender, EventArgs e)
        {
            Graphics graPaper = picbxDrawing.CreateGraphics();
            if (ckbHoldDice5.Checked != true)
            {
                graPaper.FillRectangle(Brushes.Yellow, 440, 40, 95, 10);
                graPaper.FillRectangle(Brushes.Yellow, 440, 50, 10, 85);
                graPaper.FillRectangle(Brushes.Yellow, 450, 125, 85, 10);
                graPaper.FillRectangle(Brushes.Yellow, 525, 50, 10, 75);
                ckbHoldDice5.Checked = true;
            }
            else
            {
                graPaper.FillRectangle(Brushes.Gainsboro, 440, 40, 95, 10);
                graPaper.FillRectangle(Brushes.Gainsboro, 440, 50, 10, 85);
                graPaper.FillRectangle(Brushes.Gainsboro, 450, 125, 85, 10);
                graPaper.FillRectangle(Brushes.Gainsboro, 525, 50, 10, 75);
                ckbHoldDice5.Checked = false;
            }
        }
    }
}
