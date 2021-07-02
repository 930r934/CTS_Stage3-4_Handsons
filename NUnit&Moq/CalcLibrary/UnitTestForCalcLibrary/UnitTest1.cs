using System;
using CalcLibrary;
using NUnit.Framework;

namespace UnitTestForCalcLibrary
{
    [TestFixture]
    public class UnitTest1
    {
        private SimpleCalculator A;

        public UnitTest1()
        {
            A = new SimpleCalculator();
        }

        [Test]
        public void TestCorrect_Add_vals()
        {
            var gen_output = A.Addition(5, 6);
            Assert.AreEqual(11, gen_output);
        }

        [Test]
        public void TestCorrect_Sub_vals()
        {
            var gen_output = A.Subtraction(6,5);
            Assert.AreEqual(1, gen_output);
        }

        [Test]
        public void TestCorrect_Mul_vals()
        {
            var gen_output = A.Multiplication(6, 5);
            Assert.AreEqual(30, gen_output);
        }

        [Test]
        public void TestException_DivByZero_vals()
        {
            Assert.Throws<ArgumentException>(() => A.Division(5,0));
        }
    }
}
