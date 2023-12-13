using BullandCow;
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
        public BullandCow.GuessResult CheckResultWithAnotherNumber(String anotherGuessNumber)
        {
            int numberofCows = 0;
            int numberofBulls = 0;
            for (int i = 0; i < anotherGuessNumber.Length; i++)
            {
                String number = anotherGuessNumber[i].ToString();
                int indexofNumberinSecret = this.Number.IndexOf(number);
                if (indexofNumberinSecret == -1)
                {
                    continue;
                }
                if (indexofNumberinSecret != i)
                {
                    numberofCows++;
                    continue;
                }

                numberofBulls++;
            }
            GuessResult result = new GuessResult(numberofCows, numberofBulls);
            return result;
        }
        public int NumberOfMatch(String anotherGuessNumber)
        {
            int i;
            int noofMatch = 0;
            for (i = 0; i < Number.Length; i++)
            {
                if(anotherGuessNumber.Contains (Number[i].ToString()))
                {
                    noofMatch++;
                }
            }
            return noofMatch;
        }
        public void Validate(String guessNumber, BullandCow.GuessResult result)
        {

        }

    }
}
