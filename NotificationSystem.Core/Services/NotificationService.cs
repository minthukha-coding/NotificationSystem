using NotificationSystem.Core.Interfaces;
using NotificationSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem.Core.Services;

public class NotificationService : INotificationService
{
    public readonly IEnumerable<INotificationProvider> _providers;

    public NotificationService(IEnumerable<INotificationProvider> providers)
    {
        _providers = providers;
    }

    public async Task<NotificationResult> SendNotificationAsync(NotificationMessage message)
    {
        var provider = _providers.FirstOrDefault(p => p.Type == message.Type);
        if (provider == null)
            return new NotificationResult { Success = false, Message = "No provider found" };

        return await provider.SendAsync(message);
    }
}
