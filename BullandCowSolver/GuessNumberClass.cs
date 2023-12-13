using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullandCowSolver
{
    public class GuessNumberClass
    {
        public String Number { get; private set; }
        public Boolean isValid { get; set; } = true;
        public GuessNumberClass (String number)
        {
            this.Number = number;
        }

        public void Validate(String guessNumber, BullandCow.GuessResult result)
        {

        }

    }
}
