using NotificationSystem.Core.Enums;
using NotificationSystem.Core.Interfaces;
using NotificationSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem.Providers.Email;

public class EmailNotificationProvider : INotificationProvider
{
    public NotificationType Type => NotificationType.Email;

    public async Task<NotificationResult> SendAsync(NotificationMessage message)
    {
        // Simulated SMTP email sending logic here...
        return await Task.FromResult(new NotificationResult
        {
            Success = true,
            Message = $"Email sent to {message.To}"
        });
    }
}