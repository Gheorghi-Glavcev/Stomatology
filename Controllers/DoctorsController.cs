using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stomatology.Data;
using Stomatology.Data.Services;
using Stomatology.Models;

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
            var data = await _service.GetAllDoctorsAsync();
            return View(data);
        }

        //Get: Doctors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name")]Doctor doctor)
        {
            if (!ModelState.IsValid)
            {
                return View(doctor);
            }

            await _service.AddDoctorAsync(doctor);
            return RedirectToAction(nameof(Index));
        }

        //Get: Doctors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var doctorDetails = await _service.GetDoctorByIdAsync(id);

            if (doctorDetails == null) return View("Not found"); 
            
            return View(doctorDetails);
        }

        //Get: Doctors/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var doctorDetails = await _service.GetDoctorByIdAsync(id);

            if (doctorDetails == null) return View("Not found");

            return View(doctorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Name")] Doctor doctor)
        {
            if (!ModelState.IsValid)
            {
                return View(doctor);
            }

            await _service.UpdateDoctorAsync(id, doctor);
            return RedirectToAction(nameof(Index));
        }

        //Get: Doctors/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var doctorDetails = await _service.GetDoctorByIdAsync(id);

            if (doctorDetails == null) return View("Not found");

            return View(doctorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doctorDetails = await _service.GetDoctorByIdAsync(id);

            if (doctorDetails == null) return View("Not found");

            await _service.DeleteDoctorAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
