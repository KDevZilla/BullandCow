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
        public enum GameResultEnum
        {
            NotDecide=0,
            Lose=1,
            Win=2
        }
        public GameResultEnum GameResult { get; private set; } = GameResultEnum.NotDecide;
        private static readonly Random getrandom = new Random();
        public int DigitLength { get; private set; } = 4;
      //  public bool IsWon { get; private set; } = false;
        public List<String> listGuessNumberHistory = null;
        public List<GuessResult> listGuessResultHistory = null;
        public GuessResult CheckResult(String guestNumber)
        {
            int i;
            int numberofBulls = 0;
            int numberofCows = 0;
            HashSet<String> hsh = new HashSet<String>();
            for (i = 0; i < guestNumber.Length; i++)
            {
                if(hsh.Contains (guestNumber [i].ToString()))
                {
                    throw new ArgumentException($"{guestNumber} contains a duplicate number");
                }
                hsh.Add(guestNumber[i].ToString());
            }
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
            listGuessNumberHistory.Add(guestNumber);
            listGuessResultHistory.Add(result);
            if(result.NumberofBulls == DigitLength)
            {
                GameResult = GameResultEnum.Win;
            }

            if(CurrentGuestNumber > 7)
            {
                GameResult = GameResultEnum.Lose;
            }
            CurrentGuestNumber++;
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
            while(hsh.Count < numberofDigit)
            {
                int RandomNumber = GetRandomNumber(1, 9);
                if(hsh.Contains(RandomNumber))
                {
                    continue;
                }
                hsh.Add(RandomNumber);
            }
            StringBuilder strB = new StringBuilder();
            //hsh.ElementAt ()
            //hsh.ForEach (strB.Append (hsh[]))
            foreach(int number in hsh)
            {
                strB.Append(number);
            }

            SecretNumber = strB.ToString();
        }
        public void GenereateSecretNumberForTesting(String secretNumber)
        {
            this.SecretNumber = secretNumber;
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
        public int CurrentGuestNumber { get; private set; } = 1;
        public void Initial(int numberofDigit)
        {
            DigitLength = numberofDigit;
            GenerateSecretNumber(DigitLength);
            listGuessNumberHistory = new List<string>();
            listGuessResultHistory = new List<GuessResult>();
            GameResult = GameResultEnum.NotDecide;
        }
    }
}
