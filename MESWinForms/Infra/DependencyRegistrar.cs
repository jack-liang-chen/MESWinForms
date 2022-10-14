using Autofac;
using MESWinForms.Infra.Events;
using MESWinForms.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESWinForms.Infra
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public int Order => 0;

        public void Register(ContainerBuilder builder)
        {
            // Views
            builder.RegisterType<MainForm>().SingleInstance();

            // Services
            builder.RegisterType<CameraService>().SingleInstance();
            builder.RegisterType<FPYService>().SingleInstance();
            builder.RegisterType<AlarmService>().SingleInstance();
            builder.RegisterType<DataService>().SingleInstance();
            builder.RegisterType<Logger>().SingleInstance();

            // Events
            var consumers = AppEngine.FindClassesOfType(typeof(IConsumer<>)).ToList();
            foreach (var consumer in consumers)
            {
                builder.RegisterType(consumer)
                    .As(consumer.FindInterfaces((type, criteria) =>
                    {
                        var isMatch = type.IsGenericType && ((Type)criteria).IsAssignableFrom(type.GetGenericTypeDefinition());
                        return isMatch;
                    }, typeof(IConsumer<>)))
                    .InstancePerLifetimeScope();
            }
            builder.RegisterType<EventPublisher>().As<IEventPublisher>().SingleInstance();
            builder.RegisterType<SubscriptionService>().SingleInstance();
        }
    }
}
