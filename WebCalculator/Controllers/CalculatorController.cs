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
            double result;

            try
            {
                result = equation.Operand1 + equation.Operand2;
            }
            catch (Exception)
            {
                return BadRequest("Invalid input.");
            }
            
            return Ok(result);
        }

        [Route("api/calculator/subtract")]
        public IHttpActionResult Subtract([FromBody]EquationOperandsModel equation)
        {
            double result;

            try
            {
                result = equation.Operand1 - equation.Operand2;
            }
            catch (Exception)
            {
                return BadRequest("Invalid input.");
            }

            return Ok(result);
        }

        [Route("api/calculator/multiply")]
        public IHttpActionResult Multiply([FromBody]EquationOperandsModel equation)
        {
            double result;

            try
            {
                result = equation.Operand1 * equation.Operand2;
            }
            catch (Exception)
            {
                return BadRequest("Invalid input.");
            }

            return Ok(result);
        }

        [Route("api/calculator/divide")]
        public IHttpActionResult Divide([FromBody]EquationOperandsModel equation)
        {
            double result;

            try
            {
                result = equation.Operand1 / equation.Operand2;
            }
            catch (Exception)
            {
                return BadRequest("Invalid input.");
            }

            return Ok(result);
        }

        [Route("api/calculator/mod")]
        public IHttpActionResult Mod([FromBody]EquationOperandsModel equation)
        {
            double result;

            try
            {
                result = equation.Operand1 % equation.Operand2;
            }
            catch (Exception)
            {
                return BadRequest("Invalid input.");
            }

            return Ok(result);
        }

        [Route("api/calculator/square")]
        public IHttpActionResult Square([FromBody]EquationOperandsModel equation)
        {
            double result;

            try
            {
                result = equation.Operand1 * equation.Operand1;
            }
            catch (Exception)
            {
                return BadRequest("Invalid input.");
            }

            return Ok(result);
        }

        [Route("api/calculator/squareroot")]
        public IHttpActionResult SquareRoot([FromBody]EquationOperandsModel equation)
        {
            double result;

            try
            {
                result = Math.Sqrt(equation.Operand1);
            }
            catch (Exception)
            {
                return BadRequest("Invalid input.");
            }

            return Ok(result);
        }

        [Route("api/calculator/sin")]
        public IHttpActionResult Sin([FromBody]EquationOperandsModel equation)
        {
            double result;

            try
            {
                result = Math.Sin(equation.Operand1);
            }
            catch (Exception)
            {
                return BadRequest("Invalid input.");
            }

            return Ok(result);
        }

        [Route("api/calculator/cos")]
        public IHttpActionResult Cos([FromBody]EquationOperandsModel equation)
        {
            double result;

            try
            {
                result = Math.Cos(equation.Operand1);
            }
            catch (Exception)
            {
                return BadRequest("Invalid input.");
            }

            return Ok(result);
        }

        [Route("api/calculator/tan")]
        public IHttpActionResult Tan([FromBody]EquationOperandsModel equation)
        {
            double result;

            try
            {
                result = Math.Tan(equation.Operand1);
            }
            catch (Exception)
            {
                return BadRequest("Invalid input.");
            }

            return Ok(result);
        }
    }
}
