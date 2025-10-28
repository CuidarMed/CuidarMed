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
    public class PatientSeed : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasData(
                new Patient { PatientId = 1, UserId = 1, Dni = 12345678, Adress = "Calle Falsa 123", DateOfBirth = new DateTime(1990, 5, 20), HealthPlan = "Plan A", MembershipNumber = 1001 },
                new Patient { PatientId = 2, UserId = 2, Dni = 87654321, Adress = "Av. Siempre Viva 456", DateOfBirth = new DateTime(1985, 10, 10), HealthPlan = "Plan B", MembershipNumber = 1002 },
                new Patient { PatientId = 3, UserId = 3, Dni = 11223344, Adress = "Calle Luna 789", DateOfBirth = new DateTime(2000, 1, 15), HealthPlan = "Plan C", MembershipNumber = 1003 }
            );
        }
    }
}
