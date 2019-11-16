//----------------------------------------------------
// <copyright file="EmployeeController.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace EmployeeApi.Controllers
{
    using System.Collections.Generic;
    using BusinessManager.Interfaces;
    using Common.Models;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// EmployeeController as a class
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// private field employee
        /// </summary>
        private readonly IEmployee employee;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        /// <param name="employee">employee as a parameter</param>
        public EmployeeController(IEmployee employee)
        {
            this.employee = employee;
        }

        /// <summary>
        /// AddEmployee method to add employee
        /// </summary>
        /// <param name="employeeModel">employeeModel as a parameter</param>
        /// <returns>return result in jason format</returns>
        /// POST api/values
        [HttpPost]
        public IActionResult AddEmployee(EmployeeModel employeeModel)
        {
            var result = this.employee.AddEmployee(employeeModel);
            return this.Ok(new { result });             
        }

        /// <summary>
        /// UpdateEmployee method to update employee data
        /// </summary>
        /// <param name="id">id as a parameter</param>
        /// <param name="employeeModel">employeeModel as a parameter</param>
        /// <returns>return result in jason format</returns>
        /// PUT api/values/5
        [HttpPut]
        public IActionResult UpdateEmployee(int id, EmployeeModel employeeModel)
        {
            var result = this.employee.UpdateEmployee(id, employeeModel);
            return this.Ok(new { result });
        }

        /// <summary>
        /// DeleteEmployee method to delete employee data
        /// </summary>
        /// <param name="id">id as a parameter</param>
        /// <returns>return result in jason format</returns>
        /// DELETE api/values/5
        [HttpDelete]
        public IActionResult DeleteEmployee(int id)
        {
            var result = this.employee.DeleteEmployee(id);
            return this.Ok(new { result });
        }

        /// <summary>
        /// DisplayEmployees method to display employee data
        /// </summary>
        /// <returns>returns list of employee</returns>
        /// GET api/values
        [HttpGet]
        public IList<EmployeeModel> DisplayEmployees()
        {
            return this.employee.DisplayEmployee();
        }

        /// <summary>
        /// GetEmployeeById method to get data by employee id
        /// </summary>
        /// <param name="id">id as a parameter</param>
        /// <returns>returns list of employee</returns>
        /// GET api/values/5
        [HttpGet]
        [Route("{id}")]
        public IList<EmployeeModel> GetEmployeeById(int id)
        {
            return this.employee.GetEmployeeById(id);
        }
    }
}