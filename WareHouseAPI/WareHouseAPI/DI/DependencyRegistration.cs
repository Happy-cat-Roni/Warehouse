using FluentValidation;
using Serilog;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Extensions;
using WareHouseAPI.FluentValidation;
using WareHouseBLL.DI;

namespace WareHouseAPI.DI
{
    public static class DependencyRegistration
    {
        public static void AddApiDependencies(this IServiceCollection services, WebApplicationBuilder builder, string? connectionString)
        {
            services.AddBLLDependencies(connectionString);

            services.AddValidatorsFromAssemblyContaining<WareHouseValidaton>();
            services.AddValidatorsFromAssemblyContaining<EmployeeValidation>();
            services.AddValidatorsFromAssemblyContaining<DirectorValidation>();

            builder.Services.AddFluentValidationAutoValidation();

            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();

            builder.Logging.AddSerilog().SetMinimumLevel(LogLevel.Information);
        }
    }
}
