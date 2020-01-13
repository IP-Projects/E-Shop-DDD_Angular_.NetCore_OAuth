using Database.SqlServer;
using Domain.Core.CategoryManagement.Interfaces;
using Domain.Core.OrderItemsManagement.Interfaces;
using Domain.Core.OrderManagement.Interfaces;
using Domain.Core.ProductManagement.Interfaces;
using Domain.Core.UserManagement.Interfaces;
using Domain.Services.CategoryManagement;
using Domain.Services.OrderItemsManagement;
using Domain.Services.OrderManagement;
using Domain.Services.ProductManagement;
using Domain.Services.UserManagement;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Services
{
    public static class ServiceRegistration
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            return services.ConfigureDatabase()
                .ConfigureRepositories();
        }

        public static IServiceCollection ConfigureDatabase(this IServiceCollection services)
        {
            return services.AddDbContext<SqlServerContext>();
        }

        private static IServiceCollection ConfigureRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped<ICategoryRepository, CategoryRepository>()
                .AddScoped<IOrderRepository, OrderRepository>()
                .AddScoped<IProductRepository, ProductRepository>()
                .AddScoped<IUserRepository, UserRepository>()
                .AddScoped<IOrderItemsRepository, OrderItemsRepository>()
                ;
        }
    }
}
