using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-INFT2012 - Assignment 1 - Plus Mois
//-Authors Brock Buttsworth and Will Ballinger.
//-Created 4/10/17
//-Brief Description: Games class with Gets and Sets

namespace WillBallingerBrockButtsworthAssgt
{
    public class Game
    {
        // Variables
        private Int32 iPlayerID;
        private string sType;
        private Int32 iTurn;
        private Int32 iRoll;
        private Int32 iGoalScore;
        private Int32 iTotalScore;
        private Int32[] iArrayDice;
        private Boolean bCurrentTurn;

        // Constructor
        public Game(Int32 tempPlayerID, string tempType, Boolean tempCurrentTurn)
        {
            iTurn = 1;
            iRoll = 3;
            iArrayDice = new Int32[] { 0, 0, 0, 0, 0 };
            iPlayerID = tempPlayerID;
            sType = tempType;
            bCurrentTurn = tempCurrentTurn;
        }

        // Get Methods

        public Int32 getPlayerID()
        {
            return iPlayerID;
        }

        public string getType()
        {
            return sType;
        }

        public Int32 getTurn()
        {
            return iTurn;
        }

        public Int32 getRoll()
        {
            return iRoll;
        }

        public Int32 getGoalScore()
        {
            return iGoalScore;
        }

        public Int32 getCurrentScore()
        {
            Int32 tempCurrentScore = 0;
            tempCurrentScore = tempCurrentScore + iArrayDice[0];
            tempCurrentScore = tempCurrentScore + iArrayDice[1];
            tempCurrentScore = tempCurrentScore + iArrayDice[2];
            tempCurrentScore = tempCurrentScore + iArrayDice[3];
            tempCurrentScore = tempCurrentScore + iArrayDice[4];
            return tempCurrentScore;
        }

        public Int32 getTotalScore()
        {
            return iTotalScore;
        }

        public Int32[] getDice()
        {
            return iArrayDice;
        }

        public Int32 getDiceValue(Int32 iPosition)
        {
            return iArrayDice[iPosition];
        }

        public Boolean getCurrentTurn()
        {
            return bCurrentTurn;
        }

        // Set Methods
        public void setPlayerID(Int32 iTempPlayerID)
        {
            iPlayerID = iTempPlayerID;
        }

        public void setType(string iTempType)
        {
            sType = iTempType;
        }

        public void setTurn(Int32 iTempTurn)
        {
            iTurn = iTempTurn;
        }

        public void setRoll(Int32 iTempRoll)
        {
            iRoll = iTempRoll;
        }

        public void setGoalScore(Int32 iTempGoalScore)
        {
            iGoalScore = iTempGoalScore;
        }

        // Used to update iArrayDice rolls in the game array.
        // requires iIndex between 0 to 4 and iArrayDice rolled between 1 and 6.
        public void setDice(Int32 iIndex, Int32 iDiceRolled)
        {
            iArrayDice[iIndex-1] = iDiceRolled;
        }

        public void setCurrentTurn(Boolean iTempCurrentTurn)
        {
            bCurrentTurn = iTempCurrentTurn;
        }

        //Updates the Roll.
        public void nextRoll()
        {
            iRoll--;
        }

        //Updates the Roll.
        public void nextTurn()
        {
            iTurn++;
        }

        // resets values back to beggining without restetting iPlayerID and sType.
        public void restart()
        {
            iTurn = 0;
            iArrayDice = new Int32[] { 0, 0, 0, 0, 0 };
        }

        // Methods for calculating score
        // Calculate current score and add to current total score if even or subtracts if odd
        public void setTotalScore()
        {
            Int32 tempCurrentScore = calculateCurrentScore();
            if(isEvenNotOdd()) 
            {
                //Is Even
                iTotalScore = iTotalScore + tempCurrentScore;
            }
            else //is Odd
            {
                iTotalScore = iTotalScore - tempCurrentScore;
            }
            
        }

        //Calculates the points earned from current Game.
        private int calculateCurrentScore()
        {
            Int32 tempCurrentScore = 0;
            // Add to tempCurrentScore as game score rules. 
            // fiveInARow
            tempCurrentScore = tempCurrentScore + fiveInARow();
            // fourInARow
            tempCurrentScore = tempCurrentScore + fourInARow();
            // threeInARow
            tempCurrentScore = tempCurrentScore + threeInARow();
            tempCurrentScore = tempCurrentScore + fiveOfAKind();
            tempCurrentScore = tempCurrentScore + fourOfAKind();
            tempCurrentScore = tempCurrentScore + threeOfAKind();
            return tempCurrentScore;
        }

        // This method is to return true if value exists in iArrayDice array.
        public Boolean ifValueExists(Int32 iTempCompareValue)
        {
            Boolean response = false;
            for (Int32 i = 0; i < 5; i++)
            {
                if (iArrayDice[i] == iTempCompareValue)
                {
                    response = true;
                }
            }
            return response;
        }

        //if iArrayDice array shows a sequence of five (ie 1 2 3 4 5 or 2 3 4 5 6), returns 25.
        public Int32 fiveInARow()
        {
            Int32 returnScore = 0;
            if (ifValueExists(1))
            {
                if (ifValueExists(2))
                {
                    if (ifValueExists(3))
                    {
                        if (ifValueExists(4))
                        {
                            if (ifValueExists(5))
                            {
                                returnScore = 25;
                            }
                        }
                    }
                }
            }

            if (ifValueExists(2))
            {
                if (ifValueExists(3))
                {
                    if (ifValueExists(4))
                    {
                        if (ifValueExists(5))
                        {
                            if (ifValueExists(6))
                            {
                                returnScore = 25;
                            }
                        }
                    }
                }
            }
            return returnScore;
        }


        // if the iArrayDice show a sequence of four (eg 1 3 6 4 2), the score is 15.
        public Int32 fourInARow()
        {
            Int32 returnScore = 0;
            if (ifValueExists(1))
            {
                if (ifValueExists(2))
                {
                    if (ifValueExists(3))
                    {
                        if (ifValueExists(4))
                        {
                            returnScore = 15;
                        }
                    }
                }
            }

            if (ifValueExists(2))
            {
                if (ifValueExists(3))
                {
                    if (ifValueExists(4))
                    {
                        if (ifValueExists(5))
                        {
                            returnScore = 15;
                        }
                    }
                }
            }

            if (ifValueExists(3))
            {
                if (ifValueExists(4))
                {
                    if (ifValueExists(5))
                    {
                        if (ifValueExists(6))
                        {
                            returnScore = 15;
                        }
                    }
                }
            }
            return returnScore;

        }


        // if the iArrayDice show a sequence of three (eg 4 1 5 2 6), the score is 5.
        public Int32 threeInARow()
        {
            Int32 iReturnScore = 0;
            if (ifValueExists(1))
            {
                if (ifValueExists(2))
                {
                    if (ifValueExists(3))
                    {
                        iReturnScore = 5;
                    }
                }
            }

            if (ifValueExists(2))
            {
                if (ifValueExists(3))
                {
                    if (ifValueExists(4))
                    {
                        iReturnScore = 5;
                    }
                }
            }

            if (ifValueExists(3))
            {
                if (ifValueExists(4))
                {
                    if (ifValueExists(5))
                    {
                        iReturnScore = 5;
                    }
                }
            }
            if (ifValueExists(4))
            {
                if (ifValueExists(5))
                {
                    if (ifValueExists(6))
                    {
                        iReturnScore = 5;
                    }
                }
            }
            return iReturnScore;

        }


        // This method takes an int and returns true if exists 5 times. 
        public Boolean fiveExistsInArray(Int32 tempDiceValue)
        {
            Boolean bResponse = false;
            if (iArrayDice[0] == tempDiceValue)
            {
                if (iArrayDice[1] == tempDiceValue)
                {
                    if (iArrayDice[2] == tempDiceValue)
                    {
                        if (iArrayDice[3] == tempDiceValue)
                        {
                            if (iArrayDice[4] == tempDiceValue)
                            {
                                bResponse = true;
                            }
                        }
                    }
                }
            }
            return bResponse;
        }
       
        // if the iArrayDice show five of a kind (all five showing the same number), the score is 30.
        public Int32 fiveOfAKind()
        {
            Int32 returnScore = 0;

            for (Int32 i = 1; i < 7; i++)
            {
                if (fiveExistsInArray(i))
                {
                    returnScore = 30;
                }
            }
            return returnScore;
        }

        // This method takes an int and returns true if exists 5 times.
        public Boolean fourExistsInArray(Int32 iTempDiceValue)
        {
            Int32 iTempValue = 0;
            if (iArrayDice[0] == iTempDiceValue)
            {
                iTempValue++;
            }

            if (iArrayDice[1] == iTempDiceValue)
            {
                iTempValue++;
            }

            if (iArrayDice[2] == iTempDiceValue)
            {
                iTempValue++;
            }

            if (iArrayDice[3] == iTempDiceValue)
            {
                iTempValue++;
            }
            if (iArrayDice[4] == iTempDiceValue)
            {
                iTempValue++;
            }

            if (iTempValue == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // if the iArrayDice show four of a kind (eg 2 2 5 2 2), the score is 20.
        public Int32 fourOfAKind()
        {
            Int32 returnScore = 0;
            for (Int32 i = 1; i < 7; i++)
            {
                if (fourExistsInArray(i))
                {
                    returnScore = 20;
                }
            }
            return returnScore;
        }

        // This method takes an int and returns true if exists 3 times.
        public Boolean threeExistsInArray(Int32 tempDiceValue)
        {
            Int32 tempValue = 0;
            if (iArrayDice[0] == tempDiceValue)
            {
                tempValue++;
            }

            if (iArrayDice[1] == tempDiceValue)
            {
                tempValue++;
            }

            if (iArrayDice[2] == tempDiceValue)
            {
                tempValue++;
            }

            if (iArrayDice[3] == tempDiceValue)
            {
                tempValue++;
            }
            if (iArrayDice[4] == tempDiceValue)
            {
                tempValue++;
            }

            if (tempValue == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /* if the iArrayDice show three of a kind (eg 6 1 6 6 4), the score is 1 */
        public Int32 threeOfAKind()
        {
            Int32 returnScore = 0;
            for (Int32 i = 1; i < 7; i++)
            {
                if (threeExistsInArray(i))
                {
                    returnScore = 1;
                }
            }
            return returnScore;
        }

        /* but . . . if the total of all five iArrayDice is even, the score is added to the player’s score, 
           whereas is if the total of all five iArrayDice is odd, the score is subtracted from the player’s score. */
        public Boolean isEvenNotOdd()
        {
            Boolean bReturnValue = false;
            Int32 iCurrentTotal = getCurrentScore();
            if (iCurrentTotal % 2 == 0)
            {
                bReturnValue = true;
            }
            return bReturnValue;
        }
    }
}
