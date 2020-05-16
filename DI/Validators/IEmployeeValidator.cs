using DI.DTO;

namespace DI.Validators
{
    public interface IEmployeeValidator
    {
        bool IsValid(Employee employee);
    }
}