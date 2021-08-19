using Cliente.API.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Cliente.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            //services.AddScoped<IMediatorHandler, MediatorHandler>();
            //services.AddScoped<IRequestHandler<RegistrarClienteCommand, ValidationResult>, ClienteCommandHandler>();

            //services.AddScoped<INotificationHandler<ClienteRegistradoEvent>, ClienteEventHandler>();

            //services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ClientesContext>();
        }
    }
}