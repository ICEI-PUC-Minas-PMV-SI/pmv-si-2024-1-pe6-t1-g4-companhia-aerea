
using System;
using System.Data;
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
        private static object syncRoot = new object();
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserImplementation>();
            serviceCollection.AddScoped<ICustomerRepository, CustomerImplementation>();
            serviceCollection.AddScoped<IFlightRepository, FlightImplementation>();

            //var connectionString = "Server=db;Port=3306;Database=uaiflydb;Uid=root;Pwd=docker;SslMode=none"; //docker
            var connectionString = "Server=localhost;Port=3306;Database=uaiflydb;Uid=root;Pwd=12345678;"; //local

            serviceCollection.AddDbContext<MyContext>(
                options => options.UseMySql(
                    connectionString,
                    new MySqlServerVersion(new Version(8, 0, 21))
                )
            );



            // serviceCollection.AddDbContext<MyContext>(
            //     options => options.UseMySql(Environment.GetEnvironmentVariable("DB_CONNECTION"),
            //         new MySqlServerVersion(new Version(8, 0, 21))));


        }
    }
}