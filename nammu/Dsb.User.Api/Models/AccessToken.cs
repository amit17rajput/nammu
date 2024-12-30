namespace Dsb.User.Api.Models
{
    public class AccessToken
    {
        public string Token { get; set; } // Primary key
        public Guid UserId { get; set; }
        public string ClientId { get; set; }
        public DateTime ExpiresAt { get; set; }
        public string Scope { get; set; }

        // Navigation properties
        public Users User { get; set; }
        public Clients Client { get; set; }
    }
}
