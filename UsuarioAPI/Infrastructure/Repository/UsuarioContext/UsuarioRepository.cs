using Usuario.Infrastructure.Model;
using Usuario.Infrastructure.Repository.Base;
using System.Linq;
using Usuario.Domain.UsuarioContext;

namespace Usuario.Infrastructure.Repository.AlunoContext
{
    public class UsuarioRepository : GenericRepository<UsuarioDB, Banco>
    {
        public UsuarioRepository(Banco context) : base(context)
        {

        }

        public IQueryable<UsuarioDB> GetById(int id)
        {
            return _context.UsuarioDB.Where(x => x.Id == id);
        }

    }
}
