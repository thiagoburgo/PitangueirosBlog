using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Pitangueiros.Blog.Domain.Contracts.Repositories;

namespace Pitangueiros.Blog.Infra.Repositories.Impl.IoC
{
    public class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store) {
            container.Register(
                Component.For<IUsuarioRepository, UsuarioMemoryRepository>()
            );
            
        }
    }
}
