using FurnitureShop.Api.Data;
using FurnitureShop.Api.Entities;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddIdentity<AppUser, IdentityRole>(options => {
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;   
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 6;
    options.Password.RequireUppercase = false;
    }
).AddEntityFrameworkStores<AppDbContext>() ;

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();//Tokenni validatsiya qiladi va claimlarini shakillantiradi

app.UseAuthorization();// claimlariga qarab ruxsati borlarini ishlatib keradi 

app.MapControllers();

app.Run();
