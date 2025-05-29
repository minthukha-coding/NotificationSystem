using NotificationSystem.Core.Enums;
using NotificationSystem.Core.Interfaces;
using NotificationSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem.Providers.Push;

public class FirebasePushProvider : INotificationProvider
{
    public NotificationType Type => NotificationType.Push;

    public async Task<NotificationResult> SendAsync(NotificationMessage message)
    {
        // Simulated Firebase push sending logic here...
        return await Task.FromResult(new NotificationResult
        {
            Success = true,
            Message = $"Push notification sent to {message.To}"
        });
    }
}
