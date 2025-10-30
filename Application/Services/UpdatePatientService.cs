using Application.DTOs.Patients;
using Application.Exceptions;
using Application.Interfaces;

namespace Application.Services
{
    public class UpdatePatientService : IUpdatePatientService
    {
        private IPatientCommand _command;
        private IPatientQuery _query;

        public UpdatePatientService(IPatientCommand command, IPatientQuery query)
        {
            _command = command;
            _query = query;
        }

        public async Task<PatientResponse> UpdatePatient(long id, UpdatePatientRequest request)
        {
            var patient = await _query.getPatientById(id);

            if (patient == null)
                throw new BadRequestException("Paciente no encontrado");

            //  Actualiza todos los campos si el valor no es nulo (permite limpiar campos)
            if (request.Name != null)
                patient.Name = request.Name;

            if (request.LastName != null)
                patient.LastName = request.LastName;

            if (request.Dni.HasValue)
                patient.Dni = request.Dni.Value;

            if (request.Adress != null)
                patient.Adress = request.Adress;

            if (request.DateOfBirth.HasValue)
                patient.DateOfBirth = request.DateOfBirth.Value;

            if (request.HealthPlan != null)
                patient.HealthPlan = request.HealthPlan;

            if (request.MembershipNumber != null)
                patient.MembershipNumber = request.MembershipNumber;

            var updatedPatient = await _command.updatePatient(patient);

            return new PatientResponse
            {
                PatientId = updatedPatient.PatientId,
                Name = updatedPatient.Name,
                LastName = updatedPatient.LastName,
                Dni = updatedPatient.Dni,
                Adress = updatedPatient.Adress,
                DateOfBirth = updatedPatient.DateOfBirth,
                HealthPlan = updatedPatient.HealthPlan,
                MembershipNumber = updatedPatient.MembershipNumber
            };
        }
    }
}
