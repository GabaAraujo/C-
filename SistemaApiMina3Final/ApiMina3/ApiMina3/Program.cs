
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using ApiMina3.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.Filters;


namespace ApiMina3
{


    public class Program
    {
        public static void Main(string[] args)
        {






            var builder = WebApplication.CreateBuilder(args);
            string connString = builder.Configuration.GetConnectionString("DefaultConnection");

            //adicionar esse trecho em SQL SERVER

            builder.Services.AddDbContext<TodoContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });


            // Add services to the container.

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
