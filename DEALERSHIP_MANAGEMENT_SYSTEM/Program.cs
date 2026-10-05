
using DEALERSHIP_MANAGEMENT_SYSTEM.Data;
using DEALERSHIP_MANAGEMENT_SYSTEM.Interface;
using DEALERSHIP_MANAGEMENT_SYSTEM.Interface.Impelementation;
using DEALERSHIP_MANAGEMENT_SYSTEM.Unit_Of_Workk;
using Microsoft.EntityFrameworkCore;

namespace DEALERSHIP_MANAGEMENT_SYSTEM
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
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("conn")));
           builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();
            builder.Services.AddScoped<IVehicleCustom,VehicleCustom>();
            builder.Services.AddScoped<ICatigoryCustom, CategoryCustom>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.Use(async (context, next) =>
            {
                context.Response.WriteAsync("Hello from middleware 1\n");
                await next(context);
                context.Response.WriteAsync("Hello from middleware 1 response \n");


            });
            app.Use(async (context, next) =>
            {
                context.Response.WriteAsync("Hello from middleware 2 \n");
                await next(context);
                context.Response.WriteAsync("Hello from middleware 2 response \n");


            });
            app.Run(async (context) =>
            {
                context.Response.WriteAsync("Hello from middleware 3\n");
               
              


            });

            app.MapControllers();

            app.Run();
        }
    }
}
