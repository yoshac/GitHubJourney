using banking_service.Controllers;
using banking_service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore.SqlServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddScoped<IBankingService, BankingService>();
builder.Services.AddScoped<IBankingService,BankingService>();
builder.Services.AddSingleton<IAccountRepository,InMemoryAccountRepository>();
//builder.Services.AddDbContext<BankingDbContext>(
//    Options=>Options.UseSqlServer(builder.Configuration.GetConnectionString("dgfdgdf"))
//    );
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Bank}/{action=GetStatus}/{id?}");
app.MapControllers();
app.Run();
