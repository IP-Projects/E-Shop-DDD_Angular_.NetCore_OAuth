using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.DataContracts.CategoryManagement;
using Business.ServiceContracts.CategoryManagement;
using Business.Services.Base;
using Domain.Core.CategoryManagement.Interfaces;

namespace Business.Services.CategoryManagement
{
    public class CategoryDetailService : BaseDetailService<ICategoryRepository>, ICategoryDetailService
    {
        public CategoryDetailService(ICategoryRepository repository) : base(repository)
        {
        }

        public async Task<IEnumerable<CategoryDetail>> GetAllCategories()
        {
            var categories = await Repository.GetAllAsync();

            return categories.Select(x => x.ToDetail());
        }
    }
}
