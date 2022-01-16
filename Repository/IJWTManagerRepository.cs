using JWTWebAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JWTWebAuthentication.Repository
{
   public interface IJWTManagerRepository
    {
        Tokens GenerateToken(string userName);

        Tokens GenerateRefreshToken(string userName);
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
   
}
