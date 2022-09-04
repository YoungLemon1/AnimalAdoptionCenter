using AnimalAdoptionCenter.Models;

namespace AnimalAdoptionCenter.Services
{
    public class TempDataReposService : ITempDataReposService
    {

        public IEnumerable<Animal> GetAllAnimals() => IntiailzieAnimalz();
        public IEnumerable<Category> GetAllCategories() => IntiailzieCategories();
        public IEnumerable<City> GetAllCities() => IntiailzieCities();
        private IEnumerable<City> IntiailzieCities()
        {
            return new List<City>
            {
                new City
                {
                    CityId = 1,
                    CityName = "Jerusalem"
                },
                new City
                {
                    CityId = 2,
                    CityName = "Tel Aviv"
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
        private IEnumerable<Animal> IntiailzieAnimalz()
        {
            return new List<Animal>
            {
                new Animal
                {
                    AnimalId = 1,
                    ProfileImagePath = "/lib/pictures/animals/Dog1.jpg",
                    Name = "bob",
                    Age = 3,
                    SubCategory = "Dalmaty",
                    Sex = Models.Enums.Sex.Male,
                    Size = Models.Enums.Size.Avarage,
                    Status = Models.Enums.Status.Ready_For_Adoption,
                    OriginlCity = new City { CityId = 1, CityName = "Jerusalem" }
                },
                new Animal
                {
                    AnimalId = 2,
                    ProfileImagePath = "/lib/pictures/animals/Cat1.jpg",
                    Name = "dan",
                    Age = 4,
                    SubCategory = "dani",
                    Sex = Models.Enums.Sex.Male,
                    Size = Models.Enums.Size.Avarage,
                    Status = Models.Enums.Status.Ready_For_Adoption,
                    OriginlCity = new City { CityId = 2, CityName = "Tel Aviv" }
                }
            };
        }
    }
}
