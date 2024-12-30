namespace Dsb.User.Api.Models
{
    public class Clients
    {
        public string ClientId {  get; set; }
        public string ClientSecret { get; set; }
        public string RedirectUri { get; set; }
        public DateTime CreatedAt { get; set; } = string.Empty;

        // Navigation properties
        public ICollection<AuthorizationCode> AuthorizationCodes { get; set; }
        public ICollection<AccessToken> AccessTokens { get; set; }
        public ICollection<RefreshToken> RefreshTokens { get; set; }


    }
}
