using Microsoft.AspNetCore.Mvc;
using AnimalAdoptionCenter.Models;
using AnimalAdoptionCenter.Models.Enums;
using AnimalAdoptionCenter.Services.Repositories;

namespace AnimalAdoptionCenter.Controllers
{
    public class AnimalController : Controller
    {
        private readonly IRepository _repository;

        public AnimalController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            ViewBag.Categories = _repository.GetCategories();
            ViewBag.Cities = _repository.GetCities();
            ViewBag.Animals = _repository.GetAnimals();
            return View();
        }

        [HttpPost]
        public IActionResult AddAnimal(Animal animal)
        {            
            _repository.InsertAnimal(animal);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAnimal(Animal animal)
        {
            _repository.DeleteAnimal(animal);
            return View();
        }

        public IActionResult UpdateAnimal(int id, Animal animal)
        {
            _repository.UpdateAnimal(id, animal);
            return View();
        }
    }
}
