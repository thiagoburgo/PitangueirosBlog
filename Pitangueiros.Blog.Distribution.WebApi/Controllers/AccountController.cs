using System.Collections.Generic;
using System.Web.Http;
using Pitangueiros.Blog.App.Contracts;
using Pitangueiros.Blog.App.Entities;

namespace Pitangueiros.Blog.Distribution.WebApi.Controllers
{
    public class AccountController : ApiController
    {
        private readonly IUsuarioAppService usuarioAppService;

        public AccountController(IUsuarioAppService usuarioAppService)
        {
            this.usuarioAppService = usuarioAppService;
        }

      
        [HttpGet]
        public IList<UsuarioOutputDto> ConsultarUsuarios(string nome)
        {
            return this.usuarioAppService.ConsultarUsuarioPorNome(nome);
        }
        
        [HttpPost]
        public void CriarUsuario(UsuarioInputDto usuario) {
            this.usuarioAppService.CriarUsuario(usuario);
        }

        [HttpPost]
        public void Login(AutenticacaoInputDto autenticacaoInfo)
        {
            this.usuarioAppService.Autenticar(autenticacaoInfo);
        }

    }
}