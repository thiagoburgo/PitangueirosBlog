using System.Reflection;
using System.Web.Http;
using Castle.MicroKernel.Registration;
using Pitangueiros.Blog.Cross.IoC;

namespace Pitangueiros.Blog.Distribution.WebApi.IoC {
    public class ApiControllerConventionalRegistrar : IConventionalDependencyRegistrar
    {
        public void RegisterAssembly(IConventionalRegistrationContext context)
        {
            context.IocManager.IocContainer.Register(
                Classes.FromAssembly(context.Assembly)
                    .BasedOn<ApiController>()
                    .If(type => !type.GetTypeInfo().IsGenericTypeDefinition)
                    .LifestyleTransient()
            );
        }
    }
}