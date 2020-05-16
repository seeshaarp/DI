using DI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Validators
{
    public class DuplicateEmployeeValidator : IEmployeeValidator
    {
        public bool IsValid(Employee employee)
        {
          return true;
        }
    }
}
