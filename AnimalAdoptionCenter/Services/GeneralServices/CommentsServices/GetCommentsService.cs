using AnimalAdoptionCenter.Models;

namespace AnimalAdoptionCenter.Services.GeneralServices.CommentsServices
{
    public class GetCommentsService : IGetCommentsService
    {
        IRepository data;
        public GetCommentsService(IRepository data) => this.data = data;
        public IEnumerable<Comment> GetComments(int animalId) =>
            data.GetComments().Where(c => c.AnimalId == animalId);
    }
}
