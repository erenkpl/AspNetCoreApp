using AspNetCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreApp.Controllers
{
    public class HomeController : Controller
    {
        // localhost/Home/Index
        public IActionResult Index() // Index.cshtml dosyasını yönetir. Views/Home/ içinde
        {

            // viewbag, viewdata, tempdata, model

            ViewBag.Name = "Eren"; // Data passlemek için kullanılan bir fonksiyon
            ViewData["Name"] = "Küpeli"; // ViewBag.Name'i değiştirdi
            TempData["Name"] = "Software"; // Diğerlerinden farklı

            Customer customer = new () { Age = 24 , FirstName = "Eren", LastName = "Küpeli" };

            return View(customer); // İçerisinde bulunduğu action ile aynı isimdeli cshtml dosaysını gösterir. Önce home klasöründe sonra shared klasöründe arar.
        }

        // localhost/Home/Eren
        public IActionResult Eren() // Eren.cshtml dosyasını yönetir. Views/Home/ içinde
        {
            return View();
        }
    }
}
