using AnimalAdoptionCenter.Models;

namespace AnimalAdoptionCenter.Services
{
    public class TempDataReposService : ITempDataReposService
    {

        public IEnumerable<Animal> GetAllAnimals()
        {
            return IntiailzieAnimalz();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return IntiailzieCategories();
        }

        private IEnumerable<Animal> IntiailzieAnimalz()
        {
            return new List<Animal>
            {
                new Animal
                {
                    AnimalId = 1,
                    ProfileImagePath = "/lib/Dog1.jpg",
                    Name = "bob",
                    Age = 3,
                    SubCategory = "Dalmaty",
                    Sex = Models.Enums.eSex.Male,
                    Size = Models.Enums.eSize.Avarage,
                    Status = Models.Enums.eStatus.Ready_For_Adoption,
                },
                new Animal
                {
                    AnimalId = 2,
                    ProfileImagePath = "/lib/Cat1.jpg",
                    Name = "dan",
                    Age = 4,
                    SubCategory = "dani",
                    Sex = Models.Enums.eSex.Male,
                    Size = Models.Enums.eSize.Avarage,
                    Status = Models.Enums.eStatus.Ready_For_Adoption,
                }
            };
        }
        private IEnumerable<Category> IntiailzieCategories()
        {
            return new List<Category>
            {
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Dogs",
                    ImageUrl ="/lib/Pictures/Categories/dog.png"

                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Cats",
                    ImageUrl ="/lib/Pictures/Categories/cat.png"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Birds",
                    ImageUrl ="/lib/Pictures/Categories/bird.png"
                },
                new Category
                {
                    CategoryId = 4,
                    CategoryName = "Other",
                    ImageUrl ="/lib/Pictures/Categories/other.png"
                }
            };
        }
    }
}
