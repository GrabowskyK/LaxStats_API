using LaxStats.Models;
using LaxStats.Models.MatchStats;
using LaxStats_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Threading;

namespace LaxStats_API.Database
{
    public class DatabaseContext : DbContext
    {
            public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options){
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Game>()
                    .HasOne(m => m.HomeTeam)
                    .WithMany(t => t.HomeGames)
                    .HasForeignKey(m => m.HomeTeamId)
                    .OnDelete(DeleteBehavior.Restrict); // Zmiana na NO ACTION

                modelBuilder.Entity<Game>()
                    .HasOne(m => m.AwayTeam)
                    .WithMany(t => t.AwayGames)
                    .HasForeignKey(m => m.AwayTeamId)
                    .OnDelete(DeleteBehavior.Restrict); // Zmiana na NO ACTION

                modelBuilder.Entity<EventGoal>()
                   .HasOne(eg => eg.Player)
                   .WithMany()
                   .HasForeignKey(eg => eg.PlayerId)
                   .OnDelete(DeleteBehavior.NoAction); // Ustawienie zachowania na NO ACTION

                modelBuilder.Entity<EventPenalty>()
                    .HasOne(ep => ep.Player)
                    .WithMany()
                    .HasForeignKey(ep => ep.PlayerId)
                    .OnDelete(DeleteBehavior.NoAction);
        }

            public DbSet<League> Leagues { get; set; }
            public DbSet<Team> Teams { get; set; }
            public DbSet<Player> Players { get; set; }
            public DbSet<Game> Games { get; set; }

            //Game stats
            public DbSet<EventPenalty> EventPenalties { get; set; }
            public DbSet<EventGoal> EventGoals { get; set; }
            public DbSet<Timeouts> Timeouts { get; set; }
            public DbSet<FaceOff> FaceOffs { get; set; }
            public DbSet<Shots> Shots { get; set; }
            public DbSet<ShotsWide> ShotsWides { get; set; }
            public DbSet<Groundballs> Groundballs { get; set; }
            //public DbSet<GoalieSavesAndGoals> GoalieStats { get; set; }
    }
}
