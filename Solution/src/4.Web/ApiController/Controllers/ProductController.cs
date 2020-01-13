using System.Threading.Tasks;
using Domain.Core.ProductManagement.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace ApiController.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;
        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public void Search(string name)
        {
            //var a = await _repository.GetByAsync(x => x.Name.Contains(name));
        }
    }
}
