using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace SzkolenieTechniczne3.UserIdentity.Storage.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPlatformDbContext<TContext>(
            this IServiceCollection serviceCollection,
            Action<DbContextOptionsBuilder>? optionsAction = null,
            ServiceLifetime contextLifetime = ServiceLifetime.Scoped,
            ServiceLifetime optionsLifeTime = ServiceLifetime.Scoped)
            where TContext : DbContext
        {
            return serviceCollection.AddDbContext<TContext, TContext>(optionsAction, contextLifetime, optionsLifeTime);
        }
    }
}
