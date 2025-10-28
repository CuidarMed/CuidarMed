using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Doctors
{
    public class UpdateDoctorRequest
    {
        [Required]
        public long DoctorId { get; set; }

        [MaxLength(100)]
        public string? Specialty { get; set; }

        [MaxLength(50)]
        public string? LicenseNumber { get; set; }

        public long UserId { get; set; }
    }
}
