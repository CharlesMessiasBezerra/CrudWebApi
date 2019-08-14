using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Usuario.Infrastructure.UnitOfWork.Usuario;

namespace Service.DependecyInjection.UnitOfWorkBindings
{
    public class UnitOfWorkInjection
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<UsuarioUnitOfWork>();
            
        }
    }
}
