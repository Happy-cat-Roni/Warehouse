
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

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddApiDependencies(builder.Configuration.GetConnectionString("DefaultConnection"));
            builder.Services.AddSwaggerGen();
            builder.Services.AddAutoMapper(typeof(MappersAPI).Assembly, typeof(MappersBLL).Assembly);

            var app = builder.Build();

            app.UseMiddleware<ExceptionHandlingMiddleware>();

            // Configure the HTTP request pipeline.
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
