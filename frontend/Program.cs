using Blazored.Toast;
using frontend;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");



builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


builder.Services.AddLocalization();

/*builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://postwall-backend-service.azurewebsites.net/")
});*/

var backendURI = builder.HostEnvironment.IsDevelopment() ? "https://localhost:5001/" : "https://postwall-backend-service.azurewebsites.net/";

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(backendURI)
});

builder.Logging.SetMinimumLevel(LogLevel.Debug);//

//builder.Logging.AddConsole();


builder.Services.AddBlazorBootstrap();

builder.Services.AddBlazoredToast();

await builder.Build().RunAsync();
