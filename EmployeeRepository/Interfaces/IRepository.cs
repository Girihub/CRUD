using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeRepository.Interfaces
{
    public interface IRepository
    {
        bool AddEmployee(EmployeeModel employeeModel);
        bool DeleteEmployee(int id);
        bool UpdateEmployee(int id, EmployeeModel employeeModel);
        IList<EmployeeModel> DisplayEmployees();
        string GetEmployee(int id);
    }
}
