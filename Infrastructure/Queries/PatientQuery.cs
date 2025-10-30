using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Queries
{
    public class PatientQuery : IPatientQuery
    {
        private readonly AppDbContext _context;

        public PatientQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Patient> getPatientById(long id)
        {
            var patient = await _context.Patients.FirstOrDefaultAsync(p => p.PatientId == id);
            return patient;
        }
    }
}
