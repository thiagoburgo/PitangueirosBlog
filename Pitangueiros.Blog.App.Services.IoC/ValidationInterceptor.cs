using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace Pitangueiros.Blog.App.Services.IoC
{
    public class ValidationInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation) {
            Debug.WriteLine($"{invocation.MethodInvocationTarget.Name}({string.Join(",", invocation.Arguments)})");
            invocation.Proceed();
        }
    }
}
