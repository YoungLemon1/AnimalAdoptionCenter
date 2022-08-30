using AnimalAdoptionCenter.Models.Enums;

namespace AnimalAdoptionCenter.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public string? ProfileImagePath { get; set; }
        public Category? AnimalCategory { get; set; }
        public string? SubCategory { get; set; }
        public int Age { get; set; }
        public int CityId { get; set; }
        public string? Description { get; set; }
        public City? OriginlCity { get; set; }
        public eSex Sex { get; set; }
        public eStatus Status { get; set; }
        public eSize Size { get; set; }
    }
}
