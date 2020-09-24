using DemoInventory.Application.Interfaces;
using DemoInventory.Application.Services;
using DemoInventory.Domain.Interfaces;
using DemoInventory.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoInventory.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
