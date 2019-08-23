using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;


namespace Microsoft.Extensions.DependencyInjection
{
    using Microsoft.Extensions.Configuration;
    using DXC.Platform.AspNetCore.Authentication;

    /// <summary>
    /// </summary>
    public static partial class IServiceCollectionExtension
    {
        /// <summary>
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddAuthorizationConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthorization(options =>
            {
                var authorizationRepository = new AuthorizationConfiguration();
                configuration.GetSection("Authorization").Bind(authorizationRepository);

                foreach (var policy in authorizationRepository?.Policy)
                {
                    options.AddPolicy(policy.PolicyName, builder =>
                    {
                        var policyCount = policy?.RequiredRole is null ? 0 : policy.RequiredRole.Count();
                        if (policyCount != 0)
                            builder.RequireRole(policy.RequiredRole);

                        foreach (var claim in policy.RequiredClaim)
                        {
                            if (claim?.Values?.Count() != 0)
                                builder.RequireClaim(claim.Type, claim.Values);
                            else
                                builder.RequireClaim(claim.Type);
                        }
                    });
                }
            });
            return services;
        }
    }
}