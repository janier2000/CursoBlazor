using EmployeeManagement.Models;

namespace Serviteca.Frontend.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
    }
}
