using Microsoft.AspNetCore.Mvc;
using AnimalAdoptionCenter.Models;
using AnimalAdoptionCenter.Services;
using AnimalAdoptionCenter.Services.Repositories;

namespace AnimalAdoptionCenter.Controllers
{
    public class AnimalController : Controller
    {
        private IRepository _repository;

        public AnimalController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnimal()
        {

        }
    }
}
