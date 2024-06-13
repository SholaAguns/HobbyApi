using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HobbyApi.DBContexts;
using HobbyApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace HobbyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HobbiesController : ControllerBase
    {
        private readonly HobbyContext context;

        public HobbiesController(HobbyContext context)
        {
            this.context = context;
        }

        // GET: api/hobbies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hobby>>> GetHobbies()
        {
            return await this.context.Hobbies.ToListAsync();
        }

        // POST: api/hobbies
        [HttpPost]
        public async Task<ActionResult<Hobby>> PostHobby(HobbyCreation hobby)
        {
            var maxId = await this.context.Hobbies.AnyAsync()
                        ? await this.context.Hobbies.MaxAsync(h => h.Id) : 0;
            var newHobby = new Hobby(hobby.Name)
            {
                Category = hobby.Category,
                Description = hobby.Description,
            };

            this.context.Hobbies.Add(newHobby);
            await this.context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetHobbies), new { id = ++maxId }, hobby);
        }
    }
}
