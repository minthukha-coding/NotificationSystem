﻿using NotificationSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem.Core.Interfaces;

public interface INotificationService
{
    Task<NotificationResult> SendNotificationAsync(NotificationMessage message);
}