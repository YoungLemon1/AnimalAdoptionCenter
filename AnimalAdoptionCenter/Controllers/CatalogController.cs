using Microsoft.AspNetCore.Mvc;

namespace AnimalAdoptionCenter.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
