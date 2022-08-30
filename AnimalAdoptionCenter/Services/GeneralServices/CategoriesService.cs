using AnimalAdoptionCenter.Models;

namespace AnimalAdoptionCenter.Services.GeneralServices
{
    public class CategoriesService : ICategoriesService
    {
        ITempDataReposService _tempDataReposService;
        public CategoriesService(ITempDataReposService tempDataReposService)
        {
            _tempDataReposService = tempDataReposService;
        }
        public IEnumerable<Category> GetCategories()
        {
            return _tempDataReposService.GetAllCategories();
        }
        public void InsertCategories(string catrgoryName)
        {
            var categories = _tempDataReposService.GetAllCategories().ToList();
            categories.Add(new Category { CategoryName = catrgoryName, CategoryId = categories.Count });
        }
    }
}
