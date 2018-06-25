using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerce_Csharp_Cards.Interfaces;
using Microsoft.AspNetCore.Authorization;
using eCommerce_Csharp_Cards.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace eCommerce_Csharp_Cards.Controllers {

  [AllowAnonymous]
  [Route ("Usuarios")]
  public class UsuarioController : Controller {

    private readonly ICards _Cards;

    public UsuarioController (ICards _Cards) => this._Cards = _Cards;

    [HttpGet]
    public async Task<IActionResult> Get () {
      return await Colecciones();
    }
    
    public async Task<IActionResult> Colecciones(){
      try {
        List<IEnumerable<Cards>> Cards = new List<IEnumerable<Cards>>();
        Cards.Add(await _Cards.GetAmazon());
        Cards.Add(await _Cards.GetGooglePlay());
        Cards.Add(await _Cards.GetiTunes());
        Cards.Add(await _Cards.GetPaypal());
        Cards.Add(await _Cards.GetPlayStation());
        Cards.Add(await _Cards.GetSteam());
        Cards.Add(await _Cards.GetXbox());
        return Ok (JsonConvert.SerializeObject (Cards));
      } catch (Exception) {
        return BadRequest ("Ha ocurrido un error vuelva a intentar");
      }
    }
  }
}