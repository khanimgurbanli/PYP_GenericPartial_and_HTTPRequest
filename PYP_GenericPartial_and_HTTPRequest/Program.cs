using PYP_GenericPartial_and_HTTPRequest.Services.Abstraction;
using Refit;
using System.Text.Json;
using PYP_GenericPartial_and_HTTPRequest.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddRefitHttpClient<IProductHttpClient>("https://dummyjson.com/");

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Products}/{action=Index}/{id?}");

app.Run();
