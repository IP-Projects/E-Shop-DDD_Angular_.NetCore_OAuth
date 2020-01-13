using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain.Core.Base
{
    public interface IDbContext
    {
        DbSet<T> Set<T>() where T : class;

        Task<int> SaveChangesAsync();
    }
}