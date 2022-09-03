namespace AnimalAdoptionCenter.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public City? City { get; set; }
    }
}
