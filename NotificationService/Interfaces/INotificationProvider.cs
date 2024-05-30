using System.Threading.Tasks;

namespace NotificationService.Interfaces
{
    public interface INotificationProvider
    {
        Task<INotification> SendNotificationAsync(string target, string message);
    }
}
