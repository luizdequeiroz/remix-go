using domain.Entities;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Principal;

namespace service.Utilities
{
    public class TokenUtility
    {
        public class TokenConfigurations
        {
            public string Audience { get; set; }

            public string Issuer { get; set; }

            public int Seconds { get; set; }
        }

        public class SigningConfigurations
        {
            public SecurityKey Key { get; }

            public SigningCredentials SigningCredentials { get; }

            public SigningConfigurations()
            {
                using (var provider = new RSACryptoServiceProvider(2048))
                {
                    Key = new RsaSecurityKey(provider.ExportParameters(true));
                }

                SigningCredentials = new SigningCredentials(
                    Key, SecurityAlgorithms.RsaSha512Signature);
            }
        }

        private readonly TokenConfigurations tokenConfigurations;

        private readonly SigningConfigurations signingConfigurations;

        public TokenUtility(TokenConfigurations tokenConfigurations, SigningConfigurations signingConfigurations)
        {
            this.tokenConfigurations = tokenConfigurations;
            this.signingConfigurations = signingConfigurations;
        }
        
        public string GetToken(User user)
        {
            ClaimsIdentity identity = new ClaimsIdentity(
                new GenericIdentity(user.Username, "username"),
                new[] {
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                    new Claim(JwtRegisteredClaimNames.UniqueName, user.Username)
                }
            );

            DateTime dataCriacao = DateTime.Now;
            DateTime dataExpiracao = dataCriacao + TimeSpan.FromSeconds(tokenConfigurations.Seconds);

            var handler = new JwtSecurityTokenHandler();
            var securityToken = handler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = tokenConfigurations.Issuer,
                Audience = tokenConfigurations.Audience,
                SigningCredentials = signingConfigurations.SigningCredentials,
                Subject = identity,
                NotBefore = dataCriacao,
                Expires = dataExpiracao
            });

            var token = handler.WriteToken(securityToken);

            return token;
        }
    }
}
