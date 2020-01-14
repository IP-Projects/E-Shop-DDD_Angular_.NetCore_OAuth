using Business.DataContracts.ProductManagement;
using Business.ServiceContracts.CategoryManagement;
using Business.ServiceContracts.OrderManagement;
using Business.ServiceContracts.ProductManagement;
using Business.ServiceContracts.UserManagement;
using Business.Services.CategoryManagement;
using Business.Services.OrderManagement;
using Business.Services.ProductManagement;
using Business.Services.UserManagement;
using Domain.Core.ProductManagement.Interfaces;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Services
{
    public static class ServiceRegistration
    {
        public static IServiceCollection ConfigureBusinessServices(this IServiceCollection services)
        {
            return services
                .ConfigureDomainServices()
                .ConfigureSearchServices()
                .ConfigureDetailServices();
        }

        public static IServiceCollection ConfigureSearchServices(this IServiceCollection services)
        {
            return services
                .AddScoped<IProductSearchService, ProductSearchService>();
        }

        public static IServiceCollection ConfigureDetailServices(this IServiceCollection services)
        {
            return services
                .AddScoped<ICategoryDetailService, CategoryDetailService>()
                .AddScoped<IOrderDetailService, OrderDetailService>()
                .AddScoped<IUserDetailService, UserDetailService>();
        }
    }
}