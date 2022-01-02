using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LuCasDev.Freight.API.Controllers
{
	[Route("Identity")]
	[Authorize]
	public class IdentityController : ControllerBase
	{
		public IdentityController()
		{
		}

        [HttpGet]
        public IActionResult Get() => new JsonResult(from c in User.Claims select new { c.Type, c.Value });
    }
}

