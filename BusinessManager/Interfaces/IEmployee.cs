using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Interfaces
{
    public interface IEmployee
    {
        bool AddEmployee(EmployeeModel employeeModel);

        bool DeleteEmployee(int id);

        IList<EmployeeModel> DisplayEmployee();

        bool UpdateEmployee(int id, EmployeeModel employeeModel);

        string GetEmployee(int id);
    }
}
