
using System;
using Api.Data;
using Api.Data.Implementations;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Api.Domain.Repository;
using Data.Implementations;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserImplementation>();
            serviceCollection.AddScoped<ICustomerRepository, CustomerImplementation>();
            serviceCollection.AddScoped<IFlightRepository, FlightImplementation>();
            serviceCollection.AddScoped<IFlightIntineraryRepository, FlightIntineraryImplementation>();
            serviceCollection.AddScoped<IIataRepository, IataImplementation>();

            serviceCollection.AddDbContext<MyContext>(
                options => options.UseMySql(
                    "Server=localhost;Port=3306;Database=uaiflydb;Uid=root;Pwd=12345678;",
                    new MySqlServerVersion(new Version(8, 0, 21))
                )
            );



            // serviceCollection.AddDbContext<MyContext>(
            //     options => options.UseMySql(Environment.GetEnvironmentVariable("DB_CONNECTION"),
            //         new MySqlServerVersion(new Version(8, 0, 21))));


        }
    }
}
