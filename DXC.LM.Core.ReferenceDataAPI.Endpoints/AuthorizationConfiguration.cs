namespace DXC.Platform.AspNetCore.Authentication
{
    internal class AuthorizationConfiguration
    {
        public AuthorizationConfiguration() { }
        public AuthorizationPolicyConfiguration[] Policy { get; set; }
    }
}