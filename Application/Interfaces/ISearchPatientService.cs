using Application.DTOs.Patients;

namespace Application.Interfaces
{
    public interface ISearchPatientService
    {
        Task<PatientResponse> getPatientById(long id);
    }
}
