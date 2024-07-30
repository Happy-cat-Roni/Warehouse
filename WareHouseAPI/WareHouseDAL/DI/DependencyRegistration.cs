using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WareHouseDAL.DI
{
    public static class DependencyRegistration
    {
        public static void AddDALDependencies(this IServiceCollection services, string? connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
        }
    }
}
