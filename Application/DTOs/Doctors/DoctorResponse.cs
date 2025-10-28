using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Doctors
{
    public class DoctorResponse
    {
        public int DoctorId { get; set; }
        public string? Specialty { get; set; }
        public string? LicenseNumber { get; set; }
        public int UserId { get; set; }
    }
}
