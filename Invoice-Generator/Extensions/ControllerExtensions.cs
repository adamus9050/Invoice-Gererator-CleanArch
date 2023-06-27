using Invoice_Generator.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Invoice_Generator.Extensions
{
    public static class ControllerExtensions
    {
        public static void SetNotification(this Controller controller, string type, string message)
        {
            var notification = new Notification(type, message);

            controller.TempData["Notification"] = JsonConvert.SerializeObject(notification);
        }
        
    }
}
