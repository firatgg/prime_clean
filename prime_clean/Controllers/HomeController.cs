using Entity.Entities;
using Microsoft.AspNetCore.Mvc;
using Entity.Entities;

namespace prime_clean.Controllers
{
    public class HomeController : Controller
    {
        // Anasayfa (Home)
        public IActionResult Index()
        {
            return View();
        }

        // Hakkýmýzda (About Us)
        public IActionResult About()
        {
            return View();
        }

        // Ýletiþim (Contact)
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                // Veritabanýna kaydetme iþlemleri burada yapýlacak.
                // Örnek: _context.Contacts.Add(contact); _context.SaveChanges();
                return RedirectToAction("ContactSuccess");
            }
            return View(contact);
        }

        public IActionResult ContactSuccess()
        {
            return View();
        }

        // Hizmetlerimiz (Our Services)
        public IActionResult Services()
        {
            return View();
        }

        // Temizlik Planlayýcý (Cleaning Planner)
        public IActionResult Planner()
        {
            // Kullanýcýya temizlik planlayýcý formunu gösterecek.
            return View();
        }
    }
}
