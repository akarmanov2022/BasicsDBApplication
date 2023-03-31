namespace BasicsDBApplication.Models;

public class Player
{

    public int Id { get; set; }

    public string PlayerName { get; set; }

    public int Age { get; set; }

    public Team Team { get; set; }
}