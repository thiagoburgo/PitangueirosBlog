using Pitangueiros.Blog.Domain.Entities;

namespace Pitangueiros.Blog.Domain.Contracts.Services
{
    public interface IUsuarioService {
        bool Autenticar(string login, string senha);

        void CriarUsuario(Usuario usuario);

    }
}
