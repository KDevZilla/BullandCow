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
        public int NumberofTimesAllowToGuess { get; private set; } = 7;

        public GuessResult CheckResult(String guessNumber)
        {
            int i;
            int numberofBulls = 0;
            int numberofCows = 0;
            HashSet<String> hsh = new HashSet<String>();
            String validNumber = "123456789";
            for (i = 0; i < guessNumber.Length; i++)
            {
                bool IsNumber = validNumber.IndexOf(guessNumber[i]) != -1;
                if (!IsNumber)
                {
                    throw new ArgumentException($"{guessNumber} contains an invalid character, please enter the number between 1-9, for {DigitLength} digits");
                }
                if(hsh.Contains (guessNumber [i].ToString()))
                {
                    throw new ArgumentException($"{guessNumber} contains a duplicate number");
                }
                hsh.Add(guessNumber[i].ToString());
            }
            for (i = 0; i < guessNumber.Length; i++)
            {
                String number = guessNumber[i].ToString();
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
            listGuessNumberHistory.Add(guessNumber);
            listGuessResultHistory.Add(result);
            if (result.NumberofBulls == DigitLength)
            {
                GameResult = GameResultEnum.Win;
            }
            else
            {
                if (CurrentGuessNumber >= NumberofTimesAllowToGuess)
                {
                    GameResult = GameResultEnum.Lose;
                }
            }

            CurrentGuessNumber++;
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
            Initial(4,7);
        }

        public Game(int numberofDigit, int numberofTimeAllowGuess)
        {
            Initial(numberofDigit, numberofTimeAllowGuess);
        }
        public int CurrentGuessNumber { get; private set; } = 1;
        public void Initial(int numberofDigit, int numberofTimeAllowGuess)
        {
            this.NumberofTimesAllowToGuess = numberofTimeAllowGuess;
            DigitLength = numberofDigit;
            GenerateSecretNumber(DigitLength);
            listGuessNumberHistory = new List<string>();
            listGuessResultHistory = new List<GuessResult>();
            GameResult = GameResultEnum.NotDecide;
        }
    }
}
