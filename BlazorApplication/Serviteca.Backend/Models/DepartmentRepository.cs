using Serviteca.Backend.Data;
using EmployeeManagement.Models;

namespace EmployeeManagements.Api.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly DataContext _context;

        public DepartmentRepository(DataContext context)
        {
            _context = context;
        }

        public Department GetDepartment(int departmentId)
        {
            return _context.Departments
                .FirstOrDefault(d => d.Id == departmentId);
        }

        public IEnumerable<Department> GetDepartments()
        {
            return _context.Departments;
        }
    }
}