using Microsoft.EntityFrameworkCore;
using Stomatology.Models;

namespace Stomatology.Data.Services
{
    public class DoctorsService : IDoctorsService
    {
        private readonly AppDbContext _context;
        public DoctorsService(AppDbContext context) 
        {
            _context = context;
        }

        public void AddDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public void DeleteDoctor(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Doctor>> GetAllDoctors()
        {
            var result = await _context.Doctors.ToListAsync();
            return result;
        }

        public Doctor GetDoctorById(int id)
        {
            throw new NotImplementedException();
        }

        public Doctor UpdateDoctor(int id, Doctor doctor)
        {
            throw new NotImplementedException();
        }
    }
}
