using AnimalAdoptionCenter.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnimalAdoptionCenter.Services.GeneralServices.CommentsServices
{
    public class CommentsService : ICommentsService
    {
        readonly IRepository data;
        public CommentsService(IRepository data) => this.data = data;
        public IEnumerable<Comment> GetComments(int animalId) =>
            data.GetComments().Where(c => c.AnimalId == animalId);
        public Customer GetCustomerByComment(int commentID) 
        {
            var customers = data.GetCustomers().ToList();
            var comment = data.GetCommentById(commentID);
            return customers.Single(c => c.Id == comment.CustomerId);
        }
        public void InsertAdminComment(int id, string text)
        {
            Animal animal = data.GetAnimalById(id);
            data.InsertComment(new Comment { CustomerId = 1, AnimalId = id, CreatedDate = DateTime.Now, Text = text }, animal);
        }
    }
}
