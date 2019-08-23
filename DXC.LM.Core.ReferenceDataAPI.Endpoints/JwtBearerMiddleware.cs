using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;


/// <summary>
/// </summary>
namespace DXC.Platform.AspNetCore.Authentication
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.Net.Http.Headers;

    /// <summary>
    /// </summary>
    public sealed class JwtBearerMiddleware
    {
        private static readonly string Bearer = "bearer";
        private readonly JwtSecurityTokenHandler _handler = new JwtSecurityTokenHandler();
        private readonly RequestDelegate _next;

        /// <summary>
        /// </summary>
        /// <param name="next"></param>
        public JwtBearerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var token = context.Request.Headers[HeaderNames.Authorization].ToString();

            if (!string.IsNullOrEmpty(token))
            {
                if (!token.ToLower().StartsWith(Bearer))
                    throw new InvalidOperationException(string.Format("Expected {0} at the start of the token.", Bearer));

                var jwt = _handler.ReadJwtToken(token.Substring(Bearer.Length).TrimStart());

                context.User = new ClaimsPrincipal(
                    new ClaimsIdentity(
                        jwt.Claims
                    )
                );
            }

            await _next(context);
        }
    }
}
