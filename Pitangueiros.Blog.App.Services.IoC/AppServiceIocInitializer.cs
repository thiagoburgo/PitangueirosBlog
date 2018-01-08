using System.Reflection;
using Pitangueiros.Blog.App.Services.Impl;
using Pitangueiros.Blog.Cross.IoC;

namespace Pitangueiros.Blog.App.Services.IoC
{
    public class AppServiceIocInitializer : IIocInitializer
    {
        public void Initialize(IIocManager iocManager)
        {
            iocManager.RegisterAssemblyByConvention(Assembly.GetAssembly(typeof(UsuarioAppService)));
        }
    }
}
