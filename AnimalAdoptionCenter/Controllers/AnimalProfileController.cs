using AnimalAdoptionCenter.Models;
using AnimalAdoptionCenter.Services;
using AnimalAdoptionCenter.Services.GeneralServices.CommentsServices;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AnimalAdoptionCenter.Controllers
{
    public class AnimalProfileController : Controller
    {
        readonly IRepository _repository;
        readonly ICommentsService _commentsService;
        public Animal? CurrentAnimal { get; set; }
        public AnimalProfileController(IRepository repository, ICommentsService commentsService)
        {
            _commentsService = commentsService;
            _repository = repository;
        }

        public IActionResult Index(int id)
        {
            CurrentAnimal = _repository.GetAnimalById(id);
            return View(CurrentAnimal);
        }
        [HttpPost]
        public IActionResult AddComment(int id, string text)
        {
            _commentsService.InsertAdminComment(id, text);
            return RedirectToAction("Index", id);
        }
    }
}
