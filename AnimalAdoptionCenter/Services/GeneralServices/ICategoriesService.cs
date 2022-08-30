using AnimalAdoptionCenter.Models;

namespace AnimalAdoptionCenter.Services.GeneralServices
{
    public interface ICategoriesService
    {
        IEnumerable<Category> GetCategories();
        void InsertCategories(string catrgoryName);
    }
}