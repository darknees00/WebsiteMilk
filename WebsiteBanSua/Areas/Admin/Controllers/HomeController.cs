using Microsoft.AspNetCore.Mvc;

namespace WebsiteBanSua.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
