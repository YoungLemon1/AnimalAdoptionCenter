using AnimalAdoptionCenter.Services;
using AnimalAdoptionCenter.Services.GeneralServices;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ITempDataReposService, TempDataReposService>();
builder.Services.AddSingleton<ICategoriesService, CategoriesService>();
builder.Services.AddSingleton<ISearchService, SearchService>();
var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Profile}/{action=Index}/{id=1}"); ;
});

app.Run();