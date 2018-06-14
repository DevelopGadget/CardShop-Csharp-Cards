namespace eCommerce_Csharp_Cards.Models
{
    public class User
    {
        public string Password { get; set; }
        public string Username { get; set; }

        public User(string password, string username)
        {
            Password = password;
            Username = username;
        }
    }
}
