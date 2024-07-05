using HobbyApi.Models;

namespace HobbyApi.Services
{
    public interface IHobbyService
    {

        public Task<IEnumerable<Hobby>> GetAllHobbies();

        public Task<IEnumerable<Hobby>> GetHobbiesByCategory(string category);

        public Task<IEnumerable<string>> GetAllCategories();

        public Task<Hobby> GetHobby(Guid id);

    }
}
