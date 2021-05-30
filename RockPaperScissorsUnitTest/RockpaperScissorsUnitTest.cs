using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors_Console;

namespace RockPaperScissorsUnitTest
{
    [TestClass]
    public class RockpaperScissorsUnitTest
    {
        [TestMethod]
        public void TestRockPaperScissorReturnWinner()
        {
            int count = 0;
            int count1 = 0;
            
            Game game = new Game("Rock");
            string result = game.ReturnWinner(ref count, ref count1);
            Assert.AreEqual("Same choices", result);
        }
    }
}
