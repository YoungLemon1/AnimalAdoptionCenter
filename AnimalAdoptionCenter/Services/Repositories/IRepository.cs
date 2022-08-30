namespace AnimalAdoptionCenter.Services.Repositories;
using AnimalAdoptionCenter.Models;

public interface IRepository
{
    //Animal
    IEnumerable<Animal> GetAnimals();
    void InsertAnimal(Animal animal);
    void UpdateAnimal(int id, Animal animal);
    void DeleteAnimal(Animal animal);
    //Category
    IEnumerable<Category> GetCategories();
    void InsertCategory(Category category);
    void UpdateCategory(int id, Category category);
    void DeleteCategory(Category category);
    //City
    IEnumerable<City> GetCities();
    void InsertCity(City city);
    void UpdateCity(int id, City city);
    void DeleteCity(City city);
    //Customer
    IEnumerable<Customer> GetCustomers();
    void InsertCustomer(Customer customer);
    void UpdateCustomer(int id, Customer customer);
    void DeleteCustomer(Customer customer);
    //Comment
    IEnumerable<Comment> GetComments();
    void InsertComment(Comment comment);
    void UpdateComment(int id, Comment comment);
    void DeleteComment(Comment comment);
    //SubCategory
    IEnumerable<SubCategory> GetSubCategories();
    void InsertSubCategory(SubCategory subCategory);
    void UpdateSubCategory(int id, SubCategory subCategory);
    void DeleteSubCategory(SubCategory subCategory);
}
