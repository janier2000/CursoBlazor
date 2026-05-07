using EmployeeManagement.Models;
using System.Reflection;

namespace EmployeeManagement.Web.Components.Pages.Employee
{
    public partial class EmployeeList
    {
        public IEnumerable<Models.Employee> LstEmployees { get; set; }

        //protected override async Task OnInitializedAsync()
        //{
        //    await LoadTemporalOrderAsync();
        //}

        private void LoadEmployees()
        {
            Models.Employee e1 = new Models.Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Hastings",
                Email = "David@pragimtech.com",
                DateOfBrith = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                //Department = new Department { DepartmentId = 1, DepartmentName = "IT" },
                PhotoPath = "images/john.png"
            };

            Models.Employee e2 = new Models.Employee
            {
                EmployeeId = 2,
                FirstName = "Sam",
                LastName = "Galloway",
                Email = "Sam@pragimtech.com",
                DateOfBrith = new DateTime(1981, 12, 22),
                Gender = Gender.Male,
                //Department = new Department { DepartmentId = 2, DepartmentName = "HR" },
                PhotoPath = "images/sam.jpg"
            };

            Models.Employee e3 = new Models.Employee
            {
                EmployeeId = 3,
                FirstName = "Mary",
                LastName = "Smith",
                Email = "mary@pragimtech.com",
                DateOfBrith = new DateTime(1979, 11, 11),
                Gender = Gender.Female,
                //Department = new Department { DepartmentId = 1, DepartmentName = "IT" },
                PhotoPath = "images/mary.png"
            };

            Models.Employee e4 = new Models.Employee
            {
                EmployeeId = 3,
                FirstName = "Sara",
                LastName = "Longway",
                Email = "sara@pragimtech.com",
                DateOfBrith = new DateTime(1982, 9, 23),
                Gender = Gender.Female,
                //Department = new Department { DepartmentId = 3, DepartmentName = "Payroll" },
                PhotoPath = "images/sara.png"
            };

            LstEmployees = new List<Models.Employee> { e1, e2, e3, e4 };
        }
    }
}