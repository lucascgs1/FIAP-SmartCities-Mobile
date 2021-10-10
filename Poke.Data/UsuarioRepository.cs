using Microsoft.EntityFrameworkCore;
using Poke.Data.Context;
using Poke.Data.Interfaces;
using Poke.Model;
using System.Threading.Tasks;

namespace Poke.Data
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        private readonly ApplicationDbContext _context;

        public UsuarioRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Usuario> GetByEmail(string email)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(x => x.Email == email);
        }

        public Usuario GetFullByEmail(string email)
        {
            //return DbSet.AsNoTracking().Include(e => e.CodigoSeguranca).FirstOrDefault(x => x.Email == email);
            return null;
        }
    }
}