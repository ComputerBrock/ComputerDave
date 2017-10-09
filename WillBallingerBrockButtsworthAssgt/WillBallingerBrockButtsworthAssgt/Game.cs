﻿using System;
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

        public void setTotalScore(Int32 tempTotalScore)
        {
            totalScore = tempTotalScore;
        }

        public void setCurrentScore()
        {
            
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

    }
}
