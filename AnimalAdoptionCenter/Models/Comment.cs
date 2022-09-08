using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AnimalAdoptionCenter.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int AnimalId { get; set; }
        public Animal? Animal { get; set; }
        public string? Text { get; set; }
        [BindProperty, DataType(DataType.Date)]
        public DateTime? CreatedDate { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}