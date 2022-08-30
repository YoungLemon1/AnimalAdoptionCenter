using AnimalAdoptionCenter.Models;
using AnimalAdoptionCenter.Models.Enums;

namespace AnimalAdoptionCenter.Services.GeneralServices
{
    public interface ISearchService
    {
        string SearchText { get; set; }
        IEnumerable<Animal> GetProfilesByName(string name);
        IEnumerable<Animal> GetProfilesByAge(string age);
        IEnumerable<Animal> GetProfilesBySubCategory(string subCategory);
        IEnumerable<Animal> GetProfilesByType(string typeName);
        IEnumerable<Animal> GetProfilesByCity(string city);
        IEnumerable<Animal> GetProfilesByGender(string sex);
        IEnumerable<Animal> GetProfilesBySize(string size);
        IEnumerable<Animal> GetProfilesByName();
        IEnumerable<Animal> GetProfilesByAge();
        IEnumerable<Animal> GetProfilesBySubCategory();
        IEnumerable<Animal> GetProfilesByType();
        IEnumerable<Animal> GetProfilesByCity();
        IEnumerable<Animal> GetProfilesBySex();
        IEnumerable<Animal> GetProfilesBySize();

    }
}