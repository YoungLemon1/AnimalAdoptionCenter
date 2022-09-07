using AnimalAdoptionCenter.Models;
using Microsoft.AspNetCore.Mvc;


namespace AnimalAdoptionCenter.Controllers
{
    public class AdminController : Controller
    {
        private readonly IRepository _repository;
        public AdminController(IRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View(_repository.GetAnimals());
        }
        public IActionResult NewAnimalForm()
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
