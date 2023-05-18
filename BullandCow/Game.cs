using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullandCow
{
    public class GuessResult
    {
        public int NumberofCows { get; private set; }
        public int NumberofBulls { get; private set; }
        public GuessResult (int numberOfCows, int numberofBulls)
        {
            this.NumberofBulls = numberofBulls;
            this.NumberofCows = numberOfCows;
        }

    }
    public class Game
    {
        private static readonly Random getrandom = new Random();
        public int DigitLength { get; private set; } = 4;
        public GuessResult CheckResult(String guestNumber)
        {
            int i;
            int numberofBulls = 0;
            int numberofCows = 0;
            for (i = 0; i < guestNumber.Length; i++)
            {
                String number = guestNumber[i].ToString();
                int indexofNumberinSecret = SecretNumber.IndexOf(number);
                if(indexofNumberinSecret == -1)
                {
                    continue;
                }
                if(indexofNumberinSecret != i)
                {
                    numberofCows++;
                    continue;
                }

                numberofBulls++;
            }
            GuessResult result = new GuessResult(numberofCows, numberofBulls);
            return result;
        }
        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }
        
        public String SecretNumber { get; private set; }
        private void GenerateSecretNumber(int numberofDigit)
        {
            HashSet<int> hsh = new HashSet<int>();
            while(hsh.Count == numberofDigit)
            {

            }
            StringBuilder strB = new StringBuilder();
            //hsh.ElementAt ()
            //hsh.ForEach (strB.Append (hsh[]))
            foreach(int number in hsh)
            {
                strB.Append(hsh);
            }

            SecretNumber = strB.ToString();
        }

        private void GenerateSecretNumber()
        {
            GenerateSecretNumber(4);
        }
        public Game()
        {
            Initial(4);
        }

        public Game(int numberofDigit)
        {
            Initial(numberofDigit);
        }
        public void Initial(int numberofDigit)
        {
            DigitLength = numberofDigit;
            GenerateSecretNumber(DigitLength);
        }
    }
}
