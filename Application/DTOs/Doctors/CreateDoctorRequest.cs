using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Doctors
{
    public class CreateDoctorRequest
    {
        [Required]
        [MaxLength(100)]
        public string? Specialty { get; set; }

        [Required]
        [MaxLength(50)]
        public string? LicenseNumber { get; set; }

        [Required]
        public long UserId { get; set; }
    }

}
