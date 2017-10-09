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
//This is used to test what is saved in the Class
namespace WillBallingerBrockButtsworthAssgt.Forms
{
    public partial class TestForm : Form
    {
        public TestForm(Game tempGame, Player tempPlayer)
        {
            InitializeComponent();
            Game gameData = tempGame;
            Player playerData = tempPlayer;
            label18.Text = playerData.getPlayerID().ToString();
            label17.Text = playerData.getPlayerName();
            label16.Text = playerData.getGamesPlayed().ToString();
            label22.Text = playerData.getGamesWon().ToString();
            label10.Text = gameData.getPlayerID().ToString();
            label11.Text = gameData.getType();
            label12.Text = gameData.getTurn().ToString();
            label13.Text = gameData.getRoll().ToString();
            label14.Text = gameData.getGoalScore().ToString();
            label15.Text = gameData.getCurrentScore().ToString();
            label28.Text = gameData.getDiceValue(0).ToString();
            label27.Text = gameData.getDiceValue(1).ToString();
            label26.Text = gameData.getDiceValue(2).ToString();
            label25.Text = gameData.getDiceValue(3).ToString();
            label24.Text = gameData.getDiceValue(4).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Updates Labels
            

        }
    }
}
