using Domain.Entities;

namespace Application.Interfaces
{
    public interface IPatientQuery
    {
        Task<Patient> getPatientById(long id);
    }
}
