using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using eCommerce_Csharp_Cards.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace eCommerce_Csharp_Cards.Controllers {
    [Route ("Cards/[controller]")]
    public class LoginController : Controller {
        private IConfiguration _Config;
        public LoginController (IConfiguration config) => this._Config = config;
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login ([FromBody] User user) {
            try {
                if (!user.Username.Equals (_Config["User"].ToString ())) return StatusCode (StatusCodes.Status401Unauthorized, "Usuario invalido");
                if (!user.Password.Equals (_Config["Password"].ToString ())) return StatusCode (StatusCodes.Status401Unauthorized, "Contraseña invalida");
                var claims = new [] {
                    new Claim (JwtRegisteredClaimNames.UniqueName, user.Username),
                    new Claim ("Role", "Administrador"),
                    new Claim (JwtRegisteredClaimNames.Jti, System.Guid.NewGuid ().ToString ())
                };
                var key = new SymmetricSecurityKey (Encoding.UTF8.GetBytes (_Config["Key"]));
                var creds = new SigningCredentials (key, SecurityAlgorithms.HmacSha256);
                var expiration = System.DateTime.Now.AddDays (1);
                JwtSecurityToken token = new JwtSecurityToken (_Config["Issuer"],
                    _Config["Issuer"],
                    claims : claims,
                    expires : expiration,
                    signingCredentials : creds);
                return Ok (new {
                    token = new JwtSecurityTokenHandler ().WriteToken (token),
                        expiration = expiration
                });
            } catch (Exception) {
                return BadRequest ("Ha ocurrido un error vuelva a intentar");
            }
        }
    }
}