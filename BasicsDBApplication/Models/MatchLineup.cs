namespace BasicsDBApplication.Models;

public class MatchLineup
{

    public int Id { get; set; }

    public Match Match { get; set; }

    public Player Player { get; set; }
}