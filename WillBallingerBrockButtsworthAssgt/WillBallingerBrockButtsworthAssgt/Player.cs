using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillBallingerBrockButtsworthAssgt
{
    class Player
    {
        //Variables
        private string playerName;
        private Int32 playerID;
        private Int32 gamesPlayed;
        private Int32 gamesWon;
        
        //Get Methods

        public string getPlayerName()
        {
            return playerName;
        }

        public Int32 getPlayerID()
        {
            return playerID;
        }

        public Int32 getGamesPlayed()
        {
            return gamesPlayed;
        }

        public Int32 getGamesWon()
        {
            return gamesWon;
        }

        //Set Methods
        public void setPlayerName(string tempPlayerName)
        {
            playerName = tempPlayerName;
        }

        public void setPlayerID(Int32 tempPlayerID)
        {
            playerID = tempPlayerID;
        }

        //If the bool in True, Increments Games Won and Games Played
        //otherwise updates games played.
        public void addResult(bool tempWin)
        {
            if (tempWin==true)
            {
                gamesWon++;
                gamesPlayed++;
            }
            else
            {
                gamesPlayed++;
            }
        }
    }
}
