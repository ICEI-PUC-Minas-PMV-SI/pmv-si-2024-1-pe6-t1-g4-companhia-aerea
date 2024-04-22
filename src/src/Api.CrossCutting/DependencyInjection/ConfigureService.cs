using System;
using Api.Service.Services;
using Api.Domain.Interfaces.Services.UserAggregate;
using Microsoft.Extensions.DependencyInjection;
using Api.Domain.Interfaces.Services.CustomerAggregate;
using Api.Domain.Interfaces.Services.PurchaseAggregate;
using Service.Services;
using Domain.Interfaces.Services.FlightAggregate;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
            serviceCollection.AddTransient<ICustomerService, CustomerService>();
            serviceCollection.AddTransient<IPurchaseService, PurchaseService>();
            serviceCollection.AddTransient<IFlightService, FlightService>();
        }
    }
}
