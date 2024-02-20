using Microsoft.EntityFrameworkCore;
using ProgrammingChallenge6._1.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Db connection
var connectionString = builder.Configuration.GetConnectionString("SchoolDbContextConnection");
builder.Services.AddDbContext<SchoolDbContext>(options =>
       options.UseSqlServer(connectionString));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
