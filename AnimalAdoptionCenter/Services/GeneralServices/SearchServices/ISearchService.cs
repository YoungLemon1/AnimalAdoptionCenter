using AnimalAdoptionCenter.Models;
using AnimalAdoptionCenter.Models.Enums;
using System.Collections.Generic;

namespace AnimalAdoptionCenter.Services.GeneralServices.SearchServices
{
    public interface ISearchService
    {
        IEnumerable<Animal> GetAll(string input);
        IEnumerable<Animal> GetProfilesByName(string name);
        IEnumerable<Animal> GetProfilesByAge(string age);
        IEnumerable<Animal> GetProfilesBySubCategory(string subCategory);
        IEnumerable<Animal> GetProfilesByCategory(string typeName);
        IEnumerable<Animal> GetProfilesByCity(string city);
        IEnumerable<Animal> GetProfilesBySex(string sex);
        IEnumerable<Animal> GetProfilesBySize(string size);
    }
}