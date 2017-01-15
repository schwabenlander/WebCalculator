using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using NUnit.Framework;
using WebCalculator.Controllers;
using WebCalculator.Models;

namespace WebCalculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_ShouldAddTwoDoubles()
        {
            var controller = new CalculatorController();
            var operands = new EquationOperandsModel {Operand1 = 3, Operand2 = 4};

            IHttpActionResult actionResult = controller.Add(operands);
            var result = actionResult as OkNegotiatedContentResult<double>;
            Assert.NotNull(result);
            Assert.AreEqual(7, result.Content);
        }

        [Test]
        public void Subtract_ShouldDifferenceTwoDoubles()
        {
            var controller = new CalculatorController();
            var operands = new EquationOperandsModel { Operand1 = 8, Operand2 = 5 };

            IHttpActionResult actionResult = controller.Subtract(operands);
            var result = actionResult as OkNegotiatedContentResult<double>;
            Assert.NotNull(result);
            Assert.AreEqual(3, result.Content);
        }

        [Test]
        public void Multiply_ShouldMultiplyTwoDoubles()
        {
            var controller = new CalculatorController();
            var operands = new EquationOperandsModel { Operand1 = 6, Operand2 = 9 };

            IHttpActionResult actionResult = controller.Multiply(operands);
            var result = actionResult as OkNegotiatedContentResult<double>;
            Assert.NotNull(result);
            Assert.AreEqual(54, result.Content);
        }

        [Test]
        public void Divide_ShouldDivideTwoDoubles()
        {
            var controller = new CalculatorController();
            var operands = new EquationOperandsModel { Operand1 = 9, Operand2 = 3 };

            IHttpActionResult actionResult = controller.Divide(operands);
            var result = actionResult as OkNegotiatedContentResult<double>;
            Assert.NotNull(result);
            Assert.AreEqual(3, result.Content);
        }

        [Test]
        public void SquareRoot_ShouldCalculateTheSquareRootOfADouble()
        {
            var controller = new CalculatorController();
            var operands = new EquationOperandsModel { Operand1 = 64 };

            IHttpActionResult actionResult = controller.SquareRoot(operands);
            var result = actionResult as OkNegotiatedContentResult<double>;
            Assert.NotNull(result);
            Assert.AreEqual(8, result.Content);
        }

        [Test]
        public void Square_ShouldCalculateTheSquareOfADouble()
        {
            var controller = new CalculatorController();
            var operands = new EquationOperandsModel { Operand1 = 8 };

            IHttpActionResult actionResult = controller.Square(operands);
            var result = actionResult as OkNegotiatedContentResult<double>;
            Assert.NotNull(result);
            Assert.AreEqual(64, result.Content);
        }

        [Test]
        public void Sin_ShouldCalculateTheSineOfADouble()
        {
            var controller = new CalculatorController();
            var operands = new EquationOperandsModel { Operand1 = 0 };

            IHttpActionResult actionResult = controller.Sin(operands);
            var result = actionResult as OkNegotiatedContentResult<double>;
            Assert.NotNull(result);
            Assert.AreEqual(0, result.Content);
        }

        [Test]
        public void Cos_ShouldCalculateTheCosineOfADouble()
        {
            var controller = new CalculatorController();
            var operands = new EquationOperandsModel { Operand1 = 0 };

            IHttpActionResult actionResult = controller.Cos(operands);
            var result = actionResult as OkNegotiatedContentResult<double>;
            Assert.NotNull(result);
            Assert.AreEqual(1, result.Content);
        }

        [Test]
        public void Tan_ShouldCalculateTheTangentOfADouble()
        {
            var controller = new CalculatorController();
            var operands = new EquationOperandsModel { Operand1 = 0 };

            IHttpActionResult actionResult = controller.Tan(operands);
            var result = actionResult as OkNegotiatedContentResult<double>;
            Assert.NotNull(result);
            Assert.AreEqual(0, result.Content);
        }
    }
}
