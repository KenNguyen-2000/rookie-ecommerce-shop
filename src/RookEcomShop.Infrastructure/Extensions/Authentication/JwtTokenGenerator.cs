using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using RookEcomShop.Application.Common.Interfaces.Authentication;
using RookEcomShop.Application.Common.Interfaces.Services;
using RookEcomShop.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RookEcomShop.Infrastructure.Extensions.Authentication
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly JwtSettings _jwtSettings;
        private readonly IDateTimeProvider _dateTimeProvider;

        public JwtTokenGenerator(IOptions<JwtSettings> jwtOptions, IDateTimeProvider dateTimeProvider)
        {
            _jwtSettings = jwtOptions.Value;
            _dateTimeProvider = dateTimeProvider;
        }

        public string GenerateToken(User user)
        {
            var signingCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Secret)), SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
            new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
            new Claim(JwtRegisteredClaimNames.FamilyName, user.LastName),
            new Claim(JwtRegisteredClaimNames.GivenName, user.FirstName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),

        };

            var securityToken = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                expires: _dateTimeProvider.UtcNow.AddMinutes(_jwtSettings.ExpiryMinutes),
                claims: claims,
                signingCredentials: signingCredentials
            );

            return new JwtSecurityTokenHandler().WriteToken(securityToken);
        }
    }
}
