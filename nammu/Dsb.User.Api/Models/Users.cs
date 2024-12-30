namespace Dsb.User.Api.Models
{
    public class Users
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Provider { get; set; }
        public string ProviderId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Navigation properties
        public ICollection<AuthorizationCode> AuthorizationCodes { get; set; }
        public ICollection<AccessToken> AccessTokens { get; set; }
        public ICollection<RefreshToken> RefreshTokens { get; set; }
    }
}
