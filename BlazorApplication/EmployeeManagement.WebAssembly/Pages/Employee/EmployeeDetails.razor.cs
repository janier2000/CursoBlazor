using CurrieTechnologies.Razor.SweetAlert2;
using EmployeeManagement.WebAssembly.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using e = EmployeeManagement.Models;

namespace EmployeeManagement.WebAssembly.Pages.Employee
{
    public partial class EmployeeDetails
    {
        private e.Employee? employeeENT;
        protected string Coordinates { get; set; }
        [Inject] private IRepository Repository { get; set; } = null!;
        [EditorRequired, Parameter] public int Id { get; set; }
        protected string ButtonText { get; set; } = "Hide Footer";
        protected string CssClass { get; set; } = null;

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

        protected void Mouse_Move(MouseEventArgs e)
        {
            Coordinates = $"X = {e.ClientX} Y = {e.ClientY}";
        }

        protected void Button_Click()
        {
            if (ButtonText == "Hide Footer")
            {
                ButtonText = "Show Footer";
                CssClass = "HideFooter";
            }
            else
            {
                CssClass = null;
                ButtonText = "Hide Footer";
            }
        }

    }
}