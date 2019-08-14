using Usuario.Infrastructure.Model;
using Usuario.Infrastructure.Repository.Base;
using System.Linq;
using Usuario.Domain.CidadeContext;

namespace Usuario.Infrastructure.Repository.AlunoContext
{
    public class CidadeRepository : GenericRepository<CidadeDB, Banco>
    {
        public CidadeRepository(Banco context) : base(context)
        {

        }

        public IQueryable<CidadeDB> GetById(int id)
        {
            return _context.CidadeDB.Where(x => x.Id == id);
        }

        public IQueryable<CidadeDB> GetAll()
        {
            return _context.CidadeDB;
        }

    }
}
