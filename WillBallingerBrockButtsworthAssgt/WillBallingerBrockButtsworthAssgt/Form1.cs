using System;
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
-Authors Brock Buttsworth and Ballinger.
-Created 20/9/2017
-Brief Description :
    PlusMoins is a rather unforgiving and frustrating dice game. 
    It involves five dice, and permits the player a certain amount of judgement, 
    but luck also plays a very big part. There are two players, 
    each of whom is trying to reach an agreed total.
 */
namespace WillBallingerBrockButtsworthAssgt
{
    public partial class FormGameScreen : Form
    {
        int totalRolls = 0;
        public FormGameScreen()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Graphics graPaper = picbxDrawing.CreateGraphics();

            totalRolls = 0;
            int numberOfRolls = 3;
            //Draws First Dice
            int tempX = 50;
            int tempY = 50;
            for (int i = 0; i < numberOfRolls; i++)
            {
                drawBox(graPaper, tempX, tempY);
                rollDice(graPaper, i, tempX, tempY);
                Application.DoEvents();
                System.Threading.Thread.Sleep(1500);
            }
            //Draws Second Dice
            tempX = 150;
            tempY = 50;
            for (int i = 0; i < numberOfRolls; i++)
            {
                drawBox(graPaper, tempX, tempY);
                rollDice(graPaper, i, tempX, tempY);
                Application.DoEvents();
                System.Threading.Thread.Sleep(1500);
            }
            //Draws Third Dice
            tempX = 250;
            tempY = 50;
            for (int i = 0; i < numberOfRolls; i++)
            {
                drawBox(graPaper, tempX, tempY);
                rollDice(graPaper, i, tempX, tempY);
                Application.DoEvents();
                System.Threading.Thread.Sleep(1500);
            }
            //Draws Fourth Dice
            tempX = 350;
            tempY = 50;
            for (int i = 0; i < numberOfRolls; i++)
            {
                drawBox(graPaper, tempX, tempY);
                rollDice(graPaper, i, tempX, tempY);
                Application.DoEvents();
                System.Threading.Thread.Sleep(1500);
            }
            //Draws Fifth Dice
            tempX = 450;
            tempY = 50;
            for (int i = 0; i < numberOfRolls; i++)
            {
                drawBox(graPaper, tempX, tempY);
                rollDice(graPaper, i, tempX, tempY);
                Application.DoEvents();
                System.Threading.Thread.Sleep(1500);
            }
        }

        private void rollDice(Graphics tempCanvas, int loopValue, int xValue, int yValue)
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

        
    }
}
