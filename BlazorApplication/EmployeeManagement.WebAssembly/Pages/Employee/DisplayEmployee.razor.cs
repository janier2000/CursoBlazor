using Microsoft.AspNetCore.Components;
using e = EmployeeManagement.Models;

namespace EmployeeManagement.WebAssembly.Pages.Employee
{
    public partial class DisplayEmployee
    {
        [Parameter] public e.Employee Employee { get; set; }
        [Parameter] public bool ShowFooter { get; set; }
        [Parameter] public EventCallback<bool> OnEmployeeSelection { get; set; }

        protected bool IsSelected { get; set; }

        protected async Task CheckBoxChanged(ChangeEventArgs e)
        {
            IsSelected = (bool)e.Value;
            await OnEmployeeSelection.InvokeAsync(IsSelected);
        }
    }
}