using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.Blog.Domain.Entities;

namespace Pitangueiros.Blog.Domain.Contracts.Repositories
{
    public interface IUsuarioRepository : IRepository<Usuario, long> {
        IList<Usuario> ConsultarUsuarioPorNome(string nome);
        void Salvar(Usuario entidade);
        Usuario ObterPorId(long id);

        Usuario ObterPorLogin(string login);
    }
}
