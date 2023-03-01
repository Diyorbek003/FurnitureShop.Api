using FurnitureShop.Api.Entities;
using System.ComponentModel.DataAnnotations;

namespace FurnitureShop.Api.ViewModel;

public class UserView
{
    [Required]
    public string? UserName { get; set; }
    [Required]
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    [Required]
    public string? Email { get; set; }
    public EUserStatus Status { get; set; }
}
