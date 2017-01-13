using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebCalculator.Models;

namespace WebCalculator.Controllers
{
    public class CalculatorController : ApiController
    {
        [Route("api/calculator/add")]
        public IHttpActionResult Add(EquationOperandsModel equation)
        {
            return Ok(equation.Operand1 + equation.Operand2);
        }

        [Route("api/calculator/subtract")]
        public IHttpActionResult Subtract(int x, int y)
        {
            return Ok(x - y);
        }

        [Route("api/calculator/multiply")]
        public IHttpActionResult Multiply(double x, double y)
        {
            return Ok(x * y);
        }

        [Route("api/calculator/divide")]
        public IHttpActionResult Divide(double x, double y)
        {
            return Ok(x / y);
        }

        [Route("api/calculator/mod")]
        public IHttpActionResult Mod(double x, double y)
        {
            return Ok(x % y);
        }

        [Route("api/calculator/square")]
        public IHttpActionResult Square(double x)
        {
            return Ok(x * x);
        }

        [Route("api/calculator/squareroot")]
        public IHttpActionResult SquareRoot(double x)
        {
            return Ok(Math.Sqrt(x));
        }

        [Route("api/calculator/sin")]
        public IHttpActionResult Sin(double x)
        {
            return Ok(Math.Sin(x));
        }

        [Route("api/calculator/cos")]
        public IHttpActionResult Cos(double x)
        {
            return Ok(Math.Cos(x));
        }

        [Route("api/calculator/tan")]
        public IHttpActionResult Tan(double x)
        {
            return Ok(Math.Tan(x));
        }
    }
}
