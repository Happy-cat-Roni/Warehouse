using Microsoft.Extensions.DependencyInjection;
using WareHouseDAL.DI;

namespace WareHouseBLL.DI
{
    public static class DependencyRegistration
    {
        public static void AddBLLDependencies(this IServiceCollection services, string? connectionString)
        {
            services.AddDALDependencies(connectionString);
        }
    }
}
