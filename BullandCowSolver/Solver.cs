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

        public List<GuessNumberClass> GetValidNumber(String guessNumber, BullandCow.GuessResult result, List<GuessNumberClass> list)
        {
            int i;
            for (i = 0; i < list.Count; i++)
            {
                
            }
        }
        public void Solve(BullandCow.Game game)
        {
            List<String> listStringValidNumber = new List<string>();
            listStringValidNumber = GenAllPosibility(4, 1111, 9999, false);
            // genAllPosibility(4, 1, 9, 1, "", listResult);
            List<String> listGuess = new List<string>();
            List<GuessNumberClass> listGuessNumber = new List<GuessNumberClass>();

            listStringValidNumber.ForEach(x => listGuessNumber.Add(new GuessNumberClass(x)));

            while (game.GameResult == BullandCow.Game.GameResultEnum.NotDecide)
            {
                int i;
                for (i = 0; i < listGuessNumber.Count; i++)
                {
                    if(!listGuessNumber[i].isValid)
                    {
                        continue;
                    }
                    var result = game.CheckResultOnly(listGuessNumber[i].Number);
                    if(result.NumberofBulls ==0 && result.NumberofCows == 0)
                    {

                    }
                }
              // game.CheckResult ()
              //  game.CheckResultOnly ()
                //game.CheckResult(number.ToString());

            }
        }

    }
}
