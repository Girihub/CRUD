//----------------------------------------------------
// <copyright file="Employee.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace BusinessManager.Services
{
    using System.Collections.Generic;
    using BusinessManager.Interfaces;
    using Common.Models;
    using EmployeeRepository.Interfaces;    

    /// <summary>
    /// Employee class which implements interface IEmployee
    /// </summary>
    public class Employee : IEmployee
    {
        /// <summary>
        /// declare private field repository
        /// </summary>
        private IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="repository">repository as a parameter</param>
        public Employee(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Method to add employee 
        /// </summary>
        /// <param name="employeeModel">employeeModel as a parameter</param>
        /// <returns>call AddEmployee method from repository</returns>
        public bool AddEmployee(EmployeeModel employeeModel)
        {
            return this.repository.AddEmployee(employeeModel);
        }

        /// <summary>
        /// Method to delete employee
        /// </summary>
        /// <param name="id">id as a parameter</param>
        /// <returns>call DeleteEmployee method from repository</returns>
        public bool DeleteEmployee(int id)
        {
            return this.repository.DeleteEmployee(id);
        }

        /// <summary>
        /// Method to display employee
        /// </summary>
        /// <returns>call DisplayEmployees method from repository</returns>
        public IList<EmployeeModel> DisplayEmployee()
        {
            return this.repository.DisplayEmployees();
        }

        /// <summary>
        /// Method to update employee
        /// </summary>
        /// <param name="id">id as a parameter</param>
        /// <param name="employeeModel">employeeModel as a parameter</param>
        /// <returns>call UpdateEmployee method from repository</returns>
        public bool UpdateEmployee(int id, EmployeeModel employeeModel)
        {
            return this.repository.UpdateEmployee(id, employeeModel);
        }

        /// <summary>
        /// Method to Get Employee By Id employee
        /// </summary>
        /// <param name="id">id as a parameter</param>
        /// <returns>call GetEmployeeById method from repository</returns>
        public IList<EmployeeModel> GetEmployeeById(int id)
        {
            return this.repository.GetEmployeeById(id);
        }
    }
}
