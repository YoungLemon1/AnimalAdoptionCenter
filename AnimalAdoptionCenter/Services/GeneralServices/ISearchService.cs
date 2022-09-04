using AnimalAdoptionCenter.Models;
using AnimalAdoptionCenter.Models.Enums;

namespace AnimalAdoptionCenter.Services.GeneralServices
{
    public interface ISearchService
    {
        string SearchText { get; set; }
        IEnumerable<Animal> SearchAll();
        IEnumerable<Animal> SearchAll(string age, string city, string size, string name, string type, string gender, string subCategory);
        IEnumerable<Animal> GetProfilesByName(string name);
        IEnumerable<Animal> GetProfilesByAge(string age);
        IEnumerable<Animal> GetProfilesBySubCategory(string subCategory);
        IEnumerable<Animal> GetProfilesByType(string typeName);
        IEnumerable<Animal> GetProfilesByCity(string city);
        IEnumerable<Animal> GetProfilesByGender(string sex);
        IEnumerable<Animal> GetProfilesBySize(string size);
    }
}