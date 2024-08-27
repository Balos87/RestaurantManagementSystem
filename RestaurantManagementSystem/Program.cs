using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using RestaurantManagementSystem.Repository;
using RestaurantManagementSystem.Repository.IRepository;
using RestaurantManagementSystem.Services;
using RestaurantManagementSystem.Data;
using RestaurantManagementSystem.Services.IServices;

namespace RestaurantManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //<<< Env filen för att följa säkerhetsstandard.>>> Fick ladda hem paketet DotNetEnv för att kunna använda mig av .env filen.
            Env.Load();

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            string connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");

            builder.Services.AddDbContext<RestaurantManagementSystemContext>(options =>
            options.UseSqlServer(connectionString));

            builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
            builder.Services.AddScoped<ICustomerService, CustomerService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

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
