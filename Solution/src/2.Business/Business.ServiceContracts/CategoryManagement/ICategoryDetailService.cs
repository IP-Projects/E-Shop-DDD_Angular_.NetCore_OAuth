using System.Collections.Generic;
using System.Threading.Tasks;
using Business.DataContracts.CategoryManagement;
using Business.ServiceContracts.Base;
using Domain.Core.CategoryManagement.Interfaces;

namespace Business.ServiceContracts.CategoryManagement
{
    public interface ICategoryDetailService : IBaseDetailService<ICategoryRepository>
    {
        Task<IEnumerable<CategoryDetail>> GetAllCategories();
    }
}
