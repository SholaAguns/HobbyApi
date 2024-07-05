using HobbyApi.DBContexts;
using HobbyApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace HobbyApi.Services
{
    public class HobbyService : IHobbyService
    {
        private readonly HobbyContext context;

        public HobbyService(HobbyContext context)
        {
            this.context = context;
        }

        /*
        private List<Hobby> hobbyList = new List<Hobby>();

        public HobbyService()
        {
            Hobby newHobby1 = new Hobby()
            {
                Id = Guid.NewGuid(),
                Name = "Football",
                Category = "Sports",
                Description = "This sports involes 2 teams of 11 players each ....",
                Rating = 7.5,

            };
            Hobby newHobby2 = new Hobby()
            {
                Id = Guid.NewGuid(),
                Name = "Singing",
                Category = "Arts",
                Description = "Creating musical tones and noises....",
                Rating = 8.5,

            };

            hobbyList.Add(newHobby1);
            hobbyList.Add(newHobby2);
        }

        */

        public async Task<IEnumerable<string>> GetAllCategories()
        {
            return await this.context.Hobbies.Select(h => h.Category).Distinct().ToListAsync();
        }

        public async Task<IEnumerable<Hobby>> GetAllHobbies()
        {
         

            return await this.context.Hobbies.ToListAsync();
        }

        public async Task<IEnumerable<Hobby>> GetHobbiesByCategory(string category)
        {
            return await this.context.Hobbies.Where(h => h.Category == category).ToListAsync();
        }

        public async Task<Hobby> GetHobby(Guid id)
        {

            return await this.context.Hobbies.Where(h => h.Id == id).FirstOrDefaultAsync();
        }
    }
}
