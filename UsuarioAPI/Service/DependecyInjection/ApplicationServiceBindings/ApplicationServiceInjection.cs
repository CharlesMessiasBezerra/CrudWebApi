using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Usuario.Service.ApplicationService;

namespace Usuario.Service.DependecyInjection.ApplicationServiceBindings
{
    public class ApplicationServiceInjection
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<UsuarioApplicationService>();
            
        }
    }
}
