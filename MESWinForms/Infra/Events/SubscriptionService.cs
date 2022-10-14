using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESWinForms.Infra.Events
{
    public class SubscriptionService
    {
        public List<IConsumer<T>> GetSubscriptions<T>()
        {
            return AppEngine.ResolveAll<IConsumer<T>>();
        }
    }
}
