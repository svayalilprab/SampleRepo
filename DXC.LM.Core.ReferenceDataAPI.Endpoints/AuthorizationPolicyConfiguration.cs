namespace DXC.Platform.AspNetCore.Authentication
{
    internal class AuthorizationPolicyConfiguration
    {
        public string PolicyName { get; set; }
        public string[] RequiredRole { get; set; }
        public AuthorizationPolicyClaimConfiguration[] RequiredClaim { get; set; }
    }
}