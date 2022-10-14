using Autofac;
using MESWinForms.Infra;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MESWinForms
{
    public static class AppEngine
    {
        private static IContainer _container;

        public static void Initialize()
        {
            RegisterDependencies();
        }

        public static void RunStartupTasks()
        {
            var startUpTaskTypes = FindClassesOfType<IStartupTask>();
            var startUpTasks = new List<IStartupTask>();

            foreach (var startUpTaskType in startUpTaskTypes)
                startUpTasks.Add((IStartupTask)Activator.CreateInstance(startUpTaskType));

            foreach (var startUpTask in startUpTasks)
                startUpTask.Execute();
        }

        public static T Resolve<T>(string key = "") where T : class
        {
            if (string.IsNullOrEmpty(key))
                return _container.Resolve<T>();
            else
                return _container.ResolveKeyed<T>(key);
        }

        public static object Resolve(Type type)
        {
            return _container.Resolve(type);
        }

        public static List<T> ResolveAll<T>() where T : class
        {
            return _container.Resolve<IEnumerable<T>>().ToList();
        }

        public static object TryResolve(Type type)
        {
            _container.TryResolve(type, out object instance);
            return instance;
        }

        public static object ResolveUnRegistered(Type type)
        {
            foreach (var constructor in type.GetConstructors())
            {
                try
                {
                    var parameters = constructor.GetParameters();
                    var parameterInstances = new List<object>();
                    foreach (var parameter in parameters)
                    {
                        var service = Resolve(parameter.ParameterType);
                        if (service == null) throw new Exception("Unknown dependency");
                        parameterInstances.Add(service);
                    }
                    return Activator.CreateInstance(type, parameterInstances.ToArray());
                }
                catch (Exception)
                {
                }
            }

            throw new Exception("No constructor  was found that had all the dependencies satisfied.");
        }

        public static IEnumerable<Type> FindClassesOfType<T>()
        {
            return FindClassesOfType(typeof(T));
        }

        public static IEnumerable<Type> FindClassesOfType(Type assignTypeFrom)
        {
            var result = new List<Type>();

            foreach (var a in GetAssemblies())
            {
                foreach (var t in a.GetTypes()?.Where(x => x != null))
                {
                    if (assignTypeFrom.IsAssignableFrom(t) ||
                        (assignTypeFrom.IsGenericTypeDefinition && DoesTypeImplementOpenGeneric(t, assignTypeFrom)))
                    {
                        if (!t.IsInterface && t.IsClass && !t.IsAbstract)
                            result.Add(t);
                    }
                }
            }

            return result;
        }

        private static bool DoesTypeImplementOpenGeneric(Type type, Type openGeneric)
        {
            try
            {
                var genericTypeDefinition = openGeneric.GetGenericTypeDefinition();
                foreach (var implementedInterface in type.FindInterfaces((objType, objCriteria) => true, null))
                {
                    if (!implementedInterface.IsGenericType) continue;

                    var isMatch = genericTypeDefinition.IsAssignableFrom(implementedInterface.GetGenericTypeDefinition());
                    return isMatch;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        private static IList<Assembly> GetAssemblies()
        {
            var assemblies = new List<Assembly>();

            var currentDll = Assembly.GetExecutingAssembly().CodeBase;

            var dllPath = Path.GetDirectoryName(currentDll).Remove(0, 6);

            var targetDlls = Directory.GetFiles(dllPath).Where(f => (f.EndsWith(".exe") || f.EndsWith(".dll")));

            foreach (var dllFile in targetDlls)
            {
                assemblies.Add(Assembly.LoadFrom(dllFile));
            }

            return assemblies;
        }

        private static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            var drTypes = FindClassesOfType<IDependencyRegistrar>();
            var drInstances = new List<IDependencyRegistrar>();

            foreach (var drType in drTypes)
                drInstances.Add((IDependencyRegistrar)Activator.CreateInstance(drType));

            drInstances = drInstances.OrderBy(dr => dr.Order).ToList();
            foreach (var dependencyRegistrar in drInstances)
                dependencyRegistrar.Register(builder);

            _container = builder.Build();
        }
    }
}
