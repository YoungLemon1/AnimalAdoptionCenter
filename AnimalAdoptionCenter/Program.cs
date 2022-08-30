using Microsoft.EntityFrameworkCore;
using AnimalAdoptionCenter.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AnimalAdoptionCenterContext>(options => options.UseSqlite("Data Source=C:\\temp\\AnimalAdoptionCenterDb.db"));
//string connectionString = "Server=(localdb)\\AnimalAdoptionCenter;Database=AAC;Trusted_Connection=True";
//builder.Services.AddDbContext<AnimalAdoptionCenterContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddControllersWithViews();
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var ctx = scope.ServiceProvider.GetRequiredService<AnimalAdoptionCenterContext>();
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