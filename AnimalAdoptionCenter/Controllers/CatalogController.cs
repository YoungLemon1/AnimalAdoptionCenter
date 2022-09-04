using AnimalAdoptionCenter.Services.GeneralServices;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AnimalAdoptionCenter.Controllers
{
    public class CatalogController : Controller
    {
        ISearchService _tempData;
        public CatalogController(ISearchService tempData)
        {
            _tempData = tempData;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Search(int id)
        {
            return View();
        }
    }
}
