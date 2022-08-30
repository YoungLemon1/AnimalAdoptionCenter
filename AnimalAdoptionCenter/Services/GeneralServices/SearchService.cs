using AnimalAdoptionCenter.Models;
using AnimalAdoptionCenter.Models.Enums;

namespace AnimalAdoptionCenter.Services.GeneralServices
{
    public class SearchService : ISearchService
    {
        ITempDataReposService dataService;
        public SearchService(ITempDataReposService empDataReposService)
        {
            dataService = empDataReposService;
            SearchedList = dataService.GetAllAnimals();
            SearchText = "";
        }

        public IEnumerable<Animal> SearchedList { get; set; }
        public IEnumerable<IEnumerable<Animal>> SearchAll()
        {
            yield return GetProfilesByAge();
            yield return GetProfilesByCity();
            yield return GetProfilesBySize();
            yield return GetProfilesByName();
            yield return GetProfilesByType();
            yield return GetProfilesBySex();
            yield return GetProfilesBySubCategory();
        }
        public IEnumerable<Animal> SearchAll(string age,string city,
            string size, string name, string type,string gender, string subCategory)
        {
            SearchedList = dataService.GetAllAnimals();
            GetProfilesByAge(age);
            GetProfilesByCity(city);
            GetProfilesBySize(size);
            GetProfilesByName(name);
            GetProfilesByType(type);
            GetProfilesByGender(gender);
            GetProfilesBySubCategory(subCategory);
            return SearchedList;
        }
        public string SearchText { get; set; }
        public IEnumerable<Animal> GetProfilesByAge() => 
            SearchedList.Where(a => a.Age.ToString() == SearchText);
        public IEnumerable<Animal> GetProfilesByCity() => 
            dataService.GetAllAnimals().Where(a => a.OriginlCity!.CityName!.Contains(SearchText));
        public IEnumerable<Animal> GetProfilesBySex() =>
            dataService.GetAllAnimals().Where(a => a.Sex.ToString() == SearchText);
        public IEnumerable<Animal> GetProfilesByName() =>
            dataService.GetAllAnimals().Where(a => a.Name!.Contains(SearchText));
        public IEnumerable<Animal> GetProfilesBySize() => 
            dataService.GetAllAnimals().Where(a => a.Size.ToString().Contains(SearchText));
        public IEnumerable<Animal> GetProfilesBySubCategory() => 
            dataService.GetAllAnimals().Where(a => a.SubCategory!.Contains(SearchText));
        public IEnumerable<Animal> GetProfilesByType() => 
            dataService.GetAllAnimals().Where(a => a.GetType().Name.Contains(SearchText));
        /////////////////////////////////////////////////////////////////////\\\\\\\
        public IEnumerable<Animal> GetProfilesByName(string name) => SearchedList.Where(a => 
            a.Name!.Contains(name));
        public IEnumerable<Animal> GetProfilesByAge(string age) => SearchedList.Where(a =>
            a.Age.ToString() == age);
        public IEnumerable<Animal> GetProfilesBySubCategory(string subCategory) => SearchedList.Where(a => 
            a.SubCategory!.Contains(subCategory));
        public IEnumerable<Animal> GetProfilesByType(string typeName) => SearchedList.Where(a =>
            a.GetType().Name.Contains(typeName));
        public IEnumerable<Animal> GetProfilesByCity(string city) => SearchedList.Where(a =>
            a.OriginlCity!.CityName!.Contains(city));
        public IEnumerable<Animal> GetProfilesByGender(string sex) => SearchedList.Where(a => 
            a.Sex.ToString() == sex);
        public IEnumerable<Animal> GetProfilesBySize(string size) => SearchedList.Where(a =>
            a.Size.ToString().Contains(size));
    }
}
