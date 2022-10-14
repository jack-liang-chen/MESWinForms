using MESWinForms.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESWinForms.Infra.Events
{
    public class EventPublisher : IEventPublisher
    {
        private readonly SubscriptionService _subscriptionSvc;

        public EventPublisher(SubscriptionService subscriptionService) =>
            _subscriptionSvc = subscriptionService;

        public void Publish<T>(T eventMessage)
        {
            var subscriptions = _subscriptionSvc.GetSubscriptions<T>().ToList().OrderBy(s => s.GetType().Name);

            subscriptions.ToList().ForEach(x => PublishToConsumer(x, eventMessage));
        }

        private void PublishToConsumer<T>(IConsumer<T> x, T eventMessage)
        {
            try
            {
                x.HandleEvent(eventMessage);
            }
            catch (Exception exc)
            {
                var logger = AppEngine.Resolve<Logger>();
                //we put in to nested try-catch to prevent possible cyclic (if some error occurs)
                try
                {
                    logger.Error(exc.Message);
                }
                catch (Exception)
                {
                    //do nothing
                }
            }
        }
    }
}
