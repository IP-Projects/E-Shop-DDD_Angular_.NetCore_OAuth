using Microsoft.Extensions.DependencyInjection;

namespace Business.Services
{
    public static class ServiceRegistration
    {
        //public static IServiceCollection ConfigureDevelopmentDependencies(this IServiceCollection services)
        //{
        //    return services
        //        .ConfigureMocks()
        //        .ConfigureGenericRepositories()
        //        .ConfigureRepositories();

        //}

        public static IServiceCollection ConfigureDependencies(this IServiceCollection services)
        {
            return services;
            //return services.ConfigureDatabase();
            //.ConfigureGenericRepositories()
            //.ConfigureRepositories();
        }

        //public static IServiceCollection ConfigureDatabase(this IServiceCollection services)
        //{
        //    return services.AddDbContext<OidcContext>();
        //}

        //private static IServiceCollection ConfigureGenericRepositories(this IServiceCollection services)
        //{
        //    return services
        //        .AddScoped<IRepository<Category>, RepositoryBase<Category>>()
        //        .AddScoped<IRepository<Order>, RepositoryBase<Order>>()
        //        .AddScoped<IRepository<Product>, RepositoryBase<Product>>();
        //}

        //private static IServiceCollection ConfigureRepositories(this IServiceCollection services)
        //{
        //    return services
        //        .AddScoped<ICategoryRepository, ICategoryRepository>()
        //        .AddScoped<IOrderRepository, OrderRepository>()
        //        .AddScoped<IProductRepository, ProductRepository>()
        //        .AddScoped<IUserRepository, UserRepository>();
        //}

        //private static IServiceCollection ConfigureMocks(this IServiceCollection services)
        //{
        //    return services
        //        .AddSingleton<IEmailSender, EmailSenderMock>();
        //}
    }
}
