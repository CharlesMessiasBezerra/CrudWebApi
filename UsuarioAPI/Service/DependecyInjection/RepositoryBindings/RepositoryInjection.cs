using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Usuario.Infrastructure.Repository.AlunoContext;

namespace Usuario.Service.DependecyInjection.RepositoryBindings
{
    public class RepositoryInjection
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<UsuarioRepository>();
            
        }
    }
}
