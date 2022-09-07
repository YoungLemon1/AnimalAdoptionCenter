using AnimalAdoptionCenter.Models;
using AnimalAdoptionCenter.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AnimalAdoptionCenter.Controllers
{
    public class AnimalProfileController : Controller
    {
        readonly IRepository _repository;
        public AnimalProfileController(IRepository repository) => _repository = repository;
        public IActionResult Index(int id)
        {
            Animal animal = _repository.GetAnimalById(id);
            return View(animal);
        }
    }
}
