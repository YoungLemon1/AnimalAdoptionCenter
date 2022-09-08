using AnimalAdoptionCenter.Models;

namespace AnimalAdoptionCenter.Services.GeneralServices.CommentsServices
{
    public interface ICommentsService
    {
        IEnumerable<Comment> GetComments(int animalId);
        Customer GetCustomerByComment(int commentID);
        void InsertAdminComment(int id, string text);
    }
}
