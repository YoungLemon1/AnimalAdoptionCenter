using AnimalAdoptionCenter.Services.GeneralServices;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AnimalAdoptionCenter.Controllers
{
    public class CatalogController : Controller
    {
        //ISearchService _tempData;
        //public CatalogController(ISearchService tempData)
        //{
        //    _tempData = tempData;
        //}
        private readonly IRepository _repository;
        public CatalogController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View(_repository.GetAnimals());
        }
        public IActionResult Search()
        {
            return View();
        }
    }
}
