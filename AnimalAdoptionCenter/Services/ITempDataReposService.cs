using AnimalAdoptionCenter.Models;

namespace AnimalAdoptionCenter.Services
{
    public interface ITempDataReposService
    {
        IEnumerable<Animal> GetAllAnimals();
    }
}