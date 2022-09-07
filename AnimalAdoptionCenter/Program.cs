global using AnimalAdoptionCenter.Services.Repositories;
using AnimalAdoptionCenter.Data;
using Microsoft.EntityFrameworkCore;
using AnimalAdoptionCenter.Services;
using AnimalAdoptionCenter.Services.GeneralServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using AnimalAdoptionCenter.Services.GeneralServices.CommentsServices;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IRepository, DataRepository>();
builder.Services.AddTransient<ISearchService, SearchService>();
builder.Services.AddTransient<IGetCommentsService, GetCommentsService>();
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