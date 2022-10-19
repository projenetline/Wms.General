﻿using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Wms.Integration.Core.DataAccess.Utilities.Security.Ecryption;
using Wms.Integration.Core.Entities.Concrete;
using Wms.Integration.Core.Extensions;

namespace Wms.Integration.Core.DataAccess.Utilities.Security.Jwt
{
    public class JwtHelper : ITokenHelper
    {
        public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; set; }
        private TokenOptions tokenOptions;
        private DateTime _accessTokenExpiration;
        public JwtHelper(Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            Configuration = configuration;
            tokenOptions = new TokenOptions
            {
                Audience = configuration.GetSection("TokenOptions:Audience").Value,
                Issuer = configuration.GetSection("TokenOptions:Issuer").Value,
                AccessTokenExpression = int.Parse(configuration.GetSection("TokenOptions:AccessTokenExpression").Value),
                SecurityKey = configuration.GetSection("TokenOptions:SecurityKey").Value,
            };

            _accessTokenExpiration = DateTime.Now.AddMinutes(tokenOptions.AccessTokenExpression);
        }
        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
        {
            return new AccessToken
            {
                Token = new JwtSecurityTokenHandler().WriteToken(CreateJwtSecurityToken(user, SigningCredentialsHelper.CreateSigningCredentials(SecurityKeyHelper.CreateKey(tokenOptions.SecurityKey)), operationClaims)),
                Expiration = _accessTokenExpiration,
            };
        }
        public JwtSecurityToken CreateJwtSecurityToken(User user, SigningCredentials creadentials, List<OperationClaim> operationClaims)
        {
            return new JwtSecurityToken(
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience,
                expires: _accessTokenExpiration,
                notBefore: DateTime.Now,
                claims: SetClaims(user, operationClaims),
                signingCredentials: creadentials
                );
        }
        private IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaims)
        {
            IList<Claim> claims = new List<Claim>();
            claims.AddUserName(user.UserName);
            claims.AddNameIdentifier(user.Id.ToString());
            claims.AddName($"{user.FirstName} {user.LastName}");
            claims.AddRoles(operationClaims.Select(s => s.Name).ToArray());
            return claims;
        }
    }
}
