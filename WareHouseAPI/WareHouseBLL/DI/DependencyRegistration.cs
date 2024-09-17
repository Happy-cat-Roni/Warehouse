using Microsoft.Extensions.DependencyInjection;
using WareHouseBLL.Interface;
using WareHouseBLL.Models;
using WareHouseBLL.Service;
using WareHouseDAL.DI;
using WareHouseDAL.Entities;

namespace WareHouseBLL.DI
{
    public static class DependencyRegistration
    {
        public static void AddBLLDependencies(this IServiceCollection services, string? connectionString)
        {
            services.AddScoped<IGenericService<DirectorModel>, GenericService<DirectorModel, Director>>();
            services.AddScoped<IGenericService<EmployeesModel>, GenericService<EmployeesModel, Employees>>();
            services.AddScoped<IGenericService<WareHouseModel>, GenericService<WareHouseModel, WareHouse>>();

            services.AddDALDependencies(connectionString);
        }
    }
}
