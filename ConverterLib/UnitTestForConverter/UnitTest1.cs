using System;
using ConverterLib;
using NUnit.Framework;
using CurrencyConverterApp;

namespace UnitTestForConverter
{
    [TestFixture]
    public class UnitTest1
    {
        private Converter c;
        IDollarToEuroExchangeRateFeed exchangeRateFeed;
        [Test]
        public void Test_For_CelsiusToKelvin()
        {
            c = new Converter(exchangeRateFeed);

            var gen_output = c.CelsiusToKelvin(35);

            Assert.AreEqual(308.15,gen_output);

        }

        [Test]
        public void Test_For_KilogramToPound()
        {
            c = new Converter(exchangeRateFeed);

            var gen_output = c.KilogramToPound(35);

            Assert.AreEqual(77.175, gen_output);

        }

        [Test]
        public void Test_For_KilometerToMile()
        {
            c = new Converter(exchangeRateFeed);

            var gen_output = c.KilometerToMile(35);

            Assert.AreEqual(21.75264139216905, gen_output);

        }

        [Test]
        public void Test_For_LiterToGallon()
        {
            c = new Converter(exchangeRateFeed);

            var gen_output = c.LiterToGallon(35);

            Assert.AreEqual(9.2470277410832225, gen_output);

        }

        [Test]
        public void Test_For_USDToEuro()
        {
            c = new Converter(exchangeRateFeed);

            var gen_output = c.USDToEuro(35);

            Assert.AreEqual(273.15, gen_output);

        }

    }
}
