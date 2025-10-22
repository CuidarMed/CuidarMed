﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string? Specialty { get; set; }
        public string? LicenseNumber { get; set; } // matrícula

        // Relación con usuario
        public int UserId { get; set; }
        public User? UserNavigation { get; set; }

    }
}
