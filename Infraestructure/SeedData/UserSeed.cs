using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.SeedData
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User { Id = 1, Name = "Mariano Perez", Email = "Mariano.paciente@test.com", Password = "1234", Rol = Rol.Paciente },
                new User { Id = 2, Name = "Maria Lopez", Email = "maria.paciente@test.com", Password = "1234", Rol = Rol.Paciente },
                new User { Id = 3, Name = "Carlos Ruiz", Email = "carlos.paciente@test.com", Password = "1234", Rol = Rol.Paciente },
                new User { Id = 4, Name = "Dr. Ana Gomez", Email = "ana.medico@test.com", Password = "1234", Rol = Rol.Medico },
                new User { Id = 5, Name = "Dr. Juan Martinez", Email = "juan.medico@test.com", Password = "1234", Rol = Rol.Medico }
            );
        }
    }
}
