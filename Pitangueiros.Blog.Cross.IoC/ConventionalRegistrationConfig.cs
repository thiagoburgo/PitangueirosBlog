using Pitangueiros.Blog.Cross.Core.Configuration;

namespace Pitangueiros.Blog.Cross.IoC
{
    /// <summary>
    /// This class is used to pass configuration/options while registering classes in conventional way.
    /// </summary>
    public class ConventionalRegistrationConfig : DictionaryBasedConfig
    {
        /// <summary>
        /// Install all <see cref="Castle.DynamicProxy.IInterceptor"/> implementations automatically or not.
        /// Default: true. 
        /// </summary>
        public bool InstallInstallers { get; set; }

        /// <summary>
        /// Creates a new <see cref="ConventionalRegistrationConfig"/> object.
        /// </summary>
        public ConventionalRegistrationConfig()
        {
            InstallInstallers = true;
        }
    }
}