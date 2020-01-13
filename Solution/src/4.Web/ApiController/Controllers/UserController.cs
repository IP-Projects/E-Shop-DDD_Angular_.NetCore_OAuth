using Microsoft.AspNetCore.Mvc;


namespace ApiController.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpGet]
        public void Get()
        {
        }
    }
}
