using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Users
{
    public class CreateUserRequest
    {
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Password { get; set; }

        [Required]
        [MaxLength(20)]
        public int? Rol { get; set; }
    }
}
