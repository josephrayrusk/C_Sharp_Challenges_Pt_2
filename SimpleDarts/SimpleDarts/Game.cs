using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace SimpleDarts
{
    public class Game
    {
        private Player player1;
        private Player player2;
        private Random rdm;
        private string round;
        private int roundnumber;

        public Game(string player1Name, string player2Name)
        {
            player1 = new Player();
            player1.Name = player1Name;

            player2 = new Player();
            player2.Name = player2Name;

            rdm = new Random();
        }


        public string Play()
        {
            while (player1.Score < 300 && player2.Score < 300)
            {

                playRound(player1);
                playRound(player2);

                roundnumber++;
                round += "Round " + roundnumber.ToString() + "<br />" + String.Format("{0}'s score: {1} <br /> {2}'s score: {3} <br /><br />",
                    player1.Name, player1.Score, player2.Name, player2.Score);
              
            }
            return displayResults();
        }
        private string displayResults()
        {
            string result = round + "Final Score: <br />" + String.Format("{0}: {1}<br/>{2}: {3}",
                player1.Name,
                player1.Score,
                player2.Name,
                player2.Score);

            return result += "<br/>Winner: " +
                (player1.Score > player2.Score ? player1.Name : player2.Name);
        }
        private void playRound(Player player)
        {
            for (int i = 0; i < 3; i++)
            {
                Dart dart = new Dart(rdm);
                dart.Throw();
                Score.ScoreDart(player, dart);
                
            }
        }
    }
}