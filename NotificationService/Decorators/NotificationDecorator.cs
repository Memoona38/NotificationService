using System.Threading.Tasks;
using NotificationService.Interfaces;

namespace NotificationService.Decorators
{
    public abstract class NotificationDecorator : INotificationProvider
    {
        protected INotificationProvider _innerProvider;

        public NotificationDecorator(INotificationProvider innerProvider)
        {
            _innerProvider = innerProvider;
        }

        public virtual async Task<INotification> SendNotificationAsync(string target, string message)
        {
            return await _innerProvider.SendNotificationAsync(target, message);
        }
    }

    public class LoggingNotificationDecorator : NotificationDecorator
    {
        public LoggingNotificationDecorator(INotificationProvider innerProvider)
            : base(innerProvider)
        {
        }

        public override async Task<INotification> SendNotificationAsync(string target, string message)
        {
            Console.WriteLine($"Logging: Sending notification to {target}");
            var notification = await base.SendNotificationAsync(target, message);
            Console.WriteLine($"Logging: Notification sent to {target}");
            return notification;
        }
    }
}
