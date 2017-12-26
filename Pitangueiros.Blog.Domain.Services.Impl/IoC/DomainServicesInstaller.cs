using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Pitangueiros.Blog.Domain.Contracts.Services;

namespace Pitangueiros.Blog.Domain.Services.Impl.IoC
{
    public class DomainServicesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store) {
            container.Register(
                Component.For<IUsuarioService, UsuarioService>()
            );
        }
    }
}
