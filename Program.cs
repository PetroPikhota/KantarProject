using Microsoft.AspNetCore.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddMvc();
        builder.Services.AddRazorPages();
        var app = builder.Build();

        app.UseStatusCodePagesWithRedirects("/Home/Index");

        app.MapDefaultControllerRoute();
        app.Run();
    }

}