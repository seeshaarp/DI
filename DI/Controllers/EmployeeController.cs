using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DI.DTO;
using DI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
           return  _employeeService.GetEmployees();
        }
        [HttpPost]
        public IEnumerable<Employee> InsertEmployees(Employee employee)
        {
            return _employeeService.AddEmployee();
        }
    }
}