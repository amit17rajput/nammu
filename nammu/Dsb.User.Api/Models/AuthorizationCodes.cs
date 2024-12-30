namespace Dsb.User.Api.Models
{
    public class AuthorizationCodes
    {
        public string Code {  get; set; }
        public Guid UserId { get; set; }
        public string ClientId { get; set; }
        public DateTime ExpiresAt { get; set; }

        // Navigation properties
        public Users User { get; set; }
        public Clients Client { get; set; }
    }
}
