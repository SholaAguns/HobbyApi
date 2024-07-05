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
        public HobbyController(HobbyService hobbyService)
        {
            this.hobbyService = hobbyService;

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
        public async Task<IActionResult> GetHobby(Guid id)
        {
            var hobby = await this.hobbyService.GetHobby(id);
            if (hobby == null)
            {
                return NotFound();
            }

            return Ok(hobby);
        }



        [HttpGet("categories")]
        public async Task<IActionResult> GetCategories()
        {

            return Ok(await this.hobbyService.GetAllCategories());
        }
    }
}
