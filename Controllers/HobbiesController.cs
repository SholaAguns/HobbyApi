using HobbyApi.Models;
using HobbyApi.Services;
using Microsoft.AspNetCore.Mvc;


namespace HobbyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HobbyController : ControllerBase
    {
        private readonly HobbyService hobbyService;
        private readonly HobbyCreationService hobbyCreationService;
        public HobbyController(HobbyService hobbyService, HobbyCreationService hobbyCreationService)
        {
            this.hobbyService = hobbyService;
            this.hobbyCreationService = hobbyCreationService;

        }

        [HttpGet("ping")]
        public IActionResult HealtCheck()
        {
            return Ok("pong");

        }

        [HttpGet]
        public async Task<ActionResult> GetHobbies(string? category)
        {
            if (category == null)
            {
                return Ok(this.hobbyService.GetAllHobbies());
            }

            return Ok(this.hobbyService.GetHobbiesByCategory(category));
        }

        [HttpGet("{id}", Name = "GetHobyyById")]
        public IActionResult GetHobby(Guid id)
        {
            var hobby = this.hobbyService.GetHobby(id);
            if (hobby == null)
            {
                return Ok(NotFound());
            }

            return Ok(hobby);
        }



        [HttpGet("categories")]
        public IActionResult GetCategories()
        {

            return Ok(this.hobbyService.GetAllCategories());
        }

        [HttpPost]
        public async Task<ActionResult> CreateHoby(HobbyCreation hobbyCreationRequest)
        {
            var newHobby = new Hobby();
            newHobby = await this.hobbyCreationService.CreateHobby(hobbyCreationRequest);
            var routeValues = new { id = newHobby.Id };

            return CreatedAtRoute("GetHobyyById", routeValues, newHobby);

        }
    }
}
