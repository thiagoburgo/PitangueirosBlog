using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Pitangueiros.Blog.Cross.IoC;
using Pitangueiros.Blog.Infra.Repositories.Impl;

namespace Pitangueiros.Blog.Infra.Repositories.IoC
{
    public class RepositoryIocInitializer : IIocInitializer
    {
        public void Initialize(IIocManager iocManager)
        {
            iocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            iocManager.RegisterAssemblyByConvention(Assembly.GetAssembly(typeof(UsuarioRepository)));
        }
    }
}
