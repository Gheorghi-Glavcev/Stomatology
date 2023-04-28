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

        public async Task AddDoctorAsync(Doctor doctor)
        {
           await _context.Doctors.AddAsync(doctor);
           await _context.SaveChangesAsync();
        }

        public async Task DeleteDoctorAsync(int id)
        {
            var result = await _context.Doctors.FirstOrDefaultAsync(x => x.Id == id);
            _context.Doctors.Remove(result);
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Doctor>> GetAllDoctorsAsync()
        {
            var result = await _context.Doctors.ToListAsync();
            return result;
        }

        public async Task<Doctor> GetDoctorByIdAsync(int id)
        {
            var result = await _context.Doctors.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<Doctor> UpdateDoctorAsync(int id, Doctor doctor)
        {
            _context.Update(doctor);
            await _context.SaveChangesAsync();
            return doctor;
        }
    }
}
