using Microsoft.AspNetCore.Mvc;


namespace ApiController.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        [HttpGet]
        public void Get()
        {
        }
    }
}
