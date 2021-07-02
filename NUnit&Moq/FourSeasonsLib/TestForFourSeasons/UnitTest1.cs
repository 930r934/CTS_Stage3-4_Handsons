using System;
using NUnit;
using NUnit.Framework;
using SeasonsLib;

namespace TestForFourSeasons
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            SeasonTeller s = new SeasonTeller();
            Assert.AreEqual(s.DisplaySeasonBy("JAnuary"),"Winter");
            Assert.AreEqual(s.DisplaySeasonBy("February"), "Spring");
            Assert.AreEqual(s.DisplaySeasonBy("MaY"), "Summer");
            Assert.AreEqual(s.DisplaySeasonBy("July"), "Monsoon");
        }
    }
}
