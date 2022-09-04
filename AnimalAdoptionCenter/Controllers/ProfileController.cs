using AnimalAdoptionCenter.Models;
using AnimalAdoptionCenter.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AnimalAdoptionCenter.Controllers
{
    public class ProfileController : Controller
    {
        readonly IRepository _repository;
        public ProfileController(IRepository repository) => _repository = repository;
        public IActionResult Index(int id)
        {
            Animal animal = _repository.GetAnimals().Single(animal => animal.Id == id);
            return View(animal);
        }
    }
}
