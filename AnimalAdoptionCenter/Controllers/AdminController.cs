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
    }
}
