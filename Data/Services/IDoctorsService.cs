using Stomatology.Models;

namespace Stomatology.Data.Services
{
    public interface IDoctorsService
    {
        Task<IEnumerable<Doctor>> GetAllDoctors();
        Doctor GetDoctorById(int id);
        void AddDoctor(Doctor doctor);
        Doctor UpdateDoctor(int id, Doctor doctor);
        void DeleteDoctor(int id);
    }
}
