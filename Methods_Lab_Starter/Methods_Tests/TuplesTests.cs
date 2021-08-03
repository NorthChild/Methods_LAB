using NUnit.Framework;
using Methods_Lib;
using System;

namespace Methods_Tests
{   
        // 1 / 1 DONE

    public class TuplesTests
    {
        [TestCase(25, 3, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(33, 4, 5)]
        public void GivenANumber_DaysAndWeeks_ReturnsCorrectTuple(int totalDays, int expectedWeeks, int expectedDays)
        {
            var answer = Methods.DaysAndWeeks(totalDays);
            Assert.That(answer.weeks, Is.EqualTo(expectedWeeks), "Weeks");
            Assert.That(answer.days, Is.EqualTo(expectedDays), "Days");
        }
        [Test]
        public void GivenANegativeNumber_DaysAndWeeks_ThrowsAnException()
        {
            Assert.That(() => Methods.DaysAndWeeks(-1), Throws.TypeOf<ArgumentOutOfRangeException>()
        .With.Message.Contain("totalDays must not be negative"));
        }

        // DONE

        [TestCase(16, 64, 2.0d, 4)]
        [TestCase(6561, 531441, 9.0d, 81)]
        [TestCase(196, 2744, 3.7416573867739413d, 14)]
        public void GivenAnIntGetSquareCubeSqrRootInTuple(int pow, int squa, double sqrRt, int num) 
        {

            Assert.That(() => Methods.GiveMeATuple(num), Is.EqualTo((pow, squa, sqrRt)));
            
        }


    }
}