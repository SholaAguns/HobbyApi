using HobbyApi.Models;
using HobbyApi.Services;
using Microsoft.AspNetCore.Mvc;


namespace HobbyApi.Controllers
{
    [ApiController]
    [Route("api/hobby")]
    public class HobbyCreationController : ControllerBase
    {
        private readonly HobbyCreationService hobbyCreationService;
        public HobbyCreationController(HobbyCreationService hobbyCreationService)
        {
            this.hobbyCreationService = hobbyCreationService;

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
