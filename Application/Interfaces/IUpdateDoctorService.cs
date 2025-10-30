using Application.DTOs.Doctors;

namespace Application.Interfaces
{
    public interface IUpdateDoctorService
    {
        Task<DoctorResponse> UpdateDoctorAsync(long id, UpdateDoctorRequest request);
    }
}
