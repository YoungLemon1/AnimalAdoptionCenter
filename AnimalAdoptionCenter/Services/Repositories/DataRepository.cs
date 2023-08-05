using AnimalAdoptionCenter.Data;
using AnimalAdoptionCenter.Models;
using AnimalAdoptionCenter.Models.Enums;

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
        Animal IRepository.GetAnimalById(int id)
        {
            return _context.Animals!.Single(a => a.Id == id);
        }
        Animal IRepository.GetAnimalByName(string name)
        {
            return _context.Animals!.Single(a => a.Name == name);
        }
        IEnumerable<Animal> IRepository.GetAdoptableAnimals()
        {
            return _context.Animals!.Where(a => a.Status == EStatus.Ready_For_Adoption);
        }
        IEnumerable<Animal> IRepository.GetPopularAnimals(int num)
        {
            return _context.Animals!.OrderByDescending(animals => animals.Comments!.Count).Take(num);
        }
        IEnumerable<Animal> IRepository.GetPopularAnimals()
        {
            return _context.Animals!.OrderByDescending(animals => animals.Comments!.Count).Take(2);
        }
        IEnumerable<Category> IRepository.GetCategories()
        {
            return _context.Categories!;
        }
        IEnumerable<Category> IRepository.GetHomeCategories()
        {
            return _context.Categories!.Where(c => c.Id < 4);
        }
        Category IRepository.GetCategoryById(int id)
        {
            return _context.Categories!.Single(c => c.Id == id);
        }
        Category IRepository.GetCategoryByName(string name)
        {
            return _context.Categories!.Single(c => c.Name == name);
        }
        IEnumerable<City> IRepository.GetCities()
        {
            return _context.Cities!;
        }
        City IRepository.GetCityById(int id)
        {
            return _context.Cities!.Single(c => c.Id == id);
        }
        IEnumerable<Comment> IRepository.GetComments()
        {
            return _context.Comments!;
        }
        Comment IRepository.GetCommentById(int id) => _context.Comments!.Single(c => c.Id == id);
        IEnumerable<Customer> IRepository.GetCustomers()
        {
            return _context.Customers!;
        }
        void IRepository.InsertAnimal(Animal animal)
        {
            try
            {
                _context.Animals!.Add(animal);
                _context.SaveChanges();
            }
            catch
            {
                return;
            }
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
        void IRepository.InsertComment(Comment comment, Animal animal)
        {
            _context.Comments!.Add(comment);
            _context.SaveChanges();
        }
        void IRepository.InsertCustomer(Customer customer)
        {
            _context.Customers!.Add(customer);
            _context.SaveChanges();
        }
        void IRepository.UpdateAnimal(int id, Animal animal)
        {
            var animalInDb = _context.Animals!.Single(m => m.Id == id);

            animalInDb.CategoryId = animal.CategoryId;
            animalInDb.Age = animal.Age;
            animalInDb.CityId = animal.CityId;
            animalInDb.Sex = animal.Sex;
            animalInDb.Size = animal.Size;
            animalInDb.Status = animal.Status;
            animalInDb.IsVaccinated = animal.IsVaccinated;
            animalInDb.IsSterilized = animal.IsSterilized;
            animalInDb.IsTrained = animal.IsTrained;
            animalInDb.Description = animal.Description;
            animalInDb.ProfileImagePath = animal.ProfileImagePath;
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
    }
}
