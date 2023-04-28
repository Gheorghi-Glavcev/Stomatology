using Stomatology.Models;

namespace Stomatology.Data.Services
{
    public interface IDoctorsService
    {
        Task<IEnumerable<Doctor>> GetAllDoctorsAsync();
        Task<Doctor> GetDoctorByIdAsync(int id);
        Task AddDoctorAsync(Doctor doctor);
        Task<Doctor> UpdateDoctorAsync(int id, Doctor doctor);
        Task DeleteDoctorAsync(int id);
    }
}
