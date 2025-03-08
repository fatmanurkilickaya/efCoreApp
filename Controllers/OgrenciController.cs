using efCoreApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace efCoreApp.Controllers
{
    public class OgrenciController : Controller
    {
        //Injection yöntemi
        private readonly DataContext _context;

        public OgrenciController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Ogrenci model)
        {
            _context.Ogrenciler.Add(model);
            await _context.SaveChangesAsync();
            
            return RedirectToAction("Index","Home");
        }

    }
}