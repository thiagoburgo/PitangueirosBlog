using Pitangueiros.Blog.Cross.IoC;

namespace Pitangueiros.Blog.App.Contracts
{
    public interface IApplicationService : ITransientDependency
    {
        //Pode ter uma referencia para o UnitOfWork ou para dados do usuario logado....
    }
}
