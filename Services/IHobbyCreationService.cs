using HobbyApi.Models;

namespace HobbyApi.Services
{
    public interface IHobbyCreationService
    {
        public Task<Hobby> CreateHobby(HobbyCreation hobbyCreationRequest);
    }
}
