class User
{
    public string Username { get; }
    public string Email { get; }
    public string Password { get; }

    public User(string username, string email, string password)
    {
        Username = username;
        Email = email;
        Password = password;
    }

}