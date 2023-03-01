using FurnitureShop.Api.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetOrganizations()
        {
            return Ok();
        }
        [HttpGet("{id:guid}")]
        public IActionResult GetOrganizationById(Guid id)
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult CreateOrganization([FromBody] CreateOrganizationDto createOrganizationDto) 
        {
            return Ok();
        
        }
        [HttpPut("{id:guid}")]
        public IActionResult UpdateOrganization([FromBody] UpdateOrganizationDto updateOrganizationDto, Guid id) 
        {
            return Ok();
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteOrganization(Guid id)
        {
            return Ok();
        }
    }
}
