using System;
using Usuario.Infrastructure.Model;

namespace Usuario.Infrastructure.UnitOfWork.Base
{
    public abstract class GenericUnitOfWork
    {
        protected readonly IServiceProvider _serviceProvider;
        protected readonly Banco _context;

        public GenericUnitOfWork(Banco context, IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}