using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengers
{
    public class Players
    {
        private Players player1;
        private Players player2;

    public Players(string player1Name, string player2Name)
        {
            player1 = new Players;
            player2 = new Players;
        }
        public void Play()
        {
            while (player1.Score < 300 && player2.Score < 300)
            {

            }
        }

    }
}
