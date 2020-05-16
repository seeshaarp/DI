using DI.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceExtension
    {

        public static IServiceCollection AddCustomServices(this IServiceCollection serviceCollection)
        {

            serviceCollection.AddScoped<IEmployeeService, EmployeeService>();
            return serviceCollection;
        }
    }
}
