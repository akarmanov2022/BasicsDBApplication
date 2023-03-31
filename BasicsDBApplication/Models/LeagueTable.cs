using System.ComponentModel.DataAnnotations.Schema;

namespace BasicsDBApplication.Models;

public class LeagueTable
{

    public int Id { get; set; }

    public Team Team { get; set; }

    public int GamesPlayed { get; set; }

    public int GamesWon { get; set; }

    public int GamesLost { get; set; }

    public int GamesDraw { get; set; }

    public int GoalsFor { get; set; }

    public int GoalsAgainst { get; set; }

    public int GoalsDifference { get; set; }

    public int Points { get; set; }
}