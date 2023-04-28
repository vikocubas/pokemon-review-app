using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using PokemonReviewApp.Data;
<<<<<<< HEAD
=======
<<<<<<< HEAD
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Repository;
=======
>>>>>>> 01429dddb446bfded0fa66ef4a4f2664a0bd8fed
>>>>>>> a489154 (Added Controllers, Interfaces and Repository)

namespace PokemonReviewApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
<<<<<<< HEAD
            // Adiciona os objetos de Seed
            builder.Services.AddTransient<Seed>();
=======
<<<<<<< HEAD
            // Adiciona os objetos do Seed
            builder.Services.AddTransient<Seed>();
            // Ativa o servi�o da Interface e Reposit�rio
            builder.Services.AddScoped<IPokemonRepository, PokemonRepository>();
=======
            // Adiciona os objetos de Seed
            builder.Services.AddTransient<Seed>();
>>>>>>> 01429dddb446bfded0fa66ef4a4f2664a0bd8fed
>>>>>>> a489154 (Added Controllers, Interfaces and Repository)
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

<<<<<<< HEAD
            // ?????????????????
=======
<<<<<<< HEAD
            // Faz o envio do Seed para o SQLServer
=======
            // ?????????????????
>>>>>>> 01429dddb446bfded0fa66ef4a4f2664a0bd8fed
>>>>>>> a489154 (Added Controllers, Interfaces and Repository)
            if (args.Length == 1 && args[0].ToLower() == "seeddata")
                SeedData(app);
             
            void SeedData(IHost app)
            {
                var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

                using (var scope = scopedFactory.CreateScope())
                {
                    var service = scope.ServiceProvider.GetService<Seed>();
                    service.SeedDataContext();
                }
            }

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