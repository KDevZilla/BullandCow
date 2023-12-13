using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BullandCow;
namespace UnitTestBullandCow
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateGame()
        {
            Game game = new Game();
            Assert.AreEqual(game.GameResult , Game.GameResultEnum.NotDecide );

            game.GenereateSecretNumberForTesting("1234");
            Assert.AreEqual(game.SecretNumber, "1234");

          
        }

        [TestMethod]
        public void CheckResultWin()
        {
            Game game = new Game();
           

            game.GenereateSecretNumberForTesting("1234");
           
            GuessResult guessResult = game.Guess("1345");
            Assert.AreEqual(guessResult.NumberofBulls, 1);
            Assert.AreEqual(guessResult.NumberofCows, 2);
            Assert.AreEqual(game.GameResult, Game.GameResultEnum.NotDecide);


            guessResult = game.Guess("6789");
            Assert.AreEqual(guessResult.NumberofBulls, 0);
            Assert.AreEqual(guessResult.NumberofCows, 0);
            Assert.AreEqual(game.GameResult, Game.GameResultEnum.NotDecide);

            try
            {
                guessResult = game.Guess("1134");
                Assert.Fail("It must fail");
            }catch (ArgumentException ex)
            {
                    
            }


            guessResult = game.Guess("4321");
            Assert.AreEqual(guessResult.NumberofBulls, 0);
            Assert.AreEqual(guessResult.NumberofCows, 4);
            Assert.AreEqual(game.GameResult, Game.GameResultEnum.NotDecide);

            guessResult = game.Guess("1234");
            Assert.AreEqual(guessResult.NumberofBulls, 4);
            Assert.AreEqual(guessResult.NumberofCows, 0);
            Assert.AreEqual(game.GameResult, Game.GameResultEnum.Win);

        }

        [TestMethod]
        public void CheckResultLost()
        {
            Game game = new Game();


            game.GenereateSecretNumberForTesting("1234");

            GuessResult guessResult = game.Guess("1345");
            Assert.AreEqual(guessResult.NumberofBulls, 1);
            Assert.AreEqual(guessResult.NumberofCows, 2);
            Assert.AreEqual(game.GameResult, Game.GameResultEnum.NotDecide);

            game.Guess("1345");
            game.Guess("1345");
            game.Guess("1345");
            game.Guess("1345");
            game.Guess("1345");
            game.Guess("1345");
            game.Guess("1345");

            Assert.AreEqual(game.GameResult, Game.GameResultEnum.Lose);

        }
    }
}
