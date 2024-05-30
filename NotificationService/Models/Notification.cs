using System;
using NotificationService.Interfaces;

namespace NotificationService.Models
{
    public class Notification : INotification
    {
        public Guid Id { get; private set; }
        public string Message { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public Notification(string message)
        {
            Id = Guid.NewGuid();
            Message = message;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
