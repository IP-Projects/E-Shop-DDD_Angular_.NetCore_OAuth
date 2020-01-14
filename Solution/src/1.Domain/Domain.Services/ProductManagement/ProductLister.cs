using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Core.ProductManagement;
using Domain.Core.ProductManagement.Interfaces;
using Domain.Services.Base;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services.ProductManagement
{
    public class ProductLister : BaseLister<Product, ProductRepository>, IProductLister
    {
        private string Name { get; set; }

        public ProductLister(ProductRepository repository) : base(repository)
        {

        }

        public override async Task<IEnumerable<Product>> List()
        {
            return await Repository.GetAllAsync(x => ConstructQuery(x).Include(e => e.Category));
        }

        public void WithName(string name)
        {
            Name = name;
        }
       
    }
}
