using WareHouseBLL.DI;

namespace WareHouseAPI.DI
{
    public static class DependencyRegistration
    {
        public static void AddApiDependencies(this IServiceCollection services, string? connectionString)
        {
            services.AddBLLDependencies(connectionString);
        }
    }
}
