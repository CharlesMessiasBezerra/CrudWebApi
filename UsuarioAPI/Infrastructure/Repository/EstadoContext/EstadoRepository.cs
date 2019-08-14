using Usuario.Infrastructure.Model;
using Usuario.Infrastructure.Repository.Base;
using System.Linq;
using Usuario.Domain.EstadoContext;

namespace Usuario.Infrastructure.Repository.AlunoContext
{
    public class EstadoRepository : GenericRepository<EstadoDB, Banco>
    {
        public EstadoRepository(Banco context) : base(context)
        {

        }

        public IQueryable<EstadoDB> GetById(int id)
        {
            return _context.EstadoDB.Where(x => x.Id == id);
        }

        public IQueryable<EstadoDB> GetAll()
        {
            return _context.EstadoDB;
        }

    }
}
