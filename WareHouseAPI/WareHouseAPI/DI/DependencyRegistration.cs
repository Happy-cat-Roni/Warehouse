using WareHouseAPI.DTO;
using WareHouseBLL.DI;
using WareHouseBLL.Interface;
using WareHouseBLL.Models;
using WareHouseBLL.Service;
using WareHouseDAL.Entities;
using WareHouseDAL.Interface;
using WareHouseDAL.Repositories;

namespace WareHouseAPI.DI
{
    public static class DependencyRegistration
    {
        public static void AddApiDependencies(this IServiceCollection services, string? connectionString)
        {
            services.AddScoped<IGenericRepository<Director>, GenericService<Director>>();
            services.AddScoped<IGenericRepository<Employees>, GenericService<Employees>>();
            services.AddScoped<IGenericRepository<WareHouse>, GenericService<WareHouse>>();

            services.AddScoped<IGenericService<DirectorModel>, GenericService<DirectorModel, Director>>();
            services.AddScoped<IGenericService<EmployeesModel>, GenericService<EmployeesModel, Employees>>();
            services.AddScoped<IGenericService<WareHouseModel>, GenericService<WareHouseModel, WareHouse>>();

            services.AddBLLDependencies(connectionString);
        }
    }
}
