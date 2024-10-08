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

        // Hakkımızda (About Us)
        public IActionResult About()
        {
            return View();
        }

        // İletişim (Contact)
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
                // Veritabanına kaydetme işlemleri burada yapılacak.
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

        // Temizlik Planlayıcı (Cleaning Planner)
        public IActionResult Planner()
        {
            // Kullanıcıya temizlik planlayıcı formunu gösterecek.
            return View();
        }
    }
}
