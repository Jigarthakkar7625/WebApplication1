using Microsoft.EntityFrameworkCore;
using WebApplication.Data.Models;
using WebApplication.Service;
using WebApplication.Service.IServices;
//using WebApplication1.Models;

var builder = Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddControllersWithViews();


// Get connection string From Appsetting.json file>> 
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Connection >> SQL + EF
builder.Services.AddDbContext<TestAvinashContext>(options =>
    options.UseSqlServer(connectionString));

//  DependencyInjection
builder.Services.AddTransient<IUsers, Users>();


var app = builder.Build();


//___________________________________________________________________

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
