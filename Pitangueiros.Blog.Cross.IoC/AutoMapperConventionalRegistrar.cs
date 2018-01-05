using System.Reflection;
using AutoMapper;
using Castle.DynamicProxy;
using Castle.MicroKernel.Registration;
using Pitangueiros.Blog.Cross.IoC.AutoMapper;

namespace Pitangueiros.Blog.Cross.IoC
{
    /// <summary>
    /// This class is used to register basic dependency implementations such as <see cref="ITransientDependency"/> and <see cref="ISingletonDependency"/>.
    /// </summary>
    public class AutoMapperConventionalRegistrar : IConventionalDependencyRegistrar
    {
        public void RegisterAssembly(IConventionalRegistrationContext context)
        {
            context.IocManager.IocContainer.Register(
                Classes.FromAssembly(context.Assembly)
                    .IncludeNonPublicTypes()
                    .BasedOn<IMapperProfile>()
                    .If(type => !type.GetTypeInfo().IsGenericTypeDefinition)
                    .WithService.Base()
                    .LifestyleSingleton()
                );
            
        }
    }
}