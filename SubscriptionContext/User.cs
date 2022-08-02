using teste.ContentContext;

namespace teste.SubscriptionContext
{
    public class User : Base {
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get; private set; }
        public string Password { get; private set; }
    }    
}