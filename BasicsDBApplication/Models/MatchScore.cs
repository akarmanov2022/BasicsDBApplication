namespace BasicsDBApplication.Models;

public class MatchScore
{
    public int Id { get; set; }

    public Match Match { get; set; }

    public Team Team { get; set; }

    public int Goals { get; set; }
}