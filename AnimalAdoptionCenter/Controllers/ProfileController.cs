using AnimalAdoptionCenter.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnimalAdoptionCenter.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index(int id)
        {
            return View();
        }
    }
}
