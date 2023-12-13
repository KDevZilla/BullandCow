using BullandCow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullandCowSolver
{
    public class Solver
    {
        /*
        public List<String> getAllPosibility(int digitLengh, int minValue, int maxValue)
        {
            List<String> listResult = new List<string>();
            genAllPosibility(digitLengh, minValue, maxValue, 1, new int[digitLengh], listResult);

            return listResult;
        }
        */
        public List<String> GenAllPosibility(int digitLenth, int from, int to, bool isAllowDuplicate)
        {
            int i;
            List<String> lstResult = new List<string>();
            for (i = from; i <= to; i++)
            {
                String valueAsString = i.ToString();
                bool isContainsZero = valueAsString.IndexOf('0') > -1;

                if (valueAsString.Length < digitLenth ||
                    isContainsZero)
                {
                    continue;
                }

                bool isDuplicate = false;
                if (!isAllowDuplicate)
                {
                    isDuplicate = false;
                    for (int j = 0; j < digitLenth; j++)
                    {
                        for (int k = 0; k < digitLenth; k++)
                        {
                            if (j == k)
                            {
                                continue;
                            }
                            if (valueAsString[j] == valueAsString[k])
                            {
                                isDuplicate = true;
                                break;
                            }
                        }
                    }
                }

                if(isAllowDuplicate 
                    || !isDuplicate)
                {
                    lstResult.Add(valueAsString);
                }
            }
            return lstResult;

        }
        /*
        public List<GuessNumberClass> GetValidNumber(String guessNumber, BullandCow.GuessResult result, List<GuessNumberClass> list)
        {
            int i;
            for (i = 0; i < list.Count; i++)
            {
                
            }
        }
        */
        private void AddHshNoDigit(HashSet<String> hshNoDigit, String number)
        {
            int i;
            for (i = 0; i < number.Length; i++)
            {
                if(hshNoDigit.Contains(number[i].ToString ()))
                {
                    continue;
                }
                hshNoDigit.Add(number[i].ToString());
            }
        }
        private bool isItContainNoDigit(HashSet<String> hshNoDigit, String number)
        {
            foreach (String digit in hshNoDigit)
            {
                if(number.Contains(digit))
                {
                    return true;
                }
            }
            return false;
        }
        private static Random random = new Random();
        private int getRandom(int min, int max)
        {
            return random.Next(min, max);
        }
        public String Solve(BullandCow.Game game)
        {
            List<String> listStringValidNumber = new List<string>();
            listStringValidNumber = GenAllPosibility(4, 1111, 9999, false);
            // genAllPosibility(4, 1, 9, 1, "", listResult);
            List<String> listGuess = new List<string>();
            List<GuessNumberClass> listGuessNumber = new List<GuessNumberClass>();
            HashSet<String> hshInvalid = new HashSet<string>();
            HashSet<String> hshHasTried = new HashSet<string>();
            listStringValidNumber.ForEach(x => listGuessNumber.Add(new GuessNumberClass(x)));
            HashSet<String> hshNoDigit = new HashSet<string>();
            int guessCount = 0;
            String answer = "";
            while (game.GameResult == BullandCow.Game.GameResultEnum.NotDecide)
            {
                int i;
                GuessResult result = new GuessResult(-1,-1);
                int iCountInValid = 0;
                GuessNumberClass guessNumber = listGuessNumber[getRandom (0,listGuessNumber.Count )];

                    if(hshHasTried.Contains(guessNumber.Number))
                    {
                        continue;
                    }
                    if(hshInvalid.Contains (guessNumber.Number))
                    {
                        continue;
                    }
                    if(!guessNumber.isValid)
                    {
                        
                        continue;
                    }

                    result = game.Guess(guessNumber.Number); //game.CheckResultOnly(guessNumber.Number);
                    guessCount++;
                    if (!hshHasTried.Contains(guessNumber.Number))
                    {
                        hshHasTried.Add(guessNumber.Number);
                    }
                    if(result.NumberofBulls ==0 && result.NumberofCows == 0)
                    {
                        AddHshNoDigit(hshNoDigit, guessNumber.Number);
                    }

                    if (result.NumberofBulls  == 4)
                    {
                        string str = "Break;";
                        game.Guess(guessNumber.Number);
                        Console.WriteLine("guessCount::" + guessCount);
                        answer = guessNumber.Number;
                        break;
                    }
                    if(result.NumberofCows == 4)
                {
                    String str = "Now we know what digit, just left the position";
                }
                    for (int j = 1; j < listGuessNumber.Count; j++)
                    {
                        if (!listGuessNumber[j].isValid)
                        {
                            continue;
                        }
                        if (hshInvalid.Contains(listGuessNumber[j].Number))
                        {
                            continue;
                        }
                        if (isItContainNoDigit (hshNoDigit ,listGuessNumber [j].Number))
                        {
                            if (!hshInvalid.Contains(listGuessNumber[j].Number))
                            {
                                hshInvalid.Add(listGuessNumber[j].Number);
                            }
                            listGuessNumber[j].isValid = false;
                        }
                        GuessResult checkResult= listGuessNumber[j].CheckResultWithAnotherNumber(guessNumber.Number);
                        
                        int noofmatch = listGuessNumber[j].NumberOfMatch(guessNumber.Number );
                        if(noofmatch < result.NumberofBulls + result.NumberofCows)
                        {
                            if (!hshInvalid.Contains(listGuessNumber[j].Number))
                            {
                                hshInvalid.Add(listGuessNumber[j].Number);
                            }
                            listGuessNumber[j].isValid = false;
                        }
                        if(checkResult.NumberofBulls != result.NumberofBulls)
                    {
                        if (!hshInvalid.Contains(listGuessNumber[j].Number))
                        {
                            hshInvalid.Add(listGuessNumber[j].Number);
                        }
                        listGuessNumber[j].isValid = false;
                    }
                        /*
                        var resultFromOtherNumber = game.CheckResultOnly(listGuessNumber[j].Number);
                        if (!resultFromOtherNumber.isEqual(result))
                        {
                            listGuessNumber[i].isValid = false;
                            iCountInValid++;
                            if (!hshInvalid.Contains(listGuessNumber[j].Number))
                            {
                                hshInvalid.Add(listGuessNumber[j].Number);
                            }
                        }
                        */

                    }
                   // System.Console.WriteLine("Invalid::" + iCountInValid);


                }
                if(game.GameResult == Game.GameResultEnum.Win)
            {
                return $@"Answer is {answer} no of guess is {guessCount}";
            }

            return $@" You lost number of guess is {guessCount}";
                System.Console.WriteLine("Invalid::" + hshInvalid.Count );

                // game.CheckResult ()
                //  game.CheckResultOnly ()
                //game.CheckResult(number.ToString());

            
        }

    }
}
