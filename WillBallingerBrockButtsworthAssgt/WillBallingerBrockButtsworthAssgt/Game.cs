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
    class Game
    {
        // Variables
        private Int32 playerID;
        private string type;
        private Int32 turn;
        private Int32 goalScore;
        private Int32 currentScore;
        private Int32[] dice;

        // Constructor
        Game(Int32 tempPlayerID, string tempType)
        {
            turn = 0;
            currentScore = 0;
            dice = new Int32[] { 0, 0, 0, 0, 0 };
            playerID = tempPlayerID;
            type = tempType;
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

        public Int32 getGoalScore()
        {
            return goalScore;
        }

        public Int32 getCurrentScore()
        {
            return currentScore;
        }

        public Int32[] getDice()
        {
            return dice;
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

        public void setGoalScore(Int32 tempGoalScore)
        {
            goalScore = tempGoalScore;
        }

        public void setCurrentScore()
        {

        }

        // Used to update dice rolls in the game array.
        // requires index between 0 to 4 and dice rolled between 1 and 6.
        public void setDice(Int32 index, Int32 diceRolled)
        {
            dice[index] = diceRolled;
        }

        // resets values back to beggining without restetting playerID and type.
        public void restart()
        {
            turn = 0;
            currentScore = 0;
            dice = new Int32[] { 0, 0, 0, 0, 0 };
        }
}