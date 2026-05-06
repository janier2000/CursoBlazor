using Microsoft.AspNetCore.Components;

namespace Serviteca.Frontend.Pages.P5___Separar_html_de_c_shar
{
    public class Counter2Base : ComponentBase
    {
        protected int currentCount = 0;
        protected string fontFamily = "Verdana";

        protected void IncrementCount()
        {
            currentCount++;
        }
    }
}
