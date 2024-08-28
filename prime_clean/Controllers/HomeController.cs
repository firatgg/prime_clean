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

        // Hakk�m�zda (About Us)
        public IActionResult About()
        {
            return View();
        }

        // �leti�im (Contact)
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
                // Veritaban�na kaydetme i�lemleri burada yap�lacak.
                // �rnek: _context.Contacts.Add(contact); _context.SaveChanges();
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

        // Temizlik Planlay�c� (Cleaning Planner)
        public IActionResult Planner()
        {
            // Kullan�c�ya temizlik planlay�c� formunu g�sterecek.
            return View();
        }
    }
}
