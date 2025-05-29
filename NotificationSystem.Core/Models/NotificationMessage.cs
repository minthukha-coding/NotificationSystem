using NotificationSystem.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem.Core.Models;

public class NotificationMessage
{
    public NotificationType Type { get; set; }
    public string To { get; set; }
    public string Subject { get; set; }
    public string TemplateName { get; set; }
    public Dictionary<string, string> Data { get; set; }
}