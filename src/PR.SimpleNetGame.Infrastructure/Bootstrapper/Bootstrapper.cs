using System.Linq;
using PR.SimpleNetGame.Infrastructure.DependencyResolver;

namespace PR.SimpleNetGame.Infrastructure.Bootstrapper
{
    public static class Bootstrapper
    {
        public static void Run()
        {
            IoC
                .ResolveAll<IBootstrapperTask>()
                .ToList()
                .ForEach(t => t.Run());
        }
    }
}