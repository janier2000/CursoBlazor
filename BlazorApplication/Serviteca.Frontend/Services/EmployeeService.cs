using EmployeeManagement.Models;

namespace Serviteca.Frontend.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<IEnumerable<Employee>> GetEmployees()
        {
            throw new NotImplementedException();
        }

        //public async Task<IEnumerable<Employee>> GetEmployees()
        //{
        //    return await httpClient.GetJsonAsync<Employee[]>("api/employees");
        //}

        //public async Task<IEnumerable<Employee>> GetEmployees()
        //{
        //    return await httpClient.GetJsonAsync<Employee[]>("api/employees");
        //}

        //public async Task<IEnumerable<Employee>> IEmployeeService.GetEmployees()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
