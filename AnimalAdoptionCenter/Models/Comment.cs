namespace AnimalAdoptionCenter.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int AnimalId { get; set; }
        public string? Text { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}
