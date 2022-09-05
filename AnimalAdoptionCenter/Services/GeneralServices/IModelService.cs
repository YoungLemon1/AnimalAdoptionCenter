namespace AnimalAdoptionCenter.Services.GeneralServices
{
    using Models;
    public interface IModelService
    {
        Category GetCategory(int id);
        Category GetCategory(string name);
        IEnumerable<Category> GetCategories();
        IEnumerable<Comment> GetAnimalComments();
    }
}
