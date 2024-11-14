using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreApp.Controllers
{
    public class HomeController : Controller
    {
        // localhost/Home/Index
        public IActionResult Index() // Index.cshtml dosyasını yönetir. Views/Home/ içinde
        {
            return View();
        }

        public IActionResult Eren() // Eren.cshtml dosyasını yönetir. Views/Home/ içinde
        {
            return View();
        }
    }
}
