using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using Domain.Entities;
using System.Text;

namespace DirectoryMS.Customs
{
    public class Utilities
    {
        private readonly IConfiguration _configuration; public Utilities(IConfiguration configuration) { _configuration = configuration; }
        public string encriptationSHA256(string text)
        {
            using (SHA256 hash = SHA256.Create())
            {
                // Computar el hash en un array
                byte[] bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(text));
                // Convertir el array de bytes en un string
                StringBuilder builder = new StringBuilder(); for (int i = 0; i < bytes.Length; i++) { builder.Append(bytes[i].ToString("x2")); }
                return builder.ToString();
            }
        }
        public string triggerJWT(Patient patient)
        { // Creamos la informacion del paciente para token
            var patiemClaim = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, patient.PatientId.ToString()),
                new Claim(ClaimTypes.Name, patient.Name!),
            };
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:key"]!));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            var jwtConfiguration = new JwtSecurityToken(
                issuer: _configuration["Jwt: Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: patiemClaim, 
                expires: DateTime.UtcNow.AddMinutes(10),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(jwtConfiguration);
        }
    }
}
