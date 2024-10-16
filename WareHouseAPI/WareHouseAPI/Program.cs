using WareHouseAPI.DI;
using WareHouseAPI.Mappers;
using WareHouseAPI.Middlewares;
using WareHouseBLL.Mappers;

namespace WareHouseAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddApiDependencies(builder, builder.Configuration.GetConnectionString("DefaultConnection"));
            builder.Services.AddSwaggerGen();
            builder.Services.AddAutoMapper(typeof(MappersAPI).Assembly, typeof(MappersBLL).Assembly);

            var app = builder.Build();

            app.UseMiddleware<ExceptionHandlingMiddleware>();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
