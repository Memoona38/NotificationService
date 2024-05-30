using System;
using System.Threading.Tasks;
using NotificationService.Interfaces;
using NotificationService.Models;

namespace NotificationService.Providers
{
    public class PushNotificationProvider : INotificationProvider
    {
        public async Task<INotification> SendNotificationAsync(string target, string message)
        {
            // Pseudo code for sending push notification
            await Task.Run(() => Console.WriteLine($"Sending Push Notification to {target}: {message}"));
            return new Notification(message);
        }
    }
}
