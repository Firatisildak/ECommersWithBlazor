﻿using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace ECommerce.Application;
public static class ServiceRegistration
{
    public static void AddApplicationServices(this IServiceCollection collection)
    {
        collection.AddMediatR(typeof(ServiceRegistration));
        collection.AddHttpClient();
    }
}