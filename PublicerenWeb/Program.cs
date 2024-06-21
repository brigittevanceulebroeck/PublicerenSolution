using Microsoft.EntityFrameworkCore;
using PublicerenWeb.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<PrulariaComContext>(
        options => options.UseMySQL(
                builder.Configuration.GetConnectionString("PrulariaComConnection")));
builder.Services.AddScoped<IActiecodeRepository, SQLActiecodeRepository>();
builder.Services.AddControllersWithViews();

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
