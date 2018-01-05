using System;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using Pitangueiros.Blog.Cross.IoC;
using Pitangueiros.Blog.Cross.IoC.Extensions;

namespace Pitangueiros.Blog.Distribution.WebApi.IoC {
    public class ApiControllerActivator : IHttpControllerActivator
    {
        private readonly IIocResolver iocResolver;

        public ApiControllerActivator(IIocResolver iocResolver)
        {
            this.iocResolver = iocResolver;
        }

        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            var controllerWrapper = iocResolver.ResolveAsDisposable<IHttpController>(controllerType);
            request.RegisterForDispose(controllerWrapper);
            return controllerWrapper.Object;
        }
    }
}