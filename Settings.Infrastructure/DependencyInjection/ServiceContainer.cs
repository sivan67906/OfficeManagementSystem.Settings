using Settings.Domain.Interfaces;
using Settings.Infrastructure.Persistence;
using Settings.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ConfigurationServices.CQRS.Infrastucture.Services;
using Settings.Application.Services;
using Settings.Infrastructure.Services;

namespace Settings.Infrastructure.DependencyInjection;

public static class ServiceContainer
{
    public static IServiceCollection AddInfrastructureServices(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("configurationSettingsCS")));

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<ILeadAgentService, LeadAgentService>();
        services.AddScoped<ILeadCategoryService, LeadCategoryservice>();
        services.AddScoped<IClientService, ClientService>();
        services.AddScoped<ILeadSourceService, LeadSourceService>();
        services.AddScoped<ILeadStatusService, LeadStatusService>();

        return services;
    }
}
