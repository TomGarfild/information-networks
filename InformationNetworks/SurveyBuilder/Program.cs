using System.Reflection;
using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SurveyBuilder.Data;
using SurveyBuilder.Data.Repositories;
using SurveyBuilder.Domain.Models;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
var configuration = builder.Configuration;

services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>();

services.AddControllersWithViews();
/*services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Survey Builder", Version = "v1" });
});*/

services.AddAuthentication()
    .AddGoogle(options => {
        options.ClientId = configuration["Authentication:Google:ClientId"]!;
        options.ClientSecret = configuration["Authentication:Google:ClientSecret"]!;
    });

services.AddMediatR(serviceConfiguration =>
    serviceConfiguration.RegisterServicesFromAssembly(typeof(Program).Assembly));

TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());

services
    .AddScoped<IRepository<Survey>, SurveyRepository>()
    .AddScoped<IRepository<Response>, ResponseRepository>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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

/*
app.UseSwagger();

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    c.RoutePrefix = string.Empty;
});
*/

app.Run();