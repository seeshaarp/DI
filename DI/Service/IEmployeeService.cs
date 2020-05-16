using DI.DTO;
using System.Collections.Generic;

namespace DI.Service
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        int AddEmployee(Employee employee);
    }
}