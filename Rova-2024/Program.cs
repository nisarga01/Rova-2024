using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Rova_2024.Data;
using Rova_2024.IRepository;
using Rova_2024.IServices;
using Rova_2024.Repository;
using Rova_2024.Services;

namespace Rova_2024
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<ISellerCommercialDetailsServices, SellerCommercialDetailsServices>();
            builder.Services.AddScoped<ISellerCommercialDetailsRepository, SellerCommercialDetailsRepository>();
            builder.Services.AddDbContext<RovaDBContext>(options =>
            {
                options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
                options.EnableSensitiveDataLogging();
            });
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("CORSPolicy",
                    builder => builder
                        .WithOrigins("http://example.com", "http://localhost:5259")
                        .AllowAnyMethod()
                        .AllowAnyHeader());
                        

            });
            var app = builder.Build();
            app.UseCors("CORSPolicy");

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseSwagger();
            app.UseSwaggerUI();
            //app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
    //app.UseSwaggerUI(c =>
    //{
    //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Rova-2024");
    //});
}
