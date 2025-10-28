using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User
    {
        public long Id { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }
        public Rol Rol { get; set; }

        // Relaciones
        public Rol UserRol { get; set; }     // Rol como Enum
        public Patient? Patient { get; set; }
        public Doctor? Doctor { get; set; }
    }
}
