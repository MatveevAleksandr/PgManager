namespace PgManager.Data.Core.Models;

public class ServerConnection (string host, int port, string username, string password)
{
    private string Host { get; set; } = host;
    private int Port { get; set; } = port;
    private string Username { get; set; } = username;
    private string Password { get; set; } = password;
    public ServerConnectionState? State { get; set; }
    
    public override string ToString() => $"Host={Host};Port={Port};Username={Username};Password={Password}";
}