using System.Collections.Generic;
using Pitangueiros.Blog.App.Entities;
using Pitangueiros.Blog.Cross.IoC;

namespace Pitangueiros.Blog.App.Contracts
{
    public interface IUsuarioAppService : ITransientDependency
    {
        bool Autenticar(AutenticacaoInputDto login);

        void CriarUsuario(UsuarioInputDto usuario);

        IList<UsuarioOutputDto> ConsultarUsuarioPorNome(string nome);
    }
}
