using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Patient
    {
        public long PatientId { get; set; }
        public int Dni { get; set; }
        public string? Adress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? HealthPlan { get; set; }
        public int MembershipNumber { get; set; }

        // Relación con usuario
        public long UserId { get; set; }
        public User? UserNavigation { get; set; }
    }
}
