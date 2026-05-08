using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Serviteca.Frontend;
using Serviteca.Frontend.Repositories;
using Serviteca.Frontend.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//cambio temporal
builder.Services
       .AddSingleton(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7021/") });


builder.Services.AddScoped<IRepository, Repository>();


builder.Services.AddScoped<IEmployeeService, EmployeeService>();

builder.Services.AddSweetAlert2();

builder.Services.AddMudServices();

await builder.Build().RunAsync();