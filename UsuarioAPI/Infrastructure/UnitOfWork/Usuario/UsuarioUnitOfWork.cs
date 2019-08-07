using System;
using Usuario.Infrastructure.Model;
using Usuario.Infrastructure.Repository.AlunoContext;
using Usuario.Infrastructure.UnitOfWork.Base;
using Microsoft.Extensions.DependencyInjection;


namespace Usuario.Infrastructure.UnitOfWork.Usuario
{
    public class UsuarioUnitOfWork : GenericUnitOfWork
    {
        public UsuarioRepository UsuarioRepository => _serviceProvider.GetService<UsuarioRepository>();

        public UsuarioUnitOfWork(Banco context, IServiceProvider serviceProvider) : base(context, serviceProvider)
        {

        }
    }
}
