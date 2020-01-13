using Business.ServiceContracts.ProductManagement;
using Business.Services.ProductManagement;
using Domain.Core.ProductManagement.Interfaces;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Services
{
    public static class ServiceRegistration
    {
        public static IServiceCollection ConfigureBusinessServices(this IServiceCollection services)
        {
            return services.ConfigureDomainServices();
        }

        public static IServiceCollection ConfigureSearchServices(this IServiceCollection services)
        {
            return services.AddScoped<IProductSearchService, ProductSearchService>();
        }
    }
}