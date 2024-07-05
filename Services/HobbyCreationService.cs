using HobbyApi.DBContexts;
using HobbyApi.Models;

namespace HobbyApi.Services
{
    public class HobbyCreationService : IHobbyCreationService
    {
        private readonly HobbyContext context;

        public HobbyCreationService(HobbyContext context)
        {
            this.context = context;
        }
        public async Task<Hobby> CreateHobby(HobbyCreation hobbyCreationRequest)
        {


            var newId = Guid.NewGuid();

            var newhobby = new Hobby()
            {
                Id = newId,
                Name = hobbyCreationRequest.Name,
                Category = hobbyCreationRequest.Category,
                Description = hobbyCreationRequest.Description,
                Rating = hobbyCreationRequest.Rating,
            };

            this.context.Hobbies.Add(newhobby);
            await this.context.SaveChangesAsync();

            return newhobby;


        }
    }
}
