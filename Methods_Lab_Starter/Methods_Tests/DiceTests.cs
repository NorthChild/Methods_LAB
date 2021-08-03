using NUnit.Framework;
using System;
using Methods_Lib;

namespace Methods_Tests
{
    public class DiceTests
    {
        // DONE 

        [TestCase(92,10)]
        [TestCase(155, 7)]
        public void DiceReturnTheSumFromRgn(int seed, int expectedRes) 
        {

            var rng = new Random(seed);
            var result = Methods.RollDice(rng);

            Assert.That(result, Is.EqualTo(expectedRes));

        }
    }
}
