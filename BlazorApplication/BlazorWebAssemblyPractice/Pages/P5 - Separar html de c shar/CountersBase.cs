using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyPractice.Pages
{
    public class CountersBase : ComponentBase
    {
        protected int currentCount = 0;
        protected string fontFamily = "Verdana";

        protected void IncrementCount()
        {
            currentCount++;
        }
    }
}
