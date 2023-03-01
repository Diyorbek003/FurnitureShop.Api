using FurnitureShop.Api.Dtos;
using FurnitureShop.Api.Entities;
using FurnitureShop.Api.ViewModel;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace FurnitureShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProfilesController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(UserView), StatusCodes.Status200OK)]
        public async Task <IActionResult> GetUserProfile([FromServices] UserManager<AppUser> userManager)
        {
            var user = await userManager.GetUserAsync(User);
            return Ok(user.Adapt<UserView>());
        }
        [HttpPut]
        public IActionResult UpdateUserProfile([FromBody] UpdateUserDto updateUserDto) 
        {

            return Ok();
        }
    }
}
