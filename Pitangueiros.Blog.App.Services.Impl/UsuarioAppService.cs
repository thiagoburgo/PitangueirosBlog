using System.Collections.Generic;
using Pitangueiros.Blog.App.Contracts;
using Pitangueiros.Blog.App.Entities;
using Pitangueiros.Blog.Cross.Core.Extensions;
using Pitangueiros.Blog.Domain.Contracts.Services;
using Pitangueiros.Blog.Domain.Entities;

namespace Pitangueiros.Blog.App.Services.Impl
{
    public class UsuarioAppService : IUsuarioAppService
    {
        private readonly IUsuarioService usuarioService;

        public UsuarioAppService(IUsuarioService usuarioService) {
            this.usuarioService = usuarioService;
        }

        public bool Autenticar(AutenticacaoInputDto login) {
            //podia fazer algo com as outras informações de 'login'
            return this.usuarioService.Autenticar(login.Login, login.Senha);
        }

        public void CriarUsuario(UsuarioInputDto usuario) {
            /*Poderia mapear um objeto no outro usando uma biblioteca para facilitar
            o AutoMapper é recomendado*/

            this.usuarioService.CriarUsuario(new Usuario {
                Email = usuario.Email,
                Nome = usuario.Nome,
                Senha = usuario.Senha
            });
        }

        public IList<UsuarioOutputDto> ConsultarUsuarioPorNome(string nome)
        {
            return this.usuarioService.ConsultarUsuarioPorNome(nome).MapTo<IList<UsuarioOutputDto>>();
        }
    }
}
