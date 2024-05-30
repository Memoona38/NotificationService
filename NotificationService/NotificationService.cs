using System.Threading.Tasks;
using NotificationService.Interfaces;

namespace NotificationService
{
    public class NotificationService
    {
        private readonly INotificationProvider _provider;

        public NotificationService(INotificationProvider provider)
        {
            _provider = provider;
        }

        public async Task<INotification> NotifyAsync(string target, string message)
        {
            return await _provider.SendNotificationAsync(target, message);
        }
    }
}
