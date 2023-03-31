using System.Collections.Generic;

namespace BasicsDBApplication.Models;

public class Team
{

    public int Id { get; set; }

    public List<LeagueTable> Tables { get; set; }

    public string TeamName { get; set; }

    public string Description { get; set; }
}