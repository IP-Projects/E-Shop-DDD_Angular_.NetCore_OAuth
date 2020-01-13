using Domain.Core.CategoryManagement.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace ApiController.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _repository;
        public CategoryController(ICategoryRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public void GetAll()
        {
            
        }
    }
}
