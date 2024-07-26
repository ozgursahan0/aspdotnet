using Microsoft.AspNetCore.Mvc;
using Infra.Data; // DbContext sınıfınızın bulunduğu namespace
using Core.entities; // Model sınıflarınızın bulunduğu namespace
using System.Linq;

namespace MyMvcApp.Controllers
{
    public class TestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TestController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var countries = _context.Countries.ToList(); // Veritabanından tüm ülkeleri al
            return View(countries);
        }
    }
}
