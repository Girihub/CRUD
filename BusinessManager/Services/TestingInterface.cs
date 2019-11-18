using BusinessManager.Interfaces;
using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessManager.Services
{
    class TestingInterface : IEmployee
    {
        public bool AddEmployee(EmployeeModel employeeModel)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public IList<EmployeeModel> DisplayEmployee()
        {
            throw new NotImplementedException();
        }

        public IList<EmployeeModel> GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEmployee(int id, EmployeeModel employeeModel)
        {
            throw new NotImplementedException();
        }
    }
}
