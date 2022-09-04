using AnimalAdoptionCenter.Models.Enums;

namespace AnimalAdoptionCenter.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        //public int SubCategoryId { get; set; }
        //public SubCategory? SubCategory { get; set; }
        public string? SubCategory { get; set; }
        public string? ProfileImagePath { get; set; }
        public int Age { get; set; }
        //public int CityId { get; set; }
        //public City? OriginlCity { get; set; }
        public eSex Sex { get; set; }
        public eStatus Status { get; set; }
        public eSize Size { get; set; }
        public bool IsVaccinated { get; set; }
        public bool IsSterilized { get; set; }
        public bool IsTrained { get; set; }
        //public int CustomerId { get; set; }
        //public Customer? Customer { get; set; }
        public string? Description { get; set; }
    }
}