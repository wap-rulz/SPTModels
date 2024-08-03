namespace SPTModels;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public string Salt { get; set; }

    public User()
    {
    }

    public User(int id, string username, string passwordHash, string salt)
    {
        Id = id;
        Username = username;
        PasswordHash = passwordHash;
        Salt = salt;
    }

    public class UserDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
