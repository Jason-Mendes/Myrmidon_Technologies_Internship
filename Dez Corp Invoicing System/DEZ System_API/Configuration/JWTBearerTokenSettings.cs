#nullable disable
namespace DEZ_System_API.Configuration
{
    public class JWTBearerTokenSettings
    {
        public string SecretKet { get; set; }
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public string ExpiryTimeInSeconds { get; set; }
    }
}
