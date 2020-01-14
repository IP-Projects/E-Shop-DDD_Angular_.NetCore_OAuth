using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.DataContracts.Base;
using Business.DataContracts.ProductManagement;
using Business.ServiceContracts.ProductManagement;
using Microsoft.AspNetCore.Mvc;


namespace ApiController.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductDetailService _detailService;
        private readonly IProductSearchService _searchService;

        public ProductController(IProductDetailService detailService, IProductSearchService searchService)
        {
            _detailService = detailService;
            _searchService = searchService;
        }

        [HttpPost]
        [Route("")]
        public async Task<IEnumerable<ProductItem>> Search([FromBody]SearchDetail detail)
        {
           return await _searchService.SearchAsync(detail);
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<ProductDetail>> GetAll()
        {
            return await _detailService.GetAllProducts();
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<ProductDetail> Get(Guid id)
        {
            return await _detailService.GetProductById(id);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IEnumerable<ProductDetail>> GetByCategory(Guid id)
        {
            return await _detailService.GetProductsByCategoryId(id);
        }
    }
}
