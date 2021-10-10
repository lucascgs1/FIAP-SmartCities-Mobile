using Poke.Model;
using System.Threading.Tasks;

namespace Poke.Data.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Task<Usuario> GetByEmail(string email);

        Usuario GetFullByEmail(string email);
    }
}