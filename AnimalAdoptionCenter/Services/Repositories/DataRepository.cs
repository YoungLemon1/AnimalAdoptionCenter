using AnimalAdoptionCenter.Data;
using AnimalAdoptionCenter.Models;

namespace AnimalAdoptionCenter.Services.Repositories
{
    public class DataRepository : IRepository
    {
        private AACContext _context;

        public DataRepository(AACContext context)
        {
            _context = context;
        }
        IEnumerable<Animal> IRepository.GetAnimals()
        {
            return _context.Animals!;
        }
        IEnumerable<Category> IRepository.GetCategories()
        {
            return _context.Categories!;
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
            var animalInDb = _context.Animals!.Single(m => m.AnimalId == id);
            animalInDb = animal;
            _context.SaveChanges();
        }
        void IRepository.UpdateCategory(int id, Category category)
        {
            var categoryInDb = _context.Categories!.Single(m => m.CategoryId == id);
            categoryInDb = category;
            _context.SaveChanges();
        }
        void IRepository.UpdateCity(int id, City city)
        {
            var cityInDb = _context.Cities!.Single(m => m.CityId == id);
            cityInDb = city;
            _context.SaveChanges();
        }
        void IRepository.UpdateComment(int id, Comment comment)
        {
            var commentInDb = _context.Comments!.Single(m => m.CommentID == id);
            commentInDb = comment;
            _context.SaveChanges();
        }
        void IRepository.UpdateCustomer(int id, Customer customer)
        {
            var commentInDb = _context.Customers!.Single(m => m.CustomerId == id);
            commentInDb = customer;
            _context.SaveChanges();
        }
        void IRepository.UpdateSubCategory(int id, SubCategory subCategory)
        {
            var subCategoryInDb = _context.SubCategories!.Single(m => m.SubCategoryId == id);
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
