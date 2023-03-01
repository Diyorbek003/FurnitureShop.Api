using FurnitureShop.Api.Data;
using FurnitureShop.Api.Dtos;
using FurnitureShop.Api.Entities;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureShop.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{

  private readonly AppDbContext _context;
    public readonly Microsoft.AspNetCore.Identity.UserManager<AppUser> _userManager;
   // private readonly UserManager<AppUser> _userManager;
   private readonly SignInManager<AppUser> _signInManager;

    public AccountController(AppDbContext context, SignInManager<AppUser> signInManager,UserManager<AppUser> userManager)
    {
        _context = context;
        _signInManager = signInManager;
        _userManager = userManager;
    }

    [HttpGet]
    public IActionResult GetUsers()
    {
        var user = _context.Users.ToList();
        return Ok(user);

    }

    [HttpPost("signup")]
    public async Task <IActionResult> SignUp([FromBody]RegistrUserDto createUserDto)
    {
        if(!ModelState.IsValid)
        {
            return BadRequest();
        }
        var user = createUserDto.Adapt<AppUser>();
        // identityuserda pasword bolmaganligi uchun mapqilolmidi shuning uchun uni createasync funksiyaga bervoriladi
       var result =   await _userManager.CreateAsync(user, createUserDto.Password); // savechaingis qilish shart emas ekan ichida borakan 

        if (!result.Succeeded)// claimlarida xato bolishi mumkin bolganligi uchun resultni tekshiramiz
        {
            return BadRequest();
        }
        //claimlarini yasaydi va ulardan tokenni yasaydi va tokenni cookiga yozib jonatadi
       await _signInManager.SignInAsync(user,true);//token yasab claimlariga yozib yuboradi
        // isPoersistentni true qilsak brauzer yopilsaham cookilari turadi false bosa ochib ketadi


        return Ok();
    }


    [HttpPost("signin")]
    public IActionResult SignIn(LoginUserDto loginUserDto)
    {
        if(!ModelState.IsValid)
        {
            return BadRequest();
        }
        return Ok();
    }
}
