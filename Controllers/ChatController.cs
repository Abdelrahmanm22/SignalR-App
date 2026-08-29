using Microsoft.AspNetCore.Mvc;

namespace SignalRTestApp.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
