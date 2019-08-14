using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Usuario.Service.DependecyInjection;
using Usuario.Service.DependecyInjection.ApplicationServiceBindings;
using Usuario.Service.DependecyInjection.RepositoryBindings;
using Service.DependecyInjection.UnitOfWorkBindings;

namespace Usuario.Service.DependecyInjection
{
    public class ConfigureBindingsDependencyInjection
    {
        public static void RegisterBindings(IServiceCollection services, IConfiguration configuration)
        {
            ConfigureBindingsDatabaseContext.RegisterBindings(services, configuration);

            #region ApplicationService
            ApplicationServiceInjection.RegisterBindings(services, configuration);
            #endregion



            #region Repository
            RepositoryInjection.RegisterBindings(services, configuration);
            #endregion



            #region UnitOfWork
            UnitOfWorkInjection.RegisterBindings(services, configuration);
            #endregion
        }
    }
}