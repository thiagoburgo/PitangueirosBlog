using System.Collections.Generic;
using Pitangueiros.Blog.Cross.IoC;
using Pitangueiros.Blog.Domain.Entities;

namespace Pitangueiros.Blog.Domain.Contracts.Repositories
{
    public interface IUsuarioRepository : IRepository<Usuario, long>, ITransientDependency
    {
        IList<Usuario> ConsultarUsuarioPorNome(string nome);

        Usuario ObterPorLogin(string login);
    }
}
