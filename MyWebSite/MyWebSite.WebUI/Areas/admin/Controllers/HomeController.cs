using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite.WebUI.Areas.admin.Controllers
{
    [Area("admin"), Authorize]
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        [Route("/admin/login"),AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
    }
}
