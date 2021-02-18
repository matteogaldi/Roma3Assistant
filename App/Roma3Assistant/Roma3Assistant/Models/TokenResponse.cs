using System;
namespace Roma3Assistant.Models
{
    public class TokenResponse
    {
        public bool Success { get; set; }
        public User User { get; set; }
        public string Token { get; set; }

        public override string ToString()
        {
            return Token;
        }
    }
}
