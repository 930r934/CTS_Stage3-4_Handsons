using System;
using LeapYearCalculatorLib;
using NUnit.Framework;

namespace TestForLeapYear
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            LeapYearCalculator l = new LeapYearCalculator();
            var x = l.IsLeapYear(1200);
            Assert.AreEqual(x, -1);
            x = l.IsLeapYear(2000);
            Assert.AreEqual(x, 1);
            x = l.IsLeapYear(2001);
            Assert.AreEqual(x, 0);
                
        }
    }
}
