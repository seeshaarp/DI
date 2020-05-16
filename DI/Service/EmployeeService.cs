using DI.DTO;
using System.Collections.Generic;

namespace DI.Service
{
    public class EmployeeService : IEmployeeService
    {
        public int AddEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee
                {
                    FirstName = "Jason",
                    LastName = "Mike",
                    Id = 1,
                    ECode ="111"
                },
                new Employee
                {
                    FirstName = "Albert",
                    LastName = "Regan",
                    Id = 2,
                    ECode ="001"
                },
                 new Employee
                {
                    FirstName = "Mary",
                    LastName = "Jhon",
                    Id = 3,
                    ECode ="002"
                },
            };
        }
    }
}
