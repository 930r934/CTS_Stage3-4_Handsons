using System;
using CollectionsLib;
using NUnit.Framework;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        private EmployeeManager E;

        [Test]
        public void Test_For_Return_List()
        {
            E = new EmployeeManager();

            var gen_output = E.GetEmployees();
            bool Are_years_less = true;

            foreach( var e in gen_output)
            {
                if (e.DOJ.Year > DateTime.Now.Year)
                    Are_years_less = false;
            }

            Assert.IsTrue(Are_years_less);
        }

    }
}
