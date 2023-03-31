using System.Configuration;
using BasicsDBApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicsDBApplication.Services;

public class MyDbContext : DbContext
{
    public DbSet<Team> Teams { get; set; } = null!;

    public DbSet<Player> Players { get; set; } = null!;

    public DbSet<MatchScore> MatchScores { get; set; } = null!;

    public DbSet<Match> Matches { get; set; } = null!;

    public DbSet<MatchLineup> MatchLineups { get; set; } = null!;

    public DbSet<LeagueTable> Leagues { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["SqlServerConnection"].ConnectionString);
    }
}