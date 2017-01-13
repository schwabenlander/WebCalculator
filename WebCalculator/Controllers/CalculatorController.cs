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
        public IHttpActionResult Add([FromBody]EquationOperandsModel equation)
        {
            return Ok(equation.Operand1 + equation.Operand2);
        }

        [Route("api/calculator/subtract")]
        public IHttpActionResult Subtract([FromBody]EquationOperandsModel equation)
        {
            return Ok(equation.Operand1 - equation.Operand2);
        }

        [Route("api/calculator/multiply")]
        public IHttpActionResult Multiply([FromBody]EquationOperandsModel equation)
        {
            return Ok(equation.Operand1 * equation.Operand2);
        }

        [Route("api/calculator/divide")]
        public IHttpActionResult Divide([FromBody]EquationOperandsModel equation)
        {
            return Ok(equation.Operand1 / equation.Operand2);
        }

        [Route("api/calculator/mod")]
        public IHttpActionResult Mod([FromBody]EquationOperandsModel equation)
        {
            return Ok(equation.Operand1 % equation.Operand2);
        }

        [Route("api/calculator/square")]
        public IHttpActionResult Square([FromBody]EquationOperandsModel equation)
        {
            return Ok(equation.Operand1 * equation.Operand1);
        }

        [Route("api/calculator/squareroot")]
        public IHttpActionResult SquareRoot([FromBody]EquationOperandsModel equation)
        {
            return Ok(Math.Sqrt(equation.Operand1));
        }

        [Route("api/calculator/sin")]
        public IHttpActionResult Sin([FromBody]EquationOperandsModel equation)
        {
            return Ok(Math.Sin(equation.Operand1));
        }

        [Route("api/calculator/cos")]
        public IHttpActionResult Cos([FromBody]EquationOperandsModel equation)
        {
            return Ok(Math.Cos(equation.Operand1));
        }

        [Route("api/calculator/tan")]
        public IHttpActionResult Tan([FromBody]EquationOperandsModel equation)
        {
            return Ok(Math.Tan(equation.Operand1));
        }
    }
}
