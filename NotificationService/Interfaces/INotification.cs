using System;

namespace NotificationService.Interfaces
{
    public interface INotification
    {
        Guid Id { get; }
        string Message { get; }
        DateTime CreatedAt { get; }
    }
}
