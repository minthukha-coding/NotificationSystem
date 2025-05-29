using NotificationSystem.Core.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem.Core.Models;

public class NotificationMessage
{
    public string To { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public NotificationType Type { get; set; }
}