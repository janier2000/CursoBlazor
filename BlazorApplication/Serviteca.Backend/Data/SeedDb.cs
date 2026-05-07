using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace Serviteca.Backend.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
       
        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckDepartmentAsync();
            await CheckEmployeesAsync();
        }

        private async Task CheckDepartmentAsync()
        {
            if (!_context.Departments.Any())
            {
                _ = _context.Departments.Add(new Department
                {
                    DepartmentId=1,
                    DepartmentName = "IT"
                });
                _ = _context.Departments.Add(new Department
                {
                    DepartmentId = 2,
                    DepartmentName = "HR"
                });
                _ = _context.Departments.Add(new Department
                {
                    DepartmentId = 3,
                    DepartmentName = "Payroll"
                });
                _ = _context.Departments.Add(new Department
                {
                    DepartmentId = 4,
                    DepartmentName = "Admin"
                });
            }
            await _context.SaveChangesAsync();
        }
        private async Task CheckEmployeesAsync()
        {
            if (!_context.Employees.Any())
            {
                _ = _context.Employees.Add(new Employee
                {
                    EmployeeId = 1,
                    FirstName = "John",
                    LastName = "Hastings",
                    Email = "David@pragimtech.com",
                    DateOfBrith = new DateTime(1980, 10, 5),
                    Gender = Gender.Male,
                    DepartmentId = 1,
                    PhotoPath = "images/john.png"
                });
                _context.Employees.Add(new Employee
                {
                    EmployeeId = 2,
                    FirstName = "Sam",
                    LastName = "Galloway",
                    Email = "Sam@pragimtech.com",
                    DateOfBrith = new DateTime(1981, 12, 22),
                    Gender = Gender.Male,
                    DepartmentId = 2,
                    PhotoPath = "images/sam.jpg"

                });
                _context.Employees.Add(new Employee
                {
                    EmployeeId = 3,
                    FirstName = "Mary",
                    LastName = "Smith",
                    Email = "mary@pragimtech.com",
                    DateOfBrith = new DateTime(1979, 11, 11),
                    Gender = Gender.Female,
                    DepartmentId = 1,
                    PhotoPath = "images/mary.png"

                });
                _context.Employees.Add(new Employee
                {
                    EmployeeId = 3,
                    FirstName = "Mary",
                    LastName = "Smith",
                    Email = "mary@pragimtech.com",
                    DateOfBrith = new DateTime(1979, 11, 11),
                    Gender = Gender.Female,
                    DepartmentId = 1,
                    PhotoPath = "images/mary.png"
                });
                _context.Employees.Add(new Employee
                {
                    EmployeeId = 4,
                    FirstName = "Sara",
                    LastName = "Longway",
                    Email = "sara@pragimtech.com",
                    DateOfBrith = new DateTime(1982, 9, 23),
                    Gender = Gender.Female,
                    DepartmentId = 3,
                    PhotoPath = "images/sara.png"
                });
            }
            await _context.SaveChangesAsync();
        }

    }
}
