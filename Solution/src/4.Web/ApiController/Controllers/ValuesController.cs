using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiController.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Policy = "ApiReader")]
    public class ValuesController : Controller
    {
        // GET api/values
        [Authorize(Policy = "Consumer")]
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new JsonResult(User.Claims.Select(c => new { c.Type, c.Value }));
        }
    }
}
