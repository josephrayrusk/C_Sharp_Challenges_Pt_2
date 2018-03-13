using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        public int Score { get; set; }
        public bool Double { get; set; }
        public bool Triple { get; set; }
        private Random rdm;

        public Dart(Random random)
        {
            rdm = random;
        }

        public void Throw()
        {
            Score = rdm.Next(0, 21);
            int multiplier = rdm.Next(1, 101);
            if (multiplier < 5) Double = true;
            else if (multiplier < 10) Triple = true;
        }

    }
}
