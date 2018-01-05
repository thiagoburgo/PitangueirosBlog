using System.Collections.Generic;
using System.Linq;
using Pitangueiros.Blog.Domain.Contracts.Repositories;
using Pitangueiros.Blog.Domain.Entities;

namespace Pitangueiros.Blog.Infra.Repositories.Impl
{
    public class UsuarioRepository 
        : MemoryRepository<Usuario, long>, IUsuarioRepository
    {

        public IList<Usuario> ConsultarUsuarioPorNome(string nome) {
            var query = from usuario in minhasEntidades
                        where usuario.Nome?.Contains(nome) != null
                select usuario;

            return query.ToList();
        }
        

        public Usuario ObterPorLogin(string login) {
            // return minhasEntidades.SingleOrDefault(u => u.Email == login);

            return (from usuario in minhasEntidades
                   where usuario.Email == login
                   select usuario).SingleOrDefault();
        }
    }
}
