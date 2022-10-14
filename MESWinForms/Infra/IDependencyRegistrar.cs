using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESWinForms.Infra
{
    public interface IDependencyRegistrar
    {
        void Register(ContainerBuilder builder);

        int Order { get; }
    }
}
