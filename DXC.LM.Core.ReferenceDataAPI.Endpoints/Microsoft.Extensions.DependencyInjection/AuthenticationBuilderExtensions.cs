using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Logging;
    using Microsoft.IdentityModel.Tokens;
    using System.Collections.Generic;


    /// <summary>
    /// </summary>
    public static class AuthenticationBuilderExtensions
    {
        /// <summary>
        /// </summary>
        private static ILogger _logger;
        /// <summary>
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static AuthenticationBuilder AddJwtBearerConfiguration(this AuthenticationBuilder builder, IConfiguration configuration)
        {
            var serviceProvider = builder.Services.BuildServiceProvider();
            if (_logger is null) _logger = serviceProvider.GetRequiredService<ILogger<AuthenticationBuilder>>();

            TokenValidationParameters tokenValidationParameters = new TokenValidationParameters();
            configuration.GetSection("Authentication").GetSection("JwtBearer")
                .GetSection("TokenValidationParameters").Bind(tokenValidationParameters);



            JsonWebKeySet tokenSigningKeys = new JsonWebKeySet();
            configuration.GetSection("Authentication").GetSection("JwtBearer")
                .GetSection("TokenValidationParameters").Bind(tokenSigningKeys);


            IList<SecurityKey> _tokenIssuerSigningSecruityKeys = tokenSigningKeys.GetSigningKeys();
#if DEBUG
            var _developerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(
                    "the secret that needs to be at least 16 characeters long for HmacSha256"
                )
            );
            _tokenIssuerSigningSecruityKeys.Add(_developerSigningKey);
#endif


            tokenValidationParameters.IssuerSigningKeys = _tokenIssuerSigningSecruityKeys;
            builder.AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = tokenValidationParameters;

                options.Events = new JwtBearerEvents
                {
                    OnMessageReceived = _onMessageReceived,
                    OnChallenge = _onChallenge,
                    OnTokenValidated = _onTokenValidated,
                    OnAuthenticationFailed = _onAuthenticationFailed
                };
                options.SaveToken = true;
            });

            return builder;
        }

        /// <summary>
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private static async Task _onMessageReceived(MessageReceivedContext context)
        {
            await Task.CompletedTask;
        }

        /// <summary>
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private static async Task _onChallenge(JwtBearerChallengeContext context)
        {


            await Task.CompletedTask;
        }

        /// <summary>
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private static async Task _onTokenValidated(TokenValidatedContext context)
        {
            await Task.CompletedTask;
        }

        /// <summary>
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private static async Task _onAuthenticationFailed(AuthenticationFailedContext context)
        {
            await Task.CompletedTask;
        }
    }
}