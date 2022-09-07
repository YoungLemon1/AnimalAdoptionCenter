using AnimalAdoptionCenter.Models;
using AnimalAdoptionCenter.Services.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace AnimalAdoptionCenter.Services.GeneralServices
{
    public class SearchService : ISearchService
    {
        IRepository data;
        public SearchService(IRepository data)
        {
            this.data = data;
            animalList = data.GetAdoptableAnimals();
        }
        public IEnumerable<Animal> animalList { get; set; }

        public IEnumerable<Animal> GetAll(string input) =>
            !String.IsNullOrEmpty(input) ? SearchAll(input.ToLower()) : animalList;

        public IEnumerable<Animal> SearchAll(string input)
        {
            var lists = SearchAllOptions(input);
            var list = GroupLists(lists);
            return GroupByAll(list);
        }
        public IEnumerable<Animal> GroupByAll(IEnumerable<Animal> list) =>
            list.GroupBy(a => a.Id).Select(y => y.First());

        public IEnumerable<Animal> GetProfilesByName(string name) =>
            animalList.Where(a => a.Name!.ToLower().Contains(name));

        public IEnumerable<Animal> GetProfilesByAge(string age) =>
            animalList.Where(a => a.Age.ToString() == age);

        public IEnumerable<Animal> GetProfilesBySubCategory(string subCategory) =>
            animalList.Where(a => a.SubCategory!.ToLower().Contains(subCategory));

        public IEnumerable<Animal> GetProfilesByCategory(string typeName)
        {
            var categories = data.GetCategories().Where(c => c.Name!.ToLower().Contains(typeName));
            var animals = new List<Animal>();
            var animalsData = animalList.ToList();
            foreach (var category in categories)
                animals.AddRange(animalsData.Where(a => a.CategoryId == category.Id));
            return GroupByAll(animals);
        }
        public IEnumerable<Animal> GetProfilesByCity(string city)
        {
            var cities = data.GetCities();
            var c = cities.Where(c => c.Name!.ToLower().Contains(city)).FirstOrDefault();
            if (c != null)
                return animalList.Where(a => a.CityId == c.Id);
            else return new List<Animal>();
        }
        public IEnumerable<Animal> GetProfilesBySex(string sex) =>
            animalList.Where(a => a.Sex.ToString().ToLower() == sex);

        public IEnumerable<Animal> GetProfilesBySize(string size) =>
            animalList.Where(a => a.Size.ToString().ToLower().Contains(size));
        /////////////////////////////////////////////////////////////////////\\\\\\\
        IEnumerable<Animal> GroupLists(IEnumerable<IEnumerable<Animal>> list)
        {
            var result = new List<Animal>();
            for (int i = 0; i < list.Count(); i++)
            {
                result.AddRange(list.ToList()[i]);
            }
            return result;
        }
        IEnumerable<IEnumerable<Animal>> SearchAllOptions(string input) //a
        {
            yield return GetProfilesByAge(input);
            yield return GetProfilesByCity(input);
            yield return GetProfilesBySize(input);
            yield return GetProfilesByName(input);
            yield return GetProfilesByCategory(input);
            yield return GetProfilesBySex(input);
            yield return GetProfilesBySubCategory(input);
        }
    }
}