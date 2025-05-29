using Microsoft.AspNetCore.Mvc;
using NotificationSystem.Core.Interfaces;
using NotificationSystem.Core.Models;

namespace NotificationSystem.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendNotification([FromBody] NotificationMessage message)
        {
            var result = await _notificationService.SendNotificationAsync(message);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }
}
