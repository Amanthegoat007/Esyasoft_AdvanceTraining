using Microsoft.AspNetCore.Mvc;

namespace collegeApp_view.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
