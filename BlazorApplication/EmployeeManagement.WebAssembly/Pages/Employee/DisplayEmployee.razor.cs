using Microsoft.AspNetCore.Components;
using e = EmployeeManagement.Models;

namespace EmployeeManagement.WebAssembly.Pages.Employee
{
    public partial class DisplayEmployee
    {
        [Parameter]
        public e.Employee Employee { get; set; }

        [Parameter]
        public bool ShowFooter { get; set; }
    }
}