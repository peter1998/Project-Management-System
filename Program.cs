using Microsoft.EntityFrameworkCore;
using Project_Management_System;
using Project_Management_System.CustomMiddleware;
using Project_Management_System.DependencyInjection;



namespace Project_Management_System
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<StartUp>();
                });
    }
}


//var builder = WebApplication.CreateBuilder(args);
//// Add services to the container.



//builder.Services.AddControllersWithViews();
//builder.Services.AddTransient<IConsoleWriter, ConsoleWriter>();
//builder.Services.AddDbContext<AppDataContext>(options => options.UseSqlServer("DefaultConnection"));

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}



//app.UseHttpsRedirection();
//app.UseStaticFiles();
//app.UseRouting();
//app.UseMiddleware();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller}/{action=Index}/{id?}");

//app.MapFallbackToFile("index.html"); ;

//app.Run();
