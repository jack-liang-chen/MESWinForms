using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESWinForms.Infra.Events
{
    public interface IEventPublisher
    {
        void Publish<T>(T @event);
    }
}
