using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder();
builder.Services.AddRazorComponents().AddWebAssemblyComponents();

var app = builder.Build();
app.MapRazorComponents<RazorComponentEight.App>();
app.Run();