namespace Pitangueiros.Blog.Cross.IoC
{
    public interface IIocInitializer : ISingletonDependency {
        void Initialize(IIocManager iocManager);
    }
}
