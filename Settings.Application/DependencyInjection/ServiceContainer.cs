using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Settings.Application.Feauters.LeadAgent.Commands.CreateLeadAgent;

namespace Settings.Application.DependencyInjection;

public static class ServiceContainer
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });
        services.AddValidatorsFromAssemblyContaining<CreateLeadCategoryCommandValidator>();
        return services;
    }
}