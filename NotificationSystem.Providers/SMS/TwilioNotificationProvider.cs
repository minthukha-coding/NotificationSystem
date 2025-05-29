using NotificationSystem.Core.Enums;
using NotificationSystem.Core.Interfaces;
using NotificationSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem.Providers.SMS;

public class TwilioNotificationProvider : INotificationProvider
{
    public NotificationType Type => NotificationType.SMS;

    public async Task<NotificationResult> SendAsync(NotificationMessage message)
    {
        // Simulated Twilio SMS sending logic here...
        return await Task.FromResult(new NotificationResult
        {
            Success = true,
            Message = $"SMS sent to {message.To}"
        });
    }
}
