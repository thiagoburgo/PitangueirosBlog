using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Pitangueiros.Blog.Domain.Contracts.Repositories;
using Pitangueiros.Blog.Domain.Entities;

namespace Pitangueiros.Blog.Infra.Repositories.Impl
{
    public class UsuarioRepository 
        : EFRepository<Usuario, long>, IUsuarioRepository
    {
        public UsuarioRepository() 
            : base(new BlogDbContext()) //Registrar no IoC a implementacao e deixar ele gerenciar a injeção do DbContext
        {
        }

        public IList<Usuario> ConsultarUsuarioPorNome(string nome) {
            var query = from usuario in this.Table
                        where usuario.Nome != null 
                        && usuario.Nome.Contains(nome)
                select usuario;

            return query.ToList();
        }
        

        public Usuario ObterPorLogin(string login) {
            // return minhasEntidades.SingleOrDefault(u => u.Email == login);

            return (from usuario in Table
                   where usuario.Email == login
                   select usuario).SingleOrDefault();
        }

       
    }
}
