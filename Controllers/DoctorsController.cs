using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stomatology.Data;
using Stomatology.Data.Services;

namespace Stomatology.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly IDoctorsService _service;

        public DoctorsController(IDoctorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllDoctors();
            return View(data);
        }

        //Get: Doctors/Create
        public IActionResult Create()
        {
            return View();
        }
    }
}
