using AnimalAdoptionCenter.Models;
using AnimalAdoptionCenter.Services.GeneralServices.SearchServices;
using Microsoft.AspNetCore.Mvc;
using static System.Linq.IQueryable;

namespace AnimalAdoptionCenter.Controllers
{
    public class CatalogController : Controller
    {
        IRepository data;
        ISearchService search;
        public CatalogController(IRepository data, ISearchService search)
        {
            this.data = data;
            this.search = search;
        }
        public IActionResult Index()
        {
            var animalProfiles = data.GetAdoptableAnimals().ToList();
            return View(animalProfiles);
        }

        [HttpGet]
        public IActionResult Index(string userSearching)
        {
            ViewBag.UserSearching = userSearching;
            IEnumerable<Animal> list;
            if (IsValid(userSearching))
                list = SearchAnimals(userSearching).AsParallel().ToList();
            else
                list = GetAnimals().ToList();
            return View(list);
        }

        ///////////////////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        bool IsValid(string str) => !String.IsNullOrEmpty(str);
        IEnumerable<Animal> GetAnimals() => data.GetAdoptableAnimals();
        IEnumerable<Animal> SearchAnimals(string searchInput) => search.GetAll(searchInput);

    }
}