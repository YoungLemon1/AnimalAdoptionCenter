global using AnimalAdoptionCenter.Services.Repositories;
using AnimalAdoptionCenter.Data;
using Microsoft.EntityFrameworkCore;
using AnimalAdoptionCenter.Services.GeneralServices.CommentsServices;
using AnimalAdoptionCenter.Services.GeneralServices.SearchServices;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IRepository, DataRepository>();
builder.Services.AddTransient<ISearchService, SearchService>();
builder.Services.AddTransient<ICommentsService, CommentsService>();
string connectionString = builder.Configuration["ConnectionStrings:DefaultConnection"];
builder.Services.AddDbContext<AACContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddControllersWithViews();
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var ctx = scope.ServiceProvider.GetRequiredService<AACContext>();
    ctx.Database.Migrate();
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