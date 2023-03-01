using FurnitureShop.Api.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfilesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUserProfile()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateUserProfile([FromBody] UpdateUserDto updateUserDto) 
        {

            return Ok();
        }
    }
}
