using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ZooApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using ZooApp.data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ZooAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ZooAppContext")
    ?? throw new InvalidOperationException("Connection string 'ZooAppContext' not found.")));

builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false; // USers do not have to confrima registration with this "false" in place.
})
.AddDefaultTokenProviders()
.AddRoles<IdentityRole>()
.AddEntityFrameworkStores<ZooAppContext>();



// Add services to the container 
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); // Ensure authentication is used
app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
