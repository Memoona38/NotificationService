using System;
using System.Threading.Tasks;
using NotificationService.Interfaces;
using NotificationService.Models;

namespace NotificationService.Providers
{
    public class EmailNotificationProvider : INotificationProvider
    {
        public async Task<INotification> SendNotificationAsync(string target, string message)
        {
            // Pseudo code for sending email
            await Task.Run(() => Console.WriteLine($"Sending Email to {target}: {message}"));
            return new Notification(message);
        }
    }
}
