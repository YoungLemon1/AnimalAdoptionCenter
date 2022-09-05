using AnimalAdoptionCenter.Data;
using AnimalAdoptionCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalAdoptionCenter.Services.Repositories
{
    public class DataRepository : IRepository
    {
        private readonly AACContext _context;

        public DataRepository(AACContext context)
        {
            _context = context;
        }
        IEnumerable<Animal> IRepository.GetAnimals()
        {
            return _context.Animals!;
        }
        public Animal GetAnimalById(int id)
        {
            return _context.Animals!.Single(animal => animal.Id == id);
        }

        public Animal GetAnimalByName(string name)
        {
            return _context.Animals!.Single(animal => animal.Name == name);
        }
        public IEnumerable<Animal> GetPopularAnimals()
        {
            throw new NotImplementedException();
        }
        IEnumerable<Category> IRepository.GetCategories()
        {
            return _context.Categories!;
        }
        IEnumerable<Category> IRepository.GetHomeCategories()
        {
            return _context.Categories!.Where(c => c.Id < 4);
        }
        IEnumerable<City> IRepository.GetCities()
        {
            return _context.Cities!;
        }
        IEnumerable<Comment> IRepository.GetComments()
        {
            return _context.Comments!;
        }
        IEnumerable<Customer> IRepository.GetCustomers()
        {
            return _context.Customers!;
        }
        IEnumerable<SubCategory> IRepository.GetSubCategories()
        {
            return _context.SubCategories!;
        }
        void IRepository.InsertAnimal(Animal animal)
        {
            _context.Animals!.Add(animal);
            _context.SaveChanges();
        }
        void IRepository.InsertCategory(Category category)
        {
            _context.Categories!.Add(category);
            _context.SaveChanges();
        }
        void IRepository.InsertCity(City city)
        {
            _context.Cities!.Add(city);
            _context.SaveChanges();
        }
        void IRepository.InsertComment(Comment comment)
        {
            _context.Comments!.Add(comment);
            _context.SaveChanges();
        }
        void IRepository.InsertCustomer(Customer customer)
        {
            _context.Customers!.Add(customer);
            _context.SaveChanges();
        }
        void IRepository.InsertSubCategory(SubCategory subCategory)
        {
            _context.SubCategories!.Add(subCategory);
            _context.SaveChanges();
        }
        void IRepository.UpdateAnimal(int id, Animal animal)
        {
            var animalInDb = _context.Animals!.Single(m => m.Id == id);
            animalInDb = animal;
            _context.SaveChanges();
        }
        void IRepository.UpdateCategory(int id, Category category)
        {
            var categoryInDb = _context.Categories!.Single(m => m.Id == id);
            categoryInDb = category;
            _context.SaveChanges();
        }
        void IRepository.UpdateCity(int id, City city)
        {
            var cityInDb = _context.Cities!.Single(m => m.Id == id);
            cityInDb = city;
            _context.SaveChanges();
        }
        void IRepository.UpdateComment(int id, Comment comment)
        {
            var commentInDb = _context.Comments!.Single(m => m.Id == id);
            commentInDb = comment;
            _context.SaveChanges();
        }
        void IRepository.UpdateCustomer(int id, Customer customer)
        {
            var commentInDb = _context.Customers!.Single(m => m.Id == id);
            commentInDb = customer;
            _context.SaveChanges();
        }
        void IRepository.UpdateSubCategory(int id, SubCategory subCategory)
        {
            var subCategoryInDb = _context.SubCategories!.Single(m => m.Id == id);
            subCategoryInDb = subCategory;
            _context.SaveChanges();
        }
        void IRepository.DeleteAnimal(Animal animal)
        {
            _context.Animals!.Remove(animal);
            _context.SaveChanges();
        }
        void IRepository.DeleteCategory(Category category)
        {
            _context.Categories!.Remove(category);
            _context.SaveChanges();
        }
        void IRepository.DeleteCity(City city)
        {
            _context.Cities!.Remove(city);
            _context.SaveChanges();
        }
        void IRepository.DeleteComment(Comment comment)
        {
            _context.Comments!.Remove(comment);
            _context.SaveChanges();
        }
        void IRepository.DeleteCustomer(Customer customer)
        {
            _context.Customers!.Remove(customer);
            _context.SaveChanges();
        }
        void IRepository.DeleteSubCategory(SubCategory subCategory)
        {
            _context.SubCategories!.Remove(subCategory);
            _context.SaveChanges();
        }
    }
}
