using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using handsonsforCoreApi.Filters;
using handsonsforCoreApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace handsonsforCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[CustomAuthFilter]
    [Authorize]
    [CustomExceptionFilter]
    public class EmployeeController : ControllerBase
    {
            List<Employee> employees = new List<Employee>() { new Employee() {
            Id = 5,
            Name = "George",
            Salary = 5000000,
            Permanent = true,
            Skills = null,
            DateOfBirth = DateTime.Parse("06/04/1999")
            },

            new Employee() {
            Id = 2,
            Name = "Vardin",
            Salary = 590000,
            Permanent = false,
            Skills = null,
            DateOfBirth = DateTime.Parse("06/04/1999")
            }
            };

        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employees;
        }

        // GET api/<EmployeeController>/5
        
        [HttpGet("{id}")]
        
        public ActionResult<Employee> GetEmployee(int id)
        {
            
            foreach (var x in employees)
            {
                if(x.Id == id)
                {
                    return x;
                }
            }
            
            return NotFound();
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [Microsoft.AspNetCore.Mvc.FromBody] string value)
        {
            foreach (var x in employees)
            {
                if (x.Id == id)
                {
                    x.Name = value;
                    return x;
                }
            }
            return null;
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
