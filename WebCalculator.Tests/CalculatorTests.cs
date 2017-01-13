using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebCalculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Two_Plus_Two_Equals_Four()
        {
            int expectedResult = 4;

            Assert.AreEqual(expectedResult, 2 + 2);
        }
    }
}
