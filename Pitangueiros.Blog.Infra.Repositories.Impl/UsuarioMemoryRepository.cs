using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.Blog.Domain.Contracts.Repositories;
using Pitangueiros.Blog.Domain.Entities;

namespace Pitangueiros.Blog.Infra.Repositories.Impl
{
    public class UsuarioMemoryRepository 
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
