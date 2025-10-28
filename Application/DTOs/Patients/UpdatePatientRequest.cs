using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Patients
{
    public class UpdatePatientRequest
    {
        [Required]
        public long PatientId { get; set; }
        [MaxLength(20)]
        public int Dni { get; set; }

        [MaxLength(200)]
        public string? Adress { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [MaxLength(100)]
        public string? HealthPlan { get; set; }

        public int MembershipNumber { get; set; }

        public long UserId { get; set; }
    }
}
