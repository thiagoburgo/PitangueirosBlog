using System.Reflection;
using Pitangueiros.Blog.Cross.IoC;
using Pitangueiros.Blog.Domain.Services.Impl;

namespace Pitangueiros.Blog.Domain.Services.IoC
{
    public class ServiceIocInitializer : IIocInitializer
    {
        public void Initialize(IIocManager iocManager)
        {
            iocManager.RegisterAssemblyByConvention(Assembly.GetAssembly(typeof(UsuarioService)));
        }
    }
}
