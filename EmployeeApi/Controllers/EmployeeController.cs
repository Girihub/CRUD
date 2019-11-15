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
        public bool AddEmployee(EmployeeModel employeeModel)
        {
            return _employee.AddEmployee(employeeModel);
             
        }

        [HttpPut]
        public bool UpdateEmployee(int id, EmployeeModel employeeModel)
        {
            return _employee.UpdateEmployee(id, employeeModel);
        }

        [HttpDelete]
        public bool DeleteEmployee(int id)
        {
            return _employee.DeleteEmployee(id);
        }
    }
}