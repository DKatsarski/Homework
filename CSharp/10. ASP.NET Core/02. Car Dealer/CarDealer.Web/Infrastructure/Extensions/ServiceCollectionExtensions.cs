using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using CarDealer.Services;

namespace CarDealer.Web.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomainService(
            this IServiceCollection services)
        {
            Assembly.GetAssembly(typeof(IService));

            return services;
        }
    }
}
