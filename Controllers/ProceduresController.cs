using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stomatology.Data;

namespace Stomatology.Controllers
{
    public class ProceduresController : Controller
    {
        private readonly AppDbContext _context;

        public ProceduresController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Procedures.ToListAsync();
            return View(data);
        }
    }
}
