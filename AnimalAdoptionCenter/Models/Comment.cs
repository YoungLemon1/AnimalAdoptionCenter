namespace AnimalAdoptionCenter.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int AnimalID { get; set; }
        public string? Text { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Customer? Commenter { get; set; }
    }
}
