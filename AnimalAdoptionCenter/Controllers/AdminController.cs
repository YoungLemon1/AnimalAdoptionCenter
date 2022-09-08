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
            var animals = _repository.GetAnimals().ToList();
            return View(animals);
        }
        public IActionResult NewAnimalForm()
        {
            ViewBag.Categories = _repository.GetCategories();
            ViewBag.Cities = _repository.GetCities();
            ViewBag.Animals = _repository.GetAnimals();
            return View();
        }

        public IActionResult EditAnimalForm(int id)
        {
            ViewBag.Categories = _repository.GetCategories();
            ViewBag.Cities = _repository.GetCities();
            ViewBag.Animals = _repository.GetAnimals();
            Animal animal = _repository.GetAnimalById(id);
            return View(animal);
        }

        [HttpPost]
        public IActionResult AddAnimal(Animal animal)
        {
            _repository.InsertAnimal(animal);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult DeleteAnimal(int id)
        {
            Animal animal = _repository.GetAnimalById(id);
            _repository.DeleteAnimal(animal);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult UpdateAnimal(int id, Animal animal)
        {
            _repository.UpdateAnimal(id, animal);
            return RedirectToAction("Index");
        }
    }
}
