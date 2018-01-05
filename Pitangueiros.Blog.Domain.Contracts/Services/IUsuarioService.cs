using System.Collections.Generic;
using Pitangueiros.Blog.Cross.IoC;
using Pitangueiros.Blog.Domain.Entities;

namespace Pitangueiros.Blog.Domain.Contracts.Services
{
    public interface IUsuarioService : ITransientDependency
    {
        bool Autenticar(string login, string senha);

        void CriarUsuario(Usuario usuario);

        IList<Usuario> ConsultarUsuarioPorNome(string nome);
    }
}
