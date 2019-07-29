using Infrastructure.Repository;
using Infrastructure.UnitOfWork.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Usuario.Infrastructure
{
    public class UsuarioUnitOfWork : GenericUnitOfWork
    {
        public UsuarioRepository UsuarioRepository => _serviceProvider.GetService<UsuarioRepository>();
    }
}
