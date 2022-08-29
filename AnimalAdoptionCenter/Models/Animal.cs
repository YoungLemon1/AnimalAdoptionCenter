using AnimalAdoptionCenter.Models.Enums;

namespace AnimalAdoptionCenter.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public int CategoryId { get; set; }
        public Category? AnimalCategory { get; set; }
        // My changes
        public SubCategory? AnimalSubCategory { get; set; }
        //
        public int Age { get; set; }
        public int CityId { get; set; }
        public string? Description { get; set; }
        public City? OriginlCity { get; set; }
        public Sex AnimalSex { get; set; }
        public Status AnimalStatus { get; set; }
        public Size AnimalSize { get; set; }
        // My changes
        public bool? IsTrained { get; set; }
        public bool? IsVaccinated { get; set; }
        public Customer? Owner { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
