namespace PR.SimpleNetGame.Infrastructure.DependencyResolver
{
    public interface IDependencyResolverFactory
    {
        IDependencyResolver Create();
    }
}