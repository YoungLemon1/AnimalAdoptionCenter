using AnimalAdoptionCenter.Data;
using AnimalAdoptionCenter.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using AnimalAdoptionCenter.Services;
using AnimalAdoptionCenter.Services.GeneralServices;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IRepository, DataRepository>();
//builder.Services.AddDbContext<AnimalAdoptionCenterContext>(options => options.UseSqlite("Data Source=C:\\temp\\AnimalAdoptionCenterDb.db"));
string connectionString = builder.Configuration["ConnectionStrings:DefaultConnection"];
builder.Services.AddDbContext<AACContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ITempDataReposService, TempDataReposService>();
builder.Services.AddSingleton<ICategoriesService, CategoriesService>();
builder.Services.AddSingleton<ISearchService, SearchService>();
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
        pattern: "{controller=Profile}/{action=Index}/{id=1}"); ;
});

app.Run();