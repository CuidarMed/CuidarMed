namespace Application.DTOs.Auth
{
    public class LoginResponse
    {
        public long UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Rol { get; set; }
        public bool IsActive { get; set; }
        public string Token { get; set; } // JWT generado al iniciar sesión
        public DateTime Expiration { get; set; } // Fecha y hora de expiración del token
    }
}
