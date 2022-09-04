using AnimalAdoptionCenter.Models;
using AnimalAdoptionCenter.Models.Enums;

namespace AnimalAdoptionCenter.Services.GeneralServices
{
    public class SearchService : ISearchService
    {
        /// <summary>
        /// 
        /// SearchAll - Search a large capacity divided to many lists
        /// 
        /// first implement the SearchText Propery
        /// 
        /// and then the methods will make many lists of option based on the Proprty
        /// (SearchText Propery). then it will "group by" to make a uniq list.
        /// 
        /// SearchAll (with fields) - decrease the amount of results based on
        /// the amount of the checkers (methods). makes it a specific search.
        /// 
        /// </summary>

        ITempDataReposService dataService;
        public string SearchText { get; set; }
        public SearchService(ITempDataReposService empDataReposService)
        {
            dataService = empDataReposService;
            SearchedList = dataService.GetAllAnimals();
            SearchText = "";
        }
        public IEnumerable<Animal> SearchedList { get; set; }
        public IEnumerable<Animal> SearchAll()
        {
            if (SearchText != "")
                return GroupResults().GroupBy(a =>
                a.AnimalId).Select(y => y.First());
            else return new List<Animal>();
        }
        public IEnumerable<Animal> SearchAll(string age, string city,
                                             string size, string name, string type,
                                             string gender, string subCategory)
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
        /////////////////////////////////////////////////////////////////////\\\\\\\
        IEnumerable<Animal> GroupResults()
        {
            var result = new List<Animal>();
            for (int i = 0; i < SearchAllOptions().Count(); i++)
            {
                result.AddRange(SearchAllOptions().ToList()[i]);
            }
            return result;
        }
        IEnumerable<IEnumerable<Animal>> SearchAllOptions()
        {
            yield return GetProfilesByAge();
            yield return GetProfilesByCity();
            yield return GetProfilesBySize();
            yield return GetProfilesByName();
            yield return GetProfilesByType();
            yield return GetProfilesBySex();
            yield return GetProfilesBySubCategory();
        }
        IEnumerable<Animal> GetProfilesByAge() =>
            SearchedList.Where(a => a.Age.ToString() == SearchText);
        IEnumerable<Animal> GetProfilesByCity() =>
            dataService.GetAllAnimals().Where(a => a.OriginlCity!.CityName!.Contains(SearchText));
        IEnumerable<Animal> GetProfilesBySex() =>
            dataService.GetAllAnimals().Where(a => a.Sex.ToString() == SearchText);
        IEnumerable<Animal> GetProfilesByName() =>
            dataService.GetAllAnimals().Where(a => a.Name!.Contains(SearchText));
        IEnumerable<Animal> GetProfilesBySize() =>
            dataService.GetAllAnimals().Where(a => a.Size.ToString().Contains(SearchText));
        IEnumerable<Animal> GetProfilesBySubCategory() =>
            dataService.GetAllAnimals().Where(a => a.SubCategory!.Contains(SearchText));
        IEnumerable<Animal> GetProfilesByType() =>
            dataService.GetAllAnimals().Where(a => a.GetType().Name.Contains(SearchText));

    }
}
