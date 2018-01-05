using Pitangueiros.Blog.Cross.IoC;
using Pitangueiros.Blog.Distribution.WebApi.IoC;
using Pitangueiros.Blog.Infra.Repositories.IoC;
using System.Reflection;
using System.Web.Http;
using AutoMapper;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Pitangueiros.Blog.App.Services.IoC;
using Pitangueiros.Blog.Cross.IoC.AutoMapper;
using Pitangueiros.Blog.Domain.Services.IoC;

namespace Pitangueiros.Blog.Distribution.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {

        protected void Application_Start() {
            IocManager.Instance
                .AddConventionalRegistrar(new BasicConventionalRegistrar());

            IocManager.Instance
                .AddConventionalRegistrar(new ApiControllerConventionalRegistrar());

            //IocManager.Instance
            //    .AddConventionalRegistrar(new AutoMapperConventionalRegistrar());


            IocManager.Instance
                .RegisterAssemblyByConvention(Assembly.GetAssembly(typeof(RepositoryIocInitializer)));
            IocManager.Instance
                .RegisterAssemblyByConvention(Assembly.GetAssembly(typeof(ServiceIocInitializer)));
            IocManager.Instance
                .RegisterAssemblyByConvention(Assembly.GetAssembly(typeof(AppServiceIocInitializer)));

            IocManager.Instance
                .RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());


            foreach (IIocInitializer initializer in IocManager.Instance.ResolveAll<IIocInitializer>())
            {
                initializer.Initialize(IocManager.Instance);
            }

            foreach (IMapperProfile mapperProfile in IocManager.Instance.ResolveAll<IMapperProfile>())
            {
                if (mapperProfile is Profile profile)
                {
                    Mapper.Initialize(config => config.AddProfile(profile));

                }
            }

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        protected void Application_End()
        {
            IocManager.Instance.Dispose();
        }

    }

}
