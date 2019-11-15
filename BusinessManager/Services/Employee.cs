using BusinessManager.Interfaces;
using Common.Models;
using EmployeeRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Services
{
    public class Employee : IEmployee
    {
        IRepository _repository;

        public Employee(IRepository repository)
        {
            _repository = repository;
        }

        public bool AddEmployee(EmployeeModel employeeModel)
        {
            return _repository.AddEmployee(employeeModel);

        }

        public bool DeleteEmployee(int id)
        {
            return _repository.DeleteEmployee(id);
        }

        public IList<EmployeeModel> DisplayEmployee()
        {
            throw new NotImplementedException();
        }

        public string GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEmployee(int id, EmployeeModel employeeModel)
        {
            return _repository.UpdateEmployee(id, employeeModel);
        }
    }
}
