using EmployeeManagement.WebAssembly.Repositories;
using Microsoft.AspNetCore.Components;
using System.Net;
using e = EmployeeManagement.Models;

namespace EmployeeManagement.WebAssembly.Pages.Employee
{
    public partial class EmployeeEdit
    {
        public e.Employee EmployeeENT { get; set; } = new e.Employee();
        [Inject] private IRepository Repository { get; set; } = null!;

        [EditorRequired, Parameter] public int Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            var responseHttp = await Repository.GetAsync<e.Employee>($"/api/employees/{Id}");
            if (responseHttp.Error)
            {
                if (responseHttp.HttpResponseMessage.StatusCode == HttpStatusCode.NotFound)
                {
                    //NavigationManager.NavigateTo("/DocType");
                }
                else
                {
                    var message = await responseHttp.GetErrorMessageAsync();
                    //EnviarMensaje("Error", message!);
                }
            }
            else
            {
                EmployeeENT = responseHttp.Response;
            }
        }
    }
}