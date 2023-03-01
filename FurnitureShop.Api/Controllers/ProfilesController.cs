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
        private readonly UserManager<AppUser> _userManager;

        public ProfilesController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        [ProducesResponseType(typeof(UserView), StatusCodes.Status200OK)]
        public async Task <IActionResult> GetUserProfile([FromServices] UserManager<AppUser> userManager)
        {
            var user = await userManager.GetUserAsync(User);
            return Ok(user.Adapt<UserView>());
        }
        [HttpPut]
        public async Task <IActionResult> UpdateUserProfile([FromBody] UpdateUserDto updateUserDto) 
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var user = await _userManager.GetUserAsync(User);

            user.FirstName= updateUserDto.FirstName;
            user.LastName= updateUserDto.LastName;
            await _userManager.UpdateAsync(user);
           
            return Ok();
        }
    }
}
