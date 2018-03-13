using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartValue
{
    public class Dart
    {
        public int Score { get; set; }
        public bool Double { get; set; }
        public bool Triple { get; set; }

        private Random rdm;

        public void Multiply()
        {
            int value = rdm.Next(0, 100);
            if (value > 5 && value < 11) multiplier = 2;
            else if (value >= 0 && value < 6) multiplier = 3;
            else
            {
                multiplier = 1;
            }
        }



        public void Throw()
        {
            int value = rdm.Next(0, 22);
            int multiplier = rdm.Next(1, 101);
            if (value < 20)
            {
                score = score + multiplier * value;
            }
            else
            {
                score = score + 25;
            }
            if (multiplier < 5) Double = true;
            else if (multiplier < 10) Triple = true;

        }

    }
    public class Players
    {
        public int player1;
        public int player2;
    }

}
