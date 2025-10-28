using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.SeedData
{
    public class DoctorSeed : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasData(
                new Doctor { DoctorId = 1, UserId = 4, Specialty = "Cardiology", LicenseNumber = "ABC123" },
                new Doctor { DoctorId = 2, UserId = 5, Specialty = "Dermatology", LicenseNumber = "DEF456" }
            );
        }

    }
}
