using System.Collections.Generic;
using System.Threading.Tasks;
using Business.DataContracts.CategoryManagement;
using Business.ServiceContracts.CategoryManagement;
using Microsoft.AspNetCore.Mvc;


namespace ApiController.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryDetailService _detailService;

        public CategoryController(ICategoryDetailService detailService)
        {
            _detailService = detailService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<CategoryDetail>> GetAll()
        {
            return await _detailService.GetAllCategories();
        }
    }
}
