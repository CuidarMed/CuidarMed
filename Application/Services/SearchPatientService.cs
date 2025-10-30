using Application.DTOs.Patients;
using Application.Exceptions;
using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class SearchPatientService : ISearchPatientService
    {
        private readonly IPatientQuery _query;

        public SearchPatientService(IPatientQuery query)
        {
            _query = query;
        }

        public async Task<List<PatientResponse>> getAllPatient()
        {
            var patients = await _query.getAllPatient();

            var responce = patients.Select(p => new PatientResponse
            {
                PatientId = p.PatientId,
                Name = p.Name,
                LastName = p.LastName,
                Dni = p.Dni,
                Adress = p.Adress,
                DateOfBirth = p.DateOfBirth,
                HealthPlan = p.HealthPlan,
                MembershipNumber = p.MembershipNumber,
                UserId = p.UserId,
            }).ToList();

            return responce;
        }

        public async Task<PatientResponse> getPatientById(long id)
        {
            var patient = await _query.getPatientById(id);

            if (patient == null)
            { throw new NotFoundException("Usuario no encontrado"); }

            return await Task.FromResult(new PatientResponse
            {
                PatientId = patient.PatientId,
                Name = patient.Name,
                LastName = patient.LastName,
                Dni = patient.Dni,
                Adress = patient.Adress,
                DateOfBirth = patient.DateOfBirth,
                HealthPlan = patient.HealthPlan,
                MembershipNumber = patient.MembershipNumber,
                UserId = patient.UserId,
            });
        }
    }
}
