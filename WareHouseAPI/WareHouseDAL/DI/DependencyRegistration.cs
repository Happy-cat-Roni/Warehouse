using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WareHouseDAL.Entities;
using WareHouseDAL.Interface;
using WareHouseDAL.Repositories;

namespace WareHouseDAL.DI
{
    public static class DependencyRegistration
    {
        public static void AddDALDependencies(this IServiceCollection services, string? connectionString)
        {
            services.AddScoped<IGenericRepository<WareHouse>, GenericService<WareHouse>>();
            services.AddScoped<IGenericRepository<Employees>, GenericService<Employees>>();
            services.AddScoped<IGenericRepository<Director>, GenericService<Director>>();

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
        }
    }
}
