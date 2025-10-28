namespace Application.DTOs.Users
{
    public class UserResponse
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int Rol { get; set; }
        public bool IsActive { get; set; }
    }
}
