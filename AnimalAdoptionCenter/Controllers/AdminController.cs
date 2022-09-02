using Microsoft.AspNetCore.Mvc;
using AnimalAdoptionCenter.Models;
using AnimalAdoptionCenter.Services;

namespace AnimalAdoptionCenter.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult AddAnimal()
        //{

        //}
    }
}
