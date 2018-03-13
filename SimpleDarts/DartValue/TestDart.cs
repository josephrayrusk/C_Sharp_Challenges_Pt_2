using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleDarts
{
    public class Dart {
        public int multiplier;
        public int score;

        public void Multiply()
        {
            Random random = new Random();
            int value = random.Next(0,100);
            if (value > 5 && value < 11) multiplier = 2;
            else if (value >=0 && value < 6) multiplier = 3;
            else multiplier = 1;
        }
        public void DartMark()
        {
            Random random = new Random();
            int value = random.Next(0, 21);
            if (value < 21)
            {
                score = multiplier * value;
            }
            else
            {
                score = 25;
            }

        }
        
    }
}