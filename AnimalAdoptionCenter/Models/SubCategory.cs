namespace AnimalAdoptionCenter.Models
{
    public class SubCategory
    {
        public int SubCategoryId { get; set; }
        public string? SubCategoryName { get; set; }
        public Category? ParentCategory { get; set; }
    }
}