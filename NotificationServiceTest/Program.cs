using System;
using System.Threading.Tasks;
using NotificationService;
using NotificationService.Interfaces;
using NotificationService.Providers;
using NotificationService.Decorators;

namespace NotificationServiceTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            INotificationProvider emailProvider = new EmailNotificationProvider();
            INotificationProvider pushProvider = new PushNotificationProvider();

            // Adding logging decorator
            INotificationProvider emailWithLogging = new LoggingNotificationDecorator(emailProvider);

            NotificationService.NotificationService emailService = new NotificationService.NotificationService(emailWithLogging);
            NotificationService.NotificationService pushService = new NotificationService.NotificationService(pushProvider);

            await emailService.NotifyAsync("memoonashakeel21@gmail.com", "Breaking News: Example Email!");
            await pushService.NotifyAsync("push_target", "Breaking News: Example Push Notification!");

            Console.WriteLine("Notifications sent.");
        }
    }
}
