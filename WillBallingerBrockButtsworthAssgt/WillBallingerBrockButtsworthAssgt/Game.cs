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
        private Int32 playerID;
        private string type;
        private Int32 turn;
        private Int32 roll;
        private Int32 goalScore;
        private Int32 currentScore;
        private Int32 totalScore;
        private Int32[] dice;
        private Boolean currentTurn;
        private Boolean evenValue;  //used to diplay if currentScore Total is even

        // Constructor
        public Game(Int32 tempPlayerID, string tempType, Boolean tempCurrentTurn)
        {
            turn = 1;
            roll = 3;
            currentScore = 0;
            dice = new Int32[] { 0, 0, 0, 0, 0 };
            playerID = tempPlayerID;
            type = tempType;
            currentTurn = tempCurrentTurn;
        }

        // Get Methods

        public Int32 getPlayerID()
        {
            return playerID;
        }

        public string getType()
        {
            return type;
        }

        public Int32 getTurn()
        {
            return turn;
        }

        public Int32 getRoll()
        {
            return roll;
        }

        public Int32 getGoalScore()
        {
            return goalScore;
        }

        public Int32 getCurrentScore()
        {
            Int32 tempCurrentScore = 0;
            tempCurrentScore = tempCurrentScore + dice[0];
            tempCurrentScore = tempCurrentScore + dice[1];
            tempCurrentScore = tempCurrentScore + dice[2];
            tempCurrentScore = tempCurrentScore + dice[3];
            tempCurrentScore = tempCurrentScore + dice[4];
            return tempCurrentScore;
        }

        public Int32 getTotalScore()
        {
            return totalScore;
        }

        public Int32[] getDice()
        {
            return dice;
        }

        public Int32 getDiceValue(Int32 position)
        {
            return dice[position];
        }

        public Boolean getCurrentTurn()
        {
            return currentTurn;
        }

        // Set Methods
        public void setPlayerID(Int32 tempPlayerID)
        {
            playerID = tempPlayerID;
        }

        public void setType(string tempType)
        {
            type = tempType;
        }

        public void setTurn(Int32 tempTurn)
        {
            turn = tempTurn;
        }

        public void setRoll(Int32 tempRoll)
        {
            roll = tempRoll;
        }

        public void setGoalScore(Int32 tempGoalScore)
        {
            goalScore = tempGoalScore;
        }

        // Used to update dice rolls in the game array.
        // requires index between 0 to 4 and dice rolled between 1 and 6.
        public void setDice(Int32 index, Int32 diceRolled)
        {
            dice[index-1] = diceRolled;
        }

        public void setCurrentTurn(Boolean tempCurrentTurn)
        {
            currentTurn = tempCurrentTurn;
        }

        //Updates the Roll.
        public void nextRoll()
        {
            roll--;
        }

        //Updates the Roll.
        public void nextTurn()
        {
            turn++;
        }

        // resets values back to beggining without restetting playerID and type.
        public void restart()
        {
            turn = 0;
            currentScore = 0;
            dice = new Int32[] { 0, 0, 0, 0, 0 };
        }


        // Methods for calculating score
        // Calculate current score and add to current total score
        public void setTotalScore()
        {
            Int32 tempCurrentScore = calculateCurrentScore();
            totalScore = totalScore + tempCurrentScore;
        }

        private int calculateCurrentScore()
        {
            Int32 tempCurrentScore = 0;
            // Add to tempCurrentScore as game score rules. 
            // fiveInARow
            tempCurrentScore = tempCurrentScore + fiveInARow();
            tempCurrentScore = tempCurrentScore + fourInARow();
            tempCurrentScore = tempCurrentScore + threeInARow();
            tempCurrentScore = tempCurrentScore + fiveOfAKind();
            tempCurrentScore = tempCurrentScore + fourOfAKind();
            tempCurrentScore = tempCurrentScore + threeOfAKind();
            return tempCurrentScore;
        }

        public void setCurrentScore()
        {

        }


        // This method is to return true if value exists in dice array.
        public Boolean ifValueExists(Int32 tempCompareValue)
        {
            Boolean response = false;
            for (Int32 i = 0; i < 5; i++)
            {
                if (dice[i] == tempCompareValue)
                {
                    response = true;
                }
            }
            return response;
        }

        //if dice array shows a sequence of five (ie 1 2 3 4 5 or 2 3 4 5 6), returns 25.
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


        // if the dice show a sequence of four (eg 1 3 6 4 2), the score is 15.
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


        // if the dice show a sequence of three (eg 4 1 5 2 6), the score is 5.
        public Int32 threeInARow()
        {
            Int32 returnScore = 0;
            if (ifValueExists(1))
            {
                if (ifValueExists(2))
                {
                    if (ifValueExists(3))
                    {
                        returnScore = 5;
                    }
                }
            }

            if (ifValueExists(2))
            {
                if (ifValueExists(3))
                {
                    if (ifValueExists(4))
                    {
                        returnScore = 5;
                    }
                }
            }

            if (ifValueExists(3))
            {
                if (ifValueExists(4))
                {
                    if (ifValueExists(5))
                    {
                        returnScore = 5;
                    }
                }
            }
            if (ifValueExists(4))
            {
                if (ifValueExists(5))
                {
                    if (ifValueExists(6))
                    {
                        returnScore = 5;
                    }
                }
            }
            return returnScore;

        }


        // This method takes an int and returns true if exists 5 times. 
        public Boolean fiveExistsInArray(Int32 tempDiceValue)
        {
            Boolean response = false;
            if (dice[0] == tempDiceValue)
            {
                if (dice[1] == tempDiceValue)
                {
                    if (dice[2] == tempDiceValue)
                    {
                        if (dice[3] == tempDiceValue)
                        {
                            if (dice[4] == tempDiceValue)
                            {
                                response = true;
                            }
                        }
                    }
                }
            }
            return response;
        }
       

        // if the dice show five of a kind (all five showing the same number), the score is 30.
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
        public Boolean fourExistsInArray(Int32 tempDiceValue)
        {
            Int32 tempValue = 0;
            if (dice[0] == tempDiceValue)
            {
                tempValue++;
            }

            if (dice[1] == tempDiceValue)
            {
                tempValue++;
            }

            if (dice[2] == tempDiceValue)
            {
                tempValue++;
            }

            if (dice[3] == tempDiceValue)
            {
                tempValue++;
            }
            if (dice[4] == tempDiceValue)
            {
                tempValue++;
            }

            if (tempValue == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // if the dice show four of a kind (eg 2 2 5 2 2), the score is 20.
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
            if (dice[0] == tempDiceValue)
            {
                tempValue++;
            }

            if (dice[1] == tempDiceValue)
            {
                tempValue++;
            }

            if (dice[2] == tempDiceValue)
            {
                tempValue++;
            }

            if (dice[3] == tempDiceValue)
            {
                tempValue++;
            }
            if (dice[4] == tempDiceValue)
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

        /* if the dice show three of a kind (eg 6 1 6 6 4), the score is 1 */
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

        

        /* but . . . if the total of all five dice is even, the score is added to the player’s score, 
           whereas is if the total of all five dice is odd, the score is subtracted from the player’s score. */

        /* If there is any ambiguity concerning the score, the score will be the biggest of the possibilities.
         For example, 3 2 4 3 3 is both three of a kind and a sequence of three, so it will score 10 for three of
         a kind rather than 5 for a sequence of three (and will contribute –10 if it’s the end of the turn). */

    }
}
