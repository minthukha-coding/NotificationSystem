using NotificationSystem.Core.Enums;
using NotificationSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem.Core.Interfaces;

public interface INotificationProvider
{
    NotificationType Type { get; }
    Task<NotificationResult> SendAsync(NotificationMessage message);
}