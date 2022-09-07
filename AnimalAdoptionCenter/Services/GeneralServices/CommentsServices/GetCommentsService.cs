using AnimalAdoptionCenter.Models;

namespace AnimalAdoptionCenter.Services.GeneralServices.CommentsServices
{
    public class GetCommentsService : IGetCommentsService
    {
        IRepository data;
        public GetCommentsService(IRepository data) => this.data = data;
        public IEnumerable<Comment> GetComments(int animalId) =>
            data.GetComments().Where(c => c.AnimalId == animalId);
        public Customer GetCustomerByComment(int commentID) 
        {
            var customers = data.GetCustomers().ToList();
            var comment = data.GetCommentById(commentID);
            return customers.Single(c => c.Id == comment.CustomerId);
        }
    }
}
