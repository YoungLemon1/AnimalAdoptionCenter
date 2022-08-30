using AnimalAdoptionCenter.Data;
using AnimalAdoptionCenter.Services.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IRepository, DataRepository>();
//builder.Services.AddDbContext<AnimalAdoptionCenterContext>(options => options.UseSqlite("Data Source=C:\\temp\\AnimalAdoptionCenterDb.db"));
string connectionString = builder.Configuration["ConnectionStrings:DefaultConnection"];
builder.Services.AddDbContext<AACContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddControllersWithViews();
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var ctx = scope.ServiceProvider.GetRequiredService<AACContext>();
    ctx.Database.EnsureDeleted();
    ctx.Database.EnsureCreated();
}

app.UseRouting();
app.UseStaticFiles();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"); ;
});

app.Run();