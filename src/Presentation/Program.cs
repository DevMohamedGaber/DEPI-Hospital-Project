using Microsoft.EntityFrameworkCore;
using Application.Interfaces;
using Application.Services;
using DataAccess.Interfaces;
using DataAccess.Contexts;
using DataAccess.Data;
using Microsoft.AspNetCore.Identity;
using DataAccess.Abstacts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// add Contexts
builder.Services.AddDbContext<ApplicationContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default"))
);

builder.Services.AddDbContext<IdentityContext>(
    options=> options.UseSqlServer(builder.Configuration.GetConnectionString("Identity")));

builder.Services.AddIdentity<User, IdentityRole<uint>>((options) =>
{
    options.User.RequireUniqueEmail = true;
})
    .AddEntityFrameworkStores<IdentityContext>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/SignIn";
    options.LogoutPath = "/Account/SignIn";
    
});




// Dependancy Injection
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IPatientRepository, PatientRepository>();

builder.Services.AddScoped<IPatientService, PatientService>();


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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
