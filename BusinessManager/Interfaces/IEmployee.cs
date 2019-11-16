//----------------------------------------------------
// <copyright file="IEmployee.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace BusinessManager.Interfaces
{
    using System.Collections.Generic;
    using Common.Models;    

    /// <summary>
    /// IEmployee as an interface
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// Declare AddEmployee method to add new employee data
        /// </summary>
        /// <param name="employeeModel">employeeModel as a parameter</param>
        /// <returns>returns boolean value</returns>
        bool AddEmployee(EmployeeModel employeeModel);

        /// <summary>
        /// Declare DeleteEmployee method to delete new employee data
        /// </summary>
        /// <param name="id">id as a parameter</param>
        /// <returns>returns boolean value</returns>
        bool DeleteEmployee(int id);

        /// <summary>
        /// Declare Method to display employee
        /// </summary>
        /// <returns>returns list of employees</returns>
        IList<EmployeeModel> DisplayEmployee();

        /// <summary>
        /// Declare UpdateEmployee Method to update employee
        /// </summary>
        /// <param name="id">id of employee as a parameter</param>
        /// <param name="employeeModel">employeeModel as a parameter</param>
        /// <returns>returns boolean value</returns>
        bool UpdateEmployee(int id, EmployeeModel employeeModel);

        /// <summary>
        /// Declare Method to get data of employee by id
        /// </summary>
        /// <param name="id">id of employee as a parameter</param>
        /// <returns>returns data of employee in list</returns>
        IList<EmployeeModel> GetEmployeeById(int id);
    }
}
