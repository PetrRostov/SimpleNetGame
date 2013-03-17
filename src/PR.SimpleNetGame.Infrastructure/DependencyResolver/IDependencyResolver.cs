using System;
using System.Collections.Generic;

namespace PR.SimpleNetGame.Infrastructure.DependencyResolver
{
    public interface IDependencyResolver : IDisposable
    {
        void Register<T>(T instance);

        T Resolve<T>();

        T Resolve<T>(string name);

        IEnumerable<T> ResolveAll<T>();
    }
}