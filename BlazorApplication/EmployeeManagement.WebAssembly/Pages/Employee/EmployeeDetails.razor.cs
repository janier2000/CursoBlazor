using CurrieTechnologies.Razor.SweetAlert2;
using EmployeeManagement.WebAssembly.Repositories;
using Microsoft.AspNetCore.Components;
using e = EmployeeManagement.Models;

namespace EmployeeManagement.WebAssembly.Pages.Employee
{
    public partial class EmployeeDetails
    {
        private e.Employee? employeeENT;
        [Inject] private IRepository Repository { get; set; } = null!;
        [EditorRequired, Parameter] public int Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await LoadEmployeeAsync();
        }

        private async Task LoadEmployeeAsync()
        {
            var responseHttp = await Repository.GetAsync<e.Employee>($"/api/employees/{Id}");
            if (responseHttp.Error)
            {
                var message = await responseHttp.GetErrorMessageAsync();
               
                return;
            }
            employeeENT = responseHttp.Response;
        }

    }
}