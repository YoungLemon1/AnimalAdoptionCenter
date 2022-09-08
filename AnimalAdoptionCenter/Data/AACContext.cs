using AnimalAdoptionCenter.Models;
using AnimalAdoptionCenter.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace AnimalAdoptionCenter.Data
{
    public class AACContext : DbContext
    {
        public AACContext(DbContextOptions<AACContext> options) : base(options)
        {
        }
        public virtual DbSet<Animal>? Animals { get; set; }
        public virtual DbSet<Category>? Categories { get; set; }
        public virtual DbSet<SubCategory>? SubCategories { get; set; }
        public virtual DbSet<Customer>? Customers { get; set; }
        public virtual DbSet<City>? Cities { get; set; }
        public virtual DbSet<Comment>? Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Dog", ImagePath = "\\Images\\Categories\\Dog.png" },
                new Category { Id = 2, Name = "Cat", ImagePath = "\\Images\\Categories\\Cat.png" },
                new Category { Id = 3, Name = "Bird", ImagePath = "\\Images\\Categories\\Bird.png" },
                new Category { Id = 4, Name = "Other", ImagePath = "\\Images\\Categories\\Other.png" });
                //new Category { Id = 4, Name = "Rabbit" },
                //new Category { Id = 5, Name = "Hamster" },
                //new Category { Id = 6, Name = "Turtle" });

            modelBuilder.Entity<City>().HasData(
                new City { Id = 1, Name = "Haifa" },
                new City { Id = 2, Name = "Ramat Gan" },
                new City { Id = 3, Name = "Tel Aviv"},
                new City { Id = 4, Name = "Netanya"}
                );
            
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Offer Levi" },
                new Customer { Id = 2, Name = "Yakov Izkovich" },
                new Customer { Id = 3, Name = "Eli Chohen" },
                new Customer { Id = 4, Name = "Reut Saban" },
                new Customer { Id = 5, Name = "Yotam Even" },
                new Customer { Id = 6, Name = "Yael Sharon" });

            modelBuilder.Entity<Animal>().HasData(
                new Animal 
                { 
                    Id = 1,
                    CategoryId = 1,
                    SubCategory = "Labrador",
                    CustomerId = null,
                    Name = "Poli",
                    Age = 2, CityId = 1,
                    Sex = eSex.Male,
                    Size = eSize.Small,
                    Status = eStatus.Ready_For_Adoption,
                    IsVaccinated = true,
                    IsTrained = true,
                    IsSterilized = false,
                    ProfileImagePath= "\\Images\\Animals\\Poli.jpg",
                    Description = "Very energetic"
                },
                new Animal
                {
                    Id = 2,
                    CategoryId = 2,
                    SubCategory = "Siamese",
                    Name = "Lara",
                    Age = 6,
                    CityId = 2,
                    Sex = eSex.Female,
                    Size = eSize.Medium,
                    Status = eStatus.Ready_For_Adoption,
                    IsVaccinated = true,
                    IsTrained = true,
                    IsSterilized = true,
                    ProfileImagePath = "\\Images\\Animals\\Lara.jpg",
                    Description = "Quiet and shy"
                },
                new Animal
                {
                    Id = 3,
                    CategoryId = 3,
                    SubCategory = "Parrot",
                    Name = "Lucy",
                    Age = 13,
                    CityId = 4,
                    Sex =
                    eSex.Female,
                    Size =
                    eSize.Small,
                    Status =
                    eStatus.Injured,
                    IsVaccinated = true,
                    IsTrained = true,
                    IsSterilized = false,
                    ProfileImagePath = "\\Images\\Animals\\Lucy.jpg",
                    Description = "Found with a broken wing"
                },
                new Animal
                {
                    Id = 4,
                    CategoryId = 1,
                    SubCategory = "Buldog",
                    Name = "Woofer",
                    Age = 4,
                    CityId = 3,
                    Sex = eSex.Male,
                    Size = eSize.Medium,
                    Status = eStatus.In_Rehab,
                    IsVaccinated = true,
                    IsTrained = false,
                    IsSterilized = false,
                    ProfileImagePath = "\\Images\\Animals\\Woofer.jpg",
                    Description = "Was given to the shelter by his owner due to aggresive behavior. Further training required"
                },
                new Animal
                {
                    Id = 5,
                    CategoryId = 2,
                    SubCategory = "Persian",
                    Name = "Eli",
                    Age = 9,
                    CityId = 1,
                    Sex = eSex.Female,
                    Size = eSize.Tiny,
                    Status = eStatus.Ready_For_Adoption,
                    IsVaccinated = true,
                    IsTrained = true,
                    IsSterilized = true,
                    ProfileImagePath = "\\Images\\Animals\\Eli.jpg",
                    Description = "Found abandoned in the streets, this cat loves playing with toys and is looking for a family"
                },
                new Animal
                {
                    Id = 6,
                    CategoryId = 1,
                    SubCategory = "Husky",
                    Name = "Sheleg",
                    Age = 2,
                    CityId = 2,
                    Sex = eSex.Male,
                    Size = eSize.Medium,
                    Status = eStatus.Ready_For_Adoption,
                    IsVaccinated = true,
                    IsTrained = true,
                    IsSterilized = false,
                    ProfileImagePath = "\\Images\\Animals\\Sheleg.jpg",
                    Description = "Very energetic and talkative"
                },
                new Animal
                {
                    Id = 7,
                    CategoryId = 1,
                    SubCategory = "Pitbul",
                    Name = "Kasper",
                    Age = 3,
                    CityId = 3,
                    Sex = eSex.Male,
                    Size = eSize.Medium,
                    Status = eStatus.In_Rehab,
                    IsVaccinated = true,
                    IsTrained = true,
                    IsSterilized = true,
                    ProfileImagePath = "\\Images\\Animals\\Kasper.jpg",
                    Description = "A real baby"
                },
                new Animal
                {
                    Id = 8,
                    CategoryId = 3,
                    SubCategory = "Parrot",
                    Name = "Yusuf",
                    Age = 23,
                    CityId = 4,
                    Sex = eSex.Male,
                    Size = eSize.Small,
                    Status = eStatus.Ready_For_Adoption,
                    IsVaccinated = true,
                    IsTrained = true,
                    IsSterilized = false,
                    ProfileImagePath = "\\Images\\Animals\\Asi.jpg",
                    Description = "Very friendly parrot, fitting for small houses"
                },
                new Animal
                {
                    Id = 9,
                    CategoryId = 4,
                    SubCategory = "Frog",
                    Name = "Froggy",
                    Age = 5,
                    CityId = 4,
                    Sex = eSex.Male,
                    Size = eSize.Tiny,
                    Status = eStatus.Ready_For_Adoption,
                    IsVaccinated = false,
                    IsTrained = false,
                    IsSterilized = false,
                    ProfileImagePath = "https://a-z-animals.com/media/2021/11/tree-frog.jpg"
                }
                );

            modelBuilder.Entity<Comment>().HasData(
                new Comment 
                { 
                    Id = 1,
                    AnimalId = 1,
                    CustomerId = 2,
                    CreatedDate = new DateTime(2019, 12, 22).Date,
                    Text = "Wow so cute!" 
                },
                new Comment 
                { 
                    Id = 2, 
                    AnimalId = 1, 
                    CustomerId = 3,
                    CreatedDate = new DateTime(2020, 3, 3), 
                    Text = "How adorable"
                },
                new Comment 
                { 
                    Id = 3, 
                    AnimalId = 2,
                    CustomerId = 2,
                    CreatedDate = new DateTime(2019, 12, 22),
                    Text = "Very Cute" 
                },
                new Comment 
                { 
                    Id = 4,
                    AnimalId = 2, 
                    CustomerId = 4, 
                    CreatedDate = new DateTime(2020, 2, 23), 
                    Text = "Precius" 
                },
                new Comment 
                { 
                    Id = 5,
                    AnimalId = 3, 
                    CustomerId = 4, 
                    CreatedDate = new DateTime(2020, 2, 22),
                    Text = "Can she talk?"
                },
                new Comment 
                {
                    Id = 6,
                    AnimalId = 5, 
                    CustomerId = 5,
                    CreatedDate = new DateTime(2020, 3, 23),
                    Text = "Floof!" 
                });
        }
    }
}
