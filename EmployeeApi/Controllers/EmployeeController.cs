using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessManager.Interfaces;
using Common.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly IEmployee _employee;

        public EmployeeController(IEmployee employee)
        {
            _employee = employee;
        }

        [HttpPost]
        public IActionResult AddEmployee(EmployeeModel employeeModel)
        {
            var result = _employee.AddEmployee(employeeModel);
            return Ok(new { result });
             
        }

        [HttpPut]
        public IActionResult UpdateEmployee(int id, EmployeeModel employeeModel)
        {
            var result = _employee.UpdateEmployee(id, employeeModel);
            return Ok(new { result });
        }

        [HttpDelete]
        public IActionResult DeleteEmployee(int id)
        {
            var result = _employee.DeleteEmployee(id);
            return Ok(new { result });
        }

        [HttpGet]
        public IList<EmployeeModel> DisplayEmployees()
        {
            return _employee.DisplayEmployee();
        }
    }
}