using AnimalAdoptionCenter.Models;

namespace AnimalAdoptionCenter.Services.GeneralServices.CommentsServices
{
    public interface IGetCommentsService
    {
        IEnumerable<Comment> GetComments(int animalId);
    }
}
