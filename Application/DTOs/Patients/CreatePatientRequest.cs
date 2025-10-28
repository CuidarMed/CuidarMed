using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Patients
{
    public class CreatePatientRequest
    {
        [Required]
        [MaxLength(20)]
        public int? Dni { get; set; }

        [MaxLength(200)]
        public string? Adress { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [MaxLength(100)]
        public string? HealthPlan { get; set; }

        [Required]
        [MaxLength(50)]
        public int MembershipNumber { get; set; }

        [Required]
        public long UserId { get; set; }
    }
}
