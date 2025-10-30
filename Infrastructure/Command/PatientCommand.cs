using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;

namespace Infrastructure.Command
{
    public class PatientCommand : IPatientCommand
    {
        private readonly AppDbContext _context;

        public PatientCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task addPatient(Patient patient)
        {
            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();
        }

        public async Task<Patient> updatePatient(Patient patient)
        {
            _context.Patients.Update(patient);
            await _context.SaveChangesAsync();
            return patient;
        }
    }
}
