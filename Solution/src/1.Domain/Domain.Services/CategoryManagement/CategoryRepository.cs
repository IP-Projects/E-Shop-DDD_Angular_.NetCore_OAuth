using Domain.Core.Base;
using Domain.Core.CategoryManagement;
using Domain.Core.CategoryManagement.Interfaces;
using Domain.Services.Base;

namespace Domain.Services.CategoryManagement
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(IDbContext context) : base(context)
        {
        }
    }
}
