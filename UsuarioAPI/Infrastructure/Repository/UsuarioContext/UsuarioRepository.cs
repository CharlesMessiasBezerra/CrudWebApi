using System.Linq;

namespace Infrastructure.Repository.AlunoContext
{
    public class AlunoRepository : GenericRepository<Aluno, Banco>
    {
        public AlunoRepository(Banco context) : base(context)
        {

        }

        public IQueryable<Aluno> GetById(int id)
        {
            return _context.Aluno.Where(x => x.Id == id);
        }

        public IQueryable<Aluno> GetByNome(string nome)
        {
            return _context.Aluno.Where(x => x.Nome.Contains(nome));
        }
    }
}
