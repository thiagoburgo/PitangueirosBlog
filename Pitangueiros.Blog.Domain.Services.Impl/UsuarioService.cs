using Pitangueiros.Blog.Domain.Contracts.Repositories;
using Pitangueiros.Blog.Domain.Contracts.Services;
using Pitangueiros.Blog.Domain.Entities;

namespace Pitangueiros.Blog.Domain.Services.Impl
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }
        public bool Autenticar(string login, string senha)
        {
            Usuario usuario = this.usuarioRepository.ObterPorLogin(login);
            bool autenticado = false;
            if (usuario != null)
            {
                autenticado = usuario.Senha == senha;
            }

            return autenticado;
        }

        public void CriarUsuario(Usuario usuario)
        {
            // if (this.configurarionService.NovosUsuariosPermitidos()) {
            this.usuarioRepository.Salvar(usuario);
            // }
        }
    }
}
